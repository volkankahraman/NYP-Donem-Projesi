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
            this.components = new System.ComponentModel.Container();
            this.gbPaymentType = new System.Windows.Forms.GroupBox();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.cbCreditType = new System.Windows.Forms.ComboBox();
            this.lblCCNumber = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCCType = new System.Windows.Forms.Label();
            this.lblCashTendered = new System.Windows.Forms.Label();
            this.txtCashTendered = new System.Windows.Forms.TextBox();
            this.txtExpMonth = new System.Windows.Forms.TextBox();
            this.txtCCNumber = new System.Windows.Forms.TextBox();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.lblCheckNBR = new System.Windows.Forms.Label();
            this.txtCheckName = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.txtCheckNBR = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpYear = new System.Windows.Forms.TextBox();
            this.gbPaymentType.SuspendLayout();
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
            // cbCreditType
            // 
            this.cbCreditType.FormattingEnabled = true;
            this.cbCreditType.Items.AddRange(new object[] {
            "MasterCard",
            "Visa"});
            this.cbCreditType.Location = new System.Drawing.Point(158, 185);
            this.cbCreditType.Name = "cbCreditType";
            this.cbCreditType.Size = new System.Drawing.Size(121, 21);
            this.cbCreditType.TabIndex = 13;
            this.cbCreditType.Visible = false;
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.Location = new System.Drawing.Point(29, 169);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(99, 13);
            this.lblCCNumber.TabIndex = 12;
            this.lblCCNumber.Text = "Kredi kartı numarası";
            this.lblCCNumber.Visible = false;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(285, 169);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(96, 13);
            this.lblExpDate.TabIndex = 7;
            this.lblExpDate.Text = "Son kullanma tarihi";
            this.lblExpDate.Visible = false;
            // 
            // lblCCType
            // 
            this.lblCCType.AutoSize = true;
            this.lblCCType.Location = new System.Drawing.Point(155, 170);
            this.lblCCType.Name = "lblCCType";
            this.lblCCType.Size = new System.Drawing.Size(75, 13);
            this.lblCCType.TabIndex = 9;
            this.lblCCType.Text = "Kredi Kartı Tipi";
            this.lblCCType.Visible = false;
            // 
            // lblCashTendered
            // 
            this.lblCashTendered.AutoSize = true;
            this.lblCashTendered.Location = new System.Drawing.Point(30, 169);
            this.lblCashTendered.Name = "lblCashTendered";
            this.lblCashTendered.Size = new System.Drawing.Size(66, 13);
            this.lblCashTendered.TabIndex = 5;
            this.lblCashTendered.Text = "Nakit Miktarı";
            // 
            // txtCashTendered
            // 
            this.txtCashTendered.Location = new System.Drawing.Point(32, 186);
            this.txtCashTendered.Name = "txtCashTendered";
            this.txtCashTendered.Size = new System.Drawing.Size(100, 20);
            this.txtCashTendered.TabIndex = 4;
            // 
            // txtExpMonth
            // 
            this.txtExpMonth.Location = new System.Drawing.Point(288, 185);
            this.txtExpMonth.Name = "txtExpMonth";
            this.txtExpMonth.Size = new System.Drawing.Size(31, 20);
            this.txtExpMonth.TabIndex = 2;
            this.txtExpMonth.Visible = false;
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.Location = new System.Drawing.Point(32, 185);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCCNumber.TabIndex = 3;
            this.txtCCNumber.Visible = false;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.Location = new System.Drawing.Point(30, 169);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(25, 13);
            this.lblCheckName.TabIndex = 13;
            this.lblCheckName.Text = "İsim";
            this.lblCheckName.Visible = false;
            // 
            // lblCheckNBR
            // 
            this.lblCheckNBR.AutoSize = true;
            this.lblCheckNBR.Location = new System.Drawing.Point(155, 170);
            this.lblCheckNBR.Name = "lblCheckNBR";
            this.lblCheckNBR.Size = new System.Drawing.Size(71, 13);
            this.lblCheckNBR.TabIndex = 15;
            this.lblCheckNBR.Text = "Çek numarası";
            this.lblCheckNBR.Visible = false;
            // 
            // txtCheckName
            // 
            this.txtCheckName.Location = new System.Drawing.Point(32, 186);
            this.txtCheckName.Name = "txtCheckName";
            this.txtCheckName.Size = new System.Drawing.Size(100, 20);
            this.txtCheckName.TabIndex = 0;
            this.txtCheckName.Visible = false;
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
            // txtCheckNBR
            // 
            this.txtCheckNBR.Location = new System.Drawing.Point(158, 186);
            this.txtCheckNBR.Name = "txtCheckNBR";
            this.txtCheckNBR.Size = new System.Drawing.Size(100, 20);
            this.txtCheckNBR.TabIndex = 4;
            this.txtCheckNBR.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(31, 253);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(100, 20);
            this.txtCVC.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "/";
            // 
            // txtExpYear
            // 
            this.txtExpYear.Location = new System.Drawing.Point(343, 185);
            this.txtExpYear.Name = "txtExpYear";
            this.txtExpYear.Size = new System.Drawing.Size(31, 20);
            this.txtExpYear.TabIndex = 21;
            this.txtExpYear.Visible = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 456);
            this.Controls.Add(this.txtExpYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.cbCreditType);
            this.Controls.Add(this.lblCashTendered);
            this.Controls.Add(this.lblCCNumber);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.txtCheckNBR);
            this.Controls.Add(this.lblCCType);
            this.Controls.Add(this.txtCashTendered);
            this.Controls.Add(this.lblCheckName);
            this.Controls.Add(this.txtExpMonth);
            this.Controls.Add(this.lblCheckNBR);
            this.Controls.Add(this.txtCCNumber);
            this.Controls.Add(this.txtCheckName);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.gbPaymentType);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gbPaymentType.ResumeLayout(false);
            this.gbPaymentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaymentType;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.TextBox txtExpMonth;
        private System.Windows.Forms.TextBox txtCCNumber;
        private System.Windows.Forms.TextBox txtCheckName;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblCashTendered;
        private System.Windows.Forms.TextBox txtCashTendered;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblCCType;
        private System.Windows.Forms.Label lblCheckName;
        private System.Windows.Forms.Label lblCheckNBR;
        private System.Windows.Forms.ComboBox cbCreditType;
        private System.Windows.Forms.Label lblCCNumber;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.TextBox txtCheckNBR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpYear;
    }
}