namespace TradeJournalManager.Forms.Forms
{
    partial class FormData
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelHeader = new Label();
            buttonDo = new Button();
            comboBoxStrategy = new ComboBox();
            textBoxIndicator = new TextBox();
            textBoxSell = new TextBox();
            textBoxBuy = new TextBox();
            textBoxCertificate = new TextBox();
            textBoxReasons = new TextBox();
            dateTimePickerDateOfTrade = new DateTimePicker();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 135);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Strategy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 187);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Indicator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 240);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Certificate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 294);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Buy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 347);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "Sell:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 401);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 6;
            label7.Text = "Reasons:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 640);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 7;
            label8.Text = "Date:";
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Location = new Point(250, 59);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(16, 20);
            labelHeader.TabIndex = 8;
            labelHeader.Text = "?";
            // 
            // buttonDo
            // 
            buttonDo.Location = new Point(434, 696);
            buttonDo.Name = "buttonDo";
            buttonDo.Size = new Size(94, 29);
            buttonDo.TabIndex = 9;
            buttonDo.Text = "?";
            buttonDo.UseVisualStyleBackColor = true;
            buttonDo.Click += ButtonDo_Click;
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Location = new Point(131, 132);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(397, 28);
            comboBoxStrategy.TabIndex = 10;
            // 
            // textBoxIndicator
            // 
            textBoxIndicator.Location = new Point(131, 184);
            textBoxIndicator.Name = "textBoxIndicator";
            textBoxIndicator.Size = new Size(397, 27);
            textBoxIndicator.TabIndex = 11;
            // 
            // textBoxSell
            // 
            textBoxSell.Location = new Point(131, 344);
            textBoxSell.Name = "textBoxSell";
            textBoxSell.Size = new Size(397, 27);
            textBoxSell.TabIndex = 12;
            // 
            // textBoxBuy
            // 
            textBoxBuy.Location = new Point(131, 291);
            textBoxBuy.Name = "textBoxBuy";
            textBoxBuy.Size = new Size(397, 27);
            textBoxBuy.TabIndex = 13;
            // 
            // textBoxCertificate
            // 
            textBoxCertificate.Location = new Point(131, 237);
            textBoxCertificate.Name = "textBoxCertificate";
            textBoxCertificate.Size = new Size(397, 27);
            textBoxCertificate.TabIndex = 14;
            // 
            // textBoxReasons
            // 
            textBoxReasons.Location = new Point(131, 398);
            textBoxReasons.Multiline = true;
            textBoxReasons.Name = "textBoxReasons";
            textBoxReasons.Size = new Size(397, 211);
            textBoxReasons.TabIndex = 15;
            // 
            // dateTimePickerDateOfTrade
            // 
            dateTimePickerDateOfTrade.Location = new Point(131, 635);
            dateTimePickerDateOfTrade.Name = "dateTimePickerDateOfTrade";
            dateTimePickerDateOfTrade.Size = new Size(397, 27);
            dateTimePickerDateOfTrade.TabIndex = 16;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 737);
            Controls.Add(dateTimePickerDateOfTrade);
            Controls.Add(textBoxReasons);
            Controls.Add(textBoxCertificate);
            Controls.Add(textBoxBuy);
            Controls.Add(textBoxSell);
            Controls.Add(textBoxIndicator);
            Controls.Add(comboBoxStrategy);
            Controls.Add(buttonDo);
            Controls.Add(labelHeader);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(569, 784);
            MinimumSize = new Size(569, 784);
            Name = "FormData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data";
            Load += FormData_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label labelHeader;
        private Button buttonDo;
        private ComboBox comboBoxStrategy;
        private TextBox textBoxIndicator;
        private TextBox textBoxSell;
        private TextBox textBoxBuy;
        private TextBox textBoxCertificate;
        private TextBox textBoxReasons;
        private DateTimePicker dateTimePickerDateOfTrade;
        private ErrorProvider errorProvider;
    }
}