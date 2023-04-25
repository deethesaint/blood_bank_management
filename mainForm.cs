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
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            if (MessageBox.Show("Are you sure you want  to quit?", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }   

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
