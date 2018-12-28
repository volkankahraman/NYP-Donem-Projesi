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
            this.gbCash = new System.Windows.Forms.GroupBox();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.gbCredit = new System.Windows.Forms.GroupBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.gbPaymentType.SuspendLayout();
            this.gbCash.SuspendLayout();
            this.gbCheck.SuspendLayout();
            this.gbCredit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaymentType
            // 
            this.gbPaymentType.Controls.Add(this.rbCheck);
            this.gbPaymentType.Controls.Add(this.rbCreditCard);
            this.gbPaymentType.Controls.Add(this.rbCash);
            this.gbPaymentType.Location = new System.Drawing.Point(322, 12);
            this.gbPaymentType.Name = "gbPaymentType";
            this.gbPaymentType.Size = new System.Drawing.Size(100, 92);
            this.gbPaymentType.TabIndex = 0;
            this.gbPaymentType.TabStop = false;
            this.gbPaymentType.Text = "Ödeme Yöntemi";
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Location = new System.Drawing.Point(6, 65);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(44, 17);
            this.rbCheck.TabIndex = 2;
            this.rbCheck.Text = "Çek";
            this.rbCheck.UseVisualStyleBackColor = true;
            this.rbCheck.CheckedChanged += new System.EventHandler(this.rbCheck_CheckedChanged);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(6, 42);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(72, 17);
            this.rbCreditCard.TabIndex = 1;
            this.rbCreditCard.Text = "Kredi kartı";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(6, 19);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(50, 17);
            this.rbCash.TabIndex = 0;
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
            this.cbCreditType.Location = new System.Drawing.Point(203, 45);
            this.cbCreditType.Name = "cbCreditType";
            this.cbCreditType.Size = new System.Drawing.Size(121, 21);
            this.cbCreditType.TabIndex = 1;
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.Location = new System.Drawing.Point(95, 22);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(102, 13);
            this.lblCCNumber.TabIndex = 12;
            this.lblCCNumber.Text = "Kredi Kartı Numarası";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(59, 75);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(138, 13);
            this.lblExpDate.TabIndex = 7;
            this.lblExpDate.Text = "Son Kullanma Tarihi (Ay/Yıl)";
            // 
            // lblCCType
            // 
            this.lblCCType.AutoSize = true;
            this.lblCCType.Location = new System.Drawing.Point(122, 48);
            this.lblCCType.Name = "lblCCType";
            this.lblCCType.Size = new System.Drawing.Size(75, 13);
            this.lblCCType.TabIndex = 9;
            this.lblCCType.Text = "Kredi Kartı Tipi";
            // 
            // lblCashTendered
            // 
            this.lblCashTendered.AutoSize = true;
            this.lblCashTendered.Location = new System.Drawing.Point(105, 22);
            this.lblCashTendered.Name = "lblCashTendered";
            this.lblCashTendered.Size = new System.Drawing.Size(66, 13);
            this.lblCashTendered.TabIndex = 5;
            this.lblCashTendered.Text = "Nakit Miktarı";
            // 
            // txtCashTendered
            // 
            this.txtCashTendered.Location = new System.Drawing.Point(177, 19);
            this.txtCashTendered.Name = "txtCashTendered";
            this.txtCashTendered.Size = new System.Drawing.Size(121, 20);
            this.txtCashTendered.TabIndex = 0;
            // 
            // txtExpMonth
            // 
            this.txtExpMonth.Location = new System.Drawing.Point(203, 72);
            this.txtExpMonth.Name = "txtExpMonth";
            this.txtExpMonth.Size = new System.Drawing.Size(45, 20);
            this.txtExpMonth.TabIndex = 2;
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.Location = new System.Drawing.Point(203, 19);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(121, 20);
            this.txtCCNumber.TabIndex = 0;
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.Location = new System.Drawing.Point(146, 22);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(25, 13);
            this.lblCheckName.TabIndex = 13;
            this.lblCheckName.Text = "İsim";
            // 
            // lblCheckNBR
            // 
            this.lblCheckNBR.AutoSize = true;
            this.lblCheckNBR.Location = new System.Drawing.Point(98, 48);
            this.lblCheckNBR.Name = "lblCheckNBR";
            this.lblCheckNBR.Size = new System.Drawing.Size(73, 13);
            this.lblCheckNBR.TabIndex = 15;
            this.lblCheckNBR.Text = "Çek Numarası";
            // 
            // txtCheckName
            // 
            this.txtCheckName.Location = new System.Drawing.Point(177, 19);
            this.txtCheckName.Name = "txtCheckName";
            this.txtCheckName.Size = new System.Drawing.Size(121, 20);
            this.txtCheckName.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(347, 385);
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
            this.lblTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTax.Location = new System.Drawing.Point(12, 51);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(102, 20);
            this.lblTotalTax.TabIndex = 16;
            this.lblTotalTax.Text = "Toplam Vergi";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(12, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 20);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Toplam Tutar";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalWeight.Location = new System.Drawing.Point(12, 74);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(107, 20);
            this.lblTotalWeight.TabIndex = 16;
            this.lblTotalWeight.Text = "Toplam Ağırlık";
            // 
            // txtCheckNBR
            // 
            this.txtCheckNBR.Location = new System.Drawing.Point(177, 45);
            this.txtCheckNBR.Name = "txtCheckNBR";
            this.txtCheckNBR.Size = new System.Drawing.Size(121, 20);
            this.txtCheckNBR.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(203, 98);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(121, 20);
            this.txtCVC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "/";
            // 
            // txtExpYear
            // 
            this.txtExpYear.Location = new System.Drawing.Point(279, 72);
            this.txtExpYear.Name = "txtExpYear";
            this.txtExpYear.Size = new System.Drawing.Size(45, 20);
            this.txtExpYear.TabIndex = 3;
            // 
            // gbCash
            // 
            this.gbCash.Controls.Add(this.lblCashTendered);
            this.gbCash.Controls.Add(this.txtCashTendered);
            this.gbCash.Location = new System.Drawing.Point(12, 110);
            this.gbCash.Name = "gbCash";
            this.gbCash.Size = new System.Drawing.Size(410, 55);
            this.gbCash.TabIndex = 3;
            this.gbCash.TabStop = false;
            this.gbCash.Text = "Nakit";
            this.gbCash.Visible = false;
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.lblCheckName);
            this.gbCheck.Controls.Add(this.txtCheckName);
            this.gbCheck.Controls.Add(this.lblCheckNBR);
            this.gbCheck.Controls.Add(this.txtCheckNBR);
            this.gbCheck.Location = new System.Drawing.Point(12, 171);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Size = new System.Drawing.Size(410, 76);
            this.gbCheck.TabIndex = 4;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "Çek Bilgileri";
            this.gbCheck.Visible = false;
            // 
            // gbCredit
            // 
            this.gbCredit.Controls.Add(this.lblCVC);
            this.gbCredit.Controls.Add(this.lblExpDate);
            this.gbCredit.Controls.Add(this.txtCCNumber);
            this.gbCredit.Controls.Add(this.txtExpMonth);
            this.gbCredit.Controls.Add(this.lblCCType);
            this.gbCredit.Controls.Add(this.txtExpYear);
            this.gbCredit.Controls.Add(this.lblCCNumber);
            this.gbCredit.Controls.Add(this.label1);
            this.gbCredit.Controls.Add(this.cbCreditType);
            this.gbCredit.Controls.Add(this.txtCVC);
            this.gbCredit.Location = new System.Drawing.Point(12, 253);
            this.gbCredit.Name = "gbCredit";
            this.gbCredit.Size = new System.Drawing.Size(410, 126);
            this.gbCredit.TabIndex = 4;
            this.gbCredit.TabStop = false;
            this.gbCredit.Text = "Kredi Kartı Bilgileri";
            this.gbCredit.Visible = false;
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(169, 101);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(28, 13);
            this.lblCVC.TabIndex = 22;
            this.lblCVC.Text = "CVC";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 419);
            this.Controls.Add(this.gbCheck);
            this.Controls.Add(this.gbCredit);
            this.Controls.Add(this.gbCash);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalTax);
            this.Controls.Add(this.gbPaymentType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Payment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gbPaymentType.ResumeLayout(false);
            this.gbPaymentType.PerformLayout();
            this.gbCash.ResumeLayout(false);
            this.gbCash.PerformLayout();
            this.gbCheck.ResumeLayout(false);
            this.gbCheck.PerformLayout();
            this.gbCredit.ResumeLayout(false);
            this.gbCredit.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbCash;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.GroupBox gbCredit;
        private System.Windows.Forms.Label lblCVC;
    }
}