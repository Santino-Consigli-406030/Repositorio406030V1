namespace ProyectoBanco406030V4.Presentacion
{
    partial class FrmNuevoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvId_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvId_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUltimoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.Label();
            this.lblCbu = new System.Windows.Forms.Label();
            this.lblNumeroClienteC = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblUltimoMovimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(141, 148);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(57, 148);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(57, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(53, 29);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroCliente.TabIndex = 12;
            this.lblNumeroCliente.Text = "Numero Cliente";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(55, 438);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(162, 37);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId_cuenta,
            this.dgvId_cliente,
            this.dgvTipoCuenta,
            this.dgvCbu,
            this.dgvSaldo,
            this.dgvUltimoMovimiento});
            this.dataGridView1.Location = new System.Drawing.Point(220, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // dgvId_cuenta
            // 
            this.dgvId_cuenta.HeaderText = "id_cuenta";
            this.dgvId_cuenta.Name = "dgvId_cuenta";
            // 
            // dgvId_cliente
            // 
            this.dgvId_cliente.HeaderText = "id_cliente";
            this.dgvId_cliente.Name = "dgvId_cliente";
            // 
            // dgvTipoCuenta
            // 
            this.dgvTipoCuenta.HeaderText = "Tipo Cuenta";
            this.dgvTipoCuenta.Name = "dgvTipoCuenta";
            // 
            // dgvCbu
            // 
            this.dgvCbu.HeaderText = "Cbu";
            this.dgvCbu.Name = "dgvCbu";
            // 
            // dgvSaldo
            // 
            this.dgvSaldo.HeaderText = "Saldo";
            this.dgvSaldo.Name = "dgvSaldo";
            // 
            // dgvUltimoMovimiento
            // 
            this.dgvUltimoMovimiento.HeaderText = "Ultimo Movimiento";
            this.dgvUltimoMovimiento.Name = "dgvUltimoMovimiento";
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(642, 221);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(171, 21);
            this.cboTipoCuenta.TabIndex = 14;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipoCuenta.Location = new System.Drawing.Point(554, 224);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(65, 13);
            this.lblTipoCuenta.TabIndex = 16;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.AutoSize = true;
            this.txtNumeroCuenta.Location = new System.Drawing.Point(554, 29);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(81, 13);
            this.txtNumeroCuenta.TabIndex = 17;
            this.txtNumeroCuenta.Text = "Numero Cuenta";
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(554, 112);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(26, 13);
            this.lblCbu.TabIndex = 18;
            this.lblCbu.Text = "Cbu";
            // 
            // lblNumeroClienteC
            // 
            this.lblNumeroClienteC.AutoSize = true;
            this.lblNumeroClienteC.Location = new System.Drawing.Point(554, 69);
            this.lblNumeroClienteC.Name = "lblNumeroClienteC";
            this.lblNumeroClienteC.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroClienteC.TabIndex = 19;
            this.lblNumeroClienteC.Text = "Numero Cliente";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(664, 66);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCliente.TabIndex = 20;
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(664, 104);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(100, 20);
            this.txtCbu.TabIndex = 21;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(554, 148);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 22;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(664, 148);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 23;
            // 
            // lblUltimoMovimiento
            // 
            this.lblUltimoMovimiento.AutoSize = true;
            this.lblUltimoMovimiento.Location = new System.Drawing.Point(554, 192);
            this.lblUltimoMovimiento.Name = "lblUltimoMovimiento";
            this.lblUltimoMovimiento.Size = new System.Drawing.Size(93, 13);
            this.lblUltimoMovimiento.TabIndex = 24;
            this.lblUltimoMovimiento.Text = "Ultimo Movimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(653, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 487);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblUltimoMovimiento);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtCbu);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.lblNumeroClienteC);
            this.Controls.Add(this.lblCbu);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmNuevoCliente";
            this.Text = "FrmNuevoCliente";
            this.Load += new System.EventHandler(this.FrmNuevoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUltimoMovimiento;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label txtNumeroCuenta;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.Label lblNumeroClienteC;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblUltimoMovimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}