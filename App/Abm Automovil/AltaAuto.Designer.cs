namespace UberFrba.Abm_Automovil
{
    partial class AltaAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAuto));
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtBoxPatente = new System.Windows.Forms.TextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lnkChofer = new System.Windows.Forms.LinkLabel();
            this.lblApellidoChofer = new System.Windows.Forms.Label();
            this.lblNombreChofer = new System.Windows.Forms.Label();
            this.lblUserChofer = new System.Windows.Forms.Label();
            this.lblUserChoferValor = new System.Windows.Forms.Label();
            this.lblNombreChoferValor = new System.Windows.Forms.Label();
            this.lblApellidoChoferValor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(30, 20);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 19);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(150, 20);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(150, 22);
            this.cmbMarca.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(30, 60);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(68, 19);
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "Modelo";
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Location = new System.Drawing.Point(150, 60);
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(150, 22);
            this.txtBoxModelo.TabIndex = 4;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(30, 100);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(74, 19);
            this.lblPatente.TabIndex = 5;
            this.lblPatente.Text = "Patente";
            // 
            // txtBoxPatente
            // 
            this.txtBoxPatente.Location = new System.Drawing.Point(150, 100);
            this.txtBoxPatente.Name = "txtBoxPatente";
            this.txtBoxPatente.Size = new System.Drawing.Size(150, 22);
            this.txtBoxPatente.TabIndex = 6;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(30, 140);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(57, 19);
            this.lblTurno.TabIndex = 7;
            this.lblTurno.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(150, 140);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(150, 22);
            this.cmbTurno.TabIndex = 8;
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChofer.Location = new System.Drawing.Point(30, 180);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(63, 19);
            this.lblChofer.TabIndex = 9;
            this.lblChofer.Text = "Chofer";
            // 
            // lnkChofer
            // 
            this.lnkChofer.AutoSize = true;
            this.lnkChofer.Location = new System.Drawing.Point(150, 183);
            this.lnkChofer.Name = "lnkChofer";
            this.lnkChofer.Size = new System.Drawing.Size(93, 14);
            this.lnkChofer.TabIndex = 10;
            this.lnkChofer.TabStop = true;
            this.lnkChofer.Text = "Buscar chofer...";
            // 
            // lblApellidoChofer
            // 
            this.lblApellidoChofer.AutoSize = true;
            this.lblApellidoChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChofer.Location = new System.Drawing.Point(40, 265);
            this.lblApellidoChofer.Name = "lblApellidoChofer";
            this.lblApellidoChofer.Size = new System.Drawing.Size(49, 14);
            this.lblApellidoChofer.TabIndex = 14;
            this.lblApellidoChofer.Text = "Apellido";
            this.lblApellidoChofer.UseMnemonic = false;
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.AutoSize = true;
            this.lblNombreChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChofer.Location = new System.Drawing.Point(40, 240);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(50, 14);
            this.lblNombreChofer.TabIndex = 13;
            this.lblNombreChofer.Text = "Nombre";
            this.lblNombreChofer.UseMnemonic = false;
            // 
            // lblUserChofer
            // 
            this.lblUserChofer.AutoSize = true;
            this.lblUserChofer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserChofer.Location = new System.Drawing.Point(40, 215);
            this.lblUserChofer.Name = "lblUserChofer";
            this.lblUserChofer.Size = new System.Drawing.Size(111, 14);
            this.lblUserChofer.TabIndex = 12;
            this.lblUserChofer.Text = "Nombre de Usuario";
            // 
            // lblUserChoferValor
            // 
            this.lblUserChoferValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserChoferValor.Location = new System.Drawing.Point(150, 215);
            this.lblUserChoferValor.Name = "lblUserChoferValor";
            this.lblUserChoferValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserChoferValor.Size = new System.Drawing.Size(150, 14);
            this.lblUserChoferValor.TabIndex = 15;
            this.lblUserChoferValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreChoferValor
            // 
            this.lblNombreChoferValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombreChoferValor.Location = new System.Drawing.Point(150, 240);
            this.lblNombreChoferValor.Name = "lblNombreChoferValor";
            this.lblNombreChoferValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreChoferValor.Size = new System.Drawing.Size(150, 14);
            this.lblNombreChoferValor.TabIndex = 16;
            this.lblNombreChoferValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellidoChoferValor
            // 
            this.lblApellidoChoferValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellidoChoferValor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoChoferValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblApellidoChoferValor.Location = new System.Drawing.Point(150, 265);
            this.lblApellidoChoferValor.Name = "lblApellidoChoferValor";
            this.lblApellidoChoferValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblApellidoChoferValor.Size = new System.Drawing.Size(150, 14);
            this.lblApellidoChoferValor.TabIndex = 17;
            this.lblApellidoChoferValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(60, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(190, 310);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 30);
            this.btnIngresar.TabIndex = 25;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // AltaAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblApellidoChoferValor);
            this.Controls.Add(this.lblNombreChoferValor);
            this.Controls.Add(this.lblUserChoferValor);
            this.Controls.Add(this.lblApellidoChofer);
            this.Controls.Add(this.lblNombreChofer);
            this.Controls.Add(this.lblUserChofer);
            this.Controls.Add(this.lnkChofer);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtBoxPatente);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Automóvil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtBoxModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtBoxPatente;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.LinkLabel lnkChofer;
        private System.Windows.Forms.Label lblApellidoChofer;
        private System.Windows.Forms.Label lblNombreChofer;
        private System.Windows.Forms.Label lblUserChofer;
        private System.Windows.Forms.Label lblUserChoferValor;
        private System.Windows.Forms.Label lblNombreChoferValor;
        private System.Windows.Forms.Label lblApellidoChoferValor;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresar;
    }
}