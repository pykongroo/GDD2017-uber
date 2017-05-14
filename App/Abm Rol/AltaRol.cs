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

        public AltaRol()
        {
            InitializeComponent();
            //funcSeleccionadas = new List<Funcionalidad>();
            dtFuncSeleccionadas = new DataTable();
        }

        private void customTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
 
            var misFuncionalidades = new Funcionalidad().obtenerFuncionalidades();
            cmbFuncionalidades.DataSource = misFuncionalidades;
            cmbFuncionalidades.DisplayMember = "Descripcion";

            gridLista.AutoGenerateColumns = true;


            dtFuncSeleccionadas.Clear();
            dtFuncSeleccionadas.Columns.Add("func_id");
            dtFuncSeleccionadas.Columns.Add("descripcion");
            gridLista.DataSource = dtFuncSeleccionadas;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            gridLista.Columns.Add(btn);
            btn.HeaderText = "Acciones";
            btn.Text = "Eliminar";
            btn.Name = "btnEliminarFunc";
            btn.UseColumnTextForButtonValue = true;
            
        }


        private void cmbFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            bool exists = dtFuncSeleccionadas.AsEnumerable().Where(c => c.Field<string>("descripcion").Equals(selectedItem.Descripcion)).Count() > 0;
            if (!exists)
            {
                DataRow _funcionalidad = dtFuncSeleccionadas.NewRow();
                _funcionalidad["func_id"] = selectedItem.ID_Funcionalidad;
                _funcionalidad["descripcion"] = selectedItem.Descripcion;
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
            var misRoles = new Modelo.Rol().obtenerRoles();
            Modelo.Funcionalidad MFuncionalidad = new Funcionalidad();
            if (txtNombre.Text != "")
            {
                if (!misRoles.Exists(x => x.Nombre == txtNombre.Text))
                {
                    var miNuevoID = new Modelo.Rol().insertarRol(txtNombre.Text);
                    //MessageBox.Show("Rol insertado");
                    if (dtFuncSeleccionadas.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtFuncSeleccionadas.Rows)
                        {
                            MFuncionalidad.insertarFuncxRol(miNuevoID, Convert.ToInt32(row["func_id"]));
                        }
                    }
                    txtNombre.Text = "";
                    dtFuncSeleccionadas.Clear();
                    Menu menuPrincipal = new Menu();
                    this.Hide();
                    menuPrincipal.Show();
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
    }
}
