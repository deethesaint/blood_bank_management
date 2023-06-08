namespace Blood_Bank_Management
{
    partial class assistant_form
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blood_don_ref = new System.Windows.Forms.Button();
            this.blood_test_ref = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_search = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blood_don_ref);
            this.groupBox2.Controls.Add(this.blood_test_ref);
            this.groupBox2.Controls.Add(this.cancel_btn);
            this.groupBox2.Controls.Add(this.confirm_btn);
            this.groupBox2.Controls.Add(this.update_btn);
            this.groupBox2.Controls.Add(this.del_btn);
            this.groupBox2.Controls.Add(this.add_btn);
            this.groupBox2.Controls.Add(this.age_tb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.address_tb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.name_tb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.id_tb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(300, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 243);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý hồ sơ";
            // 
            // blood_don_ref
            // 
            this.blood_don_ref.Location = new System.Drawing.Point(188, 204);
            this.blood_don_ref.Name = "blood_don_ref";
            this.blood_don_ref.Size = new System.Drawing.Size(173, 33);
            this.blood_don_ref.TabIndex = 20;
            this.blood_don_ref.Text = "Hồ sơ hiến máu";
            this.blood_don_ref.UseVisualStyleBackColor = true;
            this.blood_don_ref.Click += new System.EventHandler(this.blood_don_ref_Click);
            // 
            // blood_test_ref
            // 
            this.blood_test_ref.Location = new System.Drawing.Point(9, 204);
            this.blood_test_ref.Name = "blood_test_ref";
            this.blood_test_ref.Size = new System.Drawing.Size(173, 33);
            this.blood_test_ref.TabIndex = 19;
            this.blood_test_ref.Text = "Hồ sơ xét nghiệm";
            this.blood_test_ref.UseVisualStyleBackColor = true;
            this.blood_test_ref.Click += new System.EventHandler(this.blood_test_ref_Click);
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
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(630, 204);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(115, 33);
            this.update_btn.TabIndex = 16;
            this.update_btn.Text = "Sửa";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(512, 204);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(115, 33);
            this.del_btn.TabIndex = 15;
            this.del_btn.Text = "Xóa";
            this.del_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(391, 204);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(115, 33);
            this.add_btn.TabIndex = 14;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id_search);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm hồ sơ";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 296);
            this.dataGridView1.TabIndex = 4;
            // 
            // assistant_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "assistant_form";
            this.Text = "assistant_form";
            this.Load += new System.EventHandler(this.assistant_form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button blood_don_ref;
        private System.Windows.Forms.Button blood_test_ref;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_search;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}