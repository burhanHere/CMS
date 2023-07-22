using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using System.Media;

namespace CMS
{
    public partial class DeleteCourse : Form
    {
        readonly SoundPlayer SoundPlayer_Obj = new(@"off-hook-tone-43891-Trimed.wav");
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");
        public DeleteCourse()
        {
            InitializeComponent();
        }
        void loadSelectCourseName_ComboBox()
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
        private void Next_button_Click(object sender, EventArgs e)
        {
            if (SelectCourse_comboBox.SelectedIndex == -1)
            {
                ErrorlableSelectCourse_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                ErrorlableSelectCourse_label.Visible = false;
                DialogResult result = MessageBox.Show("Are you sure you want to proceed!!!\n\nNOTE: By deleting this course, its corresponding sections and the students enrolled in those sections, all must be updated manually. However, there assesments will not be deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand command = new("SELECT SectionName FROM Sections WHERE CourseName = @CourseName;", connection);
                    command.Parameters.AddWithValue("@CourseName", SelectCourse_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    using MySqlDataAdapter adapter = new(command);
                    DataTable dataTable = new();
                    adapter.Fill(dataTable);
                    this.connection.Close();
                    StringBuilder sb = new();
                    using MySqlCommand command1 = new("UPDATE DivideInto SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    using MySqlCommand command2 = new("UPDATE Assignments SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    using MySqlCommand command3 = new("UPDATE Quizes SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    using MySqlCommand command4 = new("UPDATE Mids SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    using MySqlCommand command5 = new("UPDATE Final SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //command1
                        command1.Parameters.Clear();
                        command1.Parameters.AddWithValue("@SectionName", row[0].ToString());
                        this.connection.Close();
                        this.connection.Open();
                        command1.ExecuteNonQuery();
                        this.connection.Close();
                        //command2
                        command2.Parameters.Clear();
                        command2.Parameters.AddWithValue("@SectionName", row[0].ToString());
                        this.connection.Close();
                        this.connection.Open();
                        command2.ExecuteNonQuery();
                        this.connection.Close();
                        //command3
                        command3.Parameters.Clear();
                        command3.Parameters.AddWithValue("@SectionName", row[0].ToString());
                        this.connection.Close();
                        this.connection.Open();
                        command3.ExecuteNonQuery();
                        this.connection.Close();
                        //command4
                        command4.Parameters.Clear();
                        command4.Parameters.AddWithValue("@SectionName", row[0].ToString());
                        this.connection.Close();
                        this.connection.Open();
                        command4.ExecuteNonQuery();
                        this.connection.Close();
                        //command5
                        command5.Parameters.Clear();
                        command5.Parameters.AddWithValue("@SectionName", row[0].ToString());
                        this.connection.Close();
                        this.connection.Open();
                        command5.ExecuteNonQuery();
                        this.connection.Close();
                    }
                    using MySqlCommand command6 = new("DELETE FROM Sections WHERE CourseName =@CourseName;", connection);
                    command6.Parameters.AddWithValue("@CourseName", SelectCourse_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command6.ExecuteNonQuery();
                    this.connection.Close();

                    using MySqlCommand command7 = new("DELETE FROM Courses WHERE CourseName =@CourseName;", connection);
                    command7.Parameters.AddWithValue("@CourseName", SelectCourse_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command7.ExecuteNonQuery();
                    this.connection.Close();
                    SelectCourse_comboBox.SelectedIndex = -1;
                    MessageBox.Show("Course deletion successful...", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.loadSelectCourseName_ComboBox();
                }
            }
        }
        private void DeleteCourse_Load(object sender, EventArgs e)
        {
            this.loadSelectCourseName_ComboBox();
        }
    }
}
