using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management
{
    public partial class manageBlood_Participant : Form
    {
        public manageBlood_Participant()
        {
            InitializeComponent();
        }

        private void manageBlood_Participant_Load(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseConnection.Instance.getConnection();
            connection.Open();
            String query = "select bp.participant_id N'ID', bp.participant_name N'Họ và tên', bp.participant_age N'Tuổi', bp.participant_address N'Địa chỉ', bp.participant_phone N'Số điện thoại', bp.participant_email N'Email', bp.participant_blood_type N'Nhóm máu' from blood_participant as bp";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Tuổi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Họ và tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Địa chỉ"].Width = 130;
            dataGridView1.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Số điện thoại"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Nhóm máu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns["Tuổi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Số điện thoại"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            connection.Close();

            comboBox1.Items.Add("A Rh(D)+");
            comboBox1.Items.Add("B Rh(D)+");
            comboBox1.Items.Add("AB Rh(D)+");
            comboBox1.Items.Add("O Rh(D)+");
            comboBox1.Items.Add("A Rh(D)-");
            comboBox1.Items.Add("B Rh(D)-");
            comboBox1.Items.Add("AB Rh(D)-");
            comboBox1.Items.Add("O Rh(D)-");

            comboBox2.Items.Add("A Rh(D)+");
            comboBox2.Items.Add("B Rh(D)+");
            comboBox2.Items.Add("AB Rh(D)+");
            comboBox2.Items.Add("O Rh(D)+");
            comboBox2.Items.Add("A Rh(D)-");
            comboBox2.Items.Add("B Rh(D)-");
            comboBox2.Items.Add("AB Rh(D)-");
            comboBox2.Items.Add("O Rh(D)-");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                id_tb.Text = selectedRow.Cells["ID"].Value.ToString();
                name_tb.Text = selectedRow.Cells["Họ và tên"].Value.ToString();
                age_tb.Text = selectedRow.Cells["Tuổi"].Value.ToString();
                address_tb.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                phone_tb.Text = selectedRow.Cells["Số điện thoại"].Value.ToString();
                email_tb.Text = selectedRow.Cells["Email"].Value.ToString();
                comboBox2.Text = selectedRow.Cells["Nhóm máu"].Value.ToString();
            }
        }
    }
}
