using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public partial class CustomForm : Form
    {
        protected Form previo;
        private bool cbh;
        public CustomForm()
        {
            //Fake constructor
        }
        public CustomForm(Form prev_form)
        {
            InitializeComponent();
            this.previo = prev_form;
            this.cbh = true;
        }

        public void cierreInvocador(bool flag)
        {
            this.cbh = flag;
        }

        private void CustomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cbh)
            {
                this.previo.Close();
            }
        }
    }
}
