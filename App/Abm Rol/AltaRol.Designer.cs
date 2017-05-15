namespace UberFrba.Abm_Rol
{
    partial class AltaRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFuncionalidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidad";
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(193, 54);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(211, 21);
            this.cmbFuncionalidades.TabIndex = 3;
            this.cmbFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionalidades_SelectedIndexChanged);
            // 
            // gridLista
            // 
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(12, 102);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(566, 273);
            this.gridLista.TabIndex = 4;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(241, 398);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar rol";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFuncionalidad
            // 
            this.btnFuncionalidad.Location = new System.Drawing.Point(433, 54);
            this.btnFuncionalidad.Name = "btnFuncionalidad";
            this.btnFuncionalidad.Size = new System.Drawing.Size(75, 23);
            this.btnFuncionalidad.TabIndex = 6;
            this.btnFuncionalidad.Text = "Agregar";
            this.btnFuncionalidad.UseVisualStyleBackColor = true;
            this.btnFuncionalidad.Click += new System.EventHandler(this.btnFuncionalidad_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 442);
            this.Controls.Add(this.btnFuncionalidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridLista);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "AltaRol";
            this.Text = "AltaRol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaRol_FormClosing);
            this.Load += new System.EventHandler(this.AltaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFuncionalidades;
        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFuncionalidad;

    }
}