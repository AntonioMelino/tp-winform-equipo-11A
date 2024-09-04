﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Huawei");
            cboMarca.Items.Add("Motorola");

            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Televisores");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Audio");
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
    }
}
