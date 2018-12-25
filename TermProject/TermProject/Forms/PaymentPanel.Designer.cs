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
            this.gbPaymentType = new System.Windows.Forms.GroupBox();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.gbCash = new System.Windows.Forms.GroupBox();
            this.lblCashTendered = new System.Windows.Forms.Label();
            this.txtCashTendered = new System.Windows.Forms.TextBox();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.txtCheckNBR = new System.Windows.Forms.TextBox();
            this.lblCheckNBR = new System.Windows.Forms.Label();
            this.gbCreditCard = new System.Windows.Forms.GroupBox();
            this.cbCreditType = new System.Windows.Forms.ComboBox();
            this.lblCCNumber = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCCType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCCNumber = new System.Windows.Forms.TextBox();
            this.txtCheckName = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.gbPaymentType.SuspendLayout();
            this.gbCash.SuspendLayout();
            this.gbCheck.SuspendLayout();
            this.gbCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaymentType
            // 
            this.gbPaymentType.Controls.Add(this.rbCheck);
            this.gbPaymentType.Controls.Add(this.rbCreditCard);
            this.gbPaymentType.Controls.Add(this.rbCash);
            this.gbPaymentType.Location = new System.Drawing.Point(12, 12);
            this.gbPaymentType.Name = "gbPaymentType";
            this.gbPaymentType.Size = new System.Drawing.Size(410, 80);
            this.gbPaymentType.TabIndex = 0;
            this.gbPaymentType.TabStop = false;
            this.gbPaymentType.Text = "Ödeme Yöntemi";
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Location = new System.Drawing.Point(276, 32);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(44, 17);
            this.rbCheck.TabIndex = 2;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "Çek";
            this.rbCheck.UseVisualStyleBackColor = true;
            this.rbCheck.CheckedChanged += new System.EventHandler(this.rbCheck_CheckedChanged);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(122, 32);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(72, 17);
            this.rbCreditCard.TabIndex = 1;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Kredi kartı";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(6, 32);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(50, 17);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Nakit";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // gbCash
            // 
            this.gbCash.Controls.Add(this.lblCashTendered);
            this.gbCash.Controls.Add(this.txtCashTendered);
            this.gbCash.Location = new System.Drawing.Point(18, 175);
            this.gbCash.Name = "gbCash";
            this.gbCash.Size = new System.Drawing.Size(410, 155);
            this.gbCash.TabIndex = 1;
            this.gbCash.TabStop = false;
            this.gbCash.Text = "Nakit";
            this.gbCash.Visible = false;
            // 
            // lblCashTendered
            // 
            this.lblCashTendered.AutoSize = true;
            this.lblCashTendered.Location = new System.Drawing.Point(17, 38);
            this.lblCashTendered.Name = "lblCashTendered";
            this.lblCashTendered.Size = new System.Drawing.Size(66, 13);
            this.lblCashTendered.TabIndex = 5;
            this.lblCashTendered.Text = "Nakit Miktarı";
            // 
            // txtCashTendered
            // 
            this.txtCashTendered.Location = new System.Drawing.Point(20, 54);
            this.txtCashTendered.Name = "txtCashTendered";
            this.txtCashTendered.Size = new System.Drawing.Size(100, 20);
            this.txtCashTendered.TabIndex = 4;
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.lblCheckName);
            this.gbCheck.Controls.Add(this.txtCheckNBR);
            this.gbCheck.Controls.Add(this.lblCheckNBR);
            this.gbCheck.Controls.Add(this.gbCreditCard);
            this.gbCheck.Controls.Add(this.txtCheckName);
            this.gbCheck.Location = new System.Drawing.Point(18, 188);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Size = new System.Drawing.Size(410, 136);
            this.gbCheck.TabIndex = 3;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "Çek";
            this.gbCheck.Visible = false;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.Location = new System.Drawing.Point(17, 40);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(25, 13);
            this.lblCheckName.TabIndex = 13;
            this.lblCheckName.Text = "İsim";
            // 
            // txtCheckNBR
            // 
            this.txtCheckNBR.Location = new System.Drawing.Point(190, 56);
            this.txtCheckNBR.Name = "txtCheckNBR";
            this.txtCheckNBR.Size = new System.Drawing.Size(100, 20);
            this.txtCheckNBR.TabIndex = 4;
            // 
            // lblCheckNBR
            // 
            this.lblCheckNBR.AutoSize = true;
            this.lblCheckNBR.Location = new System.Drawing.Point(187, 40);
            this.lblCheckNBR.Name = "lblCheckNBR";
            this.lblCheckNBR.Size = new System.Drawing.Size(71, 13);
            this.lblCheckNBR.TabIndex = 15;
            this.lblCheckNBR.Text = "Çek numarası";
            // 
            // gbCreditCard
            // 
            this.gbCreditCard.Controls.Add(this.cbCreditType);
            this.gbCreditCard.Controls.Add(this.lblCCNumber);
            this.gbCreditCard.Controls.Add(this.lblExpDate);
            this.gbCreditCard.Controls.Add(this.lblCCType);
            this.gbCreditCard.Controls.Add(this.label4);
            this.gbCreditCard.Controls.Add(this.txtExpDate);
            this.gbCreditCard.Controls.Add(this.txtCCNumber);
            this.gbCreditCard.Location = new System.Drawing.Point(0, 0);
            this.gbCreditCard.Name = "gbCreditCard";
            this.gbCreditCard.Size = new System.Drawing.Size(410, 136);
            this.gbCreditCard.TabIndex = 2;
            this.gbCreditCard.TabStop = false;
            this.gbCreditCard.Text = "Kredi kartı";
            this.gbCreditCard.Visible = false;
            // 
            // cbCreditType
            // 
            this.cbCreditType.FormattingEnabled = true;
            this.cbCreditType.Items.AddRange(new object[] {
            "MasterCard",
            "Visa"});
            this.cbCreditType.Location = new System.Drawing.Point(146, 60);
            this.cbCreditType.Name = "cbCreditType";
            this.cbCreditType.Size = new System.Drawing.Size(121, 21);
            this.cbCreditType.TabIndex = 13;
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.Location = new System.Drawing.Point(17, 44);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(99, 13);
            this.lblCCNumber.TabIndex = 12;
            this.lblCCNumber.Text = "Kredi kartı numarası";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(273, 44);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(96, 13);
            this.lblExpDate.TabIndex = 7;
            this.lblExpDate.Text = "Son kullanma tarihi";
            // 
            // lblCCType
            // 
            this.lblCCType.AutoSize = true;
            this.lblCCType.Location = new System.Drawing.Point(143, 44);
            this.lblCCType.Name = "lblCCType";
            this.lblCCType.Size = new System.Drawing.Size(75, 13);
            this.lblCCType.TabIndex = 9;
            this.lblCCType.Text = "Kredi Kartı Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(276, 60);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(100, 20);
            this.txtExpDate.TabIndex = 2;
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.Location = new System.Drawing.Point(20, 60);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCCNumber.TabIndex = 3;
            // 
            // txtCheckName
            // 
            this.txtCheckName.Location = new System.Drawing.Point(20, 56);
            this.txtCheckName.Name = "txtCheckName";
            this.txtCheckName.Size = new System.Drawing.Size(100, 20);
            this.txtCheckName.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(347, 406);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Öde";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Location = new System.Drawing.Point(135, 115);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(72, 13);
            this.lblTotalTax.TabIndex = 16;
            this.lblTotalTax.Text = "Toplam Vergi:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 115);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Toplam tutar :";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Location = new System.Drawing.Point(261, 115);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(75, 13);
            this.lblTotalWeight.TabIndex = 16;
            this.lblTotalWeight.Text = "Toplam ağırlık:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 456);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.gbCheck);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.gbCash);
            this.Controls.Add(this.gbPaymentType);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gbPaymentType.ResumeLayout(false);
            this.gbPaymentType.PerformLayout();
            this.gbCash.ResumeLayout(false);
            this.gbCash.PerformLayout();
            this.gbCheck.ResumeLayout(false);
            this.gbCheck.PerformLayout();
            this.gbCreditCard.ResumeLayout(false);
            this.gbCreditCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaymentType;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.GroupBox gbCash;
        private System.Windows.Forms.GroupBox gbCreditCard;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtCCNumber;
        private System.Windows.Forms.TextBox txtCheckName;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCashTendered;
        private System.Windows.Forms.TextBox txtCashTendered;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblCCType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCheckName;
        private System.Windows.Forms.Label lblCheckNBR;
        private System.Windows.Forms.TextBox txtCheckNBR;
        private System.Windows.Forms.ComboBox cbCreditType;
        private System.Windows.Forms.Label lblCCNumber;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalWeight;
    }
}