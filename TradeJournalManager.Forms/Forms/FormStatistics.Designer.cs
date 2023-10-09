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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
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
            groupBox5 = new GroupBox();
            textBoxAverageHolding = new TextBox();
            label18 = new Label();
            textBoxLongestHolding = new TextBox();
            label17 = new Label();
            textBoxShortestHolding = new TextBox();
            label16 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 344);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Quote of the Day";
            // 
            // textBoxQuote
            // 
            textBoxQuote.BackColor = Color.AntiqueWhite;
            textBoxQuote.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuote.Location = new Point(25, 375);
            textBoxQuote.Margin = new Padding(3, 2, 3, 2);
            textBoxQuote.Multiline = true;
            textBoxQuote.Name = "textBoxQuote";
            textBoxQuote.ReadOnly = true;
            textBoxQuote.Size = new Size(330, 176);
            textBoxQuote.TabIndex = 1;
            textBoxQuote.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxInvestedCapital
            // 
            textBoxInvestedCapital.BackColor = Color.White;
            textBoxInvestedCapital.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInvestedCapital.Location = new Point(144, 37);
            textBoxInvestedCapital.Margin = new Padding(3, 2, 3, 2);
            textBoxInvestedCapital.Name = "textBoxInvestedCapital";
            textBoxInvestedCapital.ReadOnly = true;
            textBoxInvestedCapital.Size = new Size(263, 21);
            textBoxInvestedCapital.TabIndex = 5;
            // 
            // textBoxFirstTrade
            // 
            textBoxFirstTrade.BackColor = Color.White;
            textBoxFirstTrade.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstTrade.Location = new Point(144, 64);
            textBoxFirstTrade.Margin = new Padding(3, 2, 3, 2);
            textBoxFirstTrade.Name = "textBoxFirstTrade";
            textBoxFirstTrade.ReadOnly = true;
            textBoxFirstTrade.Size = new Size(263, 21);
            textBoxFirstTrade.TabIndex = 6;
            // 
            // progressBarWinLoss
            // 
            progressBarWinLoss.BackColor = Color.Red;
            progressBarWinLoss.ForeColor = Color.Black;
            progressBarWinLoss.Location = new Point(29, 154);
            progressBarWinLoss.Margin = new Padding(3, 2, 3, 2);
            progressBarWinLoss.Name = "progressBarWinLoss";
            progressBarWinLoss.Size = new Size(330, 70);
            progressBarWinLoss.Step = 1;
            progressBarWinLoss.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(73, 86);
            label5.Name = "label5";
            label5.Size = new Size(56, 13);
            label5.TabIndex = 11;
            label5.Text = "Total Win:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(453, 130);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(69, 67);
            label7.Name = "label7";
            label7.Size = new Size(60, 13);
            label7.TabIndex = 13;
            label7.Text = "First Trade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(35, 38);
            label8.Name = "label8";
            label8.Size = new Size(86, 13);
            label8.TabIndex = 14;
            label8.Text = "Invested Capital:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(69, 117);
            label9.Name = "label9";
            label9.Size = new Size(29, 13);
            label9.TabIndex = 15;
            label9.Text = "Win:";
            // 
            // textBoxTotalWin
            // 
            textBoxTotalWin.BackColor = Color.White;
            textBoxTotalWin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalWin.ForeColor = Color.Green;
            textBoxTotalWin.Location = new Point(144, 84);
            textBoxTotalWin.Margin = new Padding(3, 2, 3, 2);
            textBoxTotalWin.Name = "textBoxTotalWin";
            textBoxTotalWin.ReadOnly = true;
            textBoxTotalWin.Size = new Size(263, 21);
            textBoxTotalWin.TabIndex = 16;
            // 
            // textBoxAverageWin
            // 
            textBoxAverageWin.BackColor = Color.White;
            textBoxAverageWin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAverageWin.ForeColor = Color.Green;
            textBoxAverageWin.Location = new Point(144, 38);
            textBoxAverageWin.Margin = new Padding(3, 2, 3, 2);
            textBoxAverageWin.Name = "textBoxAverageWin";
            textBoxAverageWin.ReadOnly = true;
            textBoxAverageWin.Size = new Size(263, 21);
            textBoxAverageWin.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 40);
            label2.Name = "label2";
            label2.Size = new Size(72, 13);
            label2.TabIndex = 19;
            label2.Text = "Average Win:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(450, 40);
            label3.Name = "label3";
            label3.Size = new Size(75, 13);
            label3.TabIndex = 20;
            label3.Text = "Average Loss:";
            // 
            // textBoxAverageLoss
            // 
            textBoxAverageLoss.BackColor = Color.White;
            textBoxAverageLoss.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAverageLoss.ForeColor = Color.Red;
            textBoxAverageLoss.Location = new Point(542, 38);
            textBoxAverageLoss.Margin = new Padding(3, 2, 3, 2);
            textBoxAverageLoss.Name = "textBoxAverageLoss";
            textBoxAverageLoss.ReadOnly = true;
            textBoxAverageLoss.Size = new Size(263, 21);
            textBoxAverageLoss.TabIndex = 21;
            // 
            // textBoxBiggestWin
            // 
            textBoxBiggestWin.BackColor = Color.White;
            textBoxBiggestWin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBiggestWin.ForeColor = Color.Green;
            textBoxBiggestWin.Location = new Point(144, 81);
            textBoxBiggestWin.Margin = new Padding(3, 2, 3, 2);
            textBoxBiggestWin.Name = "textBoxBiggestWin";
            textBoxBiggestWin.ReadOnly = true;
            textBoxBiggestWin.Size = new Size(263, 21);
            textBoxBiggestWin.TabIndex = 22;
            // 
            // textBoxAverageRendite
            // 
            textBoxAverageRendite.BackColor = Color.White;
            textBoxAverageRendite.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAverageRendite.Location = new Point(542, 38);
            textBoxAverageRendite.Margin = new Padding(3, 2, 3, 2);
            textBoxAverageRendite.Name = "textBoxAverageRendite";
            textBoxAverageRendite.ReadOnly = true;
            textBoxAverageRendite.Size = new Size(263, 21);
            textBoxAverageRendite.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(430, 40);
            label10.Name = "label10";
            label10.Size = new Size(90, 13);
            label10.TabIndex = 24;
            label10.Text = "Average Rendite:";
            // 
            // textBoxBiggestLoss
            // 
            textBoxBiggestLoss.BackColor = Color.White;
            textBoxBiggestLoss.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBiggestLoss.ForeColor = Color.Red;
            textBoxBiggestLoss.Location = new Point(542, 81);
            textBoxBiggestLoss.Margin = new Padding(3, 2, 3, 2);
            textBoxBiggestLoss.Name = "textBoxBiggestLoss";
            textBoxBiggestLoss.ReadOnly = true;
            textBoxBiggestLoss.Size = new Size(263, 21);
            textBoxBiggestLoss.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(454, 83);
            label11.Name = "label11";
            label11.Size = new Size(70, 13);
            label11.TabIndex = 26;
            label11.Text = "Biggest Loss:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(59, 83);
            label12.Name = "label12";
            label12.Size = new Size(67, 13);
            label12.TabIndex = 27;
            label12.Text = "Biggest Win:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(470, 86);
            label14.Name = "label14";
            label14.Size = new Size(59, 13);
            label14.TabIndex = 10;
            label14.Text = "Total Loss:";
            // 
            // textBoxTotalLoss
            // 
            textBoxTotalLoss.BackColor = Color.White;
            textBoxTotalLoss.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalLoss.ForeColor = Color.Red;
            textBoxTotalLoss.Location = new Point(542, 84);
            textBoxTotalLoss.Margin = new Padding(3, 2, 3, 2);
            textBoxTotalLoss.Name = "textBoxTotalLoss";
            textBoxTotalLoss.ReadOnly = true;
            textBoxTotalLoss.Size = new Size(263, 21);
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(421, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(830, 136);
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
            groupBox2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(421, 162);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(830, 136);
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
            groupBox3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(421, 502);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(830, 144);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Random Facts";
            // 
            // textBoxTradeCount
            // 
            textBoxTradeCount.BackColor = Color.White;
            textBoxTradeCount.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTradeCount.Location = new Point(542, 64);
            textBoxTradeCount.Margin = new Padding(3, 2, 3, 2);
            textBoxTradeCount.Name = "textBoxTradeCount";
            textBoxTradeCount.ReadOnly = true;
            textBoxTradeCount.Size = new Size(263, 21);
            textBoxTradeCount.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(457, 67);
            label4.Name = "label4";
            label4.Size = new Size(69, 13);
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
            groupBox4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox4.Location = new Point(10, 9);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(388, 638);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Motivator";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(171, 86);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 20;
            label15.Text = "Ratio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(246, 117);
            label13.Name = "label13";
            label13.Size = new Size(32, 13);
            label13.TabIndex = 19;
            label13.Text = "Loss:";
            // 
            // buttonLossLegende
            // 
            buttonLossLegende.Location = new Point(285, 112);
            buttonLossLegende.Margin = new Padding(3, 2, 3, 2);
            buttonLossLegende.Name = "buttonLossLegende";
            buttonLossLegende.Size = new Size(26, 22);
            buttonLossLegende.TabIndex = 18;
            buttonLossLegende.UseVisualStyleBackColor = false;
            // 
            // buttonWinLegende
            // 
            buttonWinLegende.BackColor = Color.ForestGreen;
            buttonWinLegende.Location = new Point(103, 112);
            buttonWinLegende.Margin = new Padding(3, 2, 3, 2);
            buttonWinLegende.Name = "buttonWinLegende";
            buttonWinLegende.Size = new Size(26, 22);
            buttonWinLegende.TabIndex = 16;
            buttonWinLegende.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxAverageHolding);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(textBoxLongestHolding);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(textBoxShortestHolding);
            groupBox5.Controls.Add(label16);
            groupBox5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox5.Location = new Point(421, 320);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(830, 156);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "Duration Stats";
            // 
            // textBoxAverageHolding
            // 
            textBoxAverageHolding.BackColor = Color.White;
            textBoxAverageHolding.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAverageHolding.Location = new Point(144, 98);
            textBoxAverageHolding.Margin = new Padding(3, 2, 3, 2);
            textBoxAverageHolding.Name = "textBoxAverageHolding";
            textBoxAverageHolding.ReadOnly = true;
            textBoxAverageHolding.Size = new Size(263, 21);
            textBoxAverageHolding.TabIndex = 22;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(429, 51);
            label18.Name = "label18";
            label18.Size = new Size(88, 13);
            label18.TabIndex = 2;
            label18.Text = "Shortest Holding:";
            // 
            // textBoxLongestHolding
            // 
            textBoxLongestHolding.BackColor = Color.White;
            textBoxLongestHolding.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLongestHolding.Location = new Point(144, 49);
            textBoxLongestHolding.Margin = new Padding(3, 2, 3, 2);
            textBoxLongestHolding.Name = "textBoxLongestHolding";
            textBoxLongestHolding.ReadOnly = true;
            textBoxLongestHolding.Size = new Size(263, 21);
            textBoxLongestHolding.TabIndex = 18;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(32, 51);
            label17.Name = "label17";
            label17.Size = new Size(87, 13);
            label17.TabIndex = 1;
            label17.Text = "Longest Holding:";
            // 
            // textBoxShortestHolding
            // 
            textBoxShortestHolding.BackColor = Color.White;
            textBoxShortestHolding.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxShortestHolding.Location = new Point(542, 49);
            textBoxShortestHolding.Margin = new Padding(3, 2, 3, 2);
            textBoxShortestHolding.Name = "textBoxShortestHolding";
            textBoxShortestHolding.ReadOnly = true;
            textBoxShortestHolding.Size = new Size(263, 21);
            textBoxShortestHolding.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(30, 100);
            label16.Name = "label16";
            label16.Size = new Size(89, 13);
            label16.TabIndex = 0;
            label16.Text = "Average Holding:";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 675);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 714);
            MinimumSize = new Size(1280, 714);
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        private GroupBox groupBox5;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox textBoxAverageHolding;
        private TextBox textBoxLongestHolding;
        private TextBox textBoxShortestHolding;
    }
}