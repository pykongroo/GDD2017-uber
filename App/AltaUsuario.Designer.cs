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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.cmb_roles = new UberFrba.Utils.CustomComboBox();
            this.passwordInput = new UberFrba.Utils.PasswordInput();
            this.username = new UberFrba.Utils.CustomTextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(59, 242);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(87, 25);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(191, 242);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 25);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // cmb_roles
            // 
            this.cmb_roles.Location = new System.Drawing.Point(34, 145);
            this.cmb_roles.Name = "cmb_roles";
            this.cmb_roles.Size = new System.Drawing.Size(294, 37);
            this.cmb_roles.TabIndex = 12;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(34, 70);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(294, 60);
            this.passwordInput.TabIndex = 11;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(34, 25);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(294, 39);
            this.username.TabIndex = 10;
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 280);
            this.Controls.Add(this.cmb_roles);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.username);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private Utils.CustomTextBox username;
        private Utils.PasswordInput passwordInput;
        private Utils.CustomComboBox cmb_roles;
    }
}