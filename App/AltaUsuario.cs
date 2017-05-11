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
    public partial class AltaUsuario : CustomForm
    {
        public AltaUsuario(Form prev):base(prev)
        {
            InitializeComponent();
            username.setDescription("Usuario:");
            cmb_roles.setDescription("Rol:");
            setearRoles();
        }

        private void setearRoles()
        {
            //se deben obtener de la DB
            cmb_roles.Add("Admin");
            cmb_roles.Add("Cliente");
            cmb_roles.Add("Chofer");
        }
        
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (username.esValido() && passwordInput.esValido() && cmb_roles.esValido())
            {
                MessageBox.Show("Registro exitoso");
                //codigo de alta en DB y captura de error en DB
                //se debe validar existencia de usuario
                //la contraseña debe ser almacenada usando SHA256de la DB
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previo.Show();
        }
        
    }
}
