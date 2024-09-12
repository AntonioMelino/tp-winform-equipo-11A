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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private bool validarAlta()
        {
            if (string.IsNullOrEmpty(txtCodigoArticulo.Text))
            {
                MessageBox.Show("Por favor cargue el código");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombreArticulo.Text))
            {
                MessageBox.Show("Por favor cargue el nombre");
                return true;
            }
            if(string.IsNullOrEmpty(txtDescripcionArticulo.Text))
            {
                txtDescripcionArticulo.Text = "Sin descripcion";
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecioArticulo.Text))
            {
                MessageBox.Show("Por favor cargue el precio");
                return true;
            }
            if (string.IsNullOrEmpty(txtImagenUrl.Text))
            {
                txtImagenUrl.Text = "Sin imagen";
                pbxArticuloAlta.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
            return false;
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

                if (validarAlta())
                    return;

                if (articulo == null)
                    articulo = new Articulo();
                
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombreArticulo.Text;
                articulo.Descripcion = txtDescripcionArticulo.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);
                //articulo.Precio= Convert.ToDecimal(txtPrecioArticulo.Text);
                if (articulo.ID != 0)
                {
                    //Imagen img = new Imagen();
                    ImgNegocio imgNegocio = new ImgNegocio();
                    if(cboImagenes.SelectedIndex != -1)
                    {  
                        articulo.Imagen = (Imagen)cboImagenes.SelectedItem;                       
                        //img = imgNegocio.traerImg(articulo.Imagen.ID);
                        articulo.Imagen.ImagenUrl = txtImagenUrl.Text; // FUNCIONA USANDO EL TXT DE LA IMAGEN DEL ALTA
                        //img.IDArticulo = articulo.ID;
                        imgNegocio.modificar(articulo.Imagen);
                    }
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else 
                {
                    negocio.agregar(articulo);
                    int idart = negocio.traerArt();
                    Imagen img = new Imagen();
                    ImgNegocio imgNegocio = new ImgNegocio();
                    // --
                    //articulo.Imagen.IDArticulo = idart;
                    //articulo.Imagen.ImagenUrl = txtImagenUrl.Text;
                    //negocio.agregarImg(articulo);
                    // -- AGREGAR IMG CON NEG DE ARTICULO O TRABAJANDO IMG INDIVIDUAL.
                    // FUNCIONAN AMBOS.
                    img.IDArticulo = idart;
                    img.ImagenUrl = txtImagenUrl.Text;
                    imgNegocio.agregar(img);
                    while ((MessageBox.Show("¿Quiere cargar otra imagen?", "Other Image", MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        frmAgregarImg form = new frmAgregarImg(img);
                        form.ShowDialog();
                        Close();                 
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
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImgNegocio imgnegocio = new ImgNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboCategoria.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DisplayMember = "Descripcion";
                lblImagenes.Visible = false;
                cboImagenes.Visible = false;      
                cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
                cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
                btnNuevaImg.Visible = false;
                if (articulo != null)
                {   
                    cboImagenes.DataSource = imgnegocio.listar_x_id(articulo.ID);
                    cboImagenes.ValueMember = "Id";
                    cboImagenes.DisplayMember = "ImagenUrl";
                    cboImagenes.DropDownStyle = ComboBoxStyle.DropDownList;
                    txtImagenUrl.Enabled = false;
                    lblImagenes.Visible= true;
                    cboImagenes.Visible = true;   
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombreArticulo.Text = articulo.Nombre;
                    txtDescripcionArticulo.Text = articulo.Descripcion;
                    txtPrecioArticulo.Text = articulo.Precio.ToString("F2");
                    //txtImagenUrl.Text = articulo.Imagen.ImagenUrl;
                    //articulo.Imagen = new Imagen();
                    cboImagenes.SelectedValue = articulo.Imagen.ID;
                    cboMarca.SelectedValue = articulo.Marca.ID;
                    cboCategoria.SelectedValue = articulo.Categoria.ID;
                    btnNuevaImg.Visible = true;
                }
            }
            catch (Exception ex)
            {

                 throw;
            }
        }
        private void txtPrecioArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
                
                //SI TOCAS UNA TECLA QUE NO ES UN NUMERO NO DIGITA NADA EN PRECIO
        }
        private void cboImagenes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtImagenUrl.Enabled = true;
            
            // TE HABILITA EL TXT DE IMAGEN URL CUANDO UNO SELECIONA Y CIERRA UNA FOTO PARA MODIFICARLA
        }
        private void cboImagenes_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                articulo.Imagen = (Imagen)cboImagenes.SelectedItem;
                pbxArticuloAlta.Load(articulo.Imagen.ImagenUrl);

            }
            catch (Exception ex)
            {

                pbxArticuloAlta.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }

        private void txtPrecioArticulo_MouseMove(object sender, MouseEventArgs e)
        {
            txtPrecioArticulo.Text = "0,00";
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            try
            {
                pbxArticuloAlta.Load(txtImagenUrl.Text);
            }
            catch (Exception ex)
            {

                pbxArticuloAlta.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }

        private void btnNuevaImg_Click(object sender, EventArgs e)
        {
            Imagen img = new Imagen();
            ImgNegocio imgNegocio = new ImgNegocio();
            ArticuloNegocio negocio = new ArticuloNegocio();
            img.IDArticulo = articulo.ID;
            frmAgregarImg form = new frmAgregarImg(img);
            form.ShowDialog();
            Close();
        }
    }
}
