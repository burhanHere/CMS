namespace CMS
{
    partial class DeleteStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudent));
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectStudnetID_label = new Label();
            panel1 = new Panel();
            EnterStudentID_textBox = new TextBox();
            ErrorLable_label = new Label();
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
            tableLayoutPanel1.Controls.Add(SelectStudnetID_label, 0, 0);
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
            tableLayoutPanel1.TabIndex = 3;
            // 
            // SelectStudnetID_label
            // 
            SelectStudnetID_label.AutoSize = true;
            SelectStudnetID_label.BackColor = Color.FromArgb(192, 207, 250);
            SelectStudnetID_label.Dock = DockStyle.Fill;
            SelectStudnetID_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectStudnetID_label.Location = new Point(8, 5);
            SelectStudnetID_label.Name = "SelectStudnetID_label";
            SelectStudnetID_label.Size = new Size(268, 21);
            SelectStudnetID_label.TabIndex = 0;
            SelectStudnetID_label.Text = "Enter StudentID";
            SelectStudnetID_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 207, 250);
            panel1.Controls.Add(EnterStudentID_textBox);
            panel1.Controls.Add(ErrorLable_label);
            panel1.Controls.Add(Next_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 29);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(268, 124);
            panel1.TabIndex = 1;
            // 
            // EnterStudentID_textBox
            // 
            EnterStudentID_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            EnterStudentID_textBox.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            EnterStudentID_textBox.Dock = DockStyle.Top;
            EnterStudentID_textBox.Location = new Point(5, 5);
            EnterStudentID_textBox.Name = "EnterStudentID_textBox";
            EnterStudentID_textBox.Size = new Size(258, 23);
            EnterStudentID_textBox.TabIndex = 1;
            // 
            // ErrorLable_label
            // 
            ErrorLable_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ErrorLable_label.AutoSize = true;
            ErrorLable_label.BackColor = Color.FromArgb(255, 193, 7);
            ErrorLable_label.ForeColor = Color.Black;
            ErrorLable_label.Location = new Point(8, 104);
            ErrorLable_label.Name = "ErrorLable_label";
            ErrorLable_label.Size = new Size(101, 15);
            ErrorLable_label.TabIndex = 2;
            ErrorLable_label.Text = "Enter a StudentID!";
            ErrorLable_label.Visible = false;
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
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Student";
            Load += DeleteStudent_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label SelectStudnetID_label;
        private Panel panel1;
        private Label ErrorLable_label;
        private Button Next_button;
        private TextBox EnterStudentID_textBox;
    }
}