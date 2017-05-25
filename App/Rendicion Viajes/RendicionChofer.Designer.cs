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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_chofer_rendicion = new UberFrba.Utils.CustomComboBox();
            this.importeTotalText = new UberFrba.Utils.CustomTextBox();
            this.cmb_turno_rendicion = new UberFrba.Utils.CustomComboBox();
            this.fechaRendicion_dpicker = new UberFrba.Utils.CustomDatePick();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_chofer_rendicion
            // 
            this.cmb_chofer_rendicion.Location = new System.Drawing.Point(13, 50);
            this.cmb_chofer_rendicion.Name = "cmb_chofer_rendicion";
            this.cmb_chofer_rendicion.Size = new System.Drawing.Size(250, 30);
            this.cmb_chofer_rendicion.TabIndex = 6;
            // 
            // importeTotalText
            // 
            this.importeTotalText.Location = new System.Drawing.Point(13, 124);
            this.importeTotalText.Name = "importeTotalText";
            this.importeTotalText.Size = new System.Drawing.Size(250, 30);
            this.importeTotalText.TabIndex = 3;
            // 
            // cmb_turno_rendicion
            // 
            this.cmb_turno_rendicion.Location = new System.Drawing.Point(13, 87);
            this.cmb_turno_rendicion.Name = "cmb_turno_rendicion";
            this.cmb_turno_rendicion.Size = new System.Drawing.Size(250, 30);
            this.cmb_turno_rendicion.TabIndex = 2;
            // 
            // fechaRendicion_dpicker
            // 
            this.fechaRendicion_dpicker.Location = new System.Drawing.Point(13, 13);
            this.fechaRendicion_dpicker.Name = "fechaRendicion_dpicker";
            this.fechaRendicion_dpicker.Size = new System.Drawing.Size(250, 30);
            this.fechaRendicion_dpicker.TabIndex = 0;
            // 
            // RendicionChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 387);
            this.Controls.Add(this.cmb_chofer_rendicion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.importeTotalText);
            this.Controls.Add(this.cmb_turno_rendicion);
            this.Controls.Add(this.fechaRendicion_dpicker);
            this.Name = "RendicionChofer";
            this.Text = "Rendicion Chofer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.CustomDatePick fechaRendicion_dpicker;
        private Utils.CustomComboBox cmb_turno_rendicion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Utils.CustomTextBox importeTotalText;
        private Utils.CustomComboBox cmb_chofer_rendicion;
    }
}