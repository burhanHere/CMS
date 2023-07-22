namespace CMS
{
    partial class EditStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentInfo));
            EnterStudentID_textBox = new TextBox();
            ErrorLable_label = new Label();
            Next_button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            EnterNewStudentName_label = new Label();
            SelectStudnetID_label = new Label();
            panel2 = new Panel();
            EnterStudentName_textBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // EnterStudentID_textBox
            // 
            EnterStudentID_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            EnterStudentID_textBox.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            EnterStudentID_textBox.Dock = DockStyle.Fill;
            EnterStudentID_textBox.Location = new Point(8, 29);
            EnterStudentID_textBox.Name = "EnterStudentID_textBox";
            EnterStudentID_textBox.Size = new Size(468, 23);
            EnterStudentID_textBox.TabIndex = 1;
            // 
            // ErrorLable_label
            // 
            ErrorLable_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ErrorLable_label.AutoSize = true;
            ErrorLable_label.BackColor = Color.FromArgb(255, 193, 7);
            ErrorLable_label.ForeColor = Color.Black;
            ErrorLable_label.Location = new Point(8, 38);
            ErrorLable_label.Name = "ErrorLable_label";
            ErrorLable_label.Size = new Size(101, 15);
            ErrorLable_label.TabIndex = 2;
            ErrorLable_label.Text = "Enter a StudentID!";
            ErrorLable_label.Visible = false;
            ErrorLable_label.Click += ErrorLable_label_Click;
            // 
            // Next_button
            // 
            Next_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Next_button.BackgroundImage = Properties.Resources.arrow_forward_FILL0_wght300_GRAD200_opsz48;
            Next_button.BackgroundImageLayout = ImageLayout.Stretch;
            Next_button.Location = new Point(410, 3);
            Next_button.Name = "Next_button";
            Next_button.Size = new Size(50, 50);
            Next_button.TabIndex = 3;
            Next_button.UseVisualStyleBackColor = true;
            Next_button.Click += Next_button_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(33, 44, 85);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(EnterStudentID_textBox, 0, 1);
            tableLayoutPanel1.Controls.Add(EnterNewStudentName_label, 0, 2);
            tableLayoutPanel1.Controls.Add(SelectStudnetID_label, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 4);
            tableLayoutPanel1.Controls.Add(EnterStudentName_textBox, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(484, 173);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // EnterNewStudentName_label
            // 
            EnterNewStudentName_label.AutoSize = true;
            EnterNewStudentName_label.BackColor = Color.FromArgb(192, 207, 250);
            EnterNewStudentName_label.Dock = DockStyle.Fill;
            EnterNewStudentName_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EnterNewStudentName_label.Location = new Point(8, 55);
            EnterNewStudentName_label.Name = "EnterNewStudentName_label";
            EnterNewStudentName_label.Size = new Size(468, 21);
            EnterNewStudentName_label.TabIndex = 2;
            EnterNewStudentName_label.Text = "Enter New Student Name";
            EnterNewStudentName_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectStudnetID_label
            // 
            SelectStudnetID_label.AutoSize = true;
            SelectStudnetID_label.BackColor = Color.FromArgb(192, 207, 250);
            SelectStudnetID_label.Dock = DockStyle.Fill;
            SelectStudnetID_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectStudnetID_label.Location = new Point(8, 5);
            SelectStudnetID_label.Name = "SelectStudnetID_label";
            SelectStudnetID_label.Size = new Size(468, 21);
            SelectStudnetID_label.TabIndex = 0;
            SelectStudnetID_label.Text = "Enter StudentID";
            SelectStudnetID_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 207, 250);
            panel2.Controls.Add(Next_button);
            panel2.Controls.Add(ErrorLable_label);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(8, 108);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(468, 58);
            panel2.TabIndex = 3;
            // 
            // EnterStudentName_textBox
            // 
            EnterStudentName_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            EnterStudentName_textBox.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            EnterStudentName_textBox.Dock = DockStyle.Fill;
            EnterStudentName_textBox.Location = new Point(8, 79);
            EnterStudentName_textBox.Name = "EnterStudentName_textBox";
            EnterStudentName_textBox.Size = new Size(468, 23);
            EnterStudentName_textBox.TabIndex = 2;
            // 
            // EditStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 44, 85);
            ClientSize = new Size(484, 173);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditStudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Student Info";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox EnterStudentID_textBox;
        private Label ErrorLable_label;
        private Button Next_button;
        private TableLayoutPanel tableLayoutPanel1;
        private Label EnterNewStudentName_label;
        private Label SelectStudnetID_label;
        private Panel panel2;
        private TextBox EnterStudentName_textBox;
    }
}