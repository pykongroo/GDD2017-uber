namespace UberFrba.Estadisticas
{
    partial class Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.labelFiltroEstadistica = new System.Windows.Forms.Label();
            this.labelFiltroTrimestre = new System.Windows.Forms.Label();
            this.labelFiltroAnio = new System.Windows.Forms.Label();
            this.cmbEstadistica = new System.Windows.Forms.ComboBox();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.dgEstadistica = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.cmbTrimestre);
            this.groupBoxFiltros.Controls.Add(this.btnCerrar);
            this.groupBoxFiltros.Controls.Add(this.cmbEstadistica);
            this.groupBoxFiltros.Controls.Add(this.txtAnio);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroEstadistica);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroTrimestre);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroAnio);
            this.groupBoxFiltros.Location = new System.Drawing.Point(25, 20);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(630, 125);
            this.groupBoxFiltros.TabIndex = 6;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(510, 26);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(80, 26);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(50, 22);
            this.txtAnio.TabIndex = 3;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            this.txtAnio.Leave += new System.EventHandler(this.txtAnio_Leave);
            // 
            // labelFiltroEstadistica
            // 
            this.labelFiltroEstadistica.AutoSize = true;
            this.labelFiltroEstadistica.Location = new System.Drawing.Point(10, 90);
            this.labelFiltroEstadistica.Name = "labelFiltroEstadistica";
            this.labelFiltroEstadistica.Size = new System.Drawing.Size(63, 14);
            this.labelFiltroEstadistica.TabIndex = 2;
            this.labelFiltroEstadistica.Text = "Estadística";
            // 
            // labelFiltroTrimestre
            // 
            this.labelFiltroTrimestre.AutoSize = true;
            this.labelFiltroTrimestre.Location = new System.Drawing.Point(10, 60);
            this.labelFiltroTrimestre.Name = "labelFiltroTrimestre";
            this.labelFiltroTrimestre.Size = new System.Drawing.Size(59, 14);
            this.labelFiltroTrimestre.TabIndex = 1;
            this.labelFiltroTrimestre.Text = "Trimestre";
            // 
            // labelFiltroAnio
            // 
            this.labelFiltroAnio.AutoSize = true;
            this.labelFiltroAnio.Location = new System.Drawing.Point(10, 30);
            this.labelFiltroAnio.Name = "labelFiltroAnio";
            this.labelFiltroAnio.Size = new System.Drawing.Size(29, 14);
            this.labelFiltroAnio.TabIndex = 0;
            this.labelFiltroAnio.Text = "Año";
            // 
            // cmbEstadistica
            // 
            this.cmbEstadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadistica.FormattingEnabled = true;
            this.cmbEstadistica.Location = new System.Drawing.Point(80, 86);
            this.cmbEstadistica.Name = "cmbEstadistica";
            this.cmbEstadistica.Size = new System.Drawing.Size(400, 22);
            this.cmbEstadistica.TabIndex = 6;
            this.cmbEstadistica.SelectedIndexChanged += new System.EventHandler(this.cmbEstadistica_SelectedIndexChanged);
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Location = new System.Drawing.Point(80, 56);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(80, 22);
            this.cmbTrimestre.TabIndex = 7;
            this.cmbTrimestre.SelectedIndexChanged += new System.EventHandler(this.cmbTrimestre_SelectedIndexChanged);
            // 
            // dgEstadistica
            // 
            this.dgEstadistica.AllowUserToAddRows = false;
            this.dgEstadistica.AllowUserToDeleteRows = false;
            this.dgEstadistica.AllowUserToResizeColumns = false;
            this.dgEstadistica.AllowUserToResizeRows = false;
            this.dgEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEstadistica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEstadistica.Location = new System.Drawing.Point(25, 180);
            this.dgEstadistica.MultiSelect = false;
            this.dgEstadistica.Name = "dgEstadistica";
            this.dgEstadistica.ReadOnly = true;
            this.dgEstadistica.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgEstadistica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstadistica.Size = new System.Drawing.Size(630, 150);
            this.dgEstadistica.TabIndex = 27;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dgEstadistica);
            this.Controls.Add(this.groupBoxFiltros);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas";
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstadistica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label labelFiltroEstadistica;
        private System.Windows.Forms.Label labelFiltroTrimestre;
        private System.Windows.Forms.Label labelFiltroAnio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.ComboBox cmbEstadistica;
        private System.Windows.Forms.DataGridView dgEstadistica;
    }
}