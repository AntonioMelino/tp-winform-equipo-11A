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
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
            lblAltaMarca.Text = "Modificar Marca";
        }

        private bool validarAlta()
        {
            if (string.IsNullOrEmpty(txtDescripcionMarca.Text))
            {
                MessageBox.Show("Por favor cargue la descripcion");
                return true;
            }
            return false;
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {

                if (validarAlta())
                    return;

                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtDescripcionMarca.Text;

                if (marca.ID != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente");
                }else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            try
            {

                if (marca != null)
                {
                    txtDescripcionMarca.Text = marca.Descripcion;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
