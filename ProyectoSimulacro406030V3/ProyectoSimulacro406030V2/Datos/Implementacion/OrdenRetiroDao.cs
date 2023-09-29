using ProyectoSimulacro406030V2.Datos.Interfaz;
using ProyectoSimulacro406030V2.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimulacro406030V2.Datos.Implementacion
{
    public class OrdenRetiroDao : IOrdenRetiroDao
    {
        public List<Material> GetMaterial()
        { 
            List<Material> lMateriales = new List<Material>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_MATERIALES");
            foreach (DataRow fila in tabla.Rows)
            {
                int codigo = int.Parse(fila[0].ToString());
                string nombre = fila[1].ToString();
                double stock = double.Parse(fila[2].ToString());
                Material m = new Material(codigo, nombre, stock);
                lMateriales.Add(m);

            }
            return lMateriales;
        }
        

    }
}
