using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoBanco406030V4.Entidades;
using System.Security.Cryptography;
using System.Security.AccessControl;

namespace ProyectoBanco406030V4.Datos
{
    internal class DbHelper
    {
        private SqlConnection conexion;
        public List<Cliente> clientes { get; set; }
        public SqlDataReader Lector;
        private DbHelper help;
        public DbHelper()
        {
                conexion= new SqlConnection(@"Data Source=DESKTOP-D01O5T8\SQLEXPRESS;Initial Catalog=ProyectoBanco406030V5;Integrated Security=True");
        }
        public DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
        //public SqlDataReader Consultar(string nombreSP)
        //{
        //    conexion.Open();
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = conexion;
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.CommandText = nombreSP;
        //    SqlDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection);
        //    return reader;
        //}
        public int ProximoCliente()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_ID_CLIENTE";
            SqlParameter param = new SqlParameter("@nextCLIENTE", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            conexion.Close();

            return (int)param.Value;
        }
        public int ProximaCuenta()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_ID_CUENTA";
            SqlParameter param = new SqlParameter("@nextCUENTA", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            conexion.Close();

            return (int)param.Value;
        }
        public List<Cliente> GetClientes()
        {
            List<Cliente> Clientes = new List<Cliente>();
            help.Consultar("SP_CONSULTAR_CLIENTES");

            while (help.Lector.Read())
            {
                Cliente c = new Cliente();
                if (!help.Lector.IsDBNull(0))
                {
                   c.id_cliente = help.Lector.GetInt32(0);
                }
                if (!help.Lector.IsDBNull(1))
                {
                    c.nombre = help.Lector.GetString(1);
                }
                if (!help.Lector.IsDBNull(2))
                {
                    c.apellido = help.Lector.GetString(2);
                }
                if (!help.Lector.IsDBNull(3))
                {
                   c.dni = help.Lector.GetInt32(3);
                }
             
                clientes.Add(c);
            }
            help.Desconectar();
            return clientes;
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public bool ClienteExiste(int numCli)
        {
            bool existe = false;
            foreach (Cliente c in GetClientes())
            {
                if (c.id_cliente == numCli)
                {
                    existe = true;
                }

            }
            return existe;

        }

        public bool CargarSinCliente(Cuenta cuenta)
        {
            bool s= false;
            conexion.Open();
            SqlCommand comando= new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "";
            comando.Parameters.AddWithValue("@id_tipo_cuenta", cuenta.id_tipo_cuenta);
            comando.Parameters.AddWithValue("@cbu", cuenta.cbu);
            comando.Parameters.AddWithValue("@saldo", cuenta.saldo);
            comando.Parameters.AddWithValue("@ultimoMovimiento",cuenta.ultimoMovimiento);
            comando.ExecuteNonQuery();
            s= true;    
            conexion.Close();
            return s;
        }

        internal void CargarConCliente()
        {
            throw new NotImplementedException();
        }
    }
}
