using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class GetInputFileCSV : Form
    {
        readonly SoundPlayer SoundPlayer_Obj = new(@"off-hook-tone-43891-Trimed.wav");
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");
        public GetInputFileCSV()
        {
            InitializeComponent();
        }

        private void GetInputFileCSV_Load(object sender, EventArgs e)
        {
            using MySqlCommand command = new("SELECT CourseName FROM Courses;", this.connection);
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

        private void Next_button_Click(object sender, EventArgs e)
        {
            if (SelectCourse_comboBox.SelectedIndex == -1)
            {
                ErrorLable_label.Text = "Select a Course!";
                ErrorLable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (SelectSection_comboBox.SelectedIndex == -1)
            {
                ErrorLable_label.Text = "Select a Section!";
                ErrorLable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                ErrorLable_label.Visible = false;
                string filePath = "";
                OpenFileDialog OpenFileDialog_obj = new()
                {
                    Title = "Select a location",
                    CheckFileExists = false,
                    CheckPathExists = true,
                    FileName = "Select Folder",
                    Filter = "All Files (*.*)|*.*"
                };
                if (OpenFileDialog_obj.ShowDialog() == DialogResult.OK)
                {
                    filePath = OpenFileDialog_obj.FileName;
                    filePath = filePath.Replace("Select Folder", "");
                    filePath = filePath.Replace("\\", "/");
                    filePath = filePath + SelectCourse_comboBox.SelectedValue + "_" + SelectSection_comboBox.SelectedValue + ".CSV";
                    using MySqlCommand command = new("SELECT S.* INTO OUTFILE '" + filePath + "' FIELDS TERMINATED BY ',' ENCLOSED BY '\"' ESCAPED BY '\\\\' LINES TERMINATED BY '\\n' FROM Students S INNER JOIN DivideInto D ON D.studentid = S.studentID INNER JOIN Sections Sec ON Sec.sectionName = D.SectionName WHERE Sec.sectionName = @sectionName AND Sec.CourseName = @CourseName;", this.connection);
                    command.Parameters.AddWithValue("@sectionName", SelectSection_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@CourseName", SelectCourse_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        SelectCourse_comboBox.SelectedIndex = -1;
                        SelectSection_comboBox.SelectedIndex = -1;
                        MessageBox.Show("File downloaded sucessfully...", "Operation Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException)
                    {
                        ErrorLable_label.Text = "File already exists!";
                        ErrorLable_label.Visible = true;
                        SoundPlayer_Obj.Play();
                    }
                }
                this.connection.Close();
            }
        }
    }
}
