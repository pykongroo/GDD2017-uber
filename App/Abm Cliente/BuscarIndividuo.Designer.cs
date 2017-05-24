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
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.filtrosBox = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.textFiltroDNI = new System.Windows.Forms.TextBox();
            this.textFiltroApellido = new System.Windows.Forms.TextBox();
            this.textFiltroNombre = new System.Windows.Forms.TextBox();
            this.labelFiltroDNI = new System.Windows.Forms.Label();
            this.labelFiltroApellido = new System.Windows.Forms.Label();
            this.labelFiltroNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.filtrosBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridCliente);
            this.groupBox1.Location = new System.Drawing.Point(20, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(13, 22);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.Size = new System.Drawing.Size(510, 150);
            this.dataGridCliente.TabIndex = 0;
            this.dataGridCliente.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCliente_RowHeaderMouseDoubleClick);
            // 
            // filtrosBox
            // 
            this.filtrosBox.Controls.Add(this.btnCancelar);
            this.filtrosBox.Controls.Add(this.btnSeleccionar);
            this.filtrosBox.Controls.Add(this.textFiltroDNI);
            this.filtrosBox.Controls.Add(this.textFiltroApellido);
            this.filtrosBox.Controls.Add(this.textFiltroNombre);
            this.filtrosBox.Controls.Add(this.labelFiltroDNI);
            this.filtrosBox.Controls.Add(this.labelFiltroApellido);
            this.filtrosBox.Controls.Add(this.labelFiltroNombre);
            this.filtrosBox.Location = new System.Drawing.Point(20, 20);
            this.filtrosBox.Name = "filtrosBox";
            this.filtrosBox.Size = new System.Drawing.Size(540, 125);
            this.filtrosBox.TabIndex = 5;
            this.filtrosBox.TabStop = false;
            this.filtrosBox.Text = "Filtros";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(400, 30);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textFiltroDNI
            // 
            this.textFiltroDNI.Location = new System.Drawing.Point(71, 86);
            this.textFiltroDNI.Name = "textFiltroDNI";
            this.textFiltroDNI.Size = new System.Drawing.Size(180, 22);
            this.textFiltroDNI.TabIndex = 5;
            // 
            // textFiltroApellido
            // 
            this.textFiltroApellido.Location = new System.Drawing.Point(71, 56);
            this.textFiltroApellido.Name = "textFiltroApellido";
            this.textFiltroApellido.Size = new System.Drawing.Size(180, 22);
            this.textFiltroApellido.TabIndex = 4;
            // 
            // textFiltroNombre
            // 
            this.textFiltroNombre.Location = new System.Drawing.Point(71, 26);
            this.textFiltroNombre.Name = "textFiltroNombre";
            this.textFiltroNombre.Size = new System.Drawing.Size(180, 22);
            this.textFiltroNombre.TabIndex = 3;
            // 
            // labelFiltroDNI
            // 
            this.labelFiltroDNI.AutoSize = true;
            this.labelFiltroDNI.Location = new System.Drawing.Point(10, 90);
            this.labelFiltroDNI.Name = "labelFiltroDNI";
            this.labelFiltroDNI.Size = new System.Drawing.Size(31, 14);
            this.labelFiltroDNI.TabIndex = 2;
            this.labelFiltroDNI.Text = "DNI:";
            // 
            // labelFiltroApellido
            // 
            this.labelFiltroApellido.AutoSize = true;
            this.labelFiltroApellido.Location = new System.Drawing.Point(10, 60);
            this.labelFiltroApellido.Name = "labelFiltroApellido";
            this.labelFiltroApellido.Size = new System.Drawing.Size(53, 14);
            this.labelFiltroApellido.TabIndex = 1;
            this.labelFiltroApellido.Text = "Apellido:";
            // 
            // labelFiltroNombre
            // 
            this.labelFiltroNombre.AutoSize = true;
            this.labelFiltroNombre.Location = new System.Drawing.Point(10, 30);
            this.labelFiltroNombre.Name = "labelFiltroNombre";
            this.labelFiltroNombre.Size = new System.Drawing.Size(54, 14);
            this.labelFiltroNombre.TabIndex = 0;
            this.labelFiltroNombre.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(400, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BuscarIndividuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filtrosBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarIndividuo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar...";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.filtrosBox.ResumeLayout(false);
            this.filtrosBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.GroupBox filtrosBox;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox textFiltroDNI;
        private System.Windows.Forms.TextBox textFiltroApellido;
        private System.Windows.Forms.TextBox textFiltroNombre;
        private System.Windows.Forms.Label labelFiltroDNI;
        private System.Windows.Forms.Label labelFiltroApellido;
        private System.Windows.Forms.Label labelFiltroNombre;
        private System.Windows.Forms.Button btnCancelar;
    }
}