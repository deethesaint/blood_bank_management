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
            this.dataGridView1.CellClick += dataGridView1_CellClick;

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

            state_cb.Items.Add("Được chấp nhận");
            state_cb.Items.Add("Chưa được chấp nhận");
        }

        public blood_request_form(String where)
        {
            InitializeComponent();
            CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.where = where;
            this.dataGridView1.CellClick += dataGridView1_CellClick;

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

            state_cb.Items.Add("Được chấp nhận");
            state_cb.Items.Add("Chưa được chấp nhận");
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

                dataGridView1.Columns["ID"].Width = 120;
                dataGridView1.Columns["Tên người yêu cầu"].Width = 120;
                dataGridView1.Columns["Nhóm máu"].Width = 100;
                dataGridView1.Columns["Lượng máu yêu cầu"].Width = 120;
                dataGridView1.Columns["Ngày yêu cầu"].Width = 120;
                dataGridView1.Columns["Tình trạng"].Width = 120;

                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];

                dataGridView1.Columns["Tình trạng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Ngày yêu cầu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Lượng máu yêu cầu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! Có lỗi đã xảy ra, hãy kiểm tra dữ liệu nhập vào!\nThông báo lỗi cụ thể: - " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            
            
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
                MessageBox.Show("Oops! Có lỗi đã xảy ra, hãy kiểm tra dữ liệu nhập vào!\nThông báo lỗi cụ thể: - " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            String queryReload = "select br.blood_request_id N'ID',\r\nbp.participant_name N'Tên người yêu cầu',\r\nbp.participant_blood_type N'Nhóm máu',\r\nbr.blood_request_quantity N'Lượng máu yêu cầu',\r\nbr.blood_request_date N'Ngày yêu cầu',\r\nbr.blood_request_approval N'Tình trạng' from blood_request br\r\njoin blood_participant bp on bp.participant_id = br.participant_id";
            db_Load(queryReload);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                id_tb.Text = selectedRow.Cells["ID"].Value.ToString();
                name_tb.Text = selectedRow.Cells["Tên người yêu cầu"].Value.ToString();
                quan_tb.Text = selectedRow.Cells["Lượng máu yêu cầu"].Value.ToString();
                date_tb.Text = selectedRow.Cells["Ngày yêu cầu"].Value.ToString();
                bool state = Convert.ToBoolean(selectedRow.Cells["Tình trạng"].Value);
                if (state)
                    state_cb.Text = "Được chấp nhận";
                else
                    state_cb.Text = "Chưa được chấp nhận";
                comboBox2.Text = selectedRow.Cells["Nhóm máu"].Value.ToString();
            }
        }

        private void blood_request_form_Load(object sender, EventArgs e)
        {
            String query = "select br.blood_request_id N'ID',\r\nbp.participant_name N'Tên người yêu cầu',\r\nbp.participant_blood_type N'Nhóm máu',\r\nbr.blood_request_quantity N'Lượng máu yêu cầu',\r\nbr.blood_request_date N'Ngày yêu cầu',\r\nbr.blood_request_approval N'Tình trạng' from blood_request br\r\njoin blood_participant bp on bp.participant_id = br.participant_id";
            query += where;
            db_Load(query);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            confirm_btn.Visible = true;
            cancel_btn.Visible = true;
            del_btn.Enabled = false;
            blood_par_ref.Enabled = false;
            state_cb.Enabled = true;
            quan_tb.Enabled = true;
            dataGridView1.Enabled = false;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            confirm_btn.Visible = false;
            cancel_btn.Visible = false;
            del_btn.Enabled = true;
            blood_par_ref.Enabled = true;
            state_cb.Enabled = false;
            quan_tb.Enabled = false;
            dataGridView1.Enabled = true;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            confirm_btn.Visible = false;
            cancel_btn.Visible = false;
            del_btn.Enabled = true;
            blood_par_ref.Enabled = true;
            state_cb.Enabled = false;
            quan_tb.Enabled = false;
            dataGridView1.Enabled = true;
            int apprval = 0;
            if (state_cb.Text.ToString() == "Được chấp nhận")
                apprval = 1;
            String query = "update blood_request set blood_request_quantity = " + quan_tb.Text.ToString() +
                ", blood_request_approval = " + apprval.ToString() + " where blood_request_id = '" + id_tb.Text.ToString() + "'";
            execute_db(query);
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            String query = "delete blood_request where blood_request_id = '" + id_tb.Text.ToString() + "'";
            execute_db(query);
        }
    }
}
