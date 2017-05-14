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
    public partial class CustomDatePick : UserControl
    {
        public CustomDatePick()
        {
            InitializeComponent();
        }

        public String Text()
        {
            return dateTimePicker1.Text;
        }

        public void setDescription(String cadena)
        {
            description.Text = cadena;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            labelStatus.BackColor = Color.Green;
        }

        public bool esValido()
        {
            return true;
        }
    }
}
