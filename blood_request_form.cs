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
    public partial class blood_request_form : Form
    {
        private String where = String.Empty;
        public blood_request_form()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public blood_request_form(String where)
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

            dataGridView1.Columns["ID"].Width = 140;
            dataGridView1.Columns["Tên người yêu cầu"].Width = 140;
            dataGridView1.Columns["Lượng máu yêu cầu"].Width = 140;
            dataGridView1.Columns["Ngày yêu cầu"].Width = 140;
            dataGridView1.Columns["Tình trạng"].Width = 140;

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];

            dataGridView1.Columns["Tình trạng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Ngày yêu cầu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Lượng máu yêu cầu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void blood_request_form_Load(object sender, EventArgs e)
        {
            String query = "select br.blood_request_id N'ID',\r\nbp.participant_name N'Tên người yêu cầu',\r\nbr.blood_request_quantity N'Lượng máu yêu cầu',\r\nbr.blood_request_date N'Ngày yêu cầu',\r\nbr.blood_request_approval N'Tình trạng' from blood_request br\r\njoin blood_participant bp on bp.participant_id = br.participant_id";
            query += where;
            db_Load(query);
        }
    }
}
