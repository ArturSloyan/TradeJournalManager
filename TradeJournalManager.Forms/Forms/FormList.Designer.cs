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
            buttonAdd.Location = new Point(955, 633);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(84, 36);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAddOrEdit_Click;
            // 
            // dataGridViewTrades
            // 
            dataGridViewTrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrades.Location = new Point(12, 22);
            dataGridViewTrades.MultiSelect = false;
            dataGridViewTrades.Name = "dataGridViewTrades";
            dataGridViewTrades.ReadOnly = true;
            dataGridViewTrades.RowHeadersWidth = 51;
            dataGridViewTrades.RowTemplate.Height = 25;
            dataGridViewTrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTrades.Size = new Size(1240, 605);
            dataGridViewTrades.TabIndex = 3;
            dataGridViewTrades.CellDoubleClick += DataGridViewTrades_CellDoubleClick;
            dataGridViewTrades.SelectionChanged += DataGridViewTrades_SelectionChanged;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(1062, 633);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(84, 36);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonAddOrEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1168, 633);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(84, 36);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 679);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridViewTrades);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1280, 718);
            MinimumSize = new Size(1280, 718);
            Name = "FormList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List";
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