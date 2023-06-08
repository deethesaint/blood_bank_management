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
            this.dataGridView1.CellClick += dataGridView1_CellClick;
        }

        public blood_test_form(String where)
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.dataGridView1.CellClick += dataGridView1_CellClick;
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

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];

            dataGridView1.Columns["Ngày xét nghiệm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void execute_db(String query)
        {
            SqlConnection connection = DatabaseConnection.Instance.getConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! Có lỗi đã xảy ra, hãy kiểm tra lại kết nối cơ sở dữ liệu!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            String queryReload = "select bt.record_id N'ID', ast.assistant_name N'KTV Xét nghiệm', bt.blood_test_date N'Ngày xét nghiệm',\r\nbt.blood_test_result N'Kết quả xét nghiệm' from blood_test as bt\r\n" +
                "join assistant ast on ast.assistant_id = bt.assistant_id";
            db_Load(queryReload);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                id_tb.Text = selectedRow.Cells["ID"].Value.ToString();
                ktv_tb.Text = selectedRow.Cells["KTV Xét nghiệm"].Value.ToString();
                date_tb.Text = selectedRow.Cells["Ngày xét nghiệm"].Value.ToString();
                res_rtb.Text = selectedRow.Cells["Kết quả xét nghiệm"].Value.ToString();
            }    
        }

        private void blood_test_form_Load(object sender, EventArgs e)
        {
            String query = "select bt.record_id N'ID', ast.assistant_name N'KTV Xét nghiệm', bt.blood_test_date N'Ngày xét nghiệm',\r\nbt.blood_test_result N'Kết quả xét nghiệm' from blood_test as bt\r\n" +
                "join assistant ast on ast.assistant_id = bt.assistant_id";
            query += where;
            db_Load(query);
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            String query = "delete blood_test where record_id = '" + id_tb.Text.ToString() + "'";
            execute_db(query);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            del_btn.Enabled = false;
            confirm_btn.Visible = true;
            cancel_btn.Visible = true;
            res_rtb.Enabled = true;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            del_btn.Enabled = true;
            confirm_btn.Visible = false;
            cancel_btn.Visible = false;
            res_rtb.Enabled = false;
            String query = "update blood_test set blood_test_result = N'" + res_rtb.Text.ToString() + "' where record_id = '" + id_tb.Text.ToString() + "'";
            execute_db(query);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            del_btn.Enabled = true;
            confirm_btn.Visible = false;
            cancel_btn.Visible = false;
            res_rtb.Enabled = false;
        }
    }
}
