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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarRol));
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
            this.btnFuncionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuncionalidad.Enabled = false;
            this.btnFuncionalidad.Location = new System.Drawing.Point(507, 94);
            this.btnFuncionalidad.Name = "btnFuncionalidad";
            this.btnFuncionalidad.Size = new System.Drawing.Size(87, 23);
            this.btnFuncionalidad.TabIndex = 13;
            this.btnFuncionalidad.Text = "Agregar";
            this.btnFuncionalidad.UseVisualStyleBackColor = true;
            this.btnFuncionalidad.Click += new System.EventHandler(this.btnFuncionalidad_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(292, 424);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 34);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Guardar cambios";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gridLista
            // 
            this.gridLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Enabled = false;
            this.gridLista.Location = new System.Drawing.Point(14, 168);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(661, 239);
            this.gridLista.TabIndex = 11;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLista_CellContentClick);
            // 
            // cmbRoles
            // 
            this.cmbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(211, 27);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(257, 22);
            this.cmbRoles.TabIndex = 10;
            this.cmbRoles.SelectionChangeCommitted += new System.EventHandler(this.cmbRoles_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Funcionalidad";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccionar rol";
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFuncionalidades.Enabled = false;
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(212, 94);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(256, 22);
            this.cmbFuncionalidades.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre del rol";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreRol.Enabled = false;
            this.txtNombreRol.Location = new System.Drawing.Point(212, 66);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(255, 22);
            this.txtNombreRol.TabIndex = 16;
            // 
            // lblDeshabilitado
            // 
            this.lblDeshabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeshabilitado.AutoSize = true;
            this.lblDeshabilitado.Location = new System.Drawing.Point(78, 139);
            this.lblDeshabilitado.Name = "lblDeshabilitado";
            this.lblDeshabilitado.Size = new System.Drawing.Size(358, 14);
            this.lblDeshabilitado.TabIndex = 17;
            this.lblDeshabilitado.Text = "El rol se encuentra deshabilitado, para habilitarlo clickee el botón";
            this.lblDeshabilitado.Visible = false;
            // 
            // radioHabilitar
            // 
            this.radioHabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioHabilitar.AutoSize = true;
            this.radioHabilitar.Location = new System.Drawing.Point(453, 139);
            this.radioHabilitar.Name = "radioHabilitar";
            this.radioHabilitar.Size = new System.Drawing.Size(14, 13);
            this.radioHabilitar.TabIndex = 18;
            this.radioHabilitar.TabStop = true;
            this.radioHabilitar.UseVisualStyleBackColor = true;
            this.radioHabilitar.Visible = false;
            // 
            // EditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 472);
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
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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