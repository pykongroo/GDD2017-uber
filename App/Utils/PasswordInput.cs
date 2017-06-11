using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace UberFrba.Utils
{
    public partial class PasswordInput : UserControl
    {
        public PasswordInput()
        {
            InitializeComponent();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("La contraseña no debe estar vacía!!");
            }
            else
            {
                if (textBox1.Text == textBox2.Text)
                {
                    //
                }
                else
                {
                    if (textBox2.Text != "")
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
            }
            if (esValido())
            {
                labelStatus.BackColor = Color.Green;
            }
            else
            {
                labelStatus.BackColor = Color.Red;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("La contraseña no debe estar vacía!!");
            }
            else
            {
                if (textBox1.Text == textBox2.Text)
                {
                    //
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            if (esValido())
            {
                labelStatus.BackColor = Color.Green;
            }
            else
            {
                labelStatus.BackColor = Color.Red;
            }
        }
        
        public bool esValido()
        {
            return (textBox1.Text!="")&&(textBox1.Text == textBox2.Text);
        }

        public new String Text()
        {
            return textBox1.Text;
        }
    }
    
}
