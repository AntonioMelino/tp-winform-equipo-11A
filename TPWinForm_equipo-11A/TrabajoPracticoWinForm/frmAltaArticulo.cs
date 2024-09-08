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
using static System.Net.Mime.MediaTypeNames;

namespace TrabajoPracticoWinForm
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            lblTituloAlta.Text = "Modificar Articulo";
        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarArticulo_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {   
                if(articulo == null)
                    articulo = new Articulo();
                
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombreArticulo.Text;
                articulo.Descripcion = txtDescripcionArticulo.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                if(articulo.ID != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else 
                {
                    negocio.agregar(articulo);
                    int idart = negocio.traerArt();
                    Imagen img = new Imagen();
                    ImgNegocio imgNegocio = new ImgNegocio();
                    img.IDArticulo = idart;
                    img.ImagenUrl = txtImagenUrl.Text;
                    imgNegocio.agregar(img);
                    while ((MessageBox.Show("¿Quiere cargar otra imagen?", "Other Image", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        frmAgregarImg form = new frmAgregarImg(img);
                        form.ShowDialog(); 
                        Close();
                        //txtImagenUrl.Text = "";
                        
                        
                    }
                    MessageBox.Show("Agregado exitosamente");
                }
                

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboCategoria.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtDescripcionArticulo.Text = articulo.Descripcion;
                    txtPrecioArticulo.Text = articulo.Precio.ToString();
                    //txtImagenUrl.Text = articulo.Imagen.ImagenUrl;
                    cboMarca.SelectedValue = articulo.Marca.ID;
                    cboCategoria.SelectedValue = articulo.Categoria.ID;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            
        }

    }
}
