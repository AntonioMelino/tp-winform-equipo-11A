using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TrabajoPracticoWinForm
{
    public partial class Form1 : Form
    {
        //private List<Articulo> lista;

        private List<Articulo> listaArticulo;

        private List<Marca> listaMarca;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            
            dgvArticulos.DataSource = listaArticulo;

            pbxArticulo.Load(listaArticulo[0].Imagen.ImagenUrl);
            //cargarImagen(listaArticulo[0].Imagen.ImagenUrl);

            //lista = negocio.listar();
            //dgvArticulos.DataSource = lista;

            MarcaNegocio negocioMarca = new MarcaNegocio();
            listaMarca = negocioMarca.listar();
            dvgMarcas.DataSource = listaMarca;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string articulo = txtNombre.Text;
            string codigo = txtCodigo.Text;
            string descripcion = txtDescripcion.Text;
            string marca = cboMarca.SelectedItem.ToString();
            string categoria = cboCategoria.SelectedItem.ToString();
            string precio = txtPrecio.Text;
            lwArticulos.Items.Add(articulo + " " + codigo + " " + descripcion + " " + marca + " " + categoria + " $" + precio);

            txtNombre.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //pbxArticulo.Load(seleccionado.Imagen.ImagenUrl);
            //cargarImagen(seleccionado.Imagen.ImagenUrl);

            try
            {
                pbxArticulo.Load(seleccionado.Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
        }

        /*private void cargarImagen(ArticuloNegocio imagen)
        {
            try
            {
                pbxArticulo.Load();
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }*/
    }
}
