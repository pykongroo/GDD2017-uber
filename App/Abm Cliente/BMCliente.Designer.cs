namespace UberFrba.Abm_Cliente
{
    partial class BajaModificarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.filtrosBox = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textFiltroDNI = new System.Windows.Forms.TextBox();
            this.textFiltroApellido = new System.Windows.Forms.TextBox();
            this.textFiltroNombre = new System.Windows.Forms.TextBox();
            this.labelFiltroDNI = new System.Windows.Forms.Label();
            this.labelFiltroApellido = new System.Windows.Forms.Label();
            this.labelFiltroNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.filtrosBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(7, 20);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.Size = new System.Drawing.Size(447, 150);
            this.dataGridCliente.TabIndex = 0;
            this.dataGridCliente.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCliente_RowHeaderMouseDoubleClick);
            // 
            // filtrosBox
            // 
            this.filtrosBox.Controls.Add(this.buttonCancelar);
            this.filtrosBox.Controls.Add(this.buttonBuscar);
            this.filtrosBox.Controls.Add(this.textFiltroDNI);
            this.filtrosBox.Controls.Add(this.textFiltroApellido);
            this.filtrosBox.Controls.Add(this.textFiltroNombre);
            this.filtrosBox.Controls.Add(this.labelFiltroDNI);
            this.filtrosBox.Controls.Add(this.labelFiltroApellido);
            this.filtrosBox.Controls.Add(this.labelFiltroNombre);
            this.filtrosBox.Location = new System.Drawing.Point(12, 12);
            this.filtrosBox.Name = "filtrosBox";
            this.filtrosBox.Size = new System.Drawing.Size(460, 103);
            this.filtrosBox.TabIndex = 5;
            this.filtrosBox.TabStop = false;
            this.filtrosBox.Text = "Filtros";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(347, 60);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(347, 30);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textFiltroDNI
            // 
            this.textFiltroDNI.Location = new System.Drawing.Point(61, 71);
            this.textFiltroDNI.Name = "textFiltroDNI";
            this.textFiltroDNI.Size = new System.Drawing.Size(155, 20);
            this.textFiltroDNI.TabIndex = 5;
            // 
            // textFiltroApellido
            // 
            this.textFiltroApellido.Location = new System.Drawing.Point(61, 45);
            this.textFiltroApellido.Name = "textFiltroApellido";
            this.textFiltroApellido.Size = new System.Drawing.Size(155, 20);
            this.textFiltroApellido.TabIndex = 4;
            // 
            // textFiltroNombre
            // 
            this.textFiltroNombre.Location = new System.Drawing.Point(61, 20);
            this.textFiltroNombre.Name = "textFiltroNombre";
            this.textFiltroNombre.Size = new System.Drawing.Size(155, 20);
            this.textFiltroNombre.TabIndex = 3;
            // 
            // labelFiltroDNI
            // 
            this.labelFiltroDNI.AutoSize = true;
            this.labelFiltroDNI.Location = new System.Drawing.Point(7, 74);
            this.labelFiltroDNI.Name = "labelFiltroDNI";
            this.labelFiltroDNI.Size = new System.Drawing.Size(29, 13);
            this.labelFiltroDNI.TabIndex = 2;
            this.labelFiltroDNI.Text = "DNI:";
            // 
            // labelFiltroApellido
            // 
            this.labelFiltroApellido.AutoSize = true;
            this.labelFiltroApellido.Location = new System.Drawing.Point(7, 49);
            this.labelFiltroApellido.Name = "labelFiltroApellido";
            this.labelFiltroApellido.Size = new System.Drawing.Size(47, 13);
            this.labelFiltroApellido.TabIndex = 1;
            this.labelFiltroApellido.Text = "Apellido:";
            // 
            // labelFiltroNombre
            // 
            this.labelFiltroNombre.AutoSize = true;
            this.labelFiltroNombre.Location = new System.Drawing.Point(7, 20);
            this.labelFiltroNombre.Name = "labelFiltroNombre";
            this.labelFiltroNombre.Size = new System.Drawing.Size(47, 13);
            this.labelFiltroNombre.TabIndex = 0;
            this.labelFiltroNombre.Text = "Nombre:";
            // 
            // BajaModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filtrosBox);
            this.Name = "BajaModificarCliente";
            this.Text = "Baja/Modificacion Cliente";
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
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textFiltroDNI;
        private System.Windows.Forms.TextBox textFiltroApellido;
        private System.Windows.Forms.TextBox textFiltroNombre;
        private System.Windows.Forms.Label labelFiltroDNI;
        private System.Windows.Forms.Label labelFiltroApellido;
        private System.Windows.Forms.Label labelFiltroNombre;
    }
}