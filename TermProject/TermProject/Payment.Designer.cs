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
            this.lblPieceCounter = new System.Windows.Forms.TabPage();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.pieceCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnPayment = new System.Windows.Forms.TabPage();
            this.btnPay = new System.Windows.Forms.Button();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.rbtnCheck = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblCCNumber = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblCCV = new System.Windows.Forms.Label();
            this.lblRoutingNbr = new System.Windows.Forms.Label();
            this.lblAccountNbr = new System.Windows.Forms.Label();
            this.txtCCNumber = new System.Windows.Forms.TextBox();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtRoutingNbr = new System.Windows.Forms.TextBox();
            this.txtAccountNbr = new System.Windows.Forms.TextBox();
            this.txtCheckNbr = new System.Windows.Forms.TextBox();
            this.lblCheckNbr = new System.Windows.Forms.Label();
            this.PeymentTabs.SuspendLayout();
            this.lblPieceCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieceCounter)).BeginInit();
            this.rbtnPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeymentTabs
            // 
            this.PeymentTabs.Controls.Add(this.lblPieceCounter);
            this.PeymentTabs.Controls.Add(this.rbtnPayment);
            this.PeymentTabs.Location = new System.Drawing.Point(12, 12);
            this.PeymentTabs.Name = "PeymentTabs";
            this.PeymentTabs.SelectedIndex = 0;
            this.PeymentTabs.Size = new System.Drawing.Size(410, 426);
            this.PeymentTabs.TabIndex = 0;
            // 
            // lblPieceCounter
            // 
            this.lblPieceCounter.Controls.Add(this.btnPay);
            this.lblPieceCounter.Controls.Add(this.lblTotalCost);
            this.lblPieceCounter.Controls.Add(this.lblTaxes);
            this.lblPieceCounter.Controls.Add(this.pieceCounter);
            this.lblPieceCounter.Controls.Add(this.label1);
            this.lblPieceCounter.Location = new System.Drawing.Point(4, 22);
            this.lblPieceCounter.Name = "lblPieceCounter";
            this.lblPieceCounter.Padding = new System.Windows.Forms.Padding(3);
            this.lblPieceCounter.Size = new System.Drawing.Size(402, 400);
            this.lblPieceCounter.TabIndex = 0;
            this.lblPieceCounter.Text = "Adet Seçimi :";
            this.lblPieceCounter.UseVisualStyleBackColor = true;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(56, 202);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(70, 13);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Toplam fiyat :";
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(56, 166);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(70, 13);
            this.lblTaxes.TabIndex = 2;
            this.lblTaxes.Text = "Vergi miktarı :";
            // 
            // pieceCounter
            // 
            this.pieceCounter.Location = new System.Drawing.Point(150, 90);
            this.pieceCounter.Name = "pieceCounter";
            this.pieceCounter.Size = new System.Drawing.Size(120, 20);
            this.pieceCounter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet seçimi";
            // 
            // rbtnPayment
            // 
            this.rbtnPayment.Controls.Add(this.lblCheckNbr);
            this.rbtnPayment.Controls.Add(this.txtCheckNbr);
            this.rbtnPayment.Controls.Add(this.txtAccountNbr);
            this.rbtnPayment.Controls.Add(this.txtRoutingNbr);
            this.rbtnPayment.Controls.Add(this.txtExpDate);
            this.rbtnPayment.Controls.Add(this.txtCCV);
            this.rbtnPayment.Controls.Add(this.txtCCNumber);
            this.rbtnPayment.Controls.Add(this.lblAccountNbr);
            this.rbtnPayment.Controls.Add(this.lblRoutingNbr);
            this.rbtnPayment.Controls.Add(this.lblCCV);
            this.rbtnPayment.Controls.Add(this.lblExpDate);
            this.rbtnPayment.Controls.Add(this.lblCCNumber);
            this.rbtnPayment.Controls.Add(this.btnOrder);
            this.rbtnPayment.Controls.Add(this.rbtnCash);
            this.rbtnPayment.Controls.Add(this.rbtnCheck);
            this.rbtnPayment.Controls.Add(this.rbtnCreditCard);
            this.rbtnPayment.Location = new System.Drawing.Point(4, 22);
            this.rbtnPayment.Name = "rbtnPayment";
            this.rbtnPayment.Padding = new System.Windows.Forms.Padding(3);
            this.rbtnPayment.Size = new System.Drawing.Size(402, 400);
            this.rbtnPayment.TabIndex = 1;
            this.rbtnPayment.Text = "Ödeme";
            this.rbtnPayment.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(205, 281);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Öde";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Location = new System.Drawing.Point(37, 45);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(73, 17);
            this.rbtnCreditCard.TabIndex = 0;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "Kredi Kartı";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCheck
            // 
            this.rbtnCheck.AutoSize = true;
            this.rbtnCheck.Location = new System.Drawing.Point(272, 45);
            this.rbtnCheck.Name = "rbtnCheck";
            this.rbtnCheck.Size = new System.Drawing.Size(44, 17);
            this.rbtnCheck.TabIndex = 1;
            this.rbtnCheck.TabStop = true;
            this.rbtnCheck.Text = "Çek";
            this.rbtnCheck.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Location = new System.Drawing.Point(144, 45);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(95, 17);
            this.rbtnCash.TabIndex = 2;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Kapıda Ödeme";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(272, 330);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Sipariş ver";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.Location = new System.Drawing.Point(37, 91);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(102, 13);
            this.lblCCNumber.TabIndex = 4;
            this.lblCCNumber.Text = "Kredi kartı numarası:";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(37, 146);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(99, 13);
            this.lblExpDate.TabIndex = 5;
            this.lblExpDate.Text = "Son kullanma tarihi:";
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.Location = new System.Drawing.Point(37, 199);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(79, 13);
            this.lblCCV.TabIndex = 6;
            this.lblCCV.Text = "Güvenlik kodu:";
            // 
            // lblRoutingNbr
            // 
            this.lblRoutingNbr.AutoSize = true;
            this.lblRoutingNbr.Location = new System.Drawing.Point(269, 91);
            this.lblRoutingNbr.Name = "lblRoutingNbr";
            this.lblRoutingNbr.Size = new System.Drawing.Size(80, 13);
            this.lblRoutingNbr.TabIndex = 7;
            this.lblRoutingNbr.Text = "Sevk numarası:";
            // 
            // lblAccountNbr
            // 
            this.lblAccountNbr.AutoSize = true;
            this.lblAccountNbr.Location = new System.Drawing.Point(269, 146);
            this.lblAccountNbr.Name = "lblAccountNbr";
            this.lblAccountNbr.Size = new System.Drawing.Size(86, 13);
            this.lblAccountNbr.TabIndex = 8;
            this.lblAccountNbr.Text = "Hesap numarası:";
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.Location = new System.Drawing.Point(37, 107);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCCNumber.TabIndex = 9;
            // 
            // txtCCV
            // 
            this.txtCCV.Location = new System.Drawing.Point(40, 215);
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.Size = new System.Drawing.Size(100, 20);
            this.txtCCV.TabIndex = 10;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(40, 162);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(100, 20);
            this.txtExpDate.TabIndex = 11;
            // 
            // txtRoutingNbr
            // 
            this.txtRoutingNbr.Location = new System.Drawing.Point(272, 107);
            this.txtRoutingNbr.Name = "txtRoutingNbr";
            this.txtRoutingNbr.Size = new System.Drawing.Size(100, 20);
            this.txtRoutingNbr.TabIndex = 12;
            // 
            // txtAccountNbr
            // 
            this.txtAccountNbr.Location = new System.Drawing.Point(272, 162);
            this.txtAccountNbr.Name = "txtAccountNbr";
            this.txtAccountNbr.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNbr.TabIndex = 13;
            // 
            // txtCheckNbr
            // 
            this.txtCheckNbr.Location = new System.Drawing.Point(272, 215);
            this.txtCheckNbr.Name = "txtCheckNbr";
            this.txtCheckNbr.Size = new System.Drawing.Size(100, 20);
            this.txtCheckNbr.TabIndex = 14;
            // 
            // lblCheckNbr
            // 
            this.lblCheckNbr.AutoSize = true;
            this.lblCheckNbr.Location = new System.Drawing.Point(269, 199);
            this.lblCheckNbr.Name = "lblCheckNbr";
            this.lblCheckNbr.Size = new System.Drawing.Size(74, 13);
            this.lblCheckNbr.TabIndex = 15;
            this.lblCheckNbr.Text = "Çek numarası:";
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
            this.lblPieceCounter.ResumeLayout(false);
            this.lblPieceCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieceCounter)).EndInit();
            this.rbtnPayment.ResumeLayout(false);
            this.rbtnPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PeymentTabs;
        private System.Windows.Forms.TabPage lblPieceCounter;
        private System.Windows.Forms.TabPage rbtnPayment;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.NumericUpDown pieceCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnCheck;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.Label lblCheckNbr;
        private System.Windows.Forms.TextBox txtCheckNbr;
        private System.Windows.Forms.TextBox txtAccountNbr;
        private System.Windows.Forms.TextBox txtRoutingNbr;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.TextBox txtCCNumber;
        private System.Windows.Forms.Label lblAccountNbr;
        private System.Windows.Forms.Label lblRoutingNbr;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblCCNumber;
    }
}