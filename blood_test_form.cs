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
    public partial class blood_test_form : Form
    {
        private String where = String.Empty;

        public blood_test_form()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public blood_test_form(String where)
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
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! Có lỗi đã xảy ra, hãy kiểm tra lại kết nối cơ sở dữ liệu!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            

            dataGridView1.Columns["ID"].Width = 175;
            dataGridView1.Columns["KTV Xét nghiệm"].Width = 175;
            dataGridView1.Columns["Ngày xét nghiệm"].Width = 175;
            dataGridView1.Columns["Kết quả xét nghiệm"].Width = 175;

            dataGridView1.Columns["Ngày xét nghiệm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void blood_test_form_Load(object sender, EventArgs e)
        {
            string query = "select bt.record_id N'ID', ast.assistant_name N'KTV Xét nghiệm', bt.blood_test_date N'Ngày xét nghiệm',\r\nbt.blood_test_result N'Kết quả xét nghiệm' from blood_test as bt\r\n" +
                "join assistant ast on ast.assistant_id = bt.assistant_id";
            query += where;
            db_Load(query);
        }
    }
}
