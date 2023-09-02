using ProyectoBanco406030V4.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco406030V4
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
 
        }

        private void nuevaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nueva= new FrmNuevoCliente();
            nueva.ShowDialog();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
