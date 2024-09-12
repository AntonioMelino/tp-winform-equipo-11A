using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoWinForm
{
    
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarca;
        public frmMarcas()
        {
            InitializeComponent();

            cargar();
        }

        private void cargar()
        {
            
            MarcaNegocio negocioMarca = new MarcaNegocio();
            listaMarca = negocioMarca.listar();
            dgvMarcas.DataSource = negocioMarca.listar();

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca();
            txtFiltroMarcas.Text = ("");
            alta.ShowDialog();
            cargar();
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMarcas.CurrentRow != null)
                {
                    Marca seleccionada;
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    frmAltaMarca modificar = new frmAltaMarca(seleccionada);
                    modificar.ShowDialog();
                    txtFiltroMarcas.Text = ("");
                    cargar();
                }
                else
                {
                    MessageBox.Show("Error en la selección del artículo");
                    txtFiltroMarcas.Text = ("");
                    cargar();
                }
            }
            //Marca seleccionada;
            //seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            //frmAltaMarca modificar = new frmAltaMarca(seleccionada);
            //modificar.ShowDialog();
            //cargar();
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;

            try
            {   
                if (dgvMarcas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("Se eliminara permanentemente de nuestra base de datos, ¿Estás seguro?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                        negocio.eliminarF(seleccionada.ID);
                        txtFiltroMarcas.Text = ("");
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Error en la selección del artículo");
                    txtFiltroMarcas.Text = ("");
                    cargar();
                }
                //DialogResult respuesta = MessageBox.Show("Se eliminara permanentemente de nuestra base de datos, ¿Estás seguro?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //if (respuesta == DialogResult.Yes)
                //{
                //    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                //    negocio.eliminarF(seleccionada.ID);
                //    cargar();
                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolverMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltroMarcas_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = txtFiltroMarcas.Text.ToLower();

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaMarca.FindAll(x => x.Descripcion.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = listaMarca;
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFiltrada;

        }
    }
}
