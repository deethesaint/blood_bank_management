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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blood_Bank_Management
{
    public partial class assistant_form : Form
    {
        String where = String.Empty;
        public assistant_form()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.dataGridView1.CellClick += dataGridView1_CellClick;
        }

        public assistant_form(String where)
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.where = where;
        }

        private void db_Load(String query)
        {
            SqlConnection connection = DatabaseConnection.Instance.getConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["ID"].Width = 175;
            dataGridView1.Columns["Họ và tên"].Width = 175;
            dataGridView1.Columns["Tuổi"].Width = 175;
            dataGridView1.Columns["Địa chỉ"].Width = 175;

            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            id_tb.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            name_tb.Text = dataGridView1.CurrentRow.Cells["Họ và tên"].Value.ToString();
            age_tb.Text = dataGridView1.CurrentRow.Cells["Tuổi"].Value.ToString();
            address_tb.Text = dataGridView1.CurrentRow.Cells["Địa chỉ"].Value.ToString();

            dataGridView1.Columns["Tuổi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            }
        }

        private void assistant_form_Load(object sender, EventArgs e)
        {
            String query = "select ast.assistant_id N'ID',\r\nast.assistant_name N'Họ và tên',\r\nast.assistant_age N'Tuổi',\r\nast.assistant_address N'Địa chỉ'\r\nfrom assistant as ast";
            query += where;
            db_Load(query);
        }

        private void blood_test_ref_Click(object sender, EventArgs e)
        {
            String where = " where ast.assistant_id = '" + id_tb.Text.ToString() + "'";
            blood_test_form blood_Test_Form = new blood_test_form(where);
            blood_Test_Form.ShowDialog();
        }
    }
}
