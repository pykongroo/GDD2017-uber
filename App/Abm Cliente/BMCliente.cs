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
    public partial class BajaModificarCliente : CustomForm
    {
        private DataTable tabla = new DataTable();
        private String tipo;
        public BajaModificarCliente()
        {
            InitializeComponent();
        }

        public BajaModificarCliente(Form prev_form, String tipo) : base(prev_form)
        {
            this.tipo = tipo;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.previo.Show();
        }

        private String generarQuery()
        {
            int cont = 0;
            if (textFiltroApellido.Text != "")
            {
                cont++;
            }
            if (textFiltroNombre.Text != "")
            {
                cont++;
            }
            if (textFiltroDNI.Text != "")
            {
                cont++;
            }
            String query = "select user_apellido, user_nombre, user_dni from LJDG.Usuario where user_id in (select rxu_user from LJDG.Rol_Usuario where rxu_rol=3) ";
            if (cont>0)
            {
                query += "AND ";
                if (textFiltroApellido.Text != "")
                {
                    query += "user_apellido='" + textFiltroApellido.Text + "' ";
                    if (cont > 1)
                    {
                        query += "AND ";
                    }
                    cont--;
                }
                if (textFiltroNombre.Text != "")
                {
                    query += "user_nombre='" + textFiltroNombre.Text + "' ";
                    if (cont > 1)
                    {
                        query += "AND ";
                    }
                    cont--;
                }
                if (textFiltroDNI.Text != "")
                {
                    query += "user_dni='" + textFiltroDNI.Text + "' ";
                    if (cont > 1)
                    {
                        query += "AND ";
                    }
                    cont--;
                }
            } else
            {
                //query += "* ";
            }
            query += "group by user_apellido, user_nombre, user_dni";
            MessageBox.Show(query);
            return query;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();
            //String queryS = "select Cliente_Apellido, Cliente_Nombre, Cliente_Dni from gd_esquema.Maestra group by Cliente_Apellido, Cliente_Nombre, Cliente_Dni order by Cliente_Dni;";
            String queryS = generarQuery();
            Conexion conn = Conexion.getInstance();
            conn.con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryS, conn.con);
            dataAdapter.Fill(tabla);
            dataGridCliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridCliente.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            dataGridCliente.DataSource = tabla;
            conn.con.Close();
        }

        private void dataGridCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (tipo == "B")
            {
                MessageBox.Show("Se da de baja");
                //magia en DB
            } else if (tipo == "M")
            {
                AltaModificarCliente amCliente = new AltaModificarCliente(this, "");
                amCliente.Show();
                this.Hide();
            }
        }
    }
}
