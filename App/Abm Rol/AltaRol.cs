using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Modelo;

namespace UberFrba.Abm_Rol
{
    public partial class AltaRol : Form
    {
        // List<Funcionalidad> funcSeleccionadas;
        DataTable dtFuncSeleccionadas;
        List<Funcionalidad> misFuncionalidades;
        List<Rol> misRoles;

        public AltaRol()
        {
            InitializeComponent();
            //funcSeleccionadas = new List<Funcionalidad>();
            dtFuncSeleccionadas = new DataTable();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (dtFuncSeleccionadas.Rows.Count > 0)
                {
                    if (e.RowIndex != dtFuncSeleccionadas.Rows.Count)
                    {
                        DataRow dr = dtFuncSeleccionadas.Rows[e.RowIndex];
                        dr.Delete();
                    }
                }
            }
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            misRoles = Rol.obtenerRoles();
            misFuncionalidades = Funcionalidad.obtenerFuncionalidades();
            cmbFuncionalidades.DataSource = misFuncionalidades;
            cmbFuncionalidades.DisplayMember = "Descripcion";

            gridLista.AutoGenerateColumns = true;


            dtFuncSeleccionadas.Clear();
            dtFuncSeleccionadas.Columns.Add("ID_Funcionalidad", typeof(int));
            dtFuncSeleccionadas.Columns.Add("Descripcion", typeof(string));
            gridLista.DataSource = dtFuncSeleccionadas;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            gridLista.Columns.Add(btn);
            btn.HeaderText = "Acciones";
            btn.Text = "Eliminar";
            btn.Name = "btnEliminarFunc";
            btn.UseColumnTextForButtonValue = true;

        }

        private void btnFuncionalidad_Click(object sender, EventArgs e)
        {
            // funcSeleccionadas.Add(cmbFuncionalidades.SelectedItem);
            Funcionalidad selectedItem = (Funcionalidad)cmbFuncionalidades.SelectedItem;
            //funcSeleccionadas.Add(selectedItem);
            /* Console.WriteLine();
             foreach (Funcionalidad afunc in funcSeleccionadas)
             {
                 Console.WriteLine(afunc.Descripcion);
             }
             */

            bool exists = dtFuncSeleccionadas.AsEnumerable().Any(c => c.Field<int>("ID_Funcionalidad") == selectedItem.ID_Funcionalidad);
            if (!exists)
            {
                DataRow _funcionalidad = dtFuncSeleccionadas.NewRow();
                _funcionalidad["ID_Funcionalidad"] = selectedItem.ID_Funcionalidad;
                _funcionalidad["Descripcion"] = selectedItem.Descripcion;
                dtFuncSeleccionadas.Rows.Add(_funcionalidad);
            }
            else
            {
                MessageBox.Show("La funcionalidad ya fue seleccionada");
            }
            gridLista.Update();
            gridLista.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            if (txtNombre.Text != "")
            {
                if (!misRoles.Exists(x => x.Nombre == txtNombre.Text))
                {
                    foreach (DataRow row in dtFuncSeleccionadas.Rows)
                    {
                        if (!misFuncionalidades.Any(f => f.ID_Funcionalidad == row.Field<int>("ID_Funcionalidad")))
                        {
                            valido = false;
                            row.SetColumnError(0, "Funcionalidad inexistente");
                        }
                    }
                    if (!valido)
                    {
                        MessageBox.Show("La lista de funcionalidades seleccionadas contiene una o más funcionalidades inexistentes");
                        return;
                    }

                    var miNuevoID = Rol.insertarRol(txtNombre.Text);
                    //MessageBox.Show("Rol insertado");
                    if (dtFuncSeleccionadas.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtFuncSeleccionadas.Rows)
                        {
                            Funcionalidad.insertarFuncxRol(miNuevoID, row.Field<int>("ID_Funcionalidad"));
                        }
                    }
                    txtNombre.Text = "";
                    dtFuncSeleccionadas.Clear();
                    this.Hide();
                    //Menu menuPrincipal = new Menu();
                    //menuPrincipal.Show();

                }
                else
                {
                    MessageBox.Show("El nombre del rol ya esta siendo utilizado");
                }
            }
            else
            {
                MessageBox.Show("El nombre no puede quedar vacio");
            }

        }

        private void AltaRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //new Menu().Show();
        }

    }
}
