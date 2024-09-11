namespace TrabajoPracticoWinForm
{
    partial class frmMarcas
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
            this.lblMarcas = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnVolverMarca = new System.Windows.Forms.Button();
            this.lblFiltroMarcas = new System.Windows.Forms.Label();
            this.txtFiltroMarcas = new System.Windows.Forms.TextBox();
            this.btnBuscarMarcas = new System.Windows.Forms.Button();
            this.btnRefrescarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(43, 23);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(253, 33);
            this.lblMarcas.TabIndex = 4;
            this.lblMarcas.Text = "Listado de Marcas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(49, 107);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(247, 230);
            this.dgvMarcas.TabIndex = 5;
            this.dgvMarcas.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(49, 343);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(110, 40);
            this.btnAgregarMarca.TabIndex = 0;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(165, 343);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(110, 40);
            this.btnModificarMarca.TabIndex = 1;
            this.btnModificarMarca.Text = "Modificar Marca";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(281, 343);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(110, 40);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnVolverMarca
            // 
            this.btnVolverMarca.Location = new System.Drawing.Point(397, 343);
            this.btnVolverMarca.Name = "btnVolverMarca";
            this.btnVolverMarca.Size = new System.Drawing.Size(110, 40);
            this.btnVolverMarca.TabIndex = 3;
            this.btnVolverMarca.Text = "Volver";
            this.btnVolverMarca.UseVisualStyleBackColor = true;
            this.btnVolverMarca.Click += new System.EventHandler(this.btnVolverMarca_Click);
            // 
            // lblFiltroMarcas
            // 
            this.lblFiltroMarcas.AutoSize = true;
            this.lblFiltroMarcas.Location = new System.Drawing.Point(46, 76);
            this.lblFiltroMarcas.Name = "lblFiltroMarcas";
            this.lblFiltroMarcas.Size = new System.Drawing.Size(47, 13);
            this.lblFiltroMarcas.TabIndex = 6;
            this.lblFiltroMarcas.Text = "Nombre:";
            // 
            // txtFiltroMarcas
            // 
            this.txtFiltroMarcas.Location = new System.Drawing.Point(98, 73);
            this.txtFiltroMarcas.Name = "txtFiltroMarcas";
            this.txtFiltroMarcas.Size = new System.Drawing.Size(177, 20);
            this.txtFiltroMarcas.TabIndex = 7;
            // 
            // btnBuscarMarcas
            // 
            this.btnBuscarMarcas.Location = new System.Drawing.Point(281, 71);
            this.btnBuscarMarcas.Name = "btnBuscarMarcas";
            this.btnBuscarMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMarcas.TabIndex = 8;
            this.btnBuscarMarcas.Text = "Buscar";
            this.btnBuscarMarcas.UseVisualStyleBackColor = true;
            this.btnBuscarMarcas.Click += new System.EventHandler(this.btnBuscarMarcas_Click);
            // 
            // btnRefrescarMarca
            // 
            this.btnRefrescarMarca.Location = new System.Drawing.Point(362, 71);
            this.btnRefrescarMarca.Name = "btnRefrescarMarca";
            this.btnRefrescarMarca.Size = new System.Drawing.Size(107, 23);
            this.btnRefrescarMarca.TabIndex = 13;
            this.btnRefrescarMarca.Text = "Reestablecer lista";
            this.btnRefrescarMarca.UseVisualStyleBackColor = true;
            this.btnRefrescarMarca.Click += new System.EventHandler(this.btnRefrescarMarca_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescarMarca);
            this.Controls.Add(this.btnBuscarMarcas);
            this.Controls.Add(this.txtFiltroMarcas);
            this.Controls.Add(this.lblFiltroMarcas);
            this.Controls.Add(this.btnVolverMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.lblMarcas);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnVolverMarca;
        private System.Windows.Forms.Label lblFiltroMarcas;
        private System.Windows.Forms.TextBox txtFiltroMarcas;
        private System.Windows.Forms.Button btnBuscarMarcas;
        private System.Windows.Forms.Button btnRefrescarMarca;
    }
}