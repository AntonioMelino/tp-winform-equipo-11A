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
    public partial class frmAgregarImg : Form
    {
        private Imagen image = null;
        public frmAgregarImg()
        {
            InitializeComponent();
        }
        public frmAgregarImg(Imagen img)
        {
            InitializeComponent();
            this.image = img;
            Text = "Agregar Imagen";
        }

        private void frmAgregarImg_Load(object sender, EventArgs e)
        {
            txtImage.Text = "";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            ImgNegocio negocio = new ImgNegocio();
            Imagen imagen = new Imagen();
            imagen.IDArticulo = this.image.IDArticulo;
            imagen.ImagenUrl = txtImage.Text;
            negocio.agregar(imagen);
            Close();
        }
    }
}
