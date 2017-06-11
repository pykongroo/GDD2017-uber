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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaRol));
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(225, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidad";
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(225, 58);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(245, 22);
            this.cmbFuncionalidades.TabIndex = 3;
            // 
            // gridLista
            // 
            this.gridLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(14, 110);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(660, 294);
            this.gridLista.TabIndex = 4;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(281, 429);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 34);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Rol";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFuncionalidad
            // 
            this.btnFuncionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuncionalidad.Location = new System.Drawing.Point(505, 58);
            this.btnFuncionalidad.Name = "btnFuncionalidad";
            this.btnFuncionalidad.Size = new System.Drawing.Size(87, 25);
            this.btnFuncionalidad.TabIndex = 6;
            this.btnFuncionalidad.Text = "Agregar";
            this.btnFuncionalidad.UseVisualStyleBackColor = true;
            this.btnFuncionalidad.Click += new System.EventHandler(this.btnFuncionalidad_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 476);
            this.Controls.Add(this.btnFuncionalidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridLista);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Rol";
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