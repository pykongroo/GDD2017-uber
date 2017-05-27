namespace UberFrba.Abm_Turno
{
    partial class EditarTurno
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
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.numPrecioBase = new System.Windows.Forms.NumericUpDown();
            this.numValorKM = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.numHoraFin = new System.Windows.Forms.NumericUpDown();
            this.numHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioHabilitar = new System.Windows.Forms.RadioButton();
            this.lblDeshabilitado = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarTurno
            // 
            this.btnModificarTurno.Enabled = false;
            this.btnModificarTurno.Location = new System.Drawing.Point(136, 248);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(136, 35);
            this.btnModificarTurno.TabIndex = 22;
            this.btnModificarTurno.Text = "Modificar turno";
            this.btnModificarTurno.UseVisualStyleBackColor = true;
            this.btnModificarTurno.Click += new System.EventHandler(this.btnModificarTurno_Click);
            // 
            // numPrecioBase
            // 
            this.numPrecioBase.DecimalPlaces = 2;
            this.numPrecioBase.Enabled = false;
            this.numPrecioBase.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPrecioBase.Location = new System.Drawing.Point(252, 176);
            this.numPrecioBase.Name = "numPrecioBase";
            this.numPrecioBase.Size = new System.Drawing.Size(50, 20);
            this.numPrecioBase.TabIndex = 21;
            // 
            // numValorKM
            // 
            this.numValorKM.DecimalPlaces = 2;
            this.numValorKM.Enabled = false;
            this.numValorKM.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numValorKM.Location = new System.Drawing.Point(252, 152);
            this.numValorKM.Name = "numValorKM";
            this.numValorKM.Size = new System.Drawing.Size(50, 20);
            this.numValorKM.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(202, 128);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // numHoraFin
            // 
            this.numHoraFin.Enabled = false;
            this.numHoraFin.Location = new System.Drawing.Point(252, 103);
            this.numHoraFin.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoraFin.Name = "numHoraFin";
            this.numHoraFin.Size = new System.Drawing.Size(50, 20);
            this.numHoraFin.TabIndex = 18;
            // 
            // numHoraInicio
            // 
            this.numHoraInicio.Enabled = false;
            this.numHoraInicio.Location = new System.Drawing.Point(252, 80);
            this.numHoraInicio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoraInicio.Name = "numHoraInicio";
            this.numHoraInicio.Size = new System.Drawing.Size(50, 20);
            this.numHoraInicio.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(94, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(94, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(94, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(94, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hora Finalizacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(94, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hora Inicio";
            // 
            // radioHabilitar
            // 
            this.radioHabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioHabilitar.AutoSize = true;
            this.radioHabilitar.Location = new System.Drawing.Point(361, 214);
            this.radioHabilitar.Name = "radioHabilitar";
            this.radioHabilitar.Size = new System.Drawing.Size(14, 13);
            this.radioHabilitar.TabIndex = 24;
            this.radioHabilitar.TabStop = true;
            this.radioHabilitar.UseVisualStyleBackColor = true;
            this.radioHabilitar.Visible = false;
            // 
            // lblDeshabilitado
            // 
            this.lblDeshabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeshabilitado.AutoSize = true;
            this.lblDeshabilitado.Location = new System.Drawing.Point(40, 214);
            this.lblDeshabilitado.Name = "lblDeshabilitado";
            this.lblDeshabilitado.Size = new System.Drawing.Size(312, 13);
            this.lblDeshabilitado.TabIndex = 23;
            this.lblDeshabilitado.Text = "El rol se encuentra deshabilitado, para habilitarlo clickee el botón";
            this.lblDeshabilitado.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(424, 295);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 50;
            this.lineShape1.X2 = 360;
            this.lineShape1.Y1 = 58;
            this.lineShape1.Y2 = 58;
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(95, 25);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(213, 21);
            this.cmbTurnos.TabIndex = 27;
            this.cmbTurnos.SelectionChangeCommitted += new System.EventHandler(this.cmbTurnos_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Seleccione el turno a modificar";
            // 
            // EditarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 295);
            this.Controls.Add(this.cmbTurnos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioHabilitar);
            this.Controls.Add(this.lblDeshabilitado);
            this.Controls.Add(this.btnModificarTurno);
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
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarTurno";
            this.Load += new System.EventHandler(this.EditarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoraInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.NumericUpDown numPrecioBase;
        private System.Windows.Forms.NumericUpDown numValorKM;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown numHoraFin;
        private System.Windows.Forms.NumericUpDown numHoraInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioHabilitar;
        private System.Windows.Forms.Label lblDeshabilitado;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Label label6;
    }
}