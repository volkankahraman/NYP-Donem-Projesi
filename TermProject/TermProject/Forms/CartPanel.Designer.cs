namespace TermProject.Forms
{
    partial class CartPanel
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
            this.btnChangeQuantity = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lvCart = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnChangeQuantity
            // 
            this.btnChangeQuantity.Location = new System.Drawing.Point(366, 215);
            this.btnChangeQuantity.Name = "btnChangeQuantity";
            this.btnChangeQuantity.Size = new System.Drawing.Size(91, 23);
            this.btnChangeQuantity.TabIndex = 1;
            this.btnChangeQuantity.Text = "Adetini Değiştir";
            this.btnChangeQuantity.UseVisualStyleBackColor = true;
            this.btnChangeQuantity.Click += new System.EventHandler(this.btnChangeQuantity_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(463, 215);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Çıkar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(544, 215);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Öde";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lvCart
            // 
            this.lvCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvCart.Location = new System.Drawing.Point(12, 12);
            this.lvCart.Name = "lvCart";
            this.lvCart.Size = new System.Drawing.Size(606, 197);
            this.lvCart.TabIndex = 4;
            this.lvCart.UseCompatibleStateImageBehavior = false;
            // 
            // CartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 246);
            this.Controls.Add(this.lvCart);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChangeQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CartPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepetim";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChangeQuantity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ListView lvCart;
    }
}