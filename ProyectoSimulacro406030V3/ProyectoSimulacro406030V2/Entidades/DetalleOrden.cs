using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSimulacro406030V2.Entidades
{
    public class DetalleOrden
    {
        public Material Material { get; set; }
        public int Cantidad { get; set; }
        public DetalleOrden(Material material, int cantidad)
        {
                this.Material = material;
                this.Cantidad = cantidad;
        }

    }
}
