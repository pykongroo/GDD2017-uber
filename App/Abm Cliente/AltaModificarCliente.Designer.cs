namespace UberFrba.Abm_Cliente
{
    partial class AltaModificarCliente
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
            this.cusNombre = new UberFrba.Utils.CustomTextBox();
            this.cusApellido = new UberFrba.Utils.CustomTextBox();
            this.cusDNI = new UberFrba.Utils.CustomTextBox();
            this.cusMail = new UberFrba.Utils.CustomTextBox();
            this.cusTelefono = new UberFrba.Utils.CustomTextBox();
            this.cusDireccion = new UberFrba.Utils.CustomTextBox();
            this.cusCodPostal = new UberFrba.Utils.CustomTextBox();
            this.cusFechaNac = new UberFrba.Utils.CustomDatePick();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cusNombre
            // 
            this.cusNombre.Location = new System.Drawing.Point(13, 13);
            this.cusNombre.Name = "cusNombre";
            this.cusNombre.Size = new System.Drawing.Size(250, 30);
            this.cusNombre.TabIndex = 0;
            // 
            // cusApellido
            // 
            this.cusApellido.Location = new System.Drawing.Point(13, 50);
            this.cusApellido.Name = "cusApellido";
            this.cusApellido.Size = new System.Drawing.Size(250, 30);
            this.cusApellido.TabIndex = 1;
            // 
            // cusDNI
            // 
            this.cusDNI.Location = new System.Drawing.Point(13, 87);
            this.cusDNI.Name = "cusDNI";
            this.cusDNI.Size = new System.Drawing.Size(250, 30);
            this.cusDNI.TabIndex = 2;
            // 
            // cusMail
            // 
            this.cusMail.Location = new System.Drawing.Point(13, 124);
            this.cusMail.Name = "cusMail";
            this.cusMail.Size = new System.Drawing.Size(250, 30);
            this.cusMail.TabIndex = 3;
            // 
            // cusTelefono
            // 
            this.cusTelefono.Location = new System.Drawing.Point(13, 161);
            this.cusTelefono.Name = "cusTelefono";
            this.cusTelefono.Size = new System.Drawing.Size(250, 30);
            this.cusTelefono.TabIndex = 4;
            // 
            // cusDireccion
            // 
            this.cusDireccion.Location = new System.Drawing.Point(13, 198);
            this.cusDireccion.Name = "cusDireccion";
            this.cusDireccion.Size = new System.Drawing.Size(250, 30);
            this.cusDireccion.TabIndex = 5;
            // 
            // cusCodPostal
            // 
            this.cusCodPostal.Location = new System.Drawing.Point(13, 235);
            this.cusCodPostal.Name = "cusCodPostal";
            this.cusCodPostal.Size = new System.Drawing.Size(250, 30);
            this.cusCodPostal.TabIndex = 6;
            // 
            // cusFechaNac
            // 
            this.cusFechaNac.Location = new System.Drawing.Point(13, 272);
            this.cusFechaNac.Name = "cusFechaNac";
            this.cusFechaNac.Size = new System.Drawing.Size(250, 30);
            this.cusFechaNac.TabIndex = 7;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(31, 361);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(178, 361);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(13, 320);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(73, 17);
            this.checkBoxHabilitado.TabIndex = 10;
            this.checkBoxHabilitado.Text = "Habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // AltaModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 399);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.cusFechaNac);
            this.Controls.Add(this.cusCodPostal);
            this.Controls.Add(this.cusDireccion);
            this.Controls.Add(this.cusTelefono);
            this.Controls.Add(this.cusMail);
            this.Controls.Add(this.cusDNI);
            this.Controls.Add(this.cusApellido);
            this.Controls.Add(this.cusNombre);
            this.Name = "AltaModificarCliente";
            this.Text = "AltaModificarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.CustomTextBox cusNombre;
        private Utils.CustomTextBox cusApellido;
        private Utils.CustomTextBox cusDNI;
        private Utils.CustomTextBox cusMail;
        private Utils.CustomTextBox cusTelefono;
        private Utils.CustomTextBox cusDireccion;
        private Utils.CustomTextBox cusCodPostal;
        private Utils.CustomDatePick cusFechaNac;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.CheckBox checkBoxHabilitado;
    }
}