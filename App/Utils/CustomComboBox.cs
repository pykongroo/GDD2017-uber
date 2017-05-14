using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Utils
{
    public partial class CustomComboBox : UserControl
    {
        public CustomComboBox()
        {
            InitializeComponent();
        }

        private void comboBox_Leave(object sender, EventArgs e)
        {
            if (!this.comboBox.Items.Contains(this.comboBox.Text))
            {
                this.comboBox.Text = "";
                labelStatus.BackColor = Color.Red;
            } else
            {
                labelStatus.BackColor = Color.Green;
            }
        }
        public bool esValido()
        {
            return !(this.comboBox.Text == "");
        }

        public String Text()
        {
            return comboBox.Text;
        }

        public void Add(String item)
        {
            comboBox.Items.Add(item);
        }

        public void setDescription(String cadena)
        {
            description.Text = cadena;
        }

        public void inhabilitar()
        {
            comboBox.BackColor = Color.LightGray;
            comboBox.Enabled = false;
        }

        public void habilitar()
        {
            comboBox.BackColor = Color.White;
            comboBox.Enabled = true;
        }

        public void setData(String data)
        {
            comboBox.Text = data;
        }
    }
}
