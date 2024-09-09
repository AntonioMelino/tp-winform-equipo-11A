﻿using System;
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

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();

            dgvArticulos.DataSource = listaArticulo;

            dgvArticulos.Columns["Id"].Visible = false;
            //dgvArticulos.Columns["ImagenUrl"].Visible = false;

            pbxArticulo.Load(listaArticulo[0].Imagen.ImagenUrl);
            //cargarImagen(listaArticulo[0].Imagen.ImagenUrl);

            //lista = negocio.listar();
            //dgvArticulos.DataSource = lista;

            MarcaNegocio negocioMarca = new MarcaNegocio();
            listaMarca = negocioMarca.listar();
            dvgMarcas.DataSource = listaMarca;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void lwArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Se eliminara permanentemente de nuestra base de datos, ¿Estás seguro?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.ID);
                    cargar();
                }
                
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
            //string opcion = cboCampo.SelectedItem.ToString();
            cboCriterio.Items.Clear();
            cboCriterio.Items.Add("Comienza con");
            cboCriterio.Items.Add("Termina con");
            cboCriterio.Items.Add("Contiene");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

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
