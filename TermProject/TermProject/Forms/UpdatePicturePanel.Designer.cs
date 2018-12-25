namespace TermProject.Forms
{
    partial class UpdatePicturePanel
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
            this.pictureItem = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureItem
            // 
            this.pictureItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureItem.Image = global::TermProject.Properties.Resources.default_product;
            this.pictureItem.Location = new System.Drawing.Point(12, 12);
            this.pictureItem.Name = "pictureItem";
            this.pictureItem.Size = new System.Drawing.Size(286, 218);
            this.pictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureItem.TabIndex = 1;
            this.pictureItem.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 228);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(286, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Yükle";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdatePicturePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 280);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureItem);
            this.Name = "UpdatePicturePanel";
            this.Text = "UpdatePicturePanel";
            this.Load += new System.EventHandler(this.UpdatePicturePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureItem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}