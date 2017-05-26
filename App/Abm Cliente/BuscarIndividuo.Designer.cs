namespace UberFrba.Abm_Cliente
{
    partial class BuscarIndividuo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarIndividuo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgIndividuo = new System.Windows.Forms.DataGridView();
            this.filtrosBox = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelFiltroDNI = new System.Windows.Forms.Label();
            this.labelFiltroApellido = new System.Windows.Forms.Label();
            this.labelFiltroNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIndividuo)).BeginInit();
            this.filtrosBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgIndividuo);
            this.groupBox1.Location = new System.Drawing.Point(20, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // dgIndividuo
            // 
            this.dgIndividuo.AllowUserToAddRows = false;
            this.dgIndividuo.AllowUserToDeleteRows = false;
            this.dgIndividuo.AllowUserToResizeColumns = false;
            this.dgIndividuo.AllowUserToResizeRows = false;
            this.dgIndividuo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgIndividuo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgIndividuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgIndividuo.Location = new System.Drawing.Point(13, 22);
            this.dgIndividuo.MultiSelect = false;
            this.dgIndividuo.Name = "dgIndividuo";
            this.dgIndividuo.ReadOnly = true;
            this.dgIndividuo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgIndividuo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIndividuo.Size = new System.Drawing.Size(410, 250);
            this.dgIndividuo.TabIndex = 0;
            this.dgIndividuo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCliente_RowHeaderMouseDoubleClick);
            // 
            // filtrosBox
            // 
            this.filtrosBox.Controls.Add(this.btnCancelar);
            this.filtrosBox.Controls.Add(this.btnSeleccionar);
            this.filtrosBox.Controls.Add(this.txtDNI);
            this.filtrosBox.Controls.Add(this.txtApellido);
            this.filtrosBox.Controls.Add(this.txtNombre);
            this.filtrosBox.Controls.Add(this.labelFiltroDNI);
            this.filtrosBox.Controls.Add(this.labelFiltroApellido);
            this.filtrosBox.Controls.Add(this.labelFiltroNombre);
            this.filtrosBox.Location = new System.Drawing.Point(20, 20);
            this.filtrosBox.Name = "filtrosBox";
            this.filtrosBox.Size = new System.Drawing.Size(440, 125);
            this.filtrosBox.TabIndex = 5;
            this.filtrosBox.TabStop = false;
            this.filtrosBox.Text = "Filtros";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(300, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(300, 30);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(71, 86);
            this.txtDNI.MaxLength = 18;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(180, 22);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(71, 56);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 22);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // labelFiltroDNI
            // 
            this.labelFiltroDNI.AutoSize = true;
            this.labelFiltroDNI.Location = new System.Drawing.Point(10, 90);
            this.labelFiltroDNI.Name = "labelFiltroDNI";
            this.labelFiltroDNI.Size = new System.Drawing.Size(27, 14);
            this.labelFiltroDNI.TabIndex = 2;
            this.labelFiltroDNI.Text = "DNI";
            // 
            // labelFiltroApellido
            // 
            this.labelFiltroApellido.AutoSize = true;
            this.labelFiltroApellido.Location = new System.Drawing.Point(10, 60);
            this.labelFiltroApellido.Name = "labelFiltroApellido";
            this.labelFiltroApellido.Size = new System.Drawing.Size(49, 14);
            this.labelFiltroApellido.TabIndex = 1;
            this.labelFiltroApellido.Text = "Apellido";
            // 
            // labelFiltroNombre
            // 
            this.labelFiltroNombre.AutoSize = true;
            this.labelFiltroNombre.Location = new System.Drawing.Point(10, 30);
            this.labelFiltroNombre.Name = "labelFiltroNombre";
            this.labelFiltroNombre.Size = new System.Drawing.Size(50, 14);
            this.labelFiltroNombre.TabIndex = 0;
            this.labelFiltroNombre.Text = "Nombre";
            // 
            // BuscarIndividuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filtrosBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarIndividuo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIndividuo)).EndInit();
            this.filtrosBox.ResumeLayout(false);
            this.filtrosBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgIndividuo;
        private System.Windows.Forms.GroupBox filtrosBox;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelFiltroDNI;
        private System.Windows.Forms.Label labelFiltroApellido;
        private System.Windows.Forms.Label labelFiltroNombre;
        private System.Windows.Forms.Button btnCancelar;
    }
}