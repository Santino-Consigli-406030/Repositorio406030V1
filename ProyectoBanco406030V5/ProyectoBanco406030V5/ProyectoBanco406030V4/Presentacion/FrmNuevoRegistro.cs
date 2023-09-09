using ProyectoBanco406030V4.Datos;
using ProyectoBanco406030V4.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco406030V4.Presentacion
{
    public partial class FrmNuevoRegistro : Form
    {
        Cliente nuevo;
        DbHelper gestor;
        public FrmNuevoRegistro()
        {
            InitializeComponent();
            nuevo = new Cliente();
            gestor = new DbHelper();
           
        }   

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        { 
            CargarTiposCuentas();
            lblNumeroCuenta.Text = lblNumeroCuenta.Text + "" + gestor.ProximaCuenta();

            lblNumeroCliente.Text = lblNumeroCliente.Text + "" + gestor.ProximoCliente();
        }
        //private bool habilitar(bool x)
        //{
            
        //}

        private void CargarTiposCuentas()
        {
            DataTable tabla = gestor.Consultar("SP_CONSULTAR_TIPO_CUENTA");
            cboTipoCuenta.DataSource = tabla;
            cboTipoCuenta.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoCuenta.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private bool ValidarCliente()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || int.TryParse(txtNombre.Text, out _))
            {
                MessageBox.Show("Debe ingresar un nombre valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text) || int.TryParse(txtApellido.Text, out _))
            {
                MessageBox.Show("Debe ingresar un apellido valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtDNI.Text) || !int.TryParse(txtDNI.Text, out _))
            {
                MessageBox.Show("Debe ingresar un DNI valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

     
        private bool ValidarCuenta()
        {
            if (string.IsNullOrEmpty(txtNumeroCliente.Text) || !int.TryParse(txtNumeroCliente.Text, out _))
            {
                MessageBox.Show("Debe ingresar un numero de cliente valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtCbu.Text) || !int.TryParse(txtCbu.Text, out _))
            {
                MessageBox.Show("Debe ingresar un CBU valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(txtSaldo.Text) || !int.TryParse(txtSaldo.Text, out _))
            {
                MessageBox.Show("Debe ingresar un saldo valido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //if(DateTime.Now>dtpUM)
            if (cboTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Tipo De Cuenta", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private void btnValidarDatosCliente_Click_1(object sender, EventArgs e)
        {
            if (ValidarCliente() == true)
            {

            }
        }
        private bool validacionFinal()
        {
            bool datosClienteValidos = ValidarCliente();
            bool datosCuentasValidos= ValidarCuenta();
            if(!datosClienteValidos || !datosClienteValidos)
            {
                
                return false;
            }
            else
            {

            }
            return true;
        }
        private void btnValidarDatosCuenta_Click_1(object sender, EventArgs e)
        {
            if (ValidarCuenta() == true)
            {

            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(validacionFinal()== false) 
            {
                MessageBox.Show("Primero debe validar los datos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (DataGridViewRow fila in dgvCuentas.Rows) 
                {
                    if (fila.Cells["dgvId_cuenta"].Value != null && fila.Cells["dgvId_cuenta"].Value.ToString() == txtCbu.Text)
                    {
                        MessageBox.Show("Este cuenta ya esta registrada", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                           
                int NumCli = Convert.ToInt32(txtNumeroCliente.Text);
                int TipCuen = Convert.ToInt32(cboTipoCuenta.SelectedIndex);
                int Cbu = Convert.ToInt32(txtCbu.Text);
                int Saldo = Convert.ToInt32(txtSaldo.Text);
                DateTime Um = Convert.ToDateTime(dtpUM.Value);

                Cliente Cli = new Cliente();
                Cuenta c = new Cuenta(NumCli, TipCuen, Cbu, Saldo, Um);
                if (gestor.ClienteExiste(NumCli)==true)
                {
                    gestor.CargarSinCliente(c);
                }
                else
                {
                    gestor.CargarConCliente();

                }
               

                


            }


        }

      

      
    }
}
