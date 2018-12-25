namespace TermProject
{
    partial class ItemDetail
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.pbProductPicture = new System.Windows.Forms.PictureBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(227, 12);
            this.lblProductName.MaximumSize = new System.Drawing.Size(265, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "ProductName";
            // 
            // pbProductPicture
            // 
            this.pbProductPicture.Location = new System.Drawing.Point(12, 12);
            this.pbProductPicture.Name = "pbProductPicture";
            this.pbProductPicture.Size = new System.Drawing.Size(200, 100);
            this.pbProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductPicture.TabIndex = 1;
            this.pbProductPicture.TabStop = false;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(227, 81);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(68, 13);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "ProductPrice";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(12, 148);
            this.lblProductDescription.MaximumSize = new System.Drawing.Size(483, 0);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(97, 13);
            this.lblProductDescription.TabIndex = 3;
            this.lblProductDescription.Text = "ProductDescription";
            // 
            // lblProductWeight
            // 
            this.lblProductWeight.AutoSize = true;
            this.lblProductWeight.Location = new System.Drawing.Point(9, 224);
            this.lblProductWeight.Name = "lblProductWeight";
            this.lblProductWeight.Size = new System.Drawing.Size(78, 13);
            this.lblProductWeight.TabIndex = 4;
            this.lblProductWeight.Text = "ProductWeight";
            // 
            // ItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 282);
            this.Controls.Add(this.lblProductWeight);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.pbProductPicture);
            this.Controls.Add(this.lblProductName);
            this.Name = "ItemDetail";
            this.Text = "ItemDetail";
            this.Load += new System.EventHandler(this.ItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pbProductPicture;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductWeight;
    }
}