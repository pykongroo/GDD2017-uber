﻿namespace UberFrba
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAltaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMAltaAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMBajaAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMModiAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMAltaChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMBajaChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMModiChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMBajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMModiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMRol = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMAltaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMBajaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMModiRol = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMAltaTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMBajaTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuABMModiTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViajes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRendicion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipal,
            this.menuABM,
            this.menuViajes,
            this.menuRendicion,
            this.menuFacturacion,
            this.menuEstadisticas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAltaUsuario,
            this.menuCerrarSesion,
            this.salirToolStripMenuItem});
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(49, 20);
            this.menuPrincipal.Text = "Menu";
            // 
            // menuAltaUsuario
            // 
            this.menuAltaUsuario.Name = "menuAltaUsuario";
            this.menuAltaUsuario.Size = new System.Drawing.Size(152, 22);
            this.menuAltaUsuario.Text = "Alta Usuario";
            this.menuAltaUsuario.Visible = false;
            this.menuAltaUsuario.Click += new System.EventHandler(this.altaUsuarioToolStripMenuItem_Click);
            // 
            // menuCerrarSesion
            // 
            this.menuCerrarSesion.Name = "menuCerrarSesion";
            this.menuCerrarSesion.Size = new System.Drawing.Size(152, 22);
            this.menuCerrarSesion.Text = "Cerrar Sesión";
            this.menuCerrarSesion.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // menuABM
            // 
            this.menuABM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuABMAuto,
            this.menuABMChofer,
            this.menuABMCliente,
            this.menuABMRol,
            this.menuABMTurno});
            this.menuABM.Name = "menuABM";
            this.menuABM.Size = new System.Drawing.Size(43, 20);
            this.menuABM.Text = "ABM";
            this.menuABM.Visible = false;
            // 
            // menuABMAuto
            // 
            this.menuABMAuto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuABMAltaAuto,
            this.menuABMBajaAuto,
            this.menuABMModiAuto});
            this.menuABMAuto.Name = "menuABMAuto";
            this.menuABMAuto.Size = new System.Drawing.Size(128, 22);
            this.menuABMAuto.Text = "Automóvil";
            this.menuABMAuto.Visible = false;
            // 
            // menuABMAltaAuto
            // 
            this.menuABMAltaAuto.Name = "menuABMAltaAuto";
            this.menuABMAltaAuto.Size = new System.Drawing.Size(139, 22);
            this.menuABMAltaAuto.Text = "Alta";
            this.menuABMAltaAuto.Click += new System.EventHandler(this.menuABMAltaAuto_Click);
            // 
            // menuABMBajaAuto
            // 
            this.menuABMBajaAuto.Name = "menuABMBajaAuto";
            this.menuABMBajaAuto.Size = new System.Drawing.Size(139, 22);
            this.menuABMBajaAuto.Text = "Baja";
            this.menuABMBajaAuto.Click += new System.EventHandler(this.menuABMBajaAuto_Click);
            // 
            // menuABMModiAuto
            // 
            this.menuABMModiAuto.Name = "menuABMModiAuto";
            this.menuABMModiAuto.Size = new System.Drawing.Size(139, 22);
            this.menuABMModiAuto.Text = "Modificación";
            this.menuABMModiAuto.Click += new System.EventHandler(this.menuABMModiAuto_Click);
            // 
            // menuABMChofer
            // 
            this.menuABMChofer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuABMAltaChofer,
            this.menuABMBajaChofer,
            this.menuABMModiChofer});
            this.menuABMChofer.Name = "menuABMChofer";
            this.menuABMChofer.Size = new System.Drawing.Size(128, 22);
            this.menuABMChofer.Text = "Chofer";
            this.menuABMChofer.Visible = false;
            // 
            // menuABMAltaChofer
            // 
            this.menuABMAltaChofer.Name = "menuABMAltaChofer";
            this.menuABMAltaChofer.Size = new System.Drawing.Size(139, 22);
            this.menuABMAltaChofer.Text = "Alta";
            this.menuABMAltaChofer.Click += new System.EventHandler(this.menuABMAltaChofer_Click);
            // 
            // menuABMBajaChofer
            // 
            this.menuABMBajaChofer.Name = "menuABMBajaChofer";
            this.menuABMBajaChofer.Size = new System.Drawing.Size(139, 22);
            this.menuABMBajaChofer.Text = "Baja";
            this.menuABMBajaChofer.Click += new System.EventHandler(this.menuABMBajaChofer_Click);
            // 
            // menuABMModiChofer
            // 
            this.menuABMModiChofer.Name = "menuABMModiChofer";
            this.menuABMModiChofer.Size = new System.Drawing.Size(139, 22);
            this.menuABMModiChofer.Text = "Modificación";
            this.menuABMModiChofer.Click += new System.EventHandler(this.menuABMModiChofer_Click);
            // 
            // menuABMCliente
            // 
            this.menuABMCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuABMAltaCliente,
            this.menuABMBajaCliente,
            this.menuABMModiCliente});
            this.menuABMCliente.Name = "menuABMCliente";
            this.menuABMCliente.Size = new System.Drawing.Size(128, 22);
            this.menuABMCliente.Text = "Cliente";
            this.menuABMCliente.Visible = false;
            // 
            // menuABMAltaCliente
            // 
            this.menuABMAltaCliente.Name = "menuABMAltaCliente";
            this.menuABMAltaCliente.Size = new System.Drawing.Size(139, 22);
            this.menuABMAltaCliente.Text = "Alta";
            this.menuABMAltaCliente.Click += new System.EventHandler(this.menuABMAltaCliente_Click);
            // 
            // menuABMBajaCliente
            // 
            this.menuABMBajaCliente.Name = "menuABMBajaCliente";
            this.menuABMBajaCliente.Size = new System.Drawing.Size(139, 22);
            this.menuABMBajaCliente.Text = "Baja";
            this.menuABMBajaCliente.Click += new System.EventHandler(this.menuABMBajaCliente_Click);
            // 
            // menuABMModiCliente
            // 
            this.menuABMModiCliente.Name = "menuABMModiCliente";
            this.menuABMModiCliente.Size = new System.Drawing.Size(139, 22);
            this.menuABMModiCliente.Text = "Modificación";
            this.menuABMModiCliente.Click += new System.EventHandler(this.menuABMModiCliente_Click);
            // 
            // menuABMRol
            // 
            this.menuABMRol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuABMAltaRol,
            this.menuABMBajaRol,
            this.menuABMModiRol});
            this.menuABMRol.Name = "menuABMRol";
            this.menuABMRol.Size = new System.Drawing.Size(128, 22);
            this.menuABMRol.Text = "Rol";
            this.menuABMRol.Visible = false;
            // 
            // menuABMAltaRol
            // 
            this.menuABMAltaRol.Name = "menuABMAltaRol";
            this.menuABMAltaRol.Size = new System.Drawing.Size(139, 22);
            this.menuABMAltaRol.Text = "Alta";
            this.menuABMAltaRol.Click += new System.EventHandler(this.menuABMAltaRol_Click);
            // 
            // menuABMBajaRol
            // 
            this.menuABMBajaRol.Name = "menuABMBajaRol";
            this.menuABMBajaRol.Size = new System.Drawing.Size(139, 22);
            this.menuABMBajaRol.Text = "Baja";
            this.menuABMBajaRol.Click += new System.EventHandler(this.menuABMBajaRol_Click);
            // 
            // menuABMModiRol
            // 
            this.menuABMModiRol.Name = "menuABMModiRol";
            this.menuABMModiRol.Size = new System.Drawing.Size(139, 22);
            this.menuABMModiRol.Text = "Modificación";
            this.menuABMModiRol.Click += new System.EventHandler(this.menuABMModiRol_Click);
            // 
            // menuABMTurno
            // 
            this.menuABMTurno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuABMAltaTurno,
            this.menuABMBajaTurno,
            this.menuABMModiTurno});
            this.menuABMTurno.Name = "menuABMTurno";
            this.menuABMTurno.Size = new System.Drawing.Size(128, 22);
            this.menuABMTurno.Text = "Turno";
            this.menuABMTurno.Visible = false;
            // 
            // menuABMAltaTurno
            // 
            this.menuABMAltaTurno.Name = "menuABMAltaTurno";
            this.menuABMAltaTurno.Size = new System.Drawing.Size(139, 22);
            this.menuABMAltaTurno.Text = "Alta";
            this.menuABMAltaTurno.Click += new System.EventHandler(this.menuABMTAltaTurno_Click);
            // 
            // menuABMBajaTurno
            // 
            this.menuABMBajaTurno.Name = "menuABMBajaTurno";
            this.menuABMBajaTurno.Size = new System.Drawing.Size(139, 22);
            this.menuABMBajaTurno.Text = "Baja";
            this.menuABMBajaTurno.Click += new System.EventHandler(this.menuABMBajaTurno_Click);
            // 
            // menuABMModiTurno
            // 
            this.menuABMModiTurno.Name = "menuABMModiTurno";
            this.menuABMModiTurno.Size = new System.Drawing.Size(139, 22);
            this.menuABMModiTurno.Text = "Modificación";
            this.menuABMModiTurno.Click += new System.EventHandler(this.menuABMModiTurno_Click);
            // 
            // menuViajes
            // 
            this.menuViajes.Name = "menuViajes";
            this.menuViajes.Size = new System.Drawing.Size(96, 20);
            this.menuViajes.Text = "Registrar Viaje";
            this.menuViajes.Visible = false;
            this.menuViajes.Click += new System.EventHandler(this.menuViaje_Click);
            // 
            // menuRendicion
            // 
            this.menuRendicion.Name = "menuRendicion";
            this.menuRendicion.Size = new System.Drawing.Size(71, 20);
            this.menuRendicion.Text = "Rendición";
            this.menuRendicion.Visible = false;
            this.menuRendicion.Click += new System.EventHandler(this.rendicionChoferToolStripMenuItem_Click);
            // 
            // menuFacturacion
            // 
            this.menuFacturacion.Name = "menuFacturacion";
            this.menuFacturacion.Size = new System.Drawing.Size(81, 20);
            this.menuFacturacion.Text = "Facturación";
            this.menuFacturacion.Visible = false;
            this.menuFacturacion.Click += new System.EventHandler(this.menuFacturacion_Click);
            // 
            // menuEstadisticas
            // 
            this.menuEstadisticas.Name = "menuEstadisticas";
            this.menuEstadisticas.Size = new System.Drawing.Size(80, 20);
            this.menuEstadisticas.Text = "Estadísticas";
            this.menuEstadisticas.Visible = false;
            this.menuEstadisticas.Click += new System.EventHandler(this.menuEstadisticas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UberFRBA v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuABM;
        private System.Windows.Forms.ToolStripMenuItem menuABMAuto;
        private System.Windows.Forms.ToolStripMenuItem menuABMAltaAuto;
        private System.Windows.Forms.ToolStripMenuItem menuABMBajaAuto;
        private System.Windows.Forms.ToolStripMenuItem menuABMModiAuto;
        private System.Windows.Forms.ToolStripMenuItem menuABMChofer;
        private System.Windows.Forms.ToolStripMenuItem menuABMAltaChofer;
        private System.Windows.Forms.ToolStripMenuItem menuABMBajaChofer;
        private System.Windows.Forms.ToolStripMenuItem menuABMModiChofer;
        private System.Windows.Forms.ToolStripMenuItem menuABMCliente;
        private System.Windows.Forms.ToolStripMenuItem menuABMAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem menuABMBajaCliente;
        private System.Windows.Forms.ToolStripMenuItem menuABMModiCliente;
        private System.Windows.Forms.ToolStripMenuItem menuABMRol;
        private System.Windows.Forms.ToolStripMenuItem menuABMAltaRol;
        private System.Windows.Forms.ToolStripMenuItem menuABMBajaRol;
        private System.Windows.Forms.ToolStripMenuItem menuABMModiRol;
        private System.Windows.Forms.ToolStripMenuItem menuAltaUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuViajes;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ToolStripMenuItem menuABMTurno;
        private System.Windows.Forms.ToolStripMenuItem menuABMAltaTurno;
        private System.Windows.Forms.ToolStripMenuItem menuABMBajaTurno;
        private System.Windows.Forms.ToolStripMenuItem menuABMModiTurno;
        private System.Windows.Forms.ToolStripMenuItem menuRendicion;
        private System.Windows.Forms.ToolStripMenuItem menuFacturacion;
        private System.Windows.Forms.ToolStripMenuItem menuEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}