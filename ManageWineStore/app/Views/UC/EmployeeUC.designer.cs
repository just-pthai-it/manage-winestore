﻿
namespace ManageWineStore.app.Views.UC
{
    partial class EmployeeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectImgBt = new System.Windows.Forms.Button();
            this.genderCbb = new System.Windows.Forms.ComboBox();
            this.jobCbb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cancelBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.birthDtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchBtn = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.keyCbb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.refreshBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectImgBt);
            this.groupBox1.Controls.Add(this.genderCbb);
            this.groupBox1.Controls.Add(this.jobCbb);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cancelBt);
            this.groupBox1.Controls.Add(this.saveBt);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAccountId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.birthDtp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(707, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // selectImgBt
            // 
            this.selectImgBt.Enabled = false;
            this.selectImgBt.Location = new System.Drawing.Point(195, 341);
            this.selectImgBt.Name = "selectImgBt";
            this.selectImgBt.Size = new System.Drawing.Size(68, 23);
            this.selectImgBt.TabIndex = 41;
            this.selectImgBt.Text = "Chọn ảnh";
            this.selectImgBt.UseVisualStyleBackColor = true;
            this.selectImgBt.Click += new System.EventHandler(this.selectImgBt_Click);
            // 
            // genderCbb
            // 
            this.genderCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCbb.Enabled = false;
            this.genderCbb.FormattingEnabled = true;
            this.genderCbb.Location = new System.Drawing.Point(91, 122);
            this.genderCbb.Name = "genderCbb";
            this.genderCbb.Size = new System.Drawing.Size(87, 21);
            this.genderCbb.TabIndex = 22;
            // 
            // jobCbb
            // 
            this.jobCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobCbb.Enabled = false;
            this.jobCbb.FormattingEnabled = true;
            this.jobCbb.Location = new System.Drawing.Point(91, 89);
            this.jobCbb.Name = "jobCbb";
            this.jobCbb.Size = new System.Drawing.Size(150, 21);
            this.jobCbb.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Công việc";
            // 
            // cancelBt
            // 
            this.cancelBt.Enabled = false;
            this.cancelBt.Location = new System.Drawing.Point(267, 486);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(100, 38);
            this.cancelBt.TabIndex = 19;
            this.cancelBt.Text = "Hủy";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBt
            // 
            this.saveBt.Enabled = false;
            this.saveBt.Location = new System.Drawing.Point(60, 486);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(100, 38);
            this.saveBt.TabIndex = 18;
            this.saveBt.Text = "Lưu";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(91, 341);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(98, 139);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ảnh";
            // 
            // txtAccountId
            // 
            this.txtAccountId.Enabled = false;
            this.txtAccountId.Location = new System.Drawing.Point(89, 301);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(142, 20);
            this.txtAccountId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã TK";
            // 
            // birthDtp
            // 
            this.birthDtp.Enabled = false;
            this.birthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDtp.Location = new System.Drawing.Point(91, 160);
            this.birthDtp.Name = "birthDtp";
            this.birthDtp.Size = new System.Drawing.Size(98, 20);
            this.birthDtp.TabIndex = 13;
            this.birthDtp.Value = new System.DateTime(2021, 11, 21, 23, 54, 50, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày sinh:";
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(89, 229);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(257, 20);
            this.txtMail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(89, 193);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SĐT:";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(89, 264);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(91, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(91, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.searchBtn);
            this.splitContainer1.Panel1.Controls.Add(this.txtKeyword);
            this.splitContainer1.Panel1.Controls.Add(this.keyCbb);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(707, 541);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(574, 18);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(70, 21);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(286, 19);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(238, 20);
            this.txtKeyword.TabIndex = 16;
            // 
            // keyCbb
            // 
            this.keyCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyCbb.FormattingEnabled = true;
            this.keyCbb.Location = new System.Drawing.Point(94, 19);
            this.keyCbb.Name = "keyCbb";
            this.keyCbb.Size = new System.Drawing.Size(100, 21);
            this.keyCbb.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Từ khóa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tìm kiếm theo";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.refreshBt);
            this.splitContainer2.Panel2.Controls.Add(this.deleteBt);
            this.splitContainer2.Panel2.Controls.Add(this.updateBt);
            this.splitContainer2.Panel2.Controls.Add(this.addBt);
            this.splitContainer2.Size = new System.Drawing.Size(707, 479);
            this.splitContainer2.SplitterDistance = 395;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(707, 395);
            this.dgv.TabIndex = 0;
            // 
            // refreshBt
            // 
            this.refreshBt.Location = new System.Drawing.Point(497, 22);
            this.refreshBt.Name = "refreshBt";
            this.refreshBt.Size = new System.Drawing.Size(100, 38);
            this.refreshBt.TabIndex = 27;
            this.refreshBt.Text = "Làm mới";
            this.refreshBt.UseVisualStyleBackColor = true;
            this.refreshBt.Click += new System.EventHandler(this.refreshBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(356, 22);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(100, 38);
            this.deleteBt.TabIndex = 26;
            this.deleteBt.Text = "Xóa";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(218, 22);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(100, 38);
            this.updateBt.TabIndex = 25;
            this.updateBt.Text = "Sửa";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(80, 22);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(100, 38);
            this.addBt.TabIndex = 24;
            this.addBt.Text = "Thêm";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(1132, 541);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker birthDtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox keyCbb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.ComboBox jobCbb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox genderCbb;
        private System.Windows.Forms.Button refreshBt;
        private System.Windows.Forms.Button selectImgBt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}