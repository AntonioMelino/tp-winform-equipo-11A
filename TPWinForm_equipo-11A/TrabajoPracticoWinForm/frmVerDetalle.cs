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
    public partial class frmVerDetalle : Form
    {
        public frmVerDetalle()
        {
            InitializeComponent();
        }

        private void txtVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {

        }

        private void cboImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboImagenes.SelectedItem != null)
            {
                Imagen imagenSeleccionada = (Imagen)cboImagenes.SelectedItem;
                try
                {
                    pbImagen.Load(imagenSeleccionada.ImagenUrl);
                }
                catch (Exception ex)
                {                
                    pbImagen.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
                    MessageBox.Show("Se produjo un error al cargar la imagen. Se ha reemplazado por una imagen por defecto.");
                }
            }
        }
    }
}
