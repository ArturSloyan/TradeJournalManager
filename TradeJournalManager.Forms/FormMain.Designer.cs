namespace TradeJournalManager.Forms
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonList = new Button();
            buttonStatistics = new Button();
            labelspecial = new Label();
            SuspendLayout();
            // 
            // buttonList
            // 
            buttonList.Anchor = AnchorStyles.None;
            buttonList.Location = new Point(95, 68);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(160, 80);
            buttonList.TabIndex = 0;
            buttonList.Text = "List";
            buttonList.UseVisualStyleBackColor = true;
            buttonList.Click += ButtonList_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.Location = new Point(95, 176);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(160, 80);
            buttonStatistics.TabIndex = 1;
            buttonStatistics.Text = "Statistics";
            buttonStatistics.UseVisualStyleBackColor = true;
            buttonStatistics.Click += ButtonStatistics_Click;
            // 
            // labelspecial
            // 
            labelspecial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelspecial.AutoSize = true;
            labelspecial.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelspecial.ForeColor = Color.Red;
            labelspecial.Location = new Point(159, 219);
            labelspecial.Name = "labelspecial";
            labelspecial.Size = new Size(0, 37);
            labelspecial.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 321);
            Controls.Add(labelspecial);
            Controls.Add(buttonStatistics);
            Controls.Add(buttonList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(360, 360);
            MinimumSize = new Size(360, 360);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonList;
        private Button buttonStatistics;
        private Label labelspecial;
    }
}