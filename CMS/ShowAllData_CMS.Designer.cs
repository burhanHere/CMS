namespace CMS
{
    partial class ShowAllData_CMS
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllData_CMS));
            ShowAllData_dataGridView = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            SearchByStudentID_button = new Button();
            SearchRollNode_textBox = new TextBox();
            SearchRollNO_lable = new Label();
            DataRefresh_button = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowAllData_dataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // ShowAllData_dataGridView
            // 
            ShowAllData_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowAllData_dataGridView.BackgroundColor = Color.FromArgb(33, 44, 85);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 44, 85);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ShowAllData_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ShowAllData_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowAllData_dataGridView.Cursor = Cursors.Hand;
            ShowAllData_dataGridView.Dock = DockStyle.Fill;
            ShowAllData_dataGridView.Location = new Point(9, 86);
            ShowAllData_dataGridView.Name = "ShowAllData_dataGridView";
            ShowAllData_dataGridView.RowHeadersWidth = 51;
            ShowAllData_dataGridView.RowTemplate.Height = 29;
            ShowAllData_dataGridView.Size = new Size(1189, 643);
            ShowAllData_dataGridView.TabIndex = 4;
            ShowAllData_dataGridView.CellDoubleClick += ShowAllData_dataGridView_CellDoubleClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(192, 207, 250);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(ShowAllData_dataGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5357141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.46429F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1207, 739);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = Color.FromArgb(33, 44, 85);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(DataRefresh_button, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(9, 11);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1189, 68);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(192, 207, 250);
            tableLayoutPanel3.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(SearchByStudentID_button, 2, 0);
            tableLayoutPanel3.Controls.Add(SearchRollNode_textBox, 1, 0);
            tableLayoutPanel3.Controls.Add(SearchRollNO_lable, 0, 0);
            tableLayoutPanel3.Location = new Point(9, 11);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(385, 46);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // SearchByStudentID_button
            // 
            SearchByStudentID_button.BackgroundImage = Properties.Resources.search_FILL0_wght400_GRAD0_opsz48;
            SearchByStudentID_button.BackgroundImageLayout = ImageLayout.Stretch;
            SearchByStudentID_button.Dock = DockStyle.Fill;
            SearchByStudentID_button.Location = new Point(311, 8);
            SearchByStudentID_button.Margin = new Padding(3, 4, 3, 4);
            SearchByStudentID_button.Name = "SearchByStudentID_button";
            SearchByStudentID_button.Size = new Size(68, 40);
            SearchByStudentID_button.TabIndex = 2;
            SearchByStudentID_button.UseVisualStyleBackColor = true;
            SearchByStudentID_button.Click += SearchByStudentIS_button_Click;
            // 
            // SearchRollNode_textBox
            // 
            SearchRollNode_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            SearchRollNode_textBox.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            SearchRollNode_textBox.Dock = DockStyle.Fill;
            SearchRollNode_textBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SearchRollNode_textBox.ForeColor = Color.FromArgb(51, 51, 51);
            SearchRollNode_textBox.Location = new Point(158, 8);
            SearchRollNode_textBox.Margin = new Padding(3, 4, 3, 4);
            SearchRollNode_textBox.Name = "SearchRollNode_textBox";
            SearchRollNode_textBox.Size = new Size(147, 27);
            SearchRollNode_textBox.TabIndex = 1;
            SearchRollNode_textBox.KeyDown += SearchRollNode_textBox_KeyDown;
            // 
            // SearchRollNO_lable
            // 
            SearchRollNO_lable.AutoSize = true;
            SearchRollNO_lable.BackColor = Color.FromArgb(33, 44, 85);
            SearchRollNO_lable.Dock = DockStyle.Top;
            SearchRollNO_lable.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SearchRollNO_lable.ForeColor = Color.White;
            SearchRollNO_lable.Location = new Point(6, 4);
            SearchRollNO_lable.Name = "SearchRollNO_lable";
            SearchRollNO_lable.Size = new Size(146, 28);
            SearchRollNO_lable.TabIndex = 3;
            SearchRollNO_lable.Text = "Enter Roll NO.";
            SearchRollNO_lable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataRefresh_button
            // 
            DataRefresh_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DataRefresh_button.BackgroundImage = Properties.Resources.refresh_FILL0_wght300_GRAD200_opsz48;
            DataRefresh_button.BackgroundImageLayout = ImageLayout.Stretch;
            DataRefresh_button.Dock = DockStyle.Fill;
            DataRefresh_button.Location = new Point(400, 11);
            DataRefresh_button.Margin = new Padding(3, 4, 3, 4);
            DataRefresh_button.Name = "DataRefresh_button";
            DataRefresh_button.Size = new Size(43, 46);
            DataRefresh_button.TabIndex = 3;
            DataRefresh_button.UseVisualStyleBackColor = true;
            DataRefresh_button.Click += DataRefresh_button_Click;
            // 
            // ShowAllData_CMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 44, 85);
            ClientSize = new Size(1217, 749);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowAllData_CMS";
            Padding = new Padding(5, 5, 5, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowAllData CMS";
            Load += ShowAllData_CMS_Load;
            ((System.ComponentModel.ISupportInitialize)ShowAllData_dataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ShowAllData_dataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox SearchRollNode_textBox;
        private Button SearchByStudentID_button;
        private Label SearchRollNO_lable;
        private Button DataRefresh_button;
    }
}