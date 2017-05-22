using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Viaje
{
    public partial class RegistroViaje : Form
    {
        public RegistroViaje()
        {
            InitializeComponent();
        }

        private void RegistroViaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
