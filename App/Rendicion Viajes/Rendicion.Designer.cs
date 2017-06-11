namespace UberFrba.Rendicion_Viajes
{
    partial class Rendicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendicion));
            this.lblFecha = new System.Windows.Forms.Label();
            this.datetimeFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTurno = new System.Windows.Forms.Label();
            this.dgViajes = new System.Windows.Forms.DataGridView();
            this.lblViajes = new System.Windows.Forms.Label();
            this.lblApellidoChoferValor = new System.Windows.Forms.Label();
            this.lblNombreChoferValor = new System.Windows.Forms.Label();
            this.lblIDChoferValor = new System.Windows.Forms.Label();
            this.lnkChofer = new System.Windows.Forms.LinkLabel();
            this.lblApellidoChofer = new System.Windows.Forms.Label();
            this.lblNombreChofer = new System.Windows.Forms.Label();
            this.lblIDChofer = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblMontoTotalValor = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblPcj = new System.Windows.Forms.Label();
            this.lblPcjValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(96, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 19);
            this.lblFecha.TabIndex = 41;
            this.lblFecha.Text = "Fecha";
            // 
            // datetimeFecha
            // 
            this.datetimeFecha.CustomFormat = "dd/MM/yyyy";
            this.datetimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeFecha.Location = new System.Drawing.Point(70, 55);
            this.datetimeFecha.Name = "datetimeFecha";
            this.datetimeFecha.Size = new System.Drawing.Size(120, 20);
            this.datetimeFecha.TabIndex = 40;
            this.datetimeFecha.ValueChanged += new System.EventHandler(this.datetimeFecha_ValueChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(303, 31);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(57, 19);
            this.lblTurno.TabIndex = 43;
            this.lblTurno.Text = "Turno";
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
            this.dgViajes.Location = new System.Drawing.Point(29, 135);
            this.dgViajes.MultiSelect = false;
            this.dgViajes.Name = "dgViajes";
            this.dgViajes.ReadOnly = true;
            this.dgViajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgViajes.Size = new System.Drawing.Size(762, 300);
            this.dgViajes.TabIndex = 44;
            // 
            // lblViajes
            // 
            this.lblViajes.AutoSize = true;
            this.lblViajes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViajes.Location = new System.Drawing.Point(25, 100);
            this.lblViajes.Name = "lblViajes";
            this.lblViajes.Size = new System.Drawing.Size(135, 19);
            this.lblViajes.TabIndex = 45;
            this.lblViajes.Text = "Viajes A Rendir";
            // 
            // lblApellidoChoferValor
            // 
            this.lblApellidoChoferValor.AutoSize = true;
            this.lblApellidoChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidoChoferValor.Location = new System.Drawing.Point(652, 80);
            this.lblApellidoChoferValor.Name = "lblApellidoChoferValor";
            this.lblApellidoChoferValor.Size = new System.Drawing.Size(0, 14);
            this.lblApellidoChoferValor.TabIndex = 53;
            // 
            // lblNombreChoferValor
            // 
            this.lblNombreChoferValor.AutoSize = true;
            this.lblNombreChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreChoferValor.Location = new System.Drawing.Point(532, 80);
            this.lblNombreChoferValor.Name = "lblNombreChoferValor";
            this.lblNombreChoferValor.Size = new System.Drawing.Size(0, 14);
            this.lblNombreChoferValor.TabIndex = 52;
            // 
            // lblIDChoferValor
            // 
            this.lblIDChoferValor.AutoSize = true;
            this.lblIDChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIDChoferValor.Location = new System.Drawing.Point(482, 80);
            this.lblIDChoferValor.Name = "lblIDChoferValor";
            this.lblIDChoferValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIDChoferValor.Size = new System.Drawing.Size(104, 14);
            this.lblIDChoferValor.TabIndex = 51;
            this.lblIDChoferValor.Text = "Busque un chofer";
            // 
            // lnkChofer
            // 
            this.lnkChofer.AutoSize = true;
            this.lnkChofer.Location = new System.Drawing.Point(552, 33);
            this.lnkChofer.Name = "lnkChofer";
            this.lnkChofer.Size = new System.Drawing.Size(82, 13);
            this.lnkChofer.TabIndex = 42;
            this.lnkChofer.TabStop = true;
            this.lnkChofer.Text = "Buscar chofer...";
            this.lnkChofer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCliente_LinkClicked);
            // 
            // lblApellidoChofer
            // 
            this.lblApellidoChofer.AutoSize = true;
            this.lblApellidoChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChofer.Location = new System.Drawing.Point(652, 55);
            this.lblApellidoChofer.Name = "lblApellidoChofer";
            this.lblApellidoChofer.Size = new System.Drawing.Size(49, 14);
            this.lblApellidoChofer.TabIndex = 49;
            this.lblApellidoChofer.Text = "Apellido";
            this.lblApellidoChofer.UseMnemonic = false;
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.AutoSize = true;
            this.lblNombreChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChofer.Location = new System.Drawing.Point(532, 55);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(50, 14);
            this.lblNombreChofer.TabIndex = 48;
            this.lblNombreChofer.Text = "Nombre";
            this.lblNombreChofer.UseMnemonic = false;
            // 
            // lblIDChofer
            // 
            this.lblIDChofer.AutoSize = true;
            this.lblIDChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDChofer.Location = new System.Drawing.Point(482, 55);
            this.lblIDChofer.Name = "lblIDChofer";
            this.lblIDChofer.Size = new System.Drawing.Size(19, 14);
            this.lblIDChofer.TabIndex = 47;
            this.lblIDChofer.Text = "ID";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChofer.Location = new System.Drawing.Point(472, 30);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(63, 19);
            this.lblChofer.TabIndex = 46;
            this.lblChofer.Text = "Chofer";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(560, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(678, 456);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 43;
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
            this.lblMontoTotalValor.Size = new System.Drawing.Size(150, 30);
            this.lblMontoTotalValor.TabIndex = 57;
            this.lblMontoTotalValor.Text = "$";
            this.lblMontoTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(262, 53);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(150, 21);
            this.cmbTurno.TabIndex = 41;
            this.cmbTurno.SelectionChangeCommitted += new System.EventHandler(this.cmbTurno_SelectionChangeCommitted);
            // 
            // lblPcj
            // 
            this.lblPcj.AutoSize = true;
            this.lblPcj.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcj.Location = new System.Drawing.Point(300, 460);
            this.lblPcj.Name = "lblPcj";
            this.lblPcj.Size = new System.Drawing.Size(186, 19);
            this.lblPcj.TabIndex = 59;
            this.lblPcj.Text = "Porcentaje A Utilizar:";
            // 
            // lblPcjValor
            // 
            this.lblPcjValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPcjValor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcjValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPcjValor.Location = new System.Drawing.Point(483, 454);
            this.lblPcjValor.Name = "lblPcjValor";
            this.lblPcjValor.Size = new System.Drawing.Size(68, 30);
            this.lblPcjValor.TabIndex = 60;
            this.lblPcjValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 507);
            this.Controls.Add(this.lblPcjValor);
            this.Controls.Add(this.lblPcj);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblMontoTotalValor);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblApellidoChoferValor);
            this.Controls.Add(this.lblNombreChoferValor);
            this.Controls.Add(this.lblIDChoferValor);
            this.Controls.Add(this.lnkChofer);
            this.Controls.Add(this.lblApellidoChofer);
            this.Controls.Add(this.lblNombreChofer);
            this.Controls.Add(this.lblIDChofer);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.lblViajes);
            this.Controls.Add(this.dgViajes);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.datetimeFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rendicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendicion Viajes de Chofer";
            this.Load += new System.EventHandler(this.Rendicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker datetimeFecha;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DataGridView dgViajes;
        private System.Windows.Forms.Label lblViajes;
        private System.Windows.Forms.Label lblApellidoChoferValor;
        private System.Windows.Forms.Label lblNombreChoferValor;
        private System.Windows.Forms.Label lblIDChoferValor;
        private System.Windows.Forms.LinkLabel lnkChofer;
        private System.Windows.Forms.Label lblApellidoChofer;
        private System.Windows.Forms.Label lblNombreChofer;
        private System.Windows.Forms.Label lblIDChofer;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblMontoTotal;
        public System.Windows.Forms.Label lblMontoTotalValor;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblPcj;
        public System.Windows.Forms.Label lblPcjValor;
    }
}