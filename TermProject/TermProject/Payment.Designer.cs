namespace TermProject
{
    partial class Payment
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
            this.PeymentTabs = new System.Windows.Forms.TabControl();
            this.tabQuantity = new System.Windows.Forms.TabPage();
            this.tabPayment = new System.Windows.Forms.TabPage();
            this.PeymentTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeymentTabs
            // 
            this.PeymentTabs.Controls.Add(this.tabQuantity);
            this.PeymentTabs.Controls.Add(this.tabPayment);
            this.PeymentTabs.Location = new System.Drawing.Point(12, 12);
            this.PeymentTabs.Name = "PeymentTabs";
            this.PeymentTabs.SelectedIndex = 0;
            this.PeymentTabs.Size = new System.Drawing.Size(410, 426);
            this.PeymentTabs.TabIndex = 0;
            // 
            // tabQuantity
            // 
            this.tabQuantity.Location = new System.Drawing.Point(4, 22);
            this.tabQuantity.Name = "tabQuantity";
            this.tabQuantity.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuantity.Size = new System.Drawing.Size(402, 400);
            this.tabQuantity.TabIndex = 0;
            this.tabQuantity.Text = "Adet Seçimi";
            this.tabQuantity.UseVisualStyleBackColor = true;
            // 
            // tabPayment
            // 
            this.tabPayment.Location = new System.Drawing.Point(4, 22);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayment.Size = new System.Drawing.Size(402, 400);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.Text = "Ödeme";
            this.tabPayment.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.PeymentTabs);
            this.Name = "Payment";
            this.Text = "Payment";
            this.PeymentTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PeymentTabs;
        private System.Windows.Forms.TabPage tabQuantity;
        private System.Windows.Forms.TabPage tabPayment;
    }
}