namespace Blood_Bank_Management
{
    partial class manageBlood_Participant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_search = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blood_req_ref = new System.Windows.Forms.Button();
            this.blood_don_ref = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blood_don_add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id_search);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm hồ sơ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhóm máu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // name_search
            // 
            this.name_search.Location = new System.Drawing.Point(44, 69);
            this.name_search.Name = "name_search";
            this.name_search.Size = new System.Drawing.Size(232, 22);
            this.name_search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // id_search
            // 
            this.id_search.Location = new System.Drawing.Point(44, 32);
            this.id_search.Name = "id_search";
            this.id_search.Size = new System.Drawing.Size(231, 22);
            this.id_search.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(7, 204);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(269, 33);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blood_don_add_btn);
            this.groupBox2.Controls.Add(this.blood_req_ref);
            this.groupBox2.Controls.Add(this.blood_don_ref);
            this.groupBox2.Controls.Add(this.cancel_btn);
            this.groupBox2.Controls.Add(this.confirm_btn);
            this.groupBox2.Controls.Add(this.update_btn);
            this.groupBox2.Controls.Add(this.del_btn);
            this.groupBox2.Controls.Add(this.add_btn);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.age_tb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.address_tb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.email_tb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.phone_tb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.name_tb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.id_tb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(300, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 243);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý hồ sơ";
            // 
            // blood_req_ref
            // 
            this.blood_req_ref.Location = new System.Drawing.Point(188, 204);
            this.blood_req_ref.Name = "blood_req_ref";
            this.blood_req_ref.Size = new System.Drawing.Size(173, 33);
            this.blood_req_ref.TabIndex = 20;
            this.blood_req_ref.Text = "Hồ sơ yêu cầu máu";
            this.blood_req_ref.UseVisualStyleBackColor = true;
            this.blood_req_ref.Click += new System.EventHandler(this.button8_Click);
            // 
            // blood_don_ref
            // 
            this.blood_don_ref.Location = new System.Drawing.Point(9, 204);
            this.blood_don_ref.Name = "blood_don_ref";
            this.blood_don_ref.Size = new System.Drawing.Size(173, 33);
            this.blood_don_ref.TabIndex = 19;
            this.blood_don_ref.Text = "Hồ sơ hiến máu";
            this.blood_don_ref.UseVisualStyleBackColor = true;
            this.blood_don_ref.Click += new System.EventHandler(this.button7_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(550, 133);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(137, 33);
            this.cancel_btn.TabIndex = 18;
            this.cancel_btn.Text = "Thoát";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Visible = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(407, 133);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(137, 33);
            this.confirm_btn.TabIndex = 17;
            this.confirm_btn.Text = "Xác nhận";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Visible = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(630, 204);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(115, 33);
            this.update_btn.TabIndex = 16;
            this.update_btn.Text = "Sửa";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(512, 204);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(115, 33);
            this.del_btn.TabIndex = 15;
            this.del_btn.Text = "Xóa";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(391, 204);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(115, 33);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(452, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 24);
            this.comboBox2.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nhóm máu";
            // 
            // age_tb
            // 
            this.age_tb.Enabled = false;
            this.age_tb.Location = new System.Drawing.Point(452, 66);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(221, 22);
            this.age_tb.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tuổi";
            // 
            // address_tb
            // 
            this.address_tb.Enabled = false;
            this.address_tb.Location = new System.Drawing.Point(452, 29);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(221, 22);
            this.address_tb.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ";
            // 
            // email_tb
            // 
            this.email_tb.Enabled = false;
            this.email_tb.Location = new System.Drawing.Point(104, 141);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(221, 22);
            this.email_tb.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // phone_tb
            // 
            this.phone_tb.Enabled = false;
            this.phone_tb.Location = new System.Drawing.Point(104, 103);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(221, 22);
            this.phone_tb.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // name_tb
            // 
            this.name_tb.Enabled = false;
            this.name_tb.Location = new System.Drawing.Point(104, 66);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(221, 22);
            this.name_tb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Họ và tên";
            // 
            // id_tb
            // 
            this.id_tb.Enabled = false;
            this.id_tb.Location = new System.Drawing.Point(104, 29);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(221, 22);
            this.id_tb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // blood_don_add_btn
            // 
            this.blood_don_add_btn.Location = new System.Drawing.Point(9, 169);
            this.blood_don_add_btn.Name = "blood_don_add_btn";
            this.blood_don_add_btn.Size = new System.Drawing.Size(173, 33);
            this.blood_don_add_btn.TabIndex = 21;
            this.blood_don_add_btn.Text = "Tạo hồ sơ hiến máu";
            this.blood_don_add_btn.UseVisualStyleBackColor = true;
            // 
            // manageBlood_Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "manageBlood_Participant";
            this.Text = "Quản lý hồ sơ người tham gia";
            this.Load += new System.EventHandler(this.manageBlood_Participant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_search;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button blood_req_ref;
        private System.Windows.Forms.Button blood_don_ref;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button blood_don_add_btn;
    }
}