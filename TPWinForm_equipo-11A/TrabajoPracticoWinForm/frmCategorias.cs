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
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategoria;
        public frmCategorias()
        {
            InitializeComponent();

            cargar();
        }

        private void cargar()
        {

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            listaCategoria = categoriaNegocio.listar();
            dgvCategoria.DataSource = categoriaNegocio.listar();

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
            cargar();
        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            Categoria seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;
            seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            frmAltaCategoria modificar = new frmAltaCategoria(seleccionada);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada;

            try
            {
                DialogResult respuesta = MessageBox.Show("Se eliminara permanentemente de nuestra base de datos, ¿Estás seguro?", "Eliminar CAtegoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    negocio.eliminarF(seleccionada.ID);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolverCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
 

        private void txtFiltroCat_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;
            string filtro = txtFiltroCat.Text.ToLower();

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaCategoria.FindAll(x => x.Descripcion.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = listaCategoria;
            }

            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = listaFiltrada;

            if (listaFiltrada.Count == 0)
            {
                MessageBox.Show("No se encontraron categorías con el filtro ingresado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
