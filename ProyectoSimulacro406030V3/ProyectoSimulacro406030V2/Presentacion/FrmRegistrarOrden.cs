using ProyectoSimulacro406030V2.Entidades;
using ProyectoSimulacro406030V2.Servicios.Implementacion;
using ProyectoSimulacro406030V2.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSimulacro406030V2.Presentacion
{
    public partial class FrmRegistrarOrden : Form
    {
        IServicio servicio = null;
        OrdenRetiro nueva = null;
        public FrmRegistrarOrden()
        {
            InitializeComponent();
            servicio = new Servicio();
            nueva = new OrdenRetiro();
        }

        private void FrmRegistrarOrden_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            cboMateriales.DataSource = servicio.TraerMateriales();
        }
    }
}
