namespace UberFrba
{
    partial class Login
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.botonLogueo = new System.Windows.Forms.Button();
            this.botonInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(33, 61);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(31, 104);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Contraseña:";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(118, 58);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(106, 20);
            this.textUser.TabIndex = 2;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(118, 101);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(106, 20);
            this.textPass.TabIndex = 3;
            // 
            // botonLogueo
            // 
            this.botonLogueo.Location = new System.Drawing.Point(34, 164);
            this.botonLogueo.Name = "botonLogueo";
            this.botonLogueo.Size = new System.Drawing.Size(94, 39);
            this.botonLogueo.TabIndex = 4;
            this.botonLogueo.Text = "Loguear";
            this.botonLogueo.UseVisualStyleBackColor = true;
            this.botonLogueo.Click += new System.EventHandler(this.Loguear);
            // 
            // botonInicio
            // 
            this.botonInicio.Location = new System.Drawing.Point(162, 164);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(94, 39);
            this.botonInicio.TabIndex = 5;
            this.botonInicio.Text = "Atras";
            this.botonInicio.UseVisualStyleBackColor = true;
            this.botonInicio.Click += new System.EventHandler(this.Volver_Inicio);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonInicio);
            this.Controls.Add(this.botonLogueo);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button botonLogueo;
        private System.Windows.Forms.Button botonInicio;
    }
}