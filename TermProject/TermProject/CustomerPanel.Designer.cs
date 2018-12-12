namespace TermProject
{
    partial class CustomerPanel
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPicture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Location = new System.Drawing.Point(726, 365);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Detaylar";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.Location = new System.Drawing.Point(807, 365);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Satın al";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lvProducts
            // 
            this.lvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductId,
            this.ProductPicture,
            this.ProductName,
            this.Price,
            this.Weight,
            this.ProductStock});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.Location = new System.Drawing.Point(12, 12);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(870, 347);
            this.lvProducts.TabIndex = 5;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.DoubleClick += new System.EventHandler(this.lvProducts_DoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.Text = "ProductId";
            this.ProductId.Width = 0;
            // 
            // ProductPicture
            // 
            this.ProductPicture.Text = "Ürün Resmi";
            this.ProductPicture.Width = 209;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Ürün İsmi";
            this.ProductName.Width = 459;
            // 
            // Price
            // 
            this.Price.Text = "Fiyat";
            this.Price.Width = 114;
            // 
            // Weight
            // 
            this.Weight.Text = "Ağırlık";
            this.Weight.Width = 46;
            // 
            // ProductStock
            // 
            this.ProductStock.Text = "Stok";
            this.ProductStock.Width = 38;
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 493);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnInfo);
            this.Name = "CustomerPanel";
            this.Text = "Sipareş tablosu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerPanel_FormClosed);
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader ProductPicture;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.ColumnHeader ProductId;
    }
}