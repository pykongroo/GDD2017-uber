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
        bool obligatorio;
        public CustomTextBox()
        {
            InitializeComponent();
            obligatorio = true;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text == "" && obligatorio)
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

        public void noEsObligatorio()
        {
            this.obligatorio = false;
        }

        public void inhabilitar()
        {
            textBox.BackColor = Color.LightGray;
            textBox.ReadOnly = true;
        }

        public void habilitar()
        {
            textBox.BackColor = Color.White;
            textBox.ReadOnly = false;
        }

        public void setData(String data)
        {
            textBox.Text = data;
        }
    }
}
