using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class ShowAllData_CMS : Form
    {
        private const string V = "";
        public static string StudentID = V;
        public static string StudentName = V;
        public static string CourseName = V;
        public static string SectionName = V;
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");
        DataTable loadGridView()
        {
            DataTable dataTable = new();
            this.connection.Close();
            this.connection.Open();
            using MySqlCommand command = new("SELECT S.* ,Sec.Coursename,D.SectionName FROM students S Left JOIN divideinto D ON  S.studentid=D.studentid Left JOIN sections Sec ON Sec.sectionName=D.sectionName;", this.connection);
            using MySqlDataAdapter adapter = new(command);
            adapter.Fill(dataTable);
            ShowAllData_dataGridView.DataSource = dataTable;
            ShowAllData_dataGridView.AutoGenerateColumns = false;
            ShowAllData_dataGridView.ReadOnly = true;
            connection.Close();
            Color color = Color.FromArgb(255, 193, 7);
            for (int row = 0; row < ShowAllData_dataGridView.Rows.Count; row++)
            {
                for (int column = 0; column < ShowAllData_dataGridView.Columns.Count; column++)
                {
                    DataGridViewCell cell = ShowAllData_dataGridView.Rows[row].Cells[column];
                    if (cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        cell.Style.BackColor = color;
                    }
                }
            }
            return dataTable;
        }
        public ShowAllData_CMS()
        {
            InitializeComponent();
        }

        private void ShowAllData_CMS_Load(object sender, EventArgs e)
        {
            DataTable datatabe = this.loadGridView();
            SearchRollNode_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            SearchRollNode_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autoCompleteStringCollection = new();
            foreach (DataRow row in datatabe.Rows)
            {
                autoCompleteStringCollection.Add(row["StudentID"].ToString());
            }
            SearchRollNode_textBox.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void ShowAllData_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ShowAllData_dataGridView.Rows[e.RowIndex];
                StudentID = row.Cells["StudentID"].Value.ToString();
                StudentName = row.Cells["StudentName"].Value.ToString();
                CourseName = row.Cells["CourseName"].Value.ToString();
                SectionName = row.Cells["SectionName"].Value.ToString();
                ReportCard reportCard = new();
                reportCard.Show();
            }
        }

        private void DataRefresh_button_Click(object sender, EventArgs e)
        {
            this.loadGridView();
            SearchRollNode_textBox.ResetText();
        }

        private void SearchByStudentIS_button_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new();
            this.connection.Close();
            this.connection.Open();
            using MySqlCommand command = new("SELECT S.* ,Sec.Coursename,D.SectionName FROM students S Left JOIN divideinto D ON  S.studentid=D.studentid Left JOIN sections Sec ON Sec.sectionName=D.sectionName WHERE S.StudentID=@StudentID;", this.connection);
            command.Parameters.AddWithValue("@StudentID", SearchRollNode_textBox.Text);
            using MySqlDataAdapter adapter = new(command);
            adapter.Fill(dataTable);
            ShowAllData_dataGridView.DataSource = dataTable;
            ShowAllData_dataGridView.AutoGenerateColumns = false;
            ShowAllData_dataGridView.ReadOnly = true;
            connection.Close();
            Color color = Color.FromArgb(255, 193, 7);
            for (int row = 0; row < ShowAllData_dataGridView.Rows.Count; row++)
            {
                for (int column = 0; column < ShowAllData_dataGridView.Columns.Count; column++)
                {
                    DataGridViewCell cell = ShowAllData_dataGridView.Rows[row].Cells[column];
                    if (cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        cell.Style.BackColor = color;
                    }
                }
            }
        }

        private void SearchRollNode_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SearchByStudentIS_button_Click(sender, e);
            }
        }
    }
}
