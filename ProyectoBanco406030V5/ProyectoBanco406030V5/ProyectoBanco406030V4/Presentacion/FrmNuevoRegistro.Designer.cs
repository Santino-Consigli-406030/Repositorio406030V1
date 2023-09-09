namespace ProyectoBanco406030V4.Presentacion
{
    partial class FrmNuevoRegistro
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.dgvId_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvId_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCbu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUltimoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblCbu = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.lblUltimoMovimiento = new System.Windows.Forms.Label();
            this.dtpUM = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnValidarDatosCuenta = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnValidarDatosCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(103, 442);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 33);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId_cuenta,
            this.dgvId_cliente,
            this.dgvTipoCuenta,
            this.dgvCbu,
            this.dgvSaldo,
            this.dgvUltimoMovimiento});
            this.dgvCuentas.Location = new System.Drawing.Point(60, 275);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.Size = new System.Drawing.Size(645, 161);
            this.dgvCuentas.TabIndex = 15;
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
            this.cboTipoCuenta.Location = new System.Drawing.Point(388, 217);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(171, 21);
            this.cboTipoCuenta.TabIndex = 14;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipoCuenta.Location = new System.Drawing.Point(300, 220);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(65, 13);
            this.lblTipoCuenta.TabIndex = 16;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Location = new System.Drawing.Point(300, 40);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(81, 13);
            this.lblNumeroCuenta.TabIndex = 17;
            this.lblNumeroCuenta.Text = "Numero Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Numero Cliente";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(412, 66);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCliente.TabIndex = 19;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(300, 137);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 20;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(412, 137);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 21;
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(300, 103);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(26, 13);
            this.lblCbu.TabIndex = 22;
            this.lblCbu.Text = "Cbu";
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(412, 100);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(100, 20);
            this.txtCbu.TabIndex = 23;
            // 
            // lblUltimoMovimiento
            // 
            this.lblUltimoMovimiento.AutoSize = true;
            this.lblUltimoMovimiento.Location = new System.Drawing.Point(300, 180);
            this.lblUltimoMovimiento.Name = "lblUltimoMovimiento";
            this.lblUltimoMovimiento.Size = new System.Drawing.Size(93, 13);
            this.lblUltimoMovimiento.TabIndex = 24;
            this.lblUltimoMovimiento.Text = "Ultimo Movimiento";
            // 
            // dtpUM
            // 
            this.dtpUM.Location = new System.Drawing.Point(399, 180);
            this.dtpUM.Name = "dtpUM";
            this.dtpUM.Size = new System.Drawing.Size(200, 20);
            this.dtpUM.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 33);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnValidarDatosCuenta
            // 
            this.btnValidarDatosCuenta.Location = new System.Drawing.Point(598, 210);
            this.btnValidarDatosCuenta.Name = "btnValidarDatosCuenta";
            this.btnValidarDatosCuenta.Size = new System.Drawing.Size(138, 33);
            this.btnValidarDatosCuenta.TabIndex = 28;
            this.btnValidarDatosCuenta.Text = "Validar Datos";
            this.btnValidarDatosCuenta.UseVisualStyleBackColor = true;
            this.btnValidarDatosCuenta.Click += new System.EventHandler(this.btnValidarDatosCuenta_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(567, 442);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 33);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(57, 40);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroCliente.TabIndex = 39;
            this.lblNumeroCliente.Text = "Numero Cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(141, 148);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 38;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 36;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(57, 148);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 35;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(57, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 34;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre";
            // 
            // btnValidarDatosCliente
            // 
            this.btnValidarDatosCliente.Location = new System.Drawing.Point(60, 205);
            this.btnValidarDatosCliente.Name = "btnValidarDatosCliente";
            this.btnValidarDatosCliente.Size = new System.Drawing.Size(138, 33);
            this.btnValidarDatosCliente.TabIndex = 40;
            this.btnValidarDatosCliente.Text = "Validar Datos";
            this.btnValidarDatosCliente.UseVisualStyleBackColor = true;
            this.btnValidarDatosCliente.Click += new System.EventHandler(this.btnValidarDatosCliente_Click_1);
            // 
            // FrmNuevoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 487);
            this.Controls.Add(this.btnValidarDatosCliente);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnValidarDatosCuenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpUM);
            this.Controls.Add(this.lblUltimoMovimiento);
            this.Controls.Add(this.txtCbu);
            this.Controls.Add(this.lblCbu);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmNuevoRegistro";
            this.Text = "FrmNuevoCliente";
            this.Load += new System.EventHandler(this.FrmNuevoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCbu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUltimoMovimiento;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label lblUltimoMovimiento;
        private System.Windows.Forms.DateTimePicker dtpUM;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnValidarDatosCuenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnValidarDatosCliente;
    }
}