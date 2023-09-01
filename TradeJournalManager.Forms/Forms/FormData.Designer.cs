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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelHeader = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 112);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Strategy:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 158);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Indicator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 198);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Certificate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 240);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Buy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 286);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "Sell:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 329);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Rendite:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 374);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 6;
            label7.Text = "Reasons:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 500);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 7;
            label8.Text = "Date:";
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Location = new Point(214, 46);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(12, 15);
            labelHeader.TabIndex = 8;
            labelHeader.Text = "?";
            // 
            // FormData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
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
            MaximumSize = new Size(500, 600);
            MinimumSize = new Size(500, 600);
            Name = "FormData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data";
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
    }
}