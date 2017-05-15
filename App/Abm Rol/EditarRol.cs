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
    public partial class EditarRol : Form
    {
        DataTable funcDelRol;
        List<Funcionalidad> misFuncionalidades;
        List<Modelo.Rol> misRoles;
        Rol selectedItemRol;
        public EditarRol()
        {
            InitializeComponent();
        }

        private void EditarRol_Load(object sender, EventArgs e)
        {
            misFuncionalidades = Funcionalidad.obtenerFuncionalidades();
            cmbFuncionalidades.DataSource = misFuncionalidades;
            cmbFuncionalidades.DisplayMember = "Descripcion";

            misRoles = Rol.obtenerRoles();
            cmbRoles.DataSource = misRoles;
            cmbRoles.DisplayMember = "Nombre";



        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void cmbRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (gridLista.Columns.Count == 3)
                gridLista.Columns.Remove(gridLista.Columns[2]);
            List<Funcionalidad> listaFuncDelRol;
            selectedItemRol = (Modelo.Rol)cmbRoles.SelectedItem;
            listaFuncDelRol = Funcionalidad.obtenerFuncxRol(selectedItemRol.ID_Rol);
            txtNombreRol.Enabled = true;
            btnModificar.Enabled = true;
            cmbFuncionalidades.Enabled = true;
            gridLista.Enabled = true;
            btnFuncionalidad.Enabled = true;
            txtNombreRol.Text = selectedItemRol.Nombre;
            if (!selectedItemRol.Habilitado)
            {
                lblDeshabilitado.Visible = true;
                radioHabilitar.Visible = true;
            }
            else
            {
                lblDeshabilitado.Visible = false;
                radioHabilitar.Visible = false;
            }
            //DataTable dtFunciondalidades = new DataTable();
            //dtFunciondalidades.ConvertToDataTable(funcDelRol);
            funcDelRol = ConvertToDataTable(listaFuncDelRol);

            gridLista.DataSource = funcDelRol;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            gridLista.Columns.Add(btn);
            btn.HeaderText = "Acciones";
            btn.Text = "Eliminar";
            btn.Name = "btnEliminarFunc";
            btn.UseColumnTextForButtonValue = true;
            gridLista.Update();
            gridLista.Refresh();



        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (funcDelRol.Rows.Count > 0)
                {
                    if (e.RowIndex != funcDelRol.Rows.Count)
                    {
                        DataRow dr = funcDelRol.Rows[e.RowIndex];
                        dr.Delete();
                    }
                }
            }
        }

        private void btnFuncionalidad_Click(object sender, EventArgs e)
        {
            Funcionalidad selectedItem = (Funcionalidad)cmbFuncionalidades.SelectedItem;
            bool exists = funcDelRol.AsEnumerable().Where(c => c.Field<string>("descripcion").Equals(selectedItem.Descripcion)).Count() > 0;
            if (!exists)
            {
                DataRow _funcionalidad = funcDelRol.NewRow();
                _funcionalidad["ID_Funcionalidad"] = selectedItem.ID_Funcionalidad;
                _funcionalidad["Descripcion"] = selectedItem.Descripcion;
                funcDelRol.Rows.Add(_funcionalidad);
            }
            else
            {
                MessageBox.Show("La funcionalidad ya fue seleccionada");
            }
            gridLista.Update();
            gridLista.Refresh();



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int habilitar = 0;
            if (txtNombreRol.Text != "")
            {

                if (radioHabilitar.Checked)
                {
                    habilitar = 1;
                }
                Rol.editarRol(selectedItemRol.ID_Rol, txtNombreRol.Text, habilitar);
                //MessageBox.Show("Rol insertado");
                if (funcDelRol.Rows.Count > 0)
                {
                    foreach (DataRow row in funcDelRol.Rows)
                    {
                        Funcionalidad.insertarFuncxRol(selectedItemRol.ID_Rol, Convert.ToInt32(row["ID_Funcionalidad"]));
                    }
                }
                txtNombreRol.Text = "";
                funcDelRol.Clear();
                radioHabilitar.Visible = false;
                lblDeshabilitado.Visible = false;
                this.Hide();
                //Menu menuPrincipal = new Menu();
                //menuPrincipal.Show();



            }
            else
            {
                MessageBox.Show("El nombre no puede quedar vacio");
            }
        }

        private void EditarRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //new Menu().Show();
        }


    }
}
