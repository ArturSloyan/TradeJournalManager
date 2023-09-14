namespace TradeJournalManager.Forms
{
    partial class FormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            buttonAdd = new Button();
            dataGridViewTrades = new DataGridView();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrades).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(1091, 844);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(96, 48);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAddOrEdit_Click;
            // 
            // dataGridViewTrades
            // 
            dataGridViewTrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrades.Location = new Point(14, 29);
            dataGridViewTrades.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTrades.MultiSelect = false;
            dataGridViewTrades.Name = "dataGridViewTrades";
            dataGridViewTrades.ReadOnly = true;
            dataGridViewTrades.RowHeadersWidth = 51;
            dataGridViewTrades.RowTemplate.Height = 25;
            dataGridViewTrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTrades.Size = new Size(1417, 807);
            dataGridViewTrades.TabIndex = 3;
            dataGridViewTrades.CellDoubleClick += DataGridViewTrades_CellDoubleClick;
            dataGridViewTrades.SelectionChanged += DataGridViewTrades_SelectionChanged;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(1214, 844);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(96, 48);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonAddOrEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1335, 844);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 48);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 895);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridViewTrades);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1460, 942);
            MinimumSize = new Size(1460, 942);
            Name = "FormList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List";
            Load += FormList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private DataGridView dataGridViewTrades;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}