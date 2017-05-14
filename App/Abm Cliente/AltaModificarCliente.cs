using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente
{
    public partial class AltaModificarCliente : CustomForm
    {
        public AltaModificarCliente()
        {
            InitializeComponent();
        }

        public AltaModificarCliente(Form prev_form) : base(prev_form)
        {
            InitializeComponent();
            setDataComponents();
        }

        public AltaModificarCliente(Form prev_form, String clienteId) : base(prev_form)
        {
            InitializeComponent();
            setDataComponents();
            setData(clienteId);
        }

        public void setDataComponents()
        {
            cusNombre.setDescription("Nombre:");
            cusNombre.inhabilitar();
            cusApellido.setDescription("Apellido:");
            cusDNI.setDescription("DNI:");
            cusMail.setDescription("Mail:");
            cusMail.noEsObligatorio();
            cusTelefono.setDescription("Telefono:");
            cusDireccion.setDescription("Direccion:");
            cusCodPostal.setDescription("Código Postal:");
            cusFechaNac.setDescription("Fecha de nacimiento:");
            checkBoxHabilitado.Hide();
            checkBoxHabilitado.Checked = true;
        }

        private void setData(String clienteId)
        {
            //setea los valores con los datos del cliente
            //muestro checkbox de habilitacion
            checkBoxHabilitado.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            bool estadoValidez = cusNombre.esValido() && cusApellido.esValido() && 
                cusDNI.esValido() && cusMail.esValido() && cusTelefono.esValido() &&
                cusDireccion.esValido() && cusCodPostal.esValido() && cusFechaNac.esValido();
            if (estadoValidez)
            {
                bool telefonoValido = true;//verifica unicidad de telefono en DB
                if (telefonoValido)
                {
                    //se agrega a DB
                } else
                {
                    MessageBox.Show("El telefono ya existe");
                }
            } else
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
