namespace CMS
{
    partial class DeleteCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCourse));
            SelectCourseName_label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ErrorlableSelectCourse_label = new Label();
            SelectCourse_comboBox = new ComboBox();
            Next_button = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectCourseName_label
            // 
            SelectCourseName_label.AutoSize = true;
            SelectCourseName_label.BackColor = Color.FromArgb(192, 207, 250);
            SelectCourseName_label.Dock = DockStyle.Fill;
            SelectCourseName_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SelectCourseName_label.Location = new Point(8, 5);
            SelectCourseName_label.Name = "SelectCourseName_label";
            SelectCourseName_label.Size = new Size(268, 21);
            SelectCourseName_label.TabIndex = 0;
            SelectCourseName_label.Text = "Select Course Name";
            SelectCourseName_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(33, 44, 85);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(SelectCourseName_label, 0, 0);
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
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 207, 250);
            panel1.Controls.Add(ErrorlableSelectCourse_label);
            panel1.Controls.Add(SelectCourse_comboBox);
            panel1.Controls.Add(Next_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 29);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(268, 124);
            panel1.TabIndex = 1;
            // 
            // ErrorlableSelectCourse_label
            // 
            ErrorlableSelectCourse_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ErrorlableSelectCourse_label.AutoSize = true;
            ErrorlableSelectCourse_label.BackColor = Color.FromArgb(255, 193, 7);
            ErrorlableSelectCourse_label.ForeColor = Color.Black;
            ErrorlableSelectCourse_label.Location = new Point(8, 100);
            ErrorlableSelectCourse_label.Name = "ErrorlableSelectCourse_label";
            ErrorlableSelectCourse_label.Size = new Size(88, 15);
            ErrorlableSelectCourse_label.TabIndex = 2;
            ErrorlableSelectCourse_label.Text = "Select a course!";
            ErrorlableSelectCourse_label.Visible = false;
            // 
            // SelectCourse_comboBox
            // 
            SelectCourse_comboBox.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            SelectCourse_comboBox.Cursor = Cursors.Hand;
            SelectCourse_comboBox.Dock = DockStyle.Top;
            SelectCourse_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectCourse_comboBox.FormattingEnabled = true;
            SelectCourse_comboBox.Location = new Point(5, 5);
            SelectCourse_comboBox.Name = "SelectCourse_comboBox";
            SelectCourse_comboBox.Size = new Size(258, 23);
            SelectCourse_comboBox.TabIndex = 1;
            // 
            // Next_button
            // 
            Next_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Next_button.BackgroundImage = Properties.Resources.arrow_forward_FILL0_wght300_GRAD200_opsz48;
            Next_button.BackgroundImageLayout = ImageLayout.Stretch;
            Next_button.Location = new Point(209, 65);
            Next_button.Name = "Next_button";
            Next_button.Size = new Size(50, 50);
            Next_button.TabIndex = 2;
            Next_button.UseVisualStyleBackColor = true;
            Next_button.Click += Next_button_Click;
            // 
            // DeleteCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Course";
            Load += DeleteCourse_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SelectCourseName_label;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button Next_button;
        private ComboBox SelectCourse_comboBox;
        private Label ErrorlableSelectCourse_label;
    }
}