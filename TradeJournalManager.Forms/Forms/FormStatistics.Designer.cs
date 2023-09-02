namespace TradeJournalManager.Forms
{
    partial class FormStatistics
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
            label1 = new Label();
            textBoxQuote = new TextBox();
            textBoxInvestedCapital = new TextBox();
            textBoxFirstTrade = new TextBox();
            progressBarWinLoss = new ProgressBar();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxTotalWin = new TextBox();
            textBoxAverageWin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxAverageLoss = new TextBox();
            textBoxBiggestWin = new TextBox();
            textBoxAverageRendite = new TextBox();
            label10 = new Label();
            textBoxBiggestLoss = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            textBoxTotalLoss = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxTradeCount = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            label15 = new Label();
            label13 = new Label();
            buttonLossLegende = new Button();
            buttonWinLegende = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 392);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Quote of the Day";
            // 
            // textBoxQuote
            // 
            textBoxQuote.Location = new Point(29, 433);
            textBoxQuote.Multiline = true;
            textBoxQuote.Name = "textBoxQuote";
            textBoxQuote.ReadOnly = true;
            textBoxQuote.Size = new Size(377, 389);
            textBoxQuote.TabIndex = 1;
            textBoxQuote.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxInvestedCapital
            // 
            textBoxInvestedCapital.Location = new Point(164, 66);
            textBoxInvestedCapital.Name = "textBoxInvestedCapital";
            textBoxInvestedCapital.ReadOnly = true;
            textBoxInvestedCapital.Size = new Size(300, 27);
            textBoxInvestedCapital.TabIndex = 5;
            // 
            // textBoxFirstTrade
            // 
            textBoxFirstTrade.Location = new Point(161, 99);
            textBoxFirstTrade.Name = "textBoxFirstTrade";
            textBoxFirstTrade.ReadOnly = true;
            textBoxFirstTrade.Size = new Size(300, 27);
            textBoxFirstTrade.TabIndex = 6;
            // 
            // progressBarWinLoss
            // 
            progressBarWinLoss.BackColor = Color.Red;
            progressBarWinLoss.ForeColor = Color.Black;
            progressBarWinLoss.Location = new Point(29, 138);
            progressBarWinLoss.Name = "progressBarWinLoss";
            progressBarWinLoss.Size = new Size(377, 94);
            progressBarWinLoss.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 143);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 11;
            label5.Text = "Total Win:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 173);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 102);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 13;
            label7.Text = "First Trade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 69);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 14;
            label8.Text = "Invested Capital:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 86);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 15;
            label9.Text = "Win:";
            // 
            // textBoxTotalWin
            // 
            textBoxTotalWin.Location = new Point(164, 140);
            textBoxTotalWin.Name = "textBoxTotalWin";
            textBoxTotalWin.ReadOnly = true;
            textBoxTotalWin.Size = new Size(300, 27);
            textBoxTotalWin.TabIndex = 16;
            // 
            // textBoxAverageWin
            // 
            textBoxAverageWin.Location = new Point(164, 100);
            textBoxAverageWin.Name = "textBoxAverageWin";
            textBoxAverageWin.ReadOnly = true;
            textBoxAverageWin.Size = new Size(300, 27);
            textBoxAverageWin.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 103);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 19;
            label2.Text = "Average Win:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 100);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 20;
            label3.Text = "Average Loss:";
            // 
            // textBoxAverageLoss
            // 
            textBoxAverageLoss.Location = new Point(617, 100);
            textBoxAverageLoss.Name = "textBoxAverageLoss";
            textBoxAverageLoss.ReadOnly = true;
            textBoxAverageLoss.Size = new Size(300, 27);
            textBoxAverageLoss.TabIndex = 21;
            // 
            // textBoxBiggestWin
            // 
            textBoxBiggestWin.Location = new Point(164, 170);
            textBoxBiggestWin.Name = "textBoxBiggestWin";
            textBoxBiggestWin.ReadOnly = true;
            textBoxBiggestWin.Size = new Size(300, 27);
            textBoxBiggestWin.TabIndex = 22;
            // 
            // textBoxAverageRendite
            // 
            textBoxAverageRendite.Location = new Point(620, 69);
            textBoxAverageRendite.Name = "textBoxAverageRendite";
            textBoxAverageRendite.ReadOnly = true;
            textBoxAverageRendite.Size = new Size(300, 27);
            textBoxAverageRendite.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(492, 72);
            label10.Name = "label10";
            label10.Size = new Size(122, 20);
            label10.TabIndex = 24;
            label10.Text = "Average Rendite:";
            // 
            // textBoxBiggestLoss
            // 
            textBoxBiggestLoss.Location = new Point(617, 170);
            textBoxBiggestLoss.Name = "textBoxBiggestLoss";
            textBoxBiggestLoss.ReadOnly = true;
            textBoxBiggestLoss.Size = new Size(300, 27);
            textBoxBiggestLoss.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(517, 173);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 26;
            label11.Text = "Biggest Loss:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(61, 173);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 27;
            label12.Text = "Biggest Win:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(537, 146);
            label14.Name = "label14";
            label14.Size = new Size(77, 20);
            label14.TabIndex = 10;
            label14.Text = "Total Loss:";
            // 
            // textBoxTotalLoss
            // 
            textBoxTotalLoss.Location = new Point(620, 143);
            textBoxTotalLoss.Name = "textBoxTotalLoss";
            textBoxTotalLoss.ReadOnly = true;
            textBoxTotalLoss.Size = new Size(300, 27);
            textBoxTotalLoss.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxInvestedCapital);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxAverageRendite);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxTotalLoss);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBoxTotalWin);
            groupBox1.Location = new Point(481, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(949, 228);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Primary Stats";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxAverageWin);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxAverageLoss);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBoxBiggestWin);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxBiggestLoss);
            groupBox2.Location = new Point(481, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(949, 332);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Secondary Stats";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxTradeCount);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBoxFirstTrade);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(481, 641);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(949, 221);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Random Facts";
            // 
            // textBoxTradeCount
            // 
            textBoxTradeCount.Location = new Point(614, 99);
            textBoxTradeCount.Name = "textBoxTradeCount";
            textBoxTradeCount.ReadOnly = true;
            textBoxTradeCount.Size = new Size(300, 27);
            textBoxTradeCount.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 102);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 13;
            label4.Text = "Trade Count:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(buttonLossLegende);
            groupBox4.Controls.Add(buttonWinLegende);
            groupBox4.Controls.Add(progressBarWinLoss);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(textBoxQuote);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(444, 850);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Motivator";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(191, 48);
            label15.Name = "label15";
            label15.Size = new Size(44, 20);
            label15.TabIndex = 20;
            label15.Text = "Ratio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(276, 86);
            label13.Name = "label13";
            label13.Size = new Size(40, 20);
            label13.TabIndex = 19;
            label13.Text = "Loss:";
            // 
            // buttonLossLegende
            // 
            buttonLossLegende.BackColor = Color.White;
            buttonLossLegende.Location = new Point(322, 82);
            buttonLossLegende.Name = "buttonLossLegende";
            buttonLossLegende.Size = new Size(30, 29);
            buttonLossLegende.TabIndex = 18;
            buttonLossLegende.UseVisualStyleBackColor = false;
            // 
            // buttonWinLegende
            // 
            buttonWinLegende.BackColor = Color.White;
            buttonWinLegende.ForeColor = Color.White;
            buttonWinLegende.Location = new Point(114, 82);
            buttonWinLegende.Name = "buttonWinLegende";
            buttonWinLegende.Size = new Size(30, 29);
            buttonWinLegende.TabIndex = 16;
            buttonWinLegende.UseVisualStyleBackColor = false;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 897);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1460, 944);
            MinimumSize = new Size(1460, 944);
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            Load += FormStatistics_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxQuote;
        private TextBox textBoxInvestedCapital;
        private TextBox textBoxFirstTrade;
        private ProgressBar progressBarWinLoss;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxTotalWin;
        private TextBox textBoxAverageWin;
        private Label label2;
        private Label label3;
        private TextBox textBoxAverageLoss;
        private TextBox textBoxBiggestWin;
        private TextBox textBoxAverageRendite;
        private Label label10;
        private TextBox textBoxBiggestLoss;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox textBoxTotalLoss;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBoxTradeCount;
        private Label label4;
        private Button buttonLossLegende;
        private Button buttonWinLegende;
        private Label label13;
        private Label label15;
    }
}