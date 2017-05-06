namespace UberFrba
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSeleccionRol = new System.Windows.Forms.Label();
            this.cmb_roles = new System.Windows.Forms.ComboBox();
            this.botonAceptarRol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeleccionRol
            // 
            this.labelSeleccionRol.AutoSize = true;
            this.labelSeleccionRol.Location = new System.Drawing.Point(70, 49);
            this.labelSeleccionRol.Name = "labelSeleccionRol";
            this.labelSeleccionRol.Size = new System.Drawing.Size(58, 13);
            this.labelSeleccionRol.TabIndex = 0;
            this.labelSeleccionRol.Text = "Elija un rol:";
            // 
            // cmb_roles
            // 
            this.cmb_roles.FormattingEnabled = true;
            this.cmb_roles.Location = new System.Drawing.Point(67, 87);
            this.cmb_roles.Name = "cmb_roles";
            this.cmb_roles.Size = new System.Drawing.Size(143, 21);
            this.cmb_roles.TabIndex = 1;
            this.cmb_roles.Leave += new System.EventHandler(this.cmb_roles_Leave);
            // 
            // botonAceptarRol
            // 
            this.botonAceptarRol.Location = new System.Drawing.Point(75, 140);
            this.botonAceptarRol.Name = "botonAceptarRol";
            this.botonAceptarRol.Size = new System.Drawing.Size(115, 35);
            this.botonAceptarRol.TabIndex = 2;
            this.botonAceptarRol.Text = "Aceptar";
            this.botonAceptarRol.UseVisualStyleBackColor = true;
            this.botonAceptarRol.Click += new System.EventHandler(this.Loguear_Rol);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modo Pruebas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonAceptarRol);
            this.Controls.Add(this.cmb_roles);
            this.Controls.Add(this.labelSeleccionRol);
            this.Name = "Inicio";
            this.Text = "Seleccion de Rol";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccionRol;
        private System.Windows.Forms.ComboBox cmb_roles;
        private System.Windows.Forms.Button botonAceptarRol;
        private System.Windows.Forms.Button button1;
    }
}

