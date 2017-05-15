using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            String query = "select user_nombre, user_apellido, user_dni, user_mail, user_telefono, user_direccion, user_cp, user_fecha_nac, user_habilitado from LJDG.Usuario where user_id = '"+clienteId+"'";
            Conexion conn = Conexion.getInstance();
            conn.con.Open();
            SqlCommand command = new SqlCommand(query, conn.con);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cusNombre.setData(reader.GetString(0));
                cusApellido.setData(reader.GetString(1));
                cusDNI.setData(reader.GetDecimal(2).ToString());
                cusMail.setData(reader.GetString(3));
                cusTelefono.setData(reader.GetSqlValue(4).ToString());
                cusDireccion.setData(reader.GetString(5));
                String cp;
                if (reader.IsDBNull(6))
                {
                    cp = "";
                } else
                {
                    cp = reader.GetString(6);
                }
                cusCodPostal.setData(cp);
                cusFechaNac.setDate(reader.GetDateTime(7));
                checkBoxHabilitado.Checked = reader.GetBoolean(8);
            }
            conn.con.Close();
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
                    MessageBox.Show("Todo OK");
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
