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
            //ArticuloNegocio negocio = new ArticuloNegocio();
            //listaArticulo = negocio.listar();

            //dgvArticulos.DataSource = listaArticulo;

            //pbxArticulo.Load(listaArticulo[0].Imagen.ImagenUrl);
            ////cargarImagen(listaArticulo[0].Imagen.ImagenUrl);

            ////lista = negocio.listar();
            ////dgvArticulos.DataSource = lista;

            //MarcaNegocio negocioMarca = new MarcaNegocio();
            //listaMarca = negocioMarca.listar();
            //dvgMarcas.DataSource = listaMarca;

            cargar();

            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
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
            //ImgNegocio imgNegocio = new ImgNegocio();
            //seleccionado.Imagen = new Imagen();
            try
            {
                //int id = imgNegocio.traerPrimerId(seleccionado.ID);
                //seleccionado.Imagen = imgNegocio.traerImg(seleccionado.ID);
                //pbxArticulo.Load(seleccionado.Imagen.ToString());
                pbxArticulo.Load(seleccionado.Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }

        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            //dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            //pbxArticulo.Load(listaArticulo[0].Imagen.ImagenUrl);
            //cargarImagen(listaArticulo[0].Imagen.ImagenUrl);
            //pbxArticulo.Load();
            //MarcaNegocio negocioMarca = new MarcaNegocio();
            //listaMarca = negocioMarca.listar();
            //dvgMarcas.DataSource = listaMarca;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            txtFiltro.Text = ("");
            alta.ShowDialog();
            cargar();
        }

        private void lwArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    //MessageBox.Show("Por favor aprete el boton de Restablecer");
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    modificar.ShowDialog();
                    txtFiltro.Text = ("");
                    cargar();
                }
                else
                {
                    MessageBox.Show("Error en la selección del artículo");
                    txtFiltro.Text = ("");
                    cargar();
                }

                //Articulo seleccionado;
                //seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                //frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                //modificar.ShowDialog();
                //cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {   
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("Se eliminara permanentemente de nuestra base de datos, ¿Estás seguro?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.ID);
                        txtFiltro.Text = ("");
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Error en la selección del artículo");
                    txtFiltro.Text = ("");
                    cargar();
                }

                //DialogResult respuesta = MessageBox.Show("Se eliminara permanentemente de nuestra base de datos, ¿Estás seguro?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //if(respuesta == DialogResult.Yes)
                //{
                //    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                //    negocio.eliminar(seleccionado.ID);
                //    cargar();
                //}
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCriterio.Items.Clear(); // Limpia las opciones del ComboBox de criterios

            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                // Añadimos criterios para rango de precio
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
            }
            else if (opcion == "Marca")
            {
                cboCriterio.Items.Add("Igual a");
            }
            else if (opcion == "Categoria")
            {
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                // Para otros campos como "Codigo", "Nombre", etc.
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private bool validarBuscar()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el campo para buscar");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio para buscar");
                return true;
            }
            if(string.IsNullOrEmpty(txtFiltro.Text))
            {
                MessageBox.Show("Por favor cargue el filtro");
                return true;
            }

            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarBuscar())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem?.ToString();  // Criterio puede ser nulo para algunos casos como Precio
                string filtro = txtFiltro.Text;
                // Llamada a filtrar con o sin filtroExtra dependiendo del campo
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnIrMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
            cargar();
        }

        private void btnIrCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
            cargar();
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmVerDetalle VD = new frmVerDetalle();
            try
            {   
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                VD.txtCodigo.Text = seleccionado.Codigo;
                VD.txtNombre.Text = seleccionado.Nombre.ToString();
                VD.txtDescripcion.Text = seleccionado.Descripcion.ToString();
                VD.txtMarca.Text = seleccionado.Marca.ToString();
                VD.txtCategoria.Text = seleccionado.Categoria.ToString();
                VD.txtPrecio.Text = seleccionado.Precio.ToString("F2");

                if (seleccionado.Imagen.ImagenUrl != "")
                {
                    VD.pbImagen.Load(seleccionado.Imagen.ImagenUrl);
                }
                VD.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
                VD.pbImagen.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
                VD.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrarDetalleArticulo_Click(object sender, EventArgs e)
        {
            frmVerDetalle VD = new frmVerDetalle();
            try
            {   
                if(dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    VD.txtCodigo.Text = seleccionado.Codigo;
                    VD.txtNombre.Text = seleccionado.Nombre.ToString();
                    VD.txtDescripcion.Text = seleccionado.Descripcion.ToString();
                    VD.txtMarca.Text = seleccionado.Marca.ToString();
                    VD.txtCategoria.Text = seleccionado.Categoria.ToString();
                    VD.txtPrecio.Text = seleccionado.Precio.ToString("F2");

                    if (seleccionado.Imagen.ImagenUrl != "")
                    {
                        VD.pbImagen.Load(seleccionado.Imagen.ImagenUrl);
                    }
                    VD.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Error en la selección del artículo");
                    cargar();
                }

                //Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                //VD.txtCodigo.Text = seleccionado.Codigo;
                //VD.txtNombre.Text = seleccionado.Nombre.ToString();
                //VD.txtDescripcion.Text = seleccionado.Descripcion.ToString();
                //VD.txtMarca.Text = seleccionado.Marca.ToString();
                //VD.txtCategoria.Text = seleccionado.Categoria.ToString();
                //VD.txtPrecio.Text = seleccionado.Precio.ToString("F2");

                //if (seleccionado.Imagen.ImagenUrl != "")
                //{
                //    VD.pbImagen.Load(seleccionado.Imagen.ImagenUrl);
                //}
                //VD.ShowDialog();
                //cargar();
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
                VD.pbImagen.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
                VD.ShowDialog();
            }
        }

        private void btnRestablecerBusquedaArticulo_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = ("");
            cargar();
        }
    }
}
