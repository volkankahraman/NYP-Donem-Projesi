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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPanel));
            this.btnCartInfo = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lvProductList = new System.Windows.Forms.ListView();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCartInfo
            // 
            this.btnCartInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnCartInfo.Image")));
            this.btnCartInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCartInfo.Location = new System.Drawing.Point(814, 10);
            this.btnCartInfo.Name = "btnCartInfo";
            this.btnCartInfo.Size = new System.Drawing.Size(68, 36);
            this.btnCartInfo.TabIndex = 1;
            this.btnCartInfo.Text = "Sepet";
            this.btnCartInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCartInfo.UseVisualStyleBackColor = true;
            this.btnCartInfo.Click += new System.EventHandler(this.btnCartInfo_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(12, 22);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerName.TabIndex = 4;
            // 
            // lvProductList
            // 
            this.lvProductList.Location = new System.Drawing.Point(13, 52);
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.Size = new System.Drawing.Size(869, 429);
            this.lvProductList.TabIndex = 5;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.DoubleClick += new System.EventHandler(this.lvProductList_DoubleClick);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(740, 10);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(68, 36);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "Siparişlerim";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 493);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.lvProductList);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnCartInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerPanel_FormClosing);
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ListView lvProductList;
        public System.Windows.Forms.Button btnCartInfo;
        public System.Windows.Forms.Button btnOrders;
    }
}