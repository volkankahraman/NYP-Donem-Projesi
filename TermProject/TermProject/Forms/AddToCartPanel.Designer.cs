namespace TermProject.Forms
{
    partial class AddToCartPanel
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
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.pbProductPicture = new System.Windows.Forms.PictureBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductTax = new System.Windows.Forms.Label();
            this.lblProductWeight = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(206, 311);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 22);
            this.btnAddToCart.TabIndex = 0;
            this.btnAddToCart.Text = "Sepete Ekle";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 143);
            this.lblProductName.MaximumSize = new System.Drawing.Size(290, 13);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(51, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün İsmi";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(35, 315);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Adet Sayısı";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(100, 312);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // pbProductPicture
            // 
            this.pbProductPicture.Location = new System.Drawing.Point(12, 12);
            this.pbProductPicture.Name = "pbProductPicture";
            this.pbProductPicture.Size = new System.Drawing.Size(290, 122);
            this.pbProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductPicture.TabIndex = 5;
            this.pbProductPicture.TabStop = false;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(12, 166);
            this.lblProductPrice.MaximumSize = new System.Drawing.Size(290, 13);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(57, 13);
            this.lblProductPrice.TabIndex = 6;
            this.lblProductPrice.Text = "Ürün Fiyatı";
            // 
            // lblProductTax
            // 
            this.lblProductTax.AutoSize = true;
            this.lblProductTax.Location = new System.Drawing.Point(12, 212);
            this.lblProductTax.MaximumSize = new System.Drawing.Size(290, 13);
            this.lblProductTax.Name = "lblProductTax";
            this.lblProductTax.Size = new System.Drawing.Size(57, 13);
            this.lblProductTax.TabIndex = 8;
            this.lblProductTax.Text = "Ürün Vergi";
            // 
            // lblProductWeight
            // 
            this.lblProductWeight.AutoSize = true;
            this.lblProductWeight.Location = new System.Drawing.Point(12, 189);
            this.lblProductWeight.MaximumSize = new System.Drawing.Size(290, 13);
            this.lblProductWeight.Name = "lblProductWeight";
            this.lblProductWeight.Size = new System.Drawing.Size(63, 13);
            this.lblProductWeight.TabIndex = 7;
            this.lblProductWeight.Text = "Ürün Ağırlığı";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(12, 235);
            this.lblProductDescription.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(76, 13);
            this.lblProductDescription.TabIndex = 9;
            this.lblProductDescription.Text = "Ürün Açıklama";
            // 
            // AddToCartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 345);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductTax);
            this.Controls.Add(this.lblProductWeight);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.pbProductPicture);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnAddToCart);
            this.Name = "AddToCartPanel";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddToCartPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.PictureBox pbProductPicture;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductTax;
        private System.Windows.Forms.Label lblProductWeight;
        private System.Windows.Forms.Label lblProductDescription;
    }
}