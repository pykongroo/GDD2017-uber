namespace UberFrba.Abm_Rol
{
    partial class BajaRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaRol));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el rol a eliminar";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(70, 79);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(248, 22);
            this.cmbRoles.TabIndex = 1;
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Location = new System.Drawing.Point(156, 150);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(87, 25);
            this.btnEliminarRol.TabIndex = 2;
            this.btnEliminarRol.Text = "Eliminar";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 205);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BajaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja Rol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BajaRol_FormClosing);
            this.Load += new System.EventHandler(this.BajaRolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnEliminarRol;
    }
}