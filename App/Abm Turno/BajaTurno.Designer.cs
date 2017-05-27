namespace UberFrba.Abm_Turno
{
    partial class BajaTurno
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
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.cmbTurnos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.Location = new System.Drawing.Point(174, 119);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTurno.TabIndex = 5;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // cmbTurnos
            // 
            this.cmbTurnos.FormattingEnabled = true;
            this.cmbTurnos.Location = new System.Drawing.Point(100, 53);
            this.cmbTurnos.Name = "cmbTurnos";
            this.cmbTurnos.Size = new System.Drawing.Size(213, 21);
            this.cmbTurnos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el turno a eliminar";
            // 
            // BajaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 194);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.cmbTurnos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BajaTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BajaTurno";
            this.Load += new System.EventHandler(this.BajaTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.ComboBox cmbTurnos;
        private System.Windows.Forms.Label label1;

    }
}