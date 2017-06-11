namespace UberFrba.Facturacion
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.datetimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.datetimeFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dgViajes = new System.Windows.Forms.DataGridView();
            this.lblViajes = new System.Windows.Forms.Label();
            this.lblApellidoClienteValor = new System.Windows.Forms.Label();
            this.lblNombreClienteValor = new System.Windows.Forms.Label();
            this.lblIDClienteValor = new System.Windows.Forms.Label();
            this.lnkCliente = new System.Windows.Forms.LinkLabel();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblMontoTotalValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(25, 30);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(131, 19);
            this.lblFechaInicio.TabIndex = 41;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // datetimeFechaInicio
            // 
            this.datetimeFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.datetimeFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeFechaInicio.Location = new System.Drawing.Point(35, 55);
            this.datetimeFechaInicio.Name = "datetimeFechaInicio";
            this.datetimeFechaInicio.Size = new System.Drawing.Size(120, 20);
            this.datetimeFechaInicio.TabIndex = 40;
            this.datetimeFechaInicio.ValueChanged += new System.EventHandler(this.datetimeFechaInicio_ValueChanged);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(220, 30);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(110, 19);
            this.lblFechaFin.TabIndex = 43;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // datetimeFechaFin
            // 
            this.datetimeFechaFin.CustomFormat = "dd/MM/yyyy";
            this.datetimeFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeFechaFin.Location = new System.Drawing.Point(230, 55);
            this.datetimeFechaFin.Name = "datetimeFechaFin";
            this.datetimeFechaFin.Size = new System.Drawing.Size(120, 20);
            this.datetimeFechaFin.TabIndex = 42;
            this.datetimeFechaFin.ValueChanged += new System.EventHandler(this.datetimeFechaFin_ValueChanged);
            // 
            // dgViajes
            // 
            this.dgViajes.AllowUserToAddRows = false;
            this.dgViajes.AllowUserToDeleteRows = false;
            this.dgViajes.AllowUserToResizeColumns = false;
            this.dgViajes.AllowUserToResizeRows = false;
            this.dgViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgViajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgViajes.Location = new System.Drawing.Point(30, 130);
            this.dgViajes.MultiSelect = false;
            this.dgViajes.Name = "dgViajes";
            this.dgViajes.ReadOnly = true;
            this.dgViajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViajes.Size = new System.Drawing.Size(720, 300);
            this.dgViajes.TabIndex = 44;
            // 
            // lblViajes
            // 
            this.lblViajes.AutoSize = true;
            this.lblViajes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViajes.Location = new System.Drawing.Point(25, 100);
            this.lblViajes.Name = "lblViajes";
            this.lblViajes.Size = new System.Drawing.Size(149, 19);
            this.lblViajes.TabIndex = 45;
            this.lblViajes.Text = "Viajes A Facturar";
            // 
            // lblApellidoClienteValor
            // 
            this.lblApellidoClienteValor.AutoSize = true;
            this.lblApellidoClienteValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoClienteValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidoClienteValor.Location = new System.Drawing.Point(600, 80);
            this.lblApellidoClienteValor.Name = "lblApellidoClienteValor";
            this.lblApellidoClienteValor.Size = new System.Drawing.Size(0, 14);
            this.lblApellidoClienteValor.TabIndex = 53;
            // 
            // lblNombreClienteValor
            // 
            this.lblNombreClienteValor.AutoSize = true;
            this.lblNombreClienteValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClienteValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreClienteValor.Location = new System.Drawing.Point(480, 80);
            this.lblNombreClienteValor.Name = "lblNombreClienteValor";
            this.lblNombreClienteValor.Size = new System.Drawing.Size(0, 14);
            this.lblNombreClienteValor.TabIndex = 52;
            // 
            // lblIDClienteValor
            // 
            this.lblIDClienteValor.AutoSize = true;
            this.lblIDClienteValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDClienteValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIDClienteValor.Location = new System.Drawing.Point(430, 80);
            this.lblIDClienteValor.Name = "lblIDClienteValor";
            this.lblIDClienteValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIDClienteValor.Size = new System.Drawing.Size(105, 14);
            this.lblIDClienteValor.TabIndex = 51;
            this.lblIDClienteValor.Text = "Busque un cliente";
            // 
            // lnkCliente
            // 
            this.lnkCliente.AutoSize = true;
            this.lnkCliente.Location = new System.Drawing.Point(500, 33);
            this.lnkCliente.Name = "lnkCliente";
            this.lnkCliente.Size = new System.Drawing.Size(83, 13);
            this.lnkCliente.TabIndex = 50;
            this.lnkCliente.TabStop = true;
            this.lnkCliente.Text = "Buscar cliente...";
            this.lnkCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCliente_LinkClicked);
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(600, 55);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(49, 14);
            this.lblApellidoCliente.TabIndex = 49;
            this.lblApellidoCliente.Text = "Apellido";
            this.lblApellidoCliente.UseMnemonic = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(480, 55);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(50, 14);
            this.lblNombreCliente.TabIndex = 48;
            this.lblNombreCliente.Text = "Nombre";
            this.lblNombreCliente.UseMnemonic = false;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(430, 55);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(19, 14);
            this.lblIDCliente.TabIndex = 47;
            this.lblIDCliente.Text = "ID";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(420, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 19);
            this.lblCliente.TabIndex = 46;
            this.lblCliente.Text = "Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(540, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(650, 456);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(25, 460);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(108, 19);
            this.lblMontoTotal.TabIndex = 56;
            this.lblMontoTotal.Text = "Monto Total";
            // 
            // lblMontoTotalValor
            // 
            this.lblMontoTotalValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotalValor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMontoTotalValor.Location = new System.Drawing.Point(139, 454);
            this.lblMontoTotalValor.Name = "lblMontoTotalValor";
            this.lblMontoTotalValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMontoTotalValor.Size = new System.Drawing.Size(150, 30);
            this.lblMontoTotalValor.TabIndex = 57;
            this.lblMontoTotalValor.Text = "$";
            this.lblMontoTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 507);
            this.Controls.Add(this.lblMontoTotalValor);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblApellidoClienteValor);
            this.Controls.Add(this.lblNombreClienteValor);
            this.Controls.Add(this.lblIDClienteValor);
            this.Controls.Add(this.lnkCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblViajes);
            this.Controls.Add(this.dgViajes);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.datetimeFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.datetimeFechaInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker datetimeFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker datetimeFechaFin;
        private System.Windows.Forms.DataGridView dgViajes;
        private System.Windows.Forms.Label lblViajes;
        public System.Windows.Forms.Label lblApellidoClienteValor;
        public System.Windows.Forms.Label lblNombreClienteValor;
        public System.Windows.Forms.Label lblIDClienteValor;
        private System.Windows.Forms.LinkLabel lnkCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblMontoTotal;
        public System.Windows.Forms.Label lblMontoTotalValor;
    }
}