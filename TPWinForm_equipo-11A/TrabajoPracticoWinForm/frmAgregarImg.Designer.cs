namespace TrabajoPracticoWinForm
{
    partial class frmAgregarImg
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
            this.lblImg = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(28, 48);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(64, 13);
            this.lblImg.TabIndex = 0;
            this.lblImg.Text = "ImagenURL";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(98, 45);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(281, 20);
            this.txtImage.TabIndex = 1;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(171, 94);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(75, 23);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Agregar";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // frmAgregarImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 144);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.lblImg);
            this.MaximumSize = new System.Drawing.Size(431, 183);
            this.MinimumSize = new System.Drawing.Size(431, 183);
            this.Name = "frmAgregarImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar otra imagen";
            this.Load += new System.EventHandler(this.frmAgregarImg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnAddImage;
    }
}