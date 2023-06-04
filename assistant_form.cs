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
    public partial class assistant_form : Form
    {
        String where = String.Empty;
        public assistant_form()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

            dataGridView1.Columns["Tuổi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void assistant_form_Load(object sender, EventArgs e)
        {
            String query = "select ast.assistant_id N'ID',\r\nast.assistant_name N'Họ và tên',\r\nast.assistant_age N'Tuổi',\r\nast.assistant_address N'Địa chỉ'\r\nfrom assistant as ast";
            query += where;
            db_Load(query);
        }
    }
}
