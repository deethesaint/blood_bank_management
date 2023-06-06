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
        String where = String.Empty;

        int gb = 0;

        public manageBlood_Participant()
        {
            InitializeComponent();
            CenterToScreen();
            this.dataGridView1.CellClick += dataGridView1_CellClick;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        public manageBlood_Participant(String where)
        {
            InitializeComponent();
            CenterToScreen();
            this.dataGridView1.CellClick += dataGridView1_CellClick;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.where = where;
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
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["ID"].Width = 60;
                dataGridView1.Columns["Tuổi"].Width = 30;
                dataGridView1.Columns["Họ và tên"].Width = 100;
                dataGridView1.Columns["Địa chỉ"].Width = 190;
                dataGridView1.Columns["Số điện thoại"].Width = 90;
                dataGridView1.Columns["Email"].Width = 150;
                dataGridView1.Columns["Nhóm máu"].Width = 85;

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

        private void executeDB(String query)
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
        }

        private void manageBlood_Participant_Load(object sender, EventArgs e)
        {
            String query = "select bp.participant_id N'ID', bp.participant_name N'Họ và tên', bp.participant_age N'Tuổi', bp.participant_address N'Địa chỉ', bp.participant_phone N'Số điện thoại', bp.participant_email N'Email', bp.participant_blood_type N'Nhóm máu' from blood_participant as bp";
            query += where;
            db_Load(query);
            id_tb.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            name_tb.Text = dataGridView1.CurrentRow.Cells["Họ và tên"].Value.ToString();
            age_tb.Text = dataGridView1.CurrentRow.Cells["Tuổi"].Value.ToString();
            address_tb.Text = dataGridView1.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            phone_tb.Text = dataGridView1.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            email_tb.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["Nhóm máu"].Value.ToString();
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            String query = "select bp.participant_id N'ID', bp.participant_name N'Họ và tên', bp.participant_age N'Tuổi', bp.participant_address N'Địa chỉ', bp.participant_phone N'Số điện thoại', bp.participant_email N'Email', bp.participant_blood_type N'Nhóm máu' from blood_participant as bp";
            String where_inner = String.Empty;
            if (id_search.Text != String.Empty || name_search.Text != String.Empty || comboBox1.Text != String.Empty)
            {
                bool needAnd = false;
                where_inner += " where ";
                if (id_search.Text != String.Empty)
                {
                    where_inner += "bp.participant_id = '" + id_search.Text + "' ";
                    needAnd = true;
                }
                if (name_search.Text != String.Empty)
                {
                    if (needAnd) where_inner += "and ";
                    else needAnd = true;
                    where_inner += "bp.participant_name like N'%" + name_search.Text + "%' ";
                }
                if (comboBox1.Text != String.Empty)
                {
                    if (needAnd) where_inner += "and ";
                    where_inner += "bp.participant_blood_type = '" + comboBox1.Text + "' ";
                }
            }
            query += where_inner;
            db_Load(query);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String args_where = " where dr.participant_id = '" + dataGridView1.CurrentRow.Cells["ID"].Value.ToString() + "'";
            manageDonation_record manageDonation_Record = new manageDonation_record(args_where);
            manageDonation_Record.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String args_where = " where bp.participant_id = '" + dataGridView1.CurrentRow.Cells["ID"].Value.ToString() + "'";
            blood_request_form blood_Request_Form = new blood_request_form(args_where);
            blood_Request_Form.Show();
        }

        private void LockControls(GroupBox groupBox, bool state)
        {
            foreach(Control control in groupBox.Controls)
            {
                control.Enabled = state;
            }
        }

        private void ChangeState(bool state)
        {
            id_tb.Enabled = state;
            name_tb.Enabled = state;
            phone_tb.Enabled = state;
            email_tb.Enabled = state;
            address_tb.Enabled = state;
            age_tb.Enabled = state;
            comboBox2.Enabled = state;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            confirm_btn.Visible = true;
            cancel_btn.Visible = true;
            LockControls(groupBox1, false);
            ChangeState(true);
            id_tb.Enabled = false;
            gb = 1;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            confirm_btn.Visible = false;
            cancel_btn.Visible = false;
            LockControls(groupBox1, true);
            ChangeState(false);
            gb = 0;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (gb == 1)
            {
                dataGridView1.Enabled = true;
                confirm_btn.Visible = false;
                cancel_btn.Visible = false;
                LockControls(groupBox1, true);
                ChangeState(false);
                String query = "update blood_participant " +
                    "set participant_name = N'" + name_tb.Text.ToString() + "'," +
                    "participant_age = " + age_tb.Text.ToString() + "," +
                    "participant_address = N'" + address_tb.Text.ToString() + "'," +
                    "participant_phone = '" + phone_tb.Text.ToString() + "'," +
                    "participant_email = '" + email_tb.Text.ToString() + "'," +
                    "participant_blood_type = '" + comboBox2.Text.ToString() + "'" +
                    " where participant_id = '" + id_tb.Text.ToString() + "'";
                executeDB(query);
                String queryReload = "select bp.participant_id N'ID', bp.participant_name N'Họ và tên', bp.participant_age N'Tuổi', bp.participant_address N'Địa chỉ', bp.participant_phone N'Số điện thoại', bp.participant_email N'Email', bp.participant_blood_type N'Nhóm máu' from blood_participant as bp";
                db_Load(queryReload);
            }    
            else if (gb == 2)
            {
                dataGridView1.Enabled = true;
                confirm_btn.Visible = false;
                cancel_btn.Visible = false;
                LockControls(groupBox1, true);
                ChangeState(false);
                String query = "insert into blood_participant " +
                    "values (" +
                    "'" + id_tb.Text.ToString() + "'," +
                    "N'" + name_tb.Text.ToString() + "'," +
                    "'" + age_tb.Text.ToString() + "'," +
                    "N'" + address_tb.Text.ToString() + "'," +
                    "'" + phone_tb.Text.ToString() + "'," +
                    "'" + email_tb.Text.ToString() + "'," +
                    "'" + comboBox2.Text.ToString() + "'" + ")";
                executeDB(query);
                String queryReload = "select bp.participant_id N'ID', bp.participant_name N'Họ và tên', bp.participant_age N'Tuổi', bp.participant_address N'Địa chỉ', bp.participant_phone N'Số điện thoại', bp.participant_email N'Email', bp.participant_blood_type N'Nhóm máu' from blood_participant as bp";
                db_Load(queryReload);
            }
            gb = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            confirm_btn.Visible = true;
            cancel_btn.Visible = true;
            LockControls(groupBox1, false);
            ChangeState(true);
            id_tb.Text = String.Empty;
            age_tb.Text = String.Empty;
            address_tb.Text = String.Empty;
            phone_tb.Text = String.Empty;
            email_tb.Text = String.Empty;
            name_tb.Text = String.Empty;
            gb = 2;
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            String query = "delete blood_participant where participant_id = '" + id_tb.Text.ToString() + "'";
            executeDB(query);
            String queryReload = "select bp.participant_id N'ID', bp.participant_name N'Họ và tên', bp.participant_age N'Tuổi', bp.participant_address N'Địa chỉ', bp.participant_phone N'Số điện thoại', bp.participant_email N'Email', bp.participant_blood_type N'Nhóm máu' from blood_participant as bp";
            db_Load(queryReload);
        }
    }
}
