namespace UberFrba.Rendicion_Viajes
{
    partial class RendicionChofer
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
            this.dgRChofer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_chofer_rendicion = new UberFrba.Utils.CustomComboBox();
            this.importeTotalText = new UberFrba.Utils.CustomTextBox();
            this.cmb_turno_rendicion = new UberFrba.Utils.CustomComboBox();
            this.fechaRendicion_dpicker = new UberFrba.Utils.CustomDatePick();
            ((System.ComponentModel.ISupportInitialize)(this.dgRChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRChofer
            // 
            this.dgRChofer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRChofer.Location = new System.Drawing.Point(13, 161);
            this.dgRChofer.Name = "dgRChofer";
            this.dgRChofer.Size = new System.Drawing.Size(342, 150);
            this.dgRChofer.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar detalle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_chofer_rendicion
            // 
            this.cmb_chofer_rendicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_chofer_rendicion.Location = new System.Drawing.Point(13, 50);
            this.cmb_chofer_rendicion.Name = "cmb_chofer_rendicion";
            this.cmb_chofer_rendicion.Size = new System.Drawing.Size(342, 30);
            this.cmb_chofer_rendicion.TabIndex = 6;
            // 
            // importeTotalText
            // 
            this.importeTotalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.importeTotalText.Location = new System.Drawing.Point(13, 124);
            this.importeTotalText.Name = "importeTotalText";
            this.importeTotalText.Size = new System.Drawing.Size(342, 30);
            this.importeTotalText.TabIndex = 3;
            // 
            // cmb_turno_rendicion
            // 
            this.cmb_turno_rendicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_turno_rendicion.Location = new System.Drawing.Point(13, 87);
            this.cmb_turno_rendicion.Name = "cmb_turno_rendicion";
            this.cmb_turno_rendicion.Size = new System.Drawing.Size(342, 30);
            this.cmb_turno_rendicion.TabIndex = 2;
            // 
            // fechaRendicion_dpicker
            // 
            this.fechaRendicion_dpicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaRendicion_dpicker.Location = new System.Drawing.Point(13, 13);
            this.fechaRendicion_dpicker.Name = "fechaRendicion_dpicker";
            this.fechaRendicion_dpicker.Size = new System.Drawing.Size(342, 30);
            this.fechaRendicion_dpicker.TabIndex = 0;
            // 
            // RendicionChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 387);
            this.Controls.Add(this.cmb_chofer_rendicion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgRChofer);
            this.Controls.Add(this.importeTotalText);
            this.Controls.Add(this.cmb_turno_rendicion);
            this.Controls.Add(this.fechaRendicion_dpicker);
            this.Name = "RendicionChofer";
            this.Text = "Rendicion Chofer";
            ((System.ComponentModel.ISupportInitialize)(this.dgRChofer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.CustomDatePick fechaRendicion_dpicker;
        private Utils.CustomComboBox cmb_turno_rendicion;
        private System.Windows.Forms.DataGridView dgRChofer;
        private System.Windows.Forms.Button button1;
        private Utils.CustomTextBox importeTotalText;
        private Utils.CustomComboBox cmb_chofer_rendicion;
    }
}