namespace UberFrba
{
    partial class AltaUsuario
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPassC = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.labelStatUser = new System.Windows.Forms.Label();
            this.labelStatPass = new System.Windows.Forms.Label();
            this.labelStatRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(43, 46);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(46, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Usuario:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(43, 73);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Contraseña:";
            // 
            // labelPassC
            // 
            this.labelPassC.AutoSize = true;
            this.labelPassC.Location = new System.Drawing.Point(43, 98);
            this.labelPassC.Name = "labelPassC";
            this.labelPassC.Size = new System.Drawing.Size(97, 13);
            this.labelPassC.TabIndex = 2;
            this.labelPassC.Text = "Repita contraseña:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(151, 46);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(151, 70);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(151, 95);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.PasswordChar = '*';
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordConfirm.TabIndex = 5;
            this.textBoxPasswordConfirm.Leave += new System.EventHandler(this.textBoxPasswordConfirm_Leave);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(46, 138);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(26, 13);
            this.labelRol.TabIndex = 6;
            this.labelRol.Text = "Rol:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(46, 184);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(151, 184);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(151, 138);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRoles.TabIndex = 10;
            this.comboBoxRoles.Leave += new System.EventHandler(this.comboBoxRoles_Leave);
            // 
            // labelStatUser
            // 
            this.labelStatUser.AutoSize = true;
            this.labelStatUser.BackColor = System.Drawing.Color.Gray;
            this.labelStatUser.Location = new System.Drawing.Point(257, 49);
            this.labelStatUser.Name = "labelStatUser";
            this.labelStatUser.Size = new System.Drawing.Size(13, 13);
            this.labelStatUser.TabIndex = 11;
            this.labelStatUser.Text = "  ";
            // 
            // labelStatPass
            // 
            this.labelStatPass.AutoSize = true;
            this.labelStatPass.BackColor = System.Drawing.Color.Gray;
            this.labelStatPass.Location = new System.Drawing.Point(257, 77);
            this.labelStatPass.Name = "labelStatPass";
            this.labelStatPass.Size = new System.Drawing.Size(13, 13);
            this.labelStatPass.TabIndex = 12;
            this.labelStatPass.Text = "  ";
            // 
            // labelStatRol
            // 
            this.labelStatRol.AutoSize = true;
            this.labelStatRol.BackColor = System.Drawing.Color.Gray;
            this.labelStatRol.Location = new System.Drawing.Point(257, 141);
            this.labelStatRol.Name = "labelStatRol";
            this.labelStatRol.Size = new System.Drawing.Size(13, 13);
            this.labelStatRol.TabIndex = 13;
            this.labelStatRol.Text = "  ";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelStatRol);
            this.Controls.Add(this.labelStatPass);
            this.Controls.Add(this.labelStatUser);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassC);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "AltaUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPassC;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label labelStatUser;
        private System.Windows.Forms.Label labelStatPass;
        private System.Windows.Forms.Label labelStatRol;
    }
}