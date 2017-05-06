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
        public CustomForm()
        {
            //Fake constructor
        }
        public CustomForm(Form prev_form)
        {
            InitializeComponent();
            this.previo = prev_form;
        }

        private void CustomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previo.Close();
        }
    }
}
