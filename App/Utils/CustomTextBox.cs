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
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                labelStatus.BackColor = Color.Red;
            } else
            {
                labelStatus.BackColor = Color.Green;
            }
        }

        public bool esValido()
        {
            return textBox.Text != "";
        }

        public String Text()
        {
            return textBox.Text;
        }

        public void setDescription(String cadena)
        {
            description.Text = cadena;
        }
    }
}
