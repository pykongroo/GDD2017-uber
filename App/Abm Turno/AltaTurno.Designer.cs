namespace UberFrba.Abm_Turno
{
    partial class AltaTurno
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.numHoraFin = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.numValorKM = new System.Windows.Forms.NumericUpDown();
            this.numPrecioBase = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Finalizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio base";
            // 
            // numHoraInicio
            // 
            this.numHoraInicio.Location = new System.Drawing.Point(185, 19);
            this.numHoraInicio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoraInicio.Name = "numHoraInicio";
            this.numHoraInicio.Size = new System.Drawing.Size(50, 20);
            this.numHoraInicio.TabIndex = 5;
            // 
            // numHoraFin
            // 
            this.numHoraFin.Location = new System.Drawing.Point(185, 42);
            this.numHoraFin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoraFin.Name = "numHoraFin";
            this.numHoraFin.Size = new System.Drawing.Size(50, 20);
            this.numHoraFin.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(135, 67);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // numValorKM
            // 
            this.numValorKM.DecimalPlaces = 2;
            this.numValorKM.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numValorKM.Location = new System.Drawing.Point(185, 91);
            this.numValorKM.Name = "numValorKM";
            this.numValorKM.Size = new System.Drawing.Size(50, 20);
            this.numValorKM.TabIndex = 8;
            // 
            // numPrecioBase
            // 
            this.numPrecioBase.DecimalPlaces = 2;
            this.numPrecioBase.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPrecioBase.Location = new System.Drawing.Point(185, 115);
            this.numPrecioBase.Name = "numPrecioBase";
            this.numPrecioBase.Size = new System.Drawing.Size(50, 20);
            this.numPrecioBase.TabIndex = 9;
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(69, 151);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarTurno.TabIndex = 11;
            this.btnAgregarTurno.Text = "Agregar turno";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 196);
            this.Controls.Add(this.btnAgregarTurno);
            this.Controls.Add(this.numPrecioBase);
            this.Controls.Add(this.numValorKM);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.numHoraFin);
            this.Controls.Add(this.numHoraInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaTurno";
            this.Text = "AltaTurno";
            this.Load += new System.EventHandler(this.AltaTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHoraInicio;
        private System.Windows.Forms.NumericUpDown numHoraFin;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown numValorKM;
        private System.Windows.Forms.NumericUpDown numPrecioBase;
        private System.Windows.Forms.Button btnAgregarTurno;
    }
}