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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormClosing += mainForm_FormClosing;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void Blood_Quantity_Load()
        {
            SqlConnection connection = DatabaseConnection.Instance.getConnection();
            String query = "select * from blood_inventory";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                arhdp.Text = dataTable.Rows[0]["blood_quantity"].ToString() + "ml";
                brhdp.Text = dataTable.Rows[1]["blood_quantity"].ToString() + "ml";
                abrhdp.Text = dataTable.Rows[2]["blood_quantity"].ToString() + "ml";
                orhdp.Text = dataTable.Rows[3]["blood_quantity"].ToString() + "ml";
                arhdm.Text = dataTable.Rows[4]["blood_quantity"].ToString() + "ml";
                brhdm.Text = dataTable.Rows[5]["blood_quantity"].ToString() + "ml";
                abrhdm.Text = dataTable.Rows[6]["blood_quantity"].ToString() + "ml";
                orhdm.Text = dataTable.Rows[7]["blood_quantity"].ToString() + "ml";
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! Có lỗi đã xảy ra, hãy kiểm tra lại kết nối cơ sở dữ liệu!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            refresh.Image = Properties.Resources.refresh;
            refresh.ImageAlign = ContentAlignment.MiddleLeft;
            refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            Blood_Quantity_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageBlood_Participant manageBlood_Participant = new manageBlood_Participant();
            manageBlood_Participant.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Blood_Quantity_Load();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manageDonation_record manageDonation_Record = new manageDonation_record();
            manageDonation_Record.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            blood_test_form blood_Test_Form = new blood_test_form();
            blood_Test_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            assistant_form assistant_Form = new assistant_form();
            assistant_Form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            blood_request_form blood_Request_Form = new blood_request_form();
            blood_Request_Form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            blood_donation_event_form blood_Donation_Event_Form = new blood_donation_event_form();
            blood_Donation_Event_Form.Show();
        }
    }
}
