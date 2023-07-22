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
using System.Transactions;
using System.Windows.Forms;

namespace CMS
{
    public partial class DeleteStudent : Form
    {
        readonly SoundPlayer SoundPlayer_Obj = new(@"off-hook-tone-43891-Trimed.wav");
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");

        void loadStudentIDInSuggestion()
        {
            using MySqlCommand command = new("SELECT StudentID FROM Students;", connection);
            connection.Close();
            connection.Open();
            using MySqlDataAdapter adapter = new(command);
            DataTable datatabe = new();
            adapter.Fill(datatabe);
            connection.Close();
            EnterStudentID_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            EnterStudentID_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autoCompleteStringCollection = new();
            foreach (DataRow row in datatabe.Rows)
            {
                autoCompleteStringCollection.Add(row["StudentID"].ToString());
            }
            EnterStudentID_textBox.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            this.loadStudentIDInSuggestion();
        }
        private void Next_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterStudentID_textBox.Text))
            {
                ErrorLable_label.Text = "Enter a StudentID!";
                ErrorLable_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                MySqlCommand command = new("SELECT count(*) FROM students WHERE studentid=@studentid;", connection);
                command.Parameters.AddWithValue("@studentid", EnterStudentID_textBox.Text);
                connection.Close();
                connection.Open();
                if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                {
                    ErrorLable_label.Text = "StudentID does not exist!";
                    ErrorLable_label.Visible = true;
                    SoundPlayer_Obj.Play();
                }
                else
                {
                    ErrorLable_label.Visible = false;
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student with studentID of :" + EnterStudentID_textBox.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        MySqlCommand command_DeleteAssignments = new("DELETE FROM assignments WHERE StudentID = @StudentID;", connection);
                        command_DeleteAssignments.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        connection.Close();
                        connection.Open();
                        command_DeleteAssignments.ExecuteNonQuery();
                        connection.Close();

                        MySqlCommand command_DeleteQuizes = new("DELETE FROM quizes WHERE StudentID = @StudentID;", connection);
                        command_DeleteQuizes.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        connection.Close();
                        connection.Open();
                        command_DeleteQuizes.ExecuteNonQuery();
                        connection.Close();

                        MySqlCommand command_DeleteMids = new("DELETE FROM mids WHERE StudentID = @StudentID;", connection);
                        command_DeleteMids.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        connection.Close();
                        connection.Open();
                        command_DeleteMids.ExecuteNonQuery();
                        connection.Close();

                        MySqlCommand command_DeleteFinal = new("DELETE FROM final WHERE StudentID = @StudentID;", connection);
                        command_DeleteFinal.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        connection.Close();
                        connection.Open();
                        command_DeleteFinal.ExecuteNonQuery();
                        connection.Close();

                        MySqlCommand command_DeleteDivideInto = new("DELETE FROM DivideInto WHERE StudentID = @StudentID;", connection);
                        command_DeleteDivideInto.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        connection.Close();
                        connection.Open();
                        command_DeleteDivideInto.ExecuteNonQuery();
                        connection.Close();

                        MySqlCommand command_DeleteStudents = new("DELETE FROM Students WHERE StudentID = @StudentID;", connection);
                        command_DeleteStudents.Parameters.AddWithValue("@StudentID", EnterStudentID_textBox.Text);
                        connection.Close();
                        connection.Open();
                        command_DeleteStudents.ExecuteNonQuery();
                        connection.Close();

                        EnterStudentID_textBox.ResetText();
                        this.loadStudentIDInSuggestion();
                    }
                }
            }
        }
    }
}
