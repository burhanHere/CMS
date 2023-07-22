using MySql.Data.MySqlClient;
using System.Data;
using System.Media;
using System.Text.RegularExpressions;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace CMS
{
    public partial class CMS_AddMarks_Form : Form
    {
        readonly SoundPlayer SoundPlayer_Obj = new(@"off-hook-tone-43891-Trimed.wav");
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");
        public void ResetAddMarksPanel()
        {
            FilePath_textBox.ResetText();
            AssesmentType_comboBox.SelectedIndex = -1;
            SelectCourse_comboBox.SelectedIndex = -1;
            SelectSection_comboBox.SelectedIndex = -1;
            TotalMarks_numericUpDown.Value = 0; ;
        }
        public void ResetAddStudentPanel()
        {
            EnterStudentID_textBox.ResetText();
            NewEnrollment_checkBox.Checked = false;
            EnterStudentFullName_textBox.ResetText();
            AddStudentSelectCourse_comboBox.SelectedIndex = -1;
            AddStudentSelectSection_comboBox.SelectedIndex = -1;
        }
        public void ResetAddSectionPanel()
        {
            EnterSectionName_textBox.ResetText();
            SelectCourseForTheSection_comboBox.SelectedIndex = -1;
        }
        public void ResetAddCoursePanel()
        {
            EnterCourseName_textBox.ResetText();
            AssignmentWeightage_numericUpDown.Value = 0; ;
            AddAssignmentWeightage_checkBox.Checked = false;
            QuizWeightage_numericUpDown.Value = 0; ;
            AddQuizWeightage_checkBox.Checked = false;
            MidWeightage_numericUpDown.Value = 0; ;
            AddmidsWeightage_checkBox.Checked = false;
            FinalWeightage_numericUpDown.Value = 0; ;
            AddFinalWeightage_checkBox.Checked = false;
        }
        public CMS_AddMarks_Form()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilePath_textBox_Click(object sender, EventArgs e)
        {
            if (FilePath_textBox.Text == "Enter a valid file path here...")
            {
                FilePath_textBox.ForeColor = Color.Black;
                FilePath_textBox.ResetText();
            }
        }

        private void Go_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FilePath_textBox.Text) || FilePath_textBox.Text == "Enter a valid file path here..." || !File.Exists(FilePath_textBox.Text))
            {
                AddMarksDisable_label.Text = "Enter a valid file path!";
                AddMarksDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (AssesmentType_comboBox.SelectedIndex == -1)
            {
                AddMarksDisable_label.Text = "Not a valid assesment type!";
                AddMarksDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (SelectCourse_comboBox.SelectedIndex == -1)
            {
                AddMarksDisable_label.Text = "Select a Course!";
                AddMarksDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (SelectSection_comboBox.SelectedIndex == -1)
            {
                AddMarksDisable_label.Text = "Select a Section!";
                AddMarksDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (TotalMarks_numericUpDown.Value == 0)
            {
                AddMarksDisable_label.Text = "Total marks cannot be 0!";
                AddMarksDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                AddMarksDisable_label.Visible = false;
                DataTable dataTable = new();
                using (TextFieldParser parser = new(FilePath_textBox.Text))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    bool isFirstRow = true;
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        if (isFirstRow)
                        {
                            for (int i = 0; i < fields.Length; i++)
                            {
                                dataTable.Columns.Add("Column" + (i + 1));
                            }
                            isFirstRow = false;
                        }
                        dataTable.Rows.Add(fields);
                    }
                }
                string insertMarksQuery = "INSERT INTO @AssesmentTypeTable(DateCommenced, TotalMarks, ObtainedMarks, SectionName, StudentID) VALUES (@DateCommenced, @TotalMarks, @ObtainedMarks, @SectionName, @StudentID)";
                string assesmentType = AssesmentType_comboBox.SelectedItem.ToString() ?? string.Empty;
                insertMarksQuery = insertMarksQuery.Replace("@AssesmentTypeTable", assesmentType);
                MySqlCommand command = new(insertMarksQuery, this.connection);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@DateCommenced", DateCommenced_dateTimePicker.Value);
                    command.Parameters.AddWithValue("@TotalMarks", TotalMarks_numericUpDown.Value);
                    command.Parameters.AddWithValue("@SectionName", SelectSection_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@ObtainedMarks", dataTable.Rows[i][2]);
                    command.Parameters.AddWithValue("@StudentID", dataTable.Rows[i][0]);
                    this.connection.Close();
                    this.connection.Open();
                    command.ExecuteNonQuery();
                    this.connection.Close();
                }
                MessageBox.Show("Marks Added Successfully...", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetAddMarksPanel();
            }
        }

        private void UploadFile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog_obj = new()
            {
                Filter = "CSV Files|*.csv"
            };
            if (OpenFileDialog_obj.ShowDialog() == DialogResult.OK)
            {
                FilePath_textBox.ResetText();
                FilePath_textBox.ForeColor = Color.Black;
                FilePath_textBox.Text = OpenFileDialog_obj.FileName;
            }
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_CMS About_CMS_Form = new();
            About_CMS_Form.Show();
        }

        private void ShowAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResetAddMarksPanel();
            AddMarks_panel.Enabled = false;
            AddMarksDisable_label.Text = "Disabled";
            AddMarksDisable_label.Visible = true;
            this.ResetAddStudentPanel();
            AddStudent_panel.Enabled = false;
            AddStudentDisable_label.Text = "Disabled";
            AddStudentDisable_label.Visible = true;
            this.ResetAddSectionPanel();
            AddSection_panel.Enabled = false;
            AddSectionDisable_label.Text = "Disabled";
            AddSectionDisable_label.Visible = true;
            this.ResetAddCoursePanel();
            AddCourse_panel.Enabled = false;
            AddCourseDisable_label.Text = "Disabled";
            AddCourseDisable_label.Visible = true;
            this.connection.Close();
            ShowAllData_CMS ShowAllData_CMS_Form = new();
            ShowAllData_CMS_Form.Show();
        }

        private void AddMarks_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse_panel.Enabled = false;
            AddCourseDisable_label.Text = "Disabled";
            AddCourseDisable_label.Visible = true;
            AddSection_panel.Enabled = false;
            AddSectionDisable_label.Text = "Disabled";
            AddSectionDisable_label.Visible = true;
            AddStudent_panel.Enabled = false;
            AddStudentDisable_label.Text = "Disabled";
            AddStudentDisable_label.Visible = true;
            AddMarks_panel.Enabled = true;
            AddMarksDisable_label.Visible = false;
            this.ResetAddStudentPanel();
            this.ResetAddSectionPanel();
            this.ResetAddCoursePanel();
            using MySqlCommand command = new("SELECT DISTINCT CourseName FROM Sections;", this.connection);
            this.connection.Close();
            this.connection.Open();
            using MySqlDataAdapter adapter = new(command);
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            SelectCourse_comboBox.DataSource = dataTable;
            SelectCourse_comboBox.DisplayMember = "CourseName";
            SelectCourse_comboBox.ValueMember = "CourseName";
            SelectCourse_comboBox.SelectedIndex = -1;
            this.connection.Close();
        }

        private void SelectCourse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using MySqlCommand command2 = new("SELECT SectionName FROM Sections WHERE     CourseName = @CourseName;", this.connection);
            command2.Parameters.AddWithValue("@CourseName", SelectCourse_comboBox.SelectedValue);
            this.connection.Close();
            this.connection.Open();
            using MySqlDataAdapter adapter = new(command2);
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            SelectSection_comboBox.DataSource = dataTable;
            SelectSection_comboBox.DisplayMember = "SectionName";
            SelectSection_comboBox.ValueMember = "SectionName";
            SelectSection_comboBox.SelectedIndex = -1;
            this.connection.Close();
        }

        private void AddSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMarks_panel.Enabled = false;
            AddMarksDisable_label.Text = "Disabled";
            AddMarksDisable_label.Visible = true;
            AddCourse_panel.Enabled = false;
            AddCourseDisable_label.Text = "Disabled";
            AddCourseDisable_label.Visible = true;
            AddStudent_panel.Enabled = false;
            AddStudentDisable_label.Text = "Disabled";
            AddStudentDisable_label.Visible = true;
            AddSection_panel.Enabled = true;
            AddSectionDisable_label.Visible = false;
            this.ResetAddMarksPanel();
            this.ResetAddStudentPanel();
            this.ResetAddCoursePanel();
            using MySqlCommand command = new("SELECT CourseName FROM Courses;", this.connection);
            this.connection.Close();
            this.connection.Open();
            using MySqlDataAdapter adapter = new(command);
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            SelectCourseForTheSection_comboBox.DataSource = dataTable;
            SelectCourseForTheSection_comboBox.DisplayMember = "CourseName";
            SelectCourseForTheSection_comboBox.ValueMember = "CourseName";
            SelectCourseForTheSection_comboBox.SelectedIndex = -1;
            this.connection.Close();
        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMarks_panel.Enabled = false;
            AddMarksDisable_label.Text = "Disabled";
            AddMarksDisable_label.Visible = true;
            AddCourse_panel.Enabled = false;
            AddCourseDisable_label.Text = "Disabled";
            AddCourseDisable_label.Visible = true;
            AddSection_panel.Enabled = false;
            AddSectionDisable_label.Text = "Disabled";
            AddSectionDisable_label.Visible = true;
            AddStudent_panel.Enabled = true;
            AddStudentDisable_label.Text = "Disabled";
            AddStudentDisable_label.Visible = false;
            this.ResetAddMarksPanel();
            this.ResetAddSectionPanel();
            this.ResetAddCoursePanel();
            using MySqlCommand command = new("SELECT DISTINCT CourseName FROM Sections;", this.connection);
            this.connection.Close();
            this.connection.Open();
            using MySqlDataAdapter adapter = new(command);
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            this.connection.Close();
            AddStudentSelectCourse_comboBox.DataSource = dataTable;
            AddStudentSelectCourse_comboBox.DisplayMember = "CourseName";
            AddStudentSelectCourse_comboBox.ValueMember = "CourseName";
            AddStudentSelectCourse_comboBox.SelectedIndex = -1;
        }

        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMarks_panel.Enabled = false;
            AddMarksDisable_label.Text = "Disabled";
            AddMarksDisable_label.Visible = true;
            AddSection_panel.Enabled = false;
            AddSectionDisable_label.Text = "Disabled";
            AddSectionDisable_label.Visible = true;
            AddStudent_panel.Enabled = false;
            AddStudentDisable_label.Text = "Disabled";
            AddStudentDisable_label.Visible = true;
            AddCourse_panel.Text = "Disabled";
            AddCourse_panel.Enabled = true;
            AddCourseDisable_label.Visible = false;
            this.ResetAddMarksPanel();
            this.ResetAddStudentPanel();
            this.ResetAddSectionPanel();
        }
        private void AddAssignmentWeightage_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddAssignmentWeightage_checkBox.Checked)
            {
                AssignmentWeightage_numericUpDown.Enabled = true;
            }
            else
            {
                AssignmentWeightage_numericUpDown.Enabled = false;
            }
        }

        private void AddQuizWeightage_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddQuizWeightage_checkBox.Checked)
            {
                QuizWeightage_numericUpDown.Enabled = true;
            }
            else
            {
                QuizWeightage_numericUpDown.Enabled = false;
            }
        }

        private void AddmidsWeightage_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddmidsWeightage_checkBox.Checked)
            {
                MidWeightage_numericUpDown.Enabled = true;
            }
            else
            {
                MidWeightage_numericUpDown.Enabled = false;
            }
        }

        private void AddFinalWeightage_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddFinalWeightage_checkBox.Checked)
            {
                FinalWeightage_numericUpDown.Enabled = true;
            }
            else
            {
                FinalWeightage_numericUpDown.Enabled = false;
            }
        }

        private void EnterSectionName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void AddSectionGO_button_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EnterSectionName_textBox.Text, @"^[A-Z]\d+$"))
            {
                AddSectionDisable_label.Text = "Invalid section name!\nAdd Section name like 'A1','A12', etc...";
                AddSectionDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (SelectCourseForTheSection_comboBox.SelectedIndex == -1)
            {
                AddSectionDisable_label.Text = "Select a course for this section!";
                AddSectionDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                AddSectionDisable_label.Visible = false;
                using MySqlCommand command = new("SELECT COUNT(SectionName) FROM Sections WHERE SectionName = @SectionName;", this.connection);
                command.Parameters.AddWithValue("@SectionName", EnterSectionName_textBox.Text);
                this.connection.Close();
                this.connection.Open();
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    this.connection.Close();
                    AddSectionDisable_label.Text = "Section already exists!\nTry some other name.";
                    AddSectionDisable_label.Visible = true;
                    SoundPlayer_Obj.Play();
                }
                else
                {
                    using MySqlCommand command1 = new("INSERT INTO Sections(SectionName,CourseName) VALUE(@SectionName,@CourseName);", this.connection);
                    command1.Parameters.AddWithValue("@SectionName", EnterSectionName_textBox.Text);
                    command1.Parameters.AddWithValue("@CourseName", SelectCourseForTheSection_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command1.ExecuteNonQuery();
                    this.connection.Close();
                    MessageBox.Show("New Section Added...", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetAddSectionPanel();
                }
                this.connection.Close();
            }
        }

        private void AddStudentSelectCourse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using MySqlCommand command2 = new("SELECT SectionName FROM Sections WHERE CourseName = @CourseName;", this.connection);
            command2.Parameters.AddWithValue("@CourseName", AddStudentSelectCourse_comboBox.SelectedValue);
            this.connection.Close();
            this.connection.Open();
            using MySqlDataAdapter adapter = new(command2);
            this.connection.Close();
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            AddStudentSelectSection_comboBox.DataSource = dataTable;
            AddStudentSelectSection_comboBox.DisplayMember = "SectionName";
            AddStudentSelectSection_comboBox.ValueMember = "SectionName";
            AddStudentSelectSection_comboBox.SelectedIndex = -1;
        }

        private void AddStudentGo_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterStudentID_textBox.Text))
            {
                AddStudentDisable_label.Text = "Enter a valid StudentID!";
                AddStudentDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (NewEnrollment_checkBox.Checked && string.IsNullOrWhiteSpace(EnterStudentFullName_textBox.Text))
            {
                AddStudentDisable_label.Text = "Enter name of the student being enrolled!";
                AddStudentDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (AddStudentSelectCourse_comboBox.SelectedIndex == -1)
            {
                AddStudentDisable_label.Text = "Select a course in which the student wants to enroll!";
                AddStudentDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (AddStudentSelectSection_comboBox.SelectedIndex == -1)
            {
                AddStudentDisable_label.Text = "Select a Section of this course!";
                AddStudentDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                AddStudentDisable_label.Visible = false;
                if (NewEnrollment_checkBox.Checked)
                {
                    using MySqlCommand command = new("SELECT COUNT(*) FROM Students WHERE StudentID=@StudentID;", this.connection);
                    command.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                    this.connection.Close();
                    this.connection.Open();
                    if (Convert.ToInt64(command.ExecuteScalar()) != 0)
                    {
                        this.connection.Close();
                        AddStudentDisable_label.Text = "StudentID already exists!";
                        AddStudentDisable_label.Visible = true;
                        SoundPlayer_Obj.Play();
                    }
                    else
                    {
                        using MySqlCommand command2 = new("INSERT INTO Students(StudentID, StudentName) VALUE (@StudentID, @StudentName);", this.connection);
                        command2.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        command2.Parameters.AddWithValue("@StudentName", EnterStudentFullName_textBox.Text);
                        this.connection.Close();
                        this.connection.Open();
                        command2.ExecuteNonQuery();
                        this.connection.Close();
                        using MySqlCommand command3 = new("INSERT INTO DivideInto (StudentID, SectionName) VALUE (@StudentID, @SectionName);", this.connection);
                        command3.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        command3.Parameters.AddWithValue("@SectionName", AddStudentSelectSection_comboBox.SelectedValue);
                        this.connection.Close();
                        this.connection.Open();
                        command3.ExecuteNonQuery();
                        this.connection.Close();
                        MessageBox.Show("New Student added and enrolled to the course...", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ResetAddStudentPanel();
                    }
                }
                else
                {
                    using MySqlCommand command1 = new("SELECT COUNT(*) FROM Students WHERE StudentID=@StudentID;", this.connection);
                    command1.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                    this.connection.Close();
                    this.connection.Open();
                    if (Convert.ToInt64(command1.ExecuteScalar()) == 0)
                    {
                        this.connection.Close();
                        AddStudentDisable_label.Text = "StudentID does not exist!";
                        AddStudentDisable_label.Visible = true;
                        SoundPlayer_Obj.Play();
                    }
                    else
                    {
                        using MySqlCommand command = new("select count(*) from students S inner join divideinto D on S.Studentid=d.studentid inner join sections Sec on sec.sectionName=D.sectionName where sec.courseName=@courseName AND S.Studentid=@Studentid;", this.connection);
                        command.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        command.Parameters.AddWithValue("@courseName", AddStudentSelectCourse_comboBox.SelectedValue);
                        this.connection.Close();
                        this.connection.Open();
                        if (Convert.ToInt64(command.ExecuteScalar()) != 0)
                        {
                            this.connection.Close();
                            AddStudentDisable_label.Text = "Student is already enrolled in this course!";
                            AddStudentDisable_label.Visible = true;
                            SoundPlayer_Obj.Play();
                        }
                        else
                        {
                            using MySqlCommand command3 = new("INSERT INTO DivideInto (StudentID, SectionName) VALUE (@StudentID, @SectionName);", this.connection);
                            command3.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                            command3.Parameters.AddWithValue("@SectionName", AddStudentSelectSection_comboBox.SelectedValue);
                            this.connection.Close();
                            this.connection.Open();
                            command3.ExecuteNonQuery();
                            this.connection.Close();
                            MessageBox.Show("New Student enrolled to the course...", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ResetAddStudentPanel();
                        }
                    }
                }
            }
        }

        private void NewEnrollment_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NewEnrollment_checkBox.Checked)
            {
                EnterStudentFullName_textBox.Enabled = true;
            }
            else
            {
                EnterStudentFullName_textBox.Enabled = false;
            }
        }

        private void AddCourseGO_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterCourseName_textBox.Text))
            {
                AddCourseDisable_label.Text = "Enter a valid Course Name!";
                AddCourseDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if ((AddAssignmentWeightage_checkBox.Checked && AssignmentWeightage_numericUpDown.Value == 0) || (AddQuizWeightage_checkBox.Checked && QuizWeightage_numericUpDown.Value == 0) || (AddmidsWeightage_checkBox.Checked && MidWeightage_numericUpDown.Value == 0) || (AddFinalWeightage_checkBox.Checked &&
                FinalWeightage_numericUpDown.Value == 0))
            {
                AddCourseDisable_label.Text = "Selected Weightages can not be 0!";
                AddCourseDisable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                using MySqlCommand command = new("SELECT COUNT(CourseName) FROM Courses WHERE CourseName = @CourseName;", this.connection);
                command.Parameters.AddWithValue("@CourseName", EnterCourseName_textBox.Text);
                this.connection.Close();
                this.connection.Open();
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    this.connection.Close();
                    AddSectionDisable_label.Text = "Course already exists!\nTry some other name.";
                    AddSectionDisable_label.Visible = true;
                    SoundPlayer_Obj.Play();
                }
                else if (AssignmentWeightage_numericUpDown.Value + QuizWeightage_numericUpDown.Value + MidWeightage_numericUpDown.Value + FinalWeightage_numericUpDown.Value != 100)
                {
                    AddCourseDisable_label.Text = "Selected weightages dont sum is not equilent to 100!\n Total weightage can onky be 100. \nTotal weightage =Assignment+Quiz+Mids+Final=100";
                    AddCourseDisable_label.Visible = true;
                    SoundPlayer_Obj.Play();
                }
                else
                {
                    AddCourseDisable_label.Visible = false;
                    using MySqlCommand command1 = new("INSERT INTO Courses(CourseName, AssignmentWeightage, QuizWeightage, MidWeightage, FinalWeightage) VALUE(@CourseName, @AssignmentWeightage, @QuizWeightage, @MidWeightage, @FinalWeightage)", this.connection);
                    command1.Parameters.AddWithValue("@CourseName", EnterCourseName_textBox.Text);
                    command1.Parameters.AddWithValue("@AssignmentWeightage", AssignmentWeightage_numericUpDown.Value);
                    command1.Parameters.AddWithValue("@QuizWeightage", QuizWeightage_numericUpDown.Value);
                    command1.Parameters.AddWithValue("@MidWeightage", MidWeightage_numericUpDown.Value);
                    command1.Parameters.AddWithValue("@FinalWeightage", FinalWeightage_numericUpDown.Value);
                    this.connection.Close();
                    this.connection.Open();
                    command1.ExecuteNonQuery();
                    this.connection.Close();
                    MessageBox.Show("New course added...", "Operation Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ResetAddCoursePanel();
                }
            }
        }

        private void DeleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResetAddMarksPanel();
            AddMarks_panel.Enabled = false;
            AddMarksDisable_label.Text = "Disabled";
            AddMarksDisable_label.Visible = true;
            this.ResetAddStudentPanel();
            AddStudent_panel.Enabled = false;
            AddStudentDisable_label.Text = "Disabled";
            AddStudentDisable_label.Visible = true;
            this.ResetAddSectionPanel();
            AddSection_panel.Enabled = false;
            AddSectionDisable_label.Text = "Disabled";
            AddSectionDisable_label.Visible = true;
            this.ResetAddCoursePanel();
            AddCourse_panel.Enabled = false;
            AddCourseDisable_label.Text = "Disabled";
            AddCourseDisable_label.Visible = true;
            this.connection.Close();
            DeleteCourse deleteCourse = new();
            deleteCourse.Show();
        }

        private void deleteSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSection deleteSection = new();
            deleteSection.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new();
            deleteStudent.Show();
        }

        private void UpdateStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudentInfo editStudentInfo = new();
            editStudentInfo.Show();
        }
        private void getInputFileCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetInputFileCSV getInputFileCSV = new();
            getInputFileCSV.Show();
        }
    }
}
