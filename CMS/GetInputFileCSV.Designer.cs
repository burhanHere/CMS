namespace CMS
{
    partial class GetInputFileCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetInputFileCSV));
            SelectSection_comboBox = new ComboBox();
            SelectCourse_label = new Label();
            SelectCourse_comboBox = new ComboBox();
            panel1 = new Panel();
            ErrorLable_label = new Label();
            Next_button = new Button();
            SelectSection_label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectSection_comboBox
            // 
            SelectSection_comboBox.Dock = DockStyle.Fill;
            SelectSection_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectSection_comboBox.FormattingEnabled = true;
            SelectSection_comboBox.Location = new Point(8, 82);
            SelectSection_comboBox.Name = "SelectSection_comboBox";
            SelectSection_comboBox.Size = new Size(268, 28);
            SelectSection_comboBox.TabIndex = 2;
            // 
            // SelectCourse_label
            // 
            SelectCourse_label.AutoSize = true;
            SelectCourse_label.BackColor = Color.White;
            SelectCourse_label.Dock = DockStyle.Fill;
            SelectCourse_label.ForeColor = Color.FromArgb(51, 51, 51);
            SelectCourse_label.Location = new Point(8, 5);
            SelectCourse_label.Name = "SelectCourse_label";
            SelectCourse_label.Size = new Size(268, 20);
            SelectCourse_label.TabIndex = 0;
            SelectCourse_label.Text = "Select Course";
            SelectCourse_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectCourse_comboBox
            // 
            SelectCourse_comboBox.Dock = DockStyle.Fill;
            SelectCourse_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectCourse_comboBox.FormattingEnabled = true;
            SelectCourse_comboBox.Location = new Point(8, 28);
            SelectCourse_comboBox.Name = "SelectCourse_comboBox";
            SelectCourse_comboBox.Size = new Size(268, 28);
            SelectCourse_comboBox.TabIndex = 1;
            SelectCourse_comboBox.SelectedIndexChanged += SelectCourse_comboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 207, 250);
            panel1.Controls.Add(ErrorLable_label);
            panel1.Controls.Add(Next_button);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 38);
            panel1.TabIndex = 4;
            // 
            // ErrorLable_label
            // 
            ErrorLable_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ErrorLable_label.AutoSize = true;
            ErrorLable_label.BackColor = Color.FromArgb(255, 193, 7);
            ErrorLable_label.ForeColor = Color.Black;
            ErrorLable_label.Location = new Point(6, 11);
            ErrorLable_label.Name = "ErrorLable_label";
            ErrorLable_label.Size = new Size(102, 20);
            ErrorLable_label.TabIndex = 4;
            ErrorLable_label.Text = "Select Course!";
            ErrorLable_label.Visible = false;
            // 
            // Next_button
            // 
            Next_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Next_button.BackgroundImage = Properties.Resources.arrow_forward_FILL0_wght300_GRAD200_opsz48;
            Next_button.BackgroundImageLayout = ImageLayout.Stretch;
            Next_button.Location = new Point(230, 3);
            Next_button.Name = "Next_button";
            Next_button.Size = new Size(34, 31);
            Next_button.TabIndex = 3;
            Next_button.UseVisualStyleBackColor = true;
            Next_button.Click += Next_button_Click;
            // 
            // SelectSection_label
            // 
            SelectSection_label.AutoSize = true;
            SelectSection_label.BackColor = Color.White;
            SelectSection_label.Dock = DockStyle.Fill;
            SelectSection_label.ForeColor = Color.FromArgb(51, 51, 51);
            SelectSection_label.Location = new Point(8, 59);
            SelectSection_label.Name = "SelectSection_label";
            SelectSection_label.Size = new Size(268, 20);
            SelectSection_label.TabIndex = 2;
            SelectSection_label.Text = "Select Section";
            SelectSection_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(33, 44, 85);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(SelectSection_comboBox, 0, 3);
            tableLayoutPanel1.Controls.Add(SelectCourse_label, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectCourse_comboBox, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 4);
            tableLayoutPanel1.Controls.Add(SelectSection_label, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(284, 162);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // GetInputFileCSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 162);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GetInputFileCSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Get Input File.CSV";
            Load += GetInputFileCSV_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox SelectSection_comboBox;
        private Label SelectCourse_label;
        private ComboBox SelectCourse_comboBox;
        private Panel panel1;
        private Label ErrorLable_label;
        private Button Next_button;
        private Label SelectSection_label;
        private TableLayoutPanel tableLayoutPanel1;
    }
}