using ProyectoSimulacro406030V2.Datos.Implementacion;
using ProyectoSimulacro406030V2.Datos.Interfaz;
using ProyectoSimulacro406030V2.Entidades;
using ProyectoSimulacro406030V2.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimulacro406030V2.Servicios.Implementacion
{
    public class Servicio:IServicio
    {
        private IOrdenRetiroDao dao;

        public Servicio()
        {
            dao = new OrdenRetiroDao();  
        }
        public List<Material> TraerMateriales()
        {
            return dao.GetMaterial();
        }

    }
}
