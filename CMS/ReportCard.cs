using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
namespace CMS
{
    public partial class ReportCard : Form
    {
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");
        public ReportCard()
        {
            InitializeComponent();
        }

        private void ReportCard_Load(object sender, EventArgs e)
        {
            StudentID2_label.Text = ShowAllData_CMS.StudentID;
            StudentName2_label.Text = ShowAllData_CMS.StudentName;
            Course2_label.Text = ShowAllData_CMS.CourseName;
            Section2_label.Text = ShowAllData_CMS.SectionName;

            this.Text = ShowAllData_CMS.StudentID;

            using MySqlCommand command_GetAssignments = new("SELECT AssignmentID,DateCommenced,TotalMarks,ObtainedMarks FROM Assignments WHERE sectionName=@SectionName AND studentID=@StudentID;", connection);
            command_GetAssignments.Parameters.AddWithValue("@SectionName", ShowAllData_CMS.SectionName);
            command_GetAssignments.Parameters.AddWithValue("@StudentID", ShowAllData_CMS.StudentID);
            connection.Close();
            connection.Open();
            using MySqlDataAdapter adapter_GetAssignemnts = new(command_GetAssignments);
            connection.Close();
            DataTable dataTable_Assignments = new();
            adapter_GetAssignemnts.Fill(dataTable_Assignments);
            Assignments_dataGridView.DataSource = dataTable_Assignments;
            double assignmentTotalSum = 0;
            double assignmentObtainedSum = 0;
            foreach (DataRow row in dataTable_Assignments.Rows)
            {
                assignmentTotalSum += Convert.ToDouble(row["TotalMarks"]);
                assignmentObtainedSum += Convert.ToDouble(row["ObtainedMarks"]);
            }
            MySqlCommand command_AssignmentWeightage = new("SELECT AssignmentWeightage FROM courses WHERE CourseName='DLD';\n", connection);
            connection.Close();
            connection.Open();
            double assignmentWeightage = Convert.ToDouble(command_AssignmentWeightage.ExecuteScalar());
            connection.Close();
            AssignmentTotal_label.Text = assignmentWeightage.ToString();
            AssignmentObtained_label.Text = (assignmentObtainedSum * assignmentWeightage / assignmentTotalSum).ToString("F" + 1);


            using MySqlCommand command_GetQuizes = new("select QuizID,DateCommenced,TotalMarks,ObtainedMarks FROM Quizes where sectionName=@SectionName AND studentID=@StudentID;", connection);
            command_GetQuizes.Parameters.AddWithValue("@SectionName", ShowAllData_CMS.SectionName);
            command_GetQuizes.Parameters.AddWithValue("@StudentID", ShowAllData_CMS.StudentID);
            connection.Close();
            connection.Open();
            using MySqlDataAdapter adapter_GetQuizes = new(command_GetQuizes);
            connection.Close();
            DataTable dataTable_Quizes = new();
            adapter_GetQuizes.Fill(dataTable_Quizes);
            Quizes_dataGridView.DataSource = dataTable_Quizes;
            double QuizesTotalSum = 0;
            double QuizesObtainedSum = 0;
            foreach (DataRow row in dataTable_Quizes.Rows)
            {
                QuizesTotalSum += Convert.ToDouble(row["TotalMarks"]);
                QuizesObtainedSum += Convert.ToDouble(row["ObtainedMarks"]);
            }
            MySqlCommand command_QuizWeightage = new("SELECT QuizWeightage FROM courses WHERE CourseName='DLD';\n", connection);
            connection.Close();
            connection.Open();
            double QuizWeightage = Convert.ToDouble(command_QuizWeightage.ExecuteScalar());
            connection.Close();
            QuizesTotal_label.Text = QuizWeightage.ToString();
            QuizesObtained_label.Text = (QuizesObtainedSum * QuizWeightage / QuizesTotalSum).ToString("F" + 1);

            using MySqlCommand command_GetMids = new("SELECT MidID,DateCommenced,TotalMarks,ObtainedMarks FROM Mids WHERE sectionName=@SectionName AND studentID=@StudentID;", connection);
            command_GetMids.Parameters.AddWithValue("@SectionName", ShowAllData_CMS.SectionName);
            command_GetMids.Parameters.AddWithValue("@StudentID", ShowAllData_CMS.StudentID);
            connection.Close();
            connection.Open();
            using MySqlDataAdapter adapter_GetMids = new(command_GetMids);
            connection.Close();
            DataTable dataTable_Mids = new();
            adapter_GetMids.Fill(dataTable_Mids);
            Mids_dataGridView.DataSource = dataTable_Mids;
            double MidsTotalSum = 0;
            double MidsObtainedSum = 0;
            foreach (DataRow row in dataTable_Mids.Rows)
            {
                MidsTotalSum += Convert.ToDouble(row["TotalMarks"]);
                MidsObtainedSum += Convert.ToDouble(row["ObtainedMarks"]);
            }
            MySqlCommand command_MidWeightage = new("SELECT MidWeightage FROM courses WHERE CourseName='DLD';\n", connection);
            connection.Close();
            connection.Open();
            double MidWeightage = Convert.ToDouble(command_MidWeightage.ExecuteScalar());
            connection.Close();
            MidsTotal_label.Text = MidWeightage.ToString();
            MidsObtained_label.Text = (MidsObtainedSum * MidWeightage / MidsTotalSum).ToString("F" + 1);

            using MySqlCommand command_GetFinal = new("SELECT FinalID,DateCommenced,TotalMarks,ObtainedMarks FROM Final WHERE sectionName=@SectionName AND studentID=@StudentID;", connection);
            command_GetFinal.Parameters.AddWithValue("@SectionName", ShowAllData_CMS.SectionName);
            command_GetFinal.Parameters.AddWithValue("@StudentID", ShowAllData_CMS.StudentID);
            connection.Close();
            connection.Open();
            using MySqlDataAdapter adapter_GetFinal = new(command_GetFinal);
            connection.Close();
            DataTable dataTable_Final = new();
            adapter_GetFinal.Fill(dataTable_Final);
            Final_dataGridView.DataSource = dataTable_Final;
            double FinalTotalSum = 0;
            double FinalObtainedSum = 0;
            foreach (DataRow row in dataTable_Final.Rows)
            {
                FinalTotalSum += Convert.ToDouble(row["TotalMarks"]);
                FinalObtainedSum += Convert.ToDouble(row["ObtainedMarks"]);
            }
            MySqlCommand command_FinalWeightage = new("SELECT FinalWeightage FROM courses WHERE CourseName='DLD';\n", connection);
            connection.Close();
            connection.Open();
            double FinalWeightage = Convert.ToDouble(command_FinalWeightage.ExecuteScalar());
            connection.Close();
            FinalTotal_label.Text = FinalWeightage.ToString();
            finalObtained_label.Text = (FinalObtainedSum * FinalWeightage / FinalTotalSum).ToString("F" + 1);

            double _finalObtained_label = 0;
            double _MidsObtained_label = 0;
            double _QuizesObtained_label = 0;
            double _AssignmentObtained_label = 0;
            if (!string.IsNullOrWhiteSpace(finalObtained_label.Text))
            {
                _finalObtained_label = Convert.ToDouble(finalObtained_label.Text);
            }
            if (!string.IsNullOrWhiteSpace(MidsObtained_label.Text))
            {
                _MidsObtained_label = Convert.ToDouble(MidsObtained_label.Text);
            }
            if (!string.IsNullOrWhiteSpace(finalObtained_label.Text))
            {
                _QuizesObtained_label = Convert.ToDouble(QuizesObtained_label.Text);
            }
            if (!string.IsNullOrWhiteSpace(finalObtained_label.Text))
            {
                _AssignmentObtained_label = Convert.ToDouble(AssignmentObtained_label.Text);
            }
            double TotalWeightage = _finalObtained_label + _MidsObtained_label + _QuizesObtained_label + _AssignmentObtained_label;

            if (TotalWeightage > 86)
            {
                Grade_label.Text = "A";
                GradePoint_label.Text = "4.0";
            }
            else if (TotalWeightage > 82)
            {
                Grade_label.Text = "A-";
                GradePoint_label.Text = "3.67";
            }
            else if (TotalWeightage > 78)
            {
                Grade_label.Text = "B+";
                GradePoint_label.Text = "3.33";
            }
            else if (TotalWeightage > 74)
            {
                Grade_label.Text = "B";
                GradePoint_label.Text = "3.0";
            }
            else if (TotalWeightage > 70)
            {
                Grade_label.Text = "B-";
                GradePoint_label.Text = "2.67";
            }
            else if (TotalWeightage > 66)
            {
                Grade_label.Text = "C+";
                GradePoint_label.Text = "2.33";
            }
            else if (TotalWeightage > 62)
            {
                Grade_label.Text = "C";
                GradePoint_label.Text = "2.0";
            }
            else if (TotalWeightage > 58)
            {
                Grade_label.Text = "C-";
                GradePoint_label.Text = "1.67";
            }
            else if (TotalWeightage > 54)
            {
                Grade_label.Text = "D+";
                GradePoint_label.Text = "1.33";
            }
            else if (TotalWeightage > 50)
            {
                Grade_label.Text = "D";
                GradePoint_label.Text = "1.0";
            }
            else
            {
                Grade_label.Text = "F";
                GradePoint_label.Text = "0";
            }
        }
    }
}
