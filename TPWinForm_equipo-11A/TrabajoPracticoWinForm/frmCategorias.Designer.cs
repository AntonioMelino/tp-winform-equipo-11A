namespace TrabajoPracticoWinForm
{
    partial class frmCategorias
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
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnVolverCategoria = new System.Windows.Forms.Button();
            this.txtFiltroCat = new System.Windows.Forms.TextBox();
            this.lblFiltroCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(43, 348);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(116, 42);
            this.btnAgregarCategoria.TabIndex = 0;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(165, 350);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(116, 42);
            this.btnModificarCategoria.TabIndex = 1;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(287, 352);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(116, 40);
            this.btnEliminarCategoria.TabIndex = 2;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(36, 31);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(298, 33);
            this.lblCategorias.TabIndex = 4;
            this.lblCategorias.Text = "Listado de Categorias";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.Location = new System.Drawing.Point(43, 113);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(245, 210);
            this.dgvCategoria.TabIndex = 5;
            this.dgvCategoria.SelectionChanged += new System.EventHandler(this.dgvCategoria_SelectionChanged);
            // 
            // btnVolverCategoria
            // 
            this.btnVolverCategoria.Location = new System.Drawing.Point(409, 355);
            this.btnVolverCategoria.Name = "btnVolverCategoria";
            this.btnVolverCategoria.Size = new System.Drawing.Size(116, 37);
            this.btnVolverCategoria.TabIndex = 3;
            this.btnVolverCategoria.Text = "Volver";
            this.btnVolverCategoria.UseVisualStyleBackColor = true;
            this.btnVolverCategoria.Click += new System.EventHandler(this.btnVolverCategoria_Click);
            // 
            // txtFiltroCat
            // 
            this.txtFiltroCat.Location = new System.Drawing.Point(160, 78);
            this.txtFiltroCat.Name = "txtFiltroCat";
            this.txtFiltroCat.Size = new System.Drawing.Size(128, 20);
            this.txtFiltroCat.TabIndex = 10;
            this.txtFiltroCat.TextChanged += new System.EventHandler(this.txtFiltroCat_TextChanged);
            // 
            // lblFiltroCat
            // 
            this.lblFiltroCat.AutoSize = true;
            this.lblFiltroCat.Location = new System.Drawing.Point(39, 81);
            this.lblFiltroCat.Name = "lblFiltroCat";
            this.lblFiltroCat.Size = new System.Drawing.Size(115, 13);
            this.lblFiltroCat.TabIndex = 9;
            this.lblFiltroCat.Text = "Filtrar por Descripción::";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiltroCat);
            this.Controls.Add(this.lblFiltroCat);
            this.Controls.Add(this.btnVolverCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnVolverCategoria;
        private System.Windows.Forms.TextBox txtFiltroCat;
        private System.Windows.Forms.Label lblFiltroCat;
    }
}