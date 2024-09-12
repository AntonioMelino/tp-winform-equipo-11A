namespace TrabajoPracticoWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblTablaArticulos = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnIrMarcas = new System.Windows.Forms.Button();
            this.btnIrCategorias = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarDetalleArticulo = new System.Windows.Forms.Button();
            this.btnRestablecerBusquedaArticulo = new System.Windows.Forms.Button();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 69);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(643, 454);
            this.dgvArticulos.TabIndex = 15;
            this.dgvArticulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentDoubleClick);
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(652, 69);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(150, 142);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 16;
            this.pbxArticulo.TabStop = false;
            // 
            // lblTablaArticulos
            // 
            this.lblTablaArticulos.AutoSize = true;
            this.lblTablaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaArticulos.Location = new System.Drawing.Point(18, 11);
            this.lblTablaArticulos.Name = "lblTablaArticulos";
            this.lblTablaArticulos.Size = new System.Drawing.Size(597, 55);
            this.lblTablaArticulos.TabIndex = 17;
            this.lblTablaArticulos.Text = "LISTADO DE ARTÍCULOS";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            this.btnAgregarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(0, 106);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(250, 45);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.FlatAppearance.BorderSize = 0;
            this.btnModificarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarArticulo.Location = new System.Drawing.Point(0, 157);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(250, 45);
            this.btnModificarArticulo.TabIndex = 1;
            this.btnModificarArticulo.Text = "Modificar Articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.FlatAppearance.BorderSize = 0;
            this.btnEliminarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(0, 208);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(250, 45);
            this.btnEliminarArticulo.TabIndex = 2;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(14, 530);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 23;
            this.lblCampo.Text = "Campo:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(74, 529);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(129, 21);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(209, 530);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 25;
            this.lblCriterio.Text = "Criterio:";
            this.lblCriterio.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(267, 529);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(124, 21);
            this.cboCriterio.TabIndex = 1;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(397, 529);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(39, 16);
            this.lblFiltro.TabIndex = 27;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(442, 530);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(173, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(127, 555);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(194, 60);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnIrMarcas
            // 
            this.btnIrMarcas.FlatAppearance.BorderSize = 0;
            this.btnIrMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIrMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrMarcas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIrMarcas.Location = new System.Drawing.Point(0, 310);
            this.btnIrMarcas.Name = "btnIrMarcas";
            this.btnIrMarcas.Size = new System.Drawing.Size(250, 95);
            this.btnIrMarcas.TabIndex = 4;
            this.btnIrMarcas.Text = "Marcas";
            this.btnIrMarcas.UseVisualStyleBackColor = true;
            this.btnIrMarcas.Click += new System.EventHandler(this.btnIrMarcas_Click);
            // 
            // btnIrCategorias
            // 
            this.btnIrCategorias.FlatAppearance.BorderSize = 0;
            this.btnIrCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnIrCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrCategorias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIrCategorias.Location = new System.Drawing.Point(0, 411);
            this.btnIrCategorias.Name = "btnIrCategorias";
            this.btnIrCategorias.Size = new System.Drawing.Size(250, 95);
            this.btnIrCategorias.TabIndex = 5;
            this.btnIrCategorias.Text = "Categorias";
            this.btnIrCategorias.UseVisualStyleBackColor = true;
            this.btnIrCategorias.Click += new System.EventHandler(this.btnIrCategorias_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(0, 529);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 95);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarDetalleArticulo
            // 
            this.btnMostrarDetalleArticulo.FlatAppearance.BorderSize = 0;
            this.btnMostrarDetalleArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMostrarDetalleArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDetalleArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarDetalleArticulo.Location = new System.Drawing.Point(0, 259);
            this.btnMostrarDetalleArticulo.Name = "btnMostrarDetalleArticulo";
            this.btnMostrarDetalleArticulo.Size = new System.Drawing.Size(250, 45);
            this.btnMostrarDetalleArticulo.TabIndex = 3;
            this.btnMostrarDetalleArticulo.Text = "Mostrar detalle Articulo";
            this.btnMostrarDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnMostrarDetalleArticulo.Click += new System.EventHandler(this.btnMostrarDetalleArticulo_Click);
            // 
            // btnRestablecerBusquedaArticulo
            // 
            this.btnRestablecerBusquedaArticulo.FlatAppearance.BorderSize = 0;
            this.btnRestablecerBusquedaArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestablecerBusquedaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecerBusquedaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerBusquedaArticulo.Location = new System.Drawing.Point(338, 556);
            this.btnRestablecerBusquedaArticulo.Name = "btnRestablecerBusquedaArticulo";
            this.btnRestablecerBusquedaArticulo.Size = new System.Drawing.Size(194, 59);
            this.btnRestablecerBusquedaArticulo.TabIndex = 4;
            this.btnRestablecerBusquedaArticulo.Text = "Restablecer búsqueda";
            this.btnRestablecerBusquedaArticulo.UseVisualStyleBackColor = true;
            this.btnRestablecerBusquedaArticulo.Click += new System.EventHandler(this.btnRestablecerBusquedaArticulo_Click);
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Controls.Add(this.btnAgregarArticulo);
            this.panelMenuLateral.Controls.Add(this.btnSalir);
            this.panelMenuLateral.Controls.Add(this.btnMostrarDetalleArticulo);
            this.panelMenuLateral.Controls.Add(this.btnIrCategorias);
            this.panelMenuLateral.Controls.Add(this.btnModificarArticulo);
            this.panelMenuLateral.Controls.Add(this.btnIrMarcas);
            this.panelMenuLateral.Controls.Add(this.btnEliminarArticulo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 627);
            this.panelMenuLateral.TabIndex = 32;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnRestablecerBusquedaArticulo);
            this.panel1.Controls.Add(this.dgvArticulos);
            this.panel1.Controls.Add(this.lblTablaArticulos);
            this.panel1.Controls.Add(this.pbxArticulo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cboCriterio);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.lblCampo);
            this.panel1.Controls.Add(this.lblFiltro);
            this.panel1.Controls.Add(this.cboCampo);
            this.panel1.Controls.Add(this.lblCriterio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 627);
            this.panel1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuLateral);
            this.MaximumSize = new System.Drawing.Size(1074, 666);
            this.MinimumSize = new System.Drawing.Size(1074, 666);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblTablaArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnIrMarcas;
        private System.Windows.Forms.Button btnIrCategorias;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarDetalleArticulo;
        private System.Windows.Forms.Button btnRestablecerBusquedaArticulo;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
    }
}

