using ProyectoBanco406030V4.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco406030V4.Presentacion
{
    public partial class FrmNuevoCliente : Form
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
           
        }

       

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            ProximoCliente();
            ProximaCuenta();
            CargarCombo();
        }

        private void CargarCombo()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-9S87BRD\SQLEXPRESS;Initial Catalog=ProyectoBanco406030V2;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_TIPO_CUENTA";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            comando.ExecuteNonQuery();
            conexion.Close();
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.ValueMember = "id_tipo_cuenta";
            cboTipoCuenta.DisplayMember = "tipo_cuenta";
        }

        private void ProximaCuenta()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-9S87BRD\SQLEXPRESS;Initial Catalog=ProyectoBanco406030V2;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_IDENTITY";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = @"next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output; //Parametro de salida
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();
            lblNumeroCliente.Text = lblNumeroCliente.Text + parametro.Value.ToString();
        }

        private void ProximoCliente()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-9S87BRD\SQLEXPRESS;Initial Catalog=ProyectoBanco406030V2;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = @"";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output; //Parametro de salida
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            conexion.Close();
            lblNumeroCliente.Text = lblNumeroCliente.Text + parametro.Value.ToString();
        }
    }
}
