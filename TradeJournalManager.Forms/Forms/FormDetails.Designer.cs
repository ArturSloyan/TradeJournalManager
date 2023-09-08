namespace TradeJournalManager.Forms.Forms
{
    partial class FormDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetails));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelHeader = new Label();
            textBoxDate = new TextBox();
            textBoxStrategy = new TextBox();
            textBoxReasons = new TextBox();
            textBoxRendite = new TextBox();
            textBoxSell = new TextBox();
            textBoxBuy = new TextBox();
            textBoxCertificate = new TextBox();
            textBoxIndicator = new TextBox();
            textBoxId = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 157);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Strategy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 211);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Indicator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 264);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Certificate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 327);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Buy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 381);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "Sell:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 439);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Rendite:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 499);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 6;
            label7.Text = "Reasons:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 667);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 7;
            label8.Text = "Date:";
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Location = new Point(245, 39);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(49, 20);
            labelHeader.TabIndex = 8;
            labelHeader.Text = "Trade:";
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.White;
            textBoxDate.Location = new Point(127, 663);
            textBoxDate.Margin = new Padding(3, 4, 3, 4);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(365, 27);
            textBoxDate.TabIndex = 16;
            // 
            // textBoxStrategy
            // 
            textBoxStrategy.BackColor = Color.White;
            textBoxStrategy.Location = new Point(127, 153);
            textBoxStrategy.Margin = new Padding(3, 4, 3, 4);
            textBoxStrategy.Name = "textBoxStrategy";
            textBoxStrategy.ReadOnly = true;
            textBoxStrategy.Size = new Size(365, 27);
            textBoxStrategy.TabIndex = 17;
            // 
            // textBoxReasons
            // 
            textBoxReasons.BackColor = Color.White;
            textBoxReasons.Location = new Point(127, 495);
            textBoxReasons.Margin = new Padding(3, 4, 3, 4);
            textBoxReasons.Multiline = true;
            textBoxReasons.Name = "textBoxReasons";
            textBoxReasons.ReadOnly = true;
            textBoxReasons.Size = new Size(365, 143);
            textBoxReasons.TabIndex = 19;
            // 
            // textBoxRendite
            // 
            textBoxRendite.BackColor = Color.White;
            textBoxRendite.Location = new Point(127, 435);
            textBoxRendite.Margin = new Padding(3, 4, 3, 4);
            textBoxRendite.Name = "textBoxRendite";
            textBoxRendite.ReadOnly = true;
            textBoxRendite.Size = new Size(365, 27);
            textBoxRendite.TabIndex = 20;
            // 
            // textBoxSell
            // 
            textBoxSell.BackColor = Color.White;
            textBoxSell.ForeColor = Color.Red;
            textBoxSell.Location = new Point(127, 377);
            textBoxSell.Margin = new Padding(3, 4, 3, 4);
            textBoxSell.Name = "textBoxSell";
            textBoxSell.ReadOnly = true;
            textBoxSell.Size = new Size(365, 27);
            textBoxSell.TabIndex = 21;
            // 
            // textBoxBuy
            // 
            textBoxBuy.BackColor = Color.White;
            textBoxBuy.ForeColor = Color.Green;
            textBoxBuy.Location = new Point(127, 323);
            textBoxBuy.Margin = new Padding(3, 4, 3, 4);
            textBoxBuy.Name = "textBoxBuy";
            textBoxBuy.ReadOnly = true;
            textBoxBuy.Size = new Size(365, 27);
            textBoxBuy.TabIndex = 22;
            // 
            // textBoxCertificate
            // 
            textBoxCertificate.BackColor = Color.White;
            textBoxCertificate.Location = new Point(127, 260);
            textBoxCertificate.Margin = new Padding(3, 4, 3, 4);
            textBoxCertificate.Name = "textBoxCertificate";
            textBoxCertificate.ReadOnly = true;
            textBoxCertificate.Size = new Size(365, 27);
            textBoxCertificate.TabIndex = 23;
            // 
            // textBoxIndicator
            // 
            textBoxIndicator.BackColor = Color.White;
            textBoxIndicator.Location = new Point(127, 207);
            textBoxIndicator.Margin = new Padding(3, 4, 3, 4);
            textBoxIndicator.Name = "textBoxIndicator";
            textBoxIndicator.ReadOnly = true;
            textBoxIndicator.Size = new Size(365, 27);
            textBoxIndicator.TabIndex = 24;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.White;
            textBoxId.Location = new Point(127, 103);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(365, 27);
            textBoxId.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 107);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 25;
            label9.Text = "Id:";
            // 
            // FormDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 737);
            Controls.Add(textBoxId);
            Controls.Add(label9);
            Controls.Add(textBoxIndicator);
            Controls.Add(textBoxCertificate);
            Controls.Add(textBoxBuy);
            Controls.Add(textBoxSell);
            Controls.Add(textBoxRendite);
            Controls.Add(textBoxReasons);
            Controls.Add(textBoxStrategy);
            Controls.Add(textBoxDate);
            Controls.Add(labelHeader);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(569, 784);
            MinimumSize = new Size(569, 784);
            Name = "FormDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details";
            Load += FormDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelHeader;
        private TextBox textBoxDate;
        private TextBox textBoxStrategy;
        private TextBox textBoxReasons;
        private TextBox textBoxRendite;
        private TextBox textBoxSell;
        private TextBox textBoxBuy;
        private TextBox textBoxCertificate;
        private TextBox textBoxIndicator;
        private TextBox textBoxId;
        private Label label9;
    }
}