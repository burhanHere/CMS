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
    public partial class EditStudentInfo : Form
    {
        readonly SoundPlayer SoundPlayer_Obj = new(@"off-hook-tone-43891-Trimed.wav");
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");
        public EditStudentInfo()
        {
            InitializeComponent();
        }

        private void ErrorLable_label_Click(object sender, EventArgs e)
        {

        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterStudentID_textBox.Text))
            {
                ErrorLable_label.Text = "Enter studentID!";
                ErrorLable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else if (string.IsNullOrWhiteSpace(EnterStudentName_textBox.Text))
            {
                ErrorLable_label.Text = "Enter New Student Name!";
                ErrorLable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                MySqlCommand command = new("SELECT count(*) FROM Students WHERE StudentID=@StudentID;", connection);
                command.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                connection.Close();
                connection.Open();
                if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                {
                    connection.Close();
                    ErrorLable_label.Text = "studentID does not exist!";
                    ErrorLable_label.Visible = true;
                    SoundPlayer_Obj.Play();
                }
                else
                {
                    ErrorLable_label.Visible = false;
                    MySqlCommand command1 = new("UPDATE Students SET StudentName=@StudentName where StudentID=@StudentID;", this.connection);
                    command1.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                    command1.Parameters.AddWithValue("@StudentName", EnterStudentName_textBox.Text);
                    this.connection.Close();
                    this.connection.Open();
                    command1.ExecuteNonQuery();
                    this.connection.Close();
                    EnterStudentID_textBox.ResetText();
                    EnterStudentName_textBox.ResetText();
                    MessageBox.Show("Editing successful...", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
