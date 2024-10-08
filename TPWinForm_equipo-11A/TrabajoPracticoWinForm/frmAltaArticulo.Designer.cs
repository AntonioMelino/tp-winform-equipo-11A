﻿namespace TrabajoPracticoWinForm
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.btnAceptarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            this.lblTituloAlta = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.pbxArticuloAlta = new System.Windows.Forms.PictureBox();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.cboImagenes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevaImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(24, 81);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(54, 13);
            this.lblNombreArticulo.TabIndex = 12;
            this.lblNombreArticulo.Text = "Nombre: *";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(25, 55);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigoArticulo.TabIndex = 13;
            this.lblCodigoArticulo.Text = "Código: *";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(9, 110);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionArticulo.TabIndex = 14;
            this.lblDescripcionArticulo.Text = "Descripción:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(77, 81);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(164, 20);
            this.txtNombreArticulo.TabIndex = 1;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(77, 55);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(164, 20);
            this.txtCodigoArticulo.TabIndex = 0;
            this.txtCodigoArticulo.TextChanged += new System.EventHandler(this.txtCodigoArticulo_TextChanged);
            this.txtCodigoArticulo.Leave += new System.EventHandler(this.txtCodigoArticulo_Leave);
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(77, 110);
            this.txtDescripcionArticulo.Multiline = true;
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(164, 64);
            this.txtDescripcionArticulo.TabIndex = 2;
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(30, 291);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblPrecioArticulo.TabIndex = 10;
            this.lblPrecioArticulo.Text = "Precio: *";
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(78, 288);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(164, 20);
            this.txtPrecioArticulo.TabIndex = 7;
            this.txtPrecioArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioArticulo_KeyPress);
            this.txtPrecioArticulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPrecioArticulo_MouseMove);
            // 
            // btnAceptarArticulo
            // 
            this.btnAceptarArticulo.Location = new System.Drawing.Point(12, 340);
            this.btnAceptarArticulo.Name = "btnAceptarArticulo";
            this.btnAceptarArticulo.Size = new System.Drawing.Size(104, 23);
            this.btnAceptarArticulo.TabIndex = 8;
            this.btnAceptarArticulo.Text = "Aceptar";
            this.btnAceptarArticulo.UseVisualStyleBackColor = true;
            this.btnAceptarArticulo.Click += new System.EventHandler(this.btnAceptarArticulo_Click);
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Location = new System.Drawing.Point(156, 340);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(102, 23);
            this.btnCancelarArticulo.TabIndex = 9;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // lblTituloAlta
            // 
            this.lblTituloAlta.AutoSize = true;
            this.lblTituloAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlta.Location = new System.Drawing.Point(71, 9);
            this.lblTituloAlta.Name = "lblTituloAlta";
            this.lblTituloAlta.Size = new System.Drawing.Size(171, 33);
            this.lblTituloAlta.TabIndex = 10;
            this.lblTituloAlta.Text = "Alta Articulo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 207);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria: *";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(25, 180);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca: *";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(77, 207);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(164, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(77, 180);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(164, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(13, 238);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(58, 13);
            this.lblImagen.TabIndex = 15;
            this.lblImagen.Text = "ImagenUrl:";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(78, 235);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(164, 20);
            this.txtImagenUrl.TabIndex = 5;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // pbxArticuloAlta
            // 
            this.pbxArticuloAlta.Location = new System.Drawing.Point(294, 53);
            this.pbxArticuloAlta.Name = "pbxArticuloAlta";
            this.pbxArticuloAlta.Size = new System.Drawing.Size(323, 251);
            this.pbxArticuloAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticuloAlta.TabIndex = 17;
            this.pbxArticuloAlta.TabStop = false;
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Location = new System.Drawing.Point(15, 264);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(56, 13);
            this.lblImagenes.TabIndex = 18;
            this.lblImagenes.Text = "Imagenes:";
            // 
            // cboImagenes
            // 
            this.cboImagenes.FormattingEnabled = true;
            this.cboImagenes.Location = new System.Drawing.Point(78, 261);
            this.cboImagenes.Name = "cboImagenes";
            this.cboImagenes.Size = new System.Drawing.Size(164, 21);
            this.cboImagenes.TabIndex = 6;
            this.cboImagenes.SelectionChangeCommitted += new System.EventHandler(this.cboImagenes_SelectionChangeCommitted);
            this.cboImagenes.SelectedValueChanged += new System.EventHandler(this.cboImagenes_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "* Campo requerido";
            // 
            // btnNuevaImg
            // 
            this.btnNuevaImg.Location = new System.Drawing.Point(413, 324);
            this.btnNuevaImg.Name = "btnNuevaImg";
            this.btnNuevaImg.Size = new System.Drawing.Size(107, 23);
            this.btnNuevaImg.TabIndex = 21;
            this.btnNuevaImg.Text = "Nueva Imagen";
            this.btnNuevaImg.UseVisualStyleBackColor = true;
            this.btnNuevaImg.Click += new System.EventHandler(this.btnNuevaImg_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 375);
            this.Controls.Add(this.btnNuevaImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboImagenes);
            this.Controls.Add(this.lblImagenes);
            this.Controls.Add(this.pbxArticuloAlta);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblTituloAlta);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.btnAceptarArticulo);
            this.Controls.Add(this.txtPrecioArticulo);
            this.Controls.Add(this.lblPrecioArticulo);
            this.Controls.Add(this.txtDescripcionArticulo);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.MaximumSize = new System.Drawing.Size(663, 414);
            this.MinimumSize = new System.Drawing.Size(663, 414);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.Button btnAceptarArticulo;
        private System.Windows.Forms.Button btnCancelarArticulo;
        private System.Windows.Forms.Label lblTituloAlta;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.PictureBox pbxArticuloAlta;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.ComboBox cboImagenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevaImg;
    }
}