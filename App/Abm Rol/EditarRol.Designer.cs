namespace UberFrba.Abm_Rol
{
    partial class EditarRol
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
            this.btnFuncionalidad = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lblDeshabilitado = new System.Windows.Forms.Label();
            this.radioHabilitar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFuncionalidad
            // 
            this.btnFuncionalidad.Enabled = false;
            this.btnFuncionalidad.Location = new System.Drawing.Point(435, 87);
            this.btnFuncionalidad.Name = "btnFuncionalidad";
            this.btnFuncionalidad.Size = new System.Drawing.Size(75, 21);
            this.btnFuncionalidad.TabIndex = 13;
            this.btnFuncionalidad.Text = "Agregar";
            this.btnFuncionalidad.UseVisualStyleBackColor = true;
            this.btnFuncionalidad.Click += new System.EventHandler(this.btnFuncionalidad_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(250, 394);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 32);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Guardar cambios";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gridLista
            // 
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Enabled = false;
            this.gridLista.Location = new System.Drawing.Point(12, 156);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(567, 222);
            this.gridLista.TabIndex = 11;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLista_CellContentClick);
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(181, 25);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(221, 21);
            this.cmbRoles.TabIndex = 10;
            this.cmbRoles.SelectionChangeCommitted += new System.EventHandler(this.cmbRoles_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Funcionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccionar rol";
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.Enabled = false;
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(182, 87);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(220, 21);
            this.cmbFuncionalidades.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre del rol";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Enabled = false;
            this.txtNombreRol.Location = new System.Drawing.Point(182, 61);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(219, 20);
            this.txtNombreRol.TabIndex = 16;
            // 
            // lblDeshabilitado
            // 
            this.lblDeshabilitado.AutoSize = true;
            this.lblDeshabilitado.Location = new System.Drawing.Point(67, 129);
            this.lblDeshabilitado.Name = "lblDeshabilitado";
            this.lblDeshabilitado.Size = new System.Drawing.Size(312, 13);
            this.lblDeshabilitado.TabIndex = 17;
            this.lblDeshabilitado.Text = "El rol se encuentra deshabilitado, para habilitarlo clickee el botón";
            this.lblDeshabilitado.Visible = false;
            // 
            // radioHabilitar
            // 
            this.radioHabilitar.AutoSize = true;
            this.radioHabilitar.Location = new System.Drawing.Point(388, 129);
            this.radioHabilitar.Name = "radioHabilitar";
            this.radioHabilitar.Size = new System.Drawing.Size(14, 13);
            this.radioHabilitar.TabIndex = 18;
            this.radioHabilitar.TabStop = true;
            this.radioHabilitar.UseVisualStyleBackColor = true;
            this.radioHabilitar.Visible = false;
            // 
            // EditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 438);
            this.Controls.Add(this.radioHabilitar);
            this.Controls.Add(this.lblDeshabilitado);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Controls.Add(this.btnFuncionalidad);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gridLista);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarRol";
            this.Text = "EditarRol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarRol_FormClosing);
            this.Load += new System.EventHandler(this.EditarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionalidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFuncionalidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label lblDeshabilitado;
        private System.Windows.Forms.RadioButton radioHabilitar;
    }
}