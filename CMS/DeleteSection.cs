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
    public partial class DeleteSection : Form
    {
        readonly SoundPlayer SoundPlayer_Obj = new(@"off-hook-tone-43891-Trimed.wav");
        readonly MySqlConnection connection = new("Server=127.0.0.1;Port=3306;Database=CMS_DP_Project;Uid=root;Pwd=;");
        void LoadSelectSectionName_ComboBox()
        {
            using MySqlCommand command = new("SELECT SectionName FROM Sections;", this.connection);
            this.connection.Close();
            this.connection.Open();
            using MySqlDataAdapter adapter = new(command);
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            SelectSection_comboBox.DataSource = dataTable;
            SelectSection_comboBox.DisplayMember = "SectionName";
            SelectSection_comboBox.ValueMember = "SectionName";
            SelectSection_comboBox.SelectedIndex = -1;
            this.connection.Close();
        }

        public DeleteSection()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if (SelectSection_comboBox.SelectedIndex == -1)
            {
                ErrorlableSelectSection_label.Visible = true;
                SoundPlayer_Obj.Play();
            }
            else
            {
                ErrorlableSelectSection_label.Visible = false;
                DialogResult result = MessageBox.Show("Are you sure you want to proceed!!!\n\nNOTE:After deleting this section, you need to reassign the section to the students who were previously enrolled in it.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    using MySqlCommand command1 = new("UPDATE DivideInto SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@SectionName", SelectSection_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command1.ExecuteNonQuery();
                    this.connection.Close();
                    using MySqlCommand command2 = new("UPDATE Assignments SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    command2.Parameters.Clear();
                    command2.Parameters.AddWithValue("@SectionName", SelectSection_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command2.ExecuteNonQuery();
                    this.connection.Close();
                    using MySqlCommand command3 = new("UPDATE Quizes SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    command3.Parameters.Clear();
                    command3.Parameters.AddWithValue("@SectionName", SelectSection_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command3.ExecuteNonQuery();
                    this.connection.Close();
                    using MySqlCommand command4 = new("UPDATE Mids SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    command4.Parameters.Clear();
                    command4.Parameters.AddWithValue("@SectionName", SelectSection_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command4.ExecuteNonQuery();
                    this.connection.Close();
                    using MySqlCommand command5 = new("UPDATE Final SET SectionName=NULL WHERE SectionName=@SectionName;", connection);
                    command5.Parameters.Clear();
                    command5.Parameters.AddWithValue("@SectionName", SelectSection_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command5.ExecuteNonQuery();
                    this.connection.Close();
                    using MySqlCommand command6 = new("DELETE FROM Sections WHERE SectionName =@SectionName;", connection);
                    command6.Parameters.AddWithValue("@SectionName", SelectSection_comboBox.SelectedValue);
                    this.connection.Close();
                    this.connection.Open();
                    command6.ExecuteNonQuery();
                    this.connection.Close();
                    SelectSection_comboBox.SelectedIndex = -1;
                    MessageBox.Show("Section deletion successful...", "Operation Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadSelectSectionName_ComboBox();
                }
            }
        }

        private void DeleteSection_Load(object sender, EventArgs e)
        {
            this.LoadSelectSectionName_ComboBox();
        }
    }
}
