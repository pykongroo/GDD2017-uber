namespace UberFrba.Abm_Automovil
{
    partial class BuscarAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarAuto));
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtBoxPatente = new System.Windows.Forms.TextBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lnkChofer = new System.Windows.Forms.LinkLabel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgAuto = new System.Windows.Forms.DataGridView();
            this.lblApellidoChoferValor = new System.Windows.Forms.Label();
            this.lblNombreChoferValor = new System.Windows.Forms.Label();
            this.lblIDChoferValor = new System.Windows.Forms.Label();
            this.lblApellidoChofer = new System.Windows.Forms.Label();
            this.lblNombreChofer = new System.Windows.Forms.Label();
            this.lblIDChofer = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(30, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 19);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(150, 20);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(150, 22);
            this.cmbMarca.TabIndex = 2;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(30, 100);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(68, 19);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Location = new System.Drawing.Point(150, 100);
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(150, 22);
            this.txtBoxModelo.TabIndex = 4;
            this.txtBoxModelo.TextChanged += new System.EventHandler(this.txtBoxModelo_TextChanged);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(30, 60);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(74, 19);
            this.lblPatente.TabIndex = 5;
            this.lblPatente.Text = "Patente";
            // 
            // txtBoxPatente
            // 
            this.txtBoxPatente.Location = new System.Drawing.Point(150, 60);
            this.txtBoxPatente.Name = "txtBoxPatente";
            this.txtBoxPatente.Size = new System.Drawing.Size(150, 22);
            this.txtBoxPatente.TabIndex = 6;
            this.txtBoxPatente.TextChanged += new System.EventHandler(this.txtBoxPatente_TextChanged);
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChofer.Location = new System.Drawing.Point(436, 23);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(63, 19);
            this.lblChofer.TabIndex = 9;
            this.lblChofer.Text = "Chofer";
            // 
            // lnkChofer
            // 
            this.lnkChofer.AutoSize = true;
            this.lnkChofer.Location = new System.Drawing.Point(547, 25);
            this.lnkChofer.Name = "lnkChofer";
            this.lnkChofer.Size = new System.Drawing.Size(54, 14);
            this.lnkChofer.TabIndex = 10;
            this.lnkChofer.TabStop = true;
            this.lnkChofer.Text = "Buscar...";
            this.lnkChofer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChofer_LinkClicked);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(550, 410);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionar.TabIndex = 23;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(440, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgAuto
            // 
            this.dgAuto.AllowUserToAddRows = false;
            this.dgAuto.AllowUserToDeleteRows = false;
            this.dgAuto.AllowUserToResizeColumns = false;
            this.dgAuto.AllowUserToResizeRows = false;
            this.dgAuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAuto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgAuto.Location = new System.Drawing.Point(34, 140);
            this.dgAuto.MultiSelect = false;
            this.dgAuto.Name = "dgAuto";
            this.dgAuto.ReadOnly = true;
            this.dgAuto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgAuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAuto.Size = new System.Drawing.Size(698, 240);
            this.dgAuto.TabIndex = 26;
            // 
            // lblApellidoChoferValor
            // 
            this.lblApellidoChoferValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellidoChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidoChoferValor.Location = new System.Drawing.Point(582, 105);
            this.lblApellidoChoferValor.Name = "lblApellidoChoferValor";
            this.lblApellidoChoferValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblApellidoChoferValor.Size = new System.Drawing.Size(150, 14);
            this.lblApellidoChoferValor.TabIndex = 32;
            this.lblApellidoChoferValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreChoferValor
            // 
            this.lblNombreChoferValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreChoferValor.Location = new System.Drawing.Point(582, 80);
            this.lblNombreChoferValor.Name = "lblNombreChoferValor";
            this.lblNombreChoferValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreChoferValor.Size = new System.Drawing.Size(150, 14);
            this.lblNombreChoferValor.TabIndex = 31;
            this.lblNombreChoferValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIDChoferValor
            // 
            this.lblIDChoferValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIDChoferValor.Location = new System.Drawing.Point(582, 55);
            this.lblIDChoferValor.Name = "lblIDChoferValor";
            this.lblIDChoferValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIDChoferValor.Size = new System.Drawing.Size(150, 14);
            this.lblIDChoferValor.TabIndex = 30;
            this.lblIDChoferValor.Text = "Busque un chofer";
            this.lblIDChoferValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellidoChofer
            // 
            this.lblApellidoChofer.AutoSize = true;
            this.lblApellidoChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChofer.Location = new System.Drawing.Point(437, 105);
            this.lblApellidoChofer.Name = "lblApellidoChofer";
            this.lblApellidoChofer.Size = new System.Drawing.Size(49, 14);
            this.lblApellidoChofer.TabIndex = 29;
            this.lblApellidoChofer.Text = "Apellido";
            this.lblApellidoChofer.UseMnemonic = false;
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.AutoSize = true;
            this.lblNombreChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChofer.Location = new System.Drawing.Point(437, 80);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(50, 14);
            this.lblNombreChofer.TabIndex = 28;
            this.lblNombreChofer.Text = "Nombre";
            this.lblNombreChofer.UseMnemonic = false;
            // 
            // lblIDChofer
            // 
            this.lblIDChofer.AutoSize = true;
            this.lblIDChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDChofer.Location = new System.Drawing.Point(437, 55);
            this.lblIDChofer.Name = "lblIDChofer";
            this.lblIDChofer.Size = new System.Drawing.Size(19, 14);
            this.lblIDChofer.TabIndex = 27;
            this.lblIDChofer.Text = "ID";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(657, 20);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BuscarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 461);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblApellidoChoferValor);
            this.Controls.Add(this.lblNombreChoferValor);
            this.Controls.Add(this.lblIDChoferValor);
            this.Controls.Add(this.lblApellidoChofer);
            this.Controls.Add(this.lblNombreChofer);
            this.Controls.Add(this.lblIDChofer);
            this.Controls.Add(this.dgAuto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lnkChofer);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.txtBoxPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Automóvil";
            ((System.ComponentModel.ISupportInitialize)(this.dgAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtBoxModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtBoxPatente;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.LinkLabel lnkChofer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgAuto;
        private System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.Label lblApellidoChoferValor;
        public System.Windows.Forms.Label lblNombreChoferValor;
        public System.Windows.Forms.Label lblIDChoferValor;
        private System.Windows.Forms.Label lblApellidoChofer;
        private System.Windows.Forms.Label lblNombreChofer;
        private System.Windows.Forms.Label lblIDChofer;
        public System.Windows.Forms.Button btnLimpiar;
    }
}