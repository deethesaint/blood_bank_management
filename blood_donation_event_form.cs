using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Blood_Bank_Management
{
    public partial class blood_donation_event_form : Form
    {
        public blood_donation_event_form()
        {
            InitializeComponent();
            CenterToScreen();
            this.dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void db_Load(String query)
        {
            SqlConnection connection = DatabaseConnection.Instance.getConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["ID"].Width = 55;
                dataGridView1.Columns["Tên sự kiện"].Width = 190;
                dataGridView1.Columns["Ngày bắt đầu"].Width = 75;
                dataGridView1.Columns["Ngày kết thúc"].Width = 75;

                dataGridView1.Columns["Ngày bắt đầu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Ngày kết thúc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! Có lỗi đã xảy ra, hãy kiểm tra lại kết nối cơ sở dữ liệu!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }   
        }

        private void db_LoadOnParticipant(String query)
        {
            SqlConnection connection = DatabaseConnection.Instance.getConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;

                dataGridView2.Columns["ID"].Width = 55;
                dataGridView2.Columns["Họ và tên"].Width = 230;
                dataGridView2.Columns["Ngày tham gia"].Width = 100;
                dataGridView2.Columns["ID Hồ sơ hiến máu tham gia"].Width = 90;

                dataGridView2.Columns["Ngày tham gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! Có lỗi đã xảy ra, hãy kiểm tra lại kết nối cơ sở dữ liệu!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String query = "select bp.participant_id N'ID',\r\nbp.participant_name N'Họ và tên',\r\nbe_bp.participated_date N'Ngày tham gia',\r\ndr.record_id N'ID Hồ sơ hiến máu tham gia'\r\nfrom blood_participant bp\r\njoin blood_event_blood_participant be_bp on be_bp.participant_id = bp.participant_id\r\njoin blood_event be on be_bp.blood_event_id = be.blood_event_id\r\njoin donation_record dr on dr.record_date = be_bp.participated_date";
            String where_inner = " where be.blood_event_id = " + "'" + dataGridView1.CurrentRow.Cells["ID"].Value.ToString() + "'";
            query += where_inner;
            db_LoadOnParticipant(query);
        }

        private void blood_donation_event_form_Load(object sender, EventArgs e)
        {
            String query = "select be.blood_event_id N'ID',\r\nbe.blood_event_name N'Tên sự kiện',\r\nbe.blood_event_date_begin N'Ngày bắt đầu',\r\nbe.blood_event_date_end N'Ngày kết thúc' from blood_event as be";
            db_Load(query);
        }
    }
}
