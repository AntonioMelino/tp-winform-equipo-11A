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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Nombre = txtNombreArticulo.Text;
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Descripcion = txtDescripcionArticulo.Text;
                articulo.Precio = decimal.Parse(txtPrecioArticulo.Text);

                negocio.agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
