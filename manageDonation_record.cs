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
    public partial class manageDonation_record : Form
    {
        String where = String.Empty;

        public manageDonation_record()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public manageDonation_record(String where)
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.where = where;
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
                dataGridView1.Columns["ID"].Width = 60;
                dataGridView1.Columns["ID Người hiến"].Width = 60;
                dataGridView1.Columns["Tên người hiến"].Width = 130;
                dataGridView1.Columns["Nhóm máu"].Width = 85;
                dataGridView1.Columns["Ngày hiến"].Width = 115;
                dataGridView1.Columns["Thể tích"].Width = 60;
                dataGridView1.Columns["Nhân viên"].Width = 130;
                dataGridView1.Columns["Tình trạng"].Width = 65;
                dataGridView1.Columns["Ngày hiến"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Thể tích"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

        private void manageDonation_record_Load(object sender, EventArgs e)
        {
            String query = "select dr.record_id N'ID', dr.participant_id N'ID Người hiến', bp.participant_name N'Tên người hiến',\r\n\t   dr.blood_type N'Nhóm máu', dr.record_date N'Ngày hiến', dr.record_blood_quantity N'Thể tích',\r\n\t   ast.assistant_name N'Nhân viên', dr.blood_record_approval N'Tình trạng'\r\nfrom donation_record dr\r\njoin blood_participant bp on dr.participant_id = bp.participant_id\r\njoin assistant ast on ast.assistant_id = dr.assistant_id";
            query += where;
            db_Load(query);
        }
    }
}
