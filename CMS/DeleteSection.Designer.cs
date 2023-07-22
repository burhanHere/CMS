namespace CMS
{
    partial class DeleteSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteSection));
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectSectionName_label = new Label();
            panel1 = new Panel();
            ErrorlableSelectSection_label = new Label();
            SelectSection_comboBox = new ComboBox();
            Next_button = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(33, 44, 85);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(SelectSectionName_label, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(284, 161);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // SelectSectionName_label
            // 
            SelectSectionName_label.AutoSize = true;
            SelectSectionName_label.BackColor = Color.FromArgb(192, 207, 250);
            SelectSectionName_label.Dock = DockStyle.Fill;
            SelectSectionName_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectSectionName_label.Location = new Point(8, 5);
            SelectSectionName_label.Name = "SelectSectionName_label";
            SelectSectionName_label.Size = new Size(268, 21);
            SelectSectionName_label.TabIndex = 0;
            SelectSectionName_label.Text = "Select Section Name";
            SelectSectionName_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 207, 250);
            panel1.Controls.Add(ErrorlableSelectSection_label);
            panel1.Controls.Add(SelectSection_comboBox);
            panel1.Controls.Add(Next_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 29);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(268, 124);
            panel1.TabIndex = 1;
            // 
            // ErrorlableSelectSection_label
            // 
            ErrorlableSelectSection_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ErrorlableSelectSection_label.AutoSize = true;
            ErrorlableSelectSection_label.BackColor = Color.FromArgb(255, 193, 7);
            ErrorlableSelectSection_label.ForeColor = Color.Black;
            ErrorlableSelectSection_label.Location = new Point(8, 104);
            ErrorlableSelectSection_label.Name = "ErrorlableSelectSection_label";
            ErrorlableSelectSection_label.Size = new Size(91, 15);
            ErrorlableSelectSection_label.TabIndex = 2;
            ErrorlableSelectSection_label.Text = "Select a section!";
            ErrorlableSelectSection_label.Visible = false;
            // 
            // SelectSection_comboBox
            // 
            SelectSection_comboBox.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            SelectSection_comboBox.Cursor = Cursors.Hand;
            SelectSection_comboBox.Dock = DockStyle.Top;
            SelectSection_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectSection_comboBox.FormattingEnabled = true;
            SelectSection_comboBox.Location = new Point(5, 5);
            SelectSection_comboBox.Name = "SelectSection_comboBox";
            SelectSection_comboBox.Size = new Size(258, 23);
            SelectSection_comboBox.TabIndex = 1;
            // 
            // Next_button
            // 
            Next_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Next_button.BackgroundImage = Properties.Resources.arrow_forward_FILL0_wght300_GRAD200_opsz48;
            Next_button.BackgroundImageLayout = ImageLayout.Stretch;
            Next_button.Location = new Point(213, 69);
            Next_button.Name = "Next_button";
            Next_button.Size = new Size(50, 50);
            Next_button.TabIndex = 2;
            Next_button.UseVisualStyleBackColor = true;
            Next_button.Click += Next_button_Click;
            // 
            // DeleteSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteSection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Section";
            Load += DeleteSection_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label SelectSectionName_label;
        private Panel panel1;
        private Label ErrorlableSelectSection_label;
        private ComboBox SelectSection_comboBox;
        private Button Next_button;
    }
}