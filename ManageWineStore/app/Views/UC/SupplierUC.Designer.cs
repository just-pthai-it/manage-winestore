﻿
namespace ManageWineStore.app.Views.UC
{
    partial class SupplierUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBt = new FontAwesome.Sharp.IconButton();
            this.saveBt = new FontAwesome.Sharp.IconButton();
            this.nationCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.searchBt = new FontAwesome.Sharp.IconButton();
            this.refreshBt = new FontAwesome.Sharp.IconButton();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.keyCbb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.deleteBt = new FontAwesome.Sharp.IconButton();
            this.updateBt = new FontAwesome.Sharp.IconButton();
            this.addBt = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.cancelBt);
            this.groupBox1.Controls.Add(this.saveBt);
            this.groupBox1.Controls.Add(this.nationCbb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // cancelBt
            // 
            this.cancelBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBt.Enabled = false;
            this.cancelBt.ForeColor = System.Drawing.Color.Red;
            this.cancelBt.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.cancelBt.IconColor = System.Drawing.Color.Red;
            this.cancelBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBt.IconSize = 25;
            this.cancelBt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelBt.Location = new System.Drawing.Point(267, 486);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(100, 38);
            this.cancelBt.TabIndex = 45;
            this.cancelBt.Text = "Hủy";
            this.cancelBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // saveBt
            // 
            this.saveBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBt.Enabled = false;
            this.saveBt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.saveBt.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveBt.IconColor = System.Drawing.Color.DodgerBlue;
            this.saveBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBt.IconSize = 25;
            this.saveBt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBt.Location = new System.Drawing.Point(60, 486);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(100, 38);
            this.saveBt.TabIndex = 44;
            this.saveBt.Text = "Lưu";
            this.saveBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // nationCbb
            // 
            this.nationCbb.Enabled = false;
            this.nationCbb.FormattingEnabled = true;
            this.nationCbb.Location = new System.Drawing.Point(89, 223);
            this.nationCbb.Name = "nationCbb";
            this.nationCbb.Size = new System.Drawing.Size(112, 21);
            this.nationCbb.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Quốc gia:";
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(89, 150);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(257, 20);
            this.txtMail.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mail: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(89, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(257, 20);
            this.txtPhone.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "SĐT:";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(89, 185);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 20);
            this.txtAddress.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(89, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 20);
            this.txtName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên NCC:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(89, 41);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã NCC:";
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
            this.splitContainer1.Panel1.Controls.Add(this.searchBt);
            this.splitContainer1.Panel1.Controls.Add(this.refreshBt);
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
            // searchBt
            // 
            this.searchBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBt.FlatAppearance.BorderSize = 0;
            this.searchBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.searchBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBt.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBt.IconColor = System.Drawing.Color.Black;
            this.searchBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBt.IconSize = 20;
            this.searchBt.Location = new System.Drawing.Point(530, 15);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(27, 27);
            this.searchBt.TabIndex = 33;
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // refreshBt
            // 
            this.refreshBt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refreshBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBt.FlatAppearance.BorderSize = 0;
            this.refreshBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.refreshBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBt.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.refreshBt.IconColor = System.Drawing.Color.DodgerBlue;
            this.refreshBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refreshBt.IconSize = 20;
            this.refreshBt.Location = new System.Drawing.Point(563, 17);
            this.refreshBt.Name = "refreshBt";
            this.refreshBt.Size = new System.Drawing.Size(27, 22);
            this.refreshBt.TabIndex = 24;
            this.refreshBt.UseVisualStyleBackColor = true;
            this.refreshBt.Click += new System.EventHandler(this.refreshBt_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKeyword.Location = new System.Drawing.Point(286, 19);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(238, 20);
            this.txtKeyword.TabIndex = 21;
            // 
            // keyCbb
            // 
            this.keyCbb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keyCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyCbb.FormattingEnabled = true;
            this.keyCbb.Location = new System.Drawing.Point(94, 19);
            this.keyCbb.Name = "keyCbb";
            this.keyCbb.Size = new System.Drawing.Size(100, 21);
            this.keyCbb.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(233, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Từ khóa";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tìm kiếm theo";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
            this.splitContainer2.Panel2.Controls.Add(this.deleteBt);
            this.splitContainer2.Panel2.Controls.Add(this.updateBt);
            this.splitContainer2.Panel2.Controls.Add(this.addBt);
            this.splitContainer2.Size = new System.Drawing.Size(707, 479);
            this.splitContainer2.SplitterDistance = 398;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(707, 398);
            this.dgv.TabIndex = 0;
            // 
            // deleteBt
            // 
            this.deleteBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBt.ForeColor = System.Drawing.Color.Red;
            this.deleteBt.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteBt.IconColor = System.Drawing.Color.Red;
            this.deleteBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBt.IconSize = 25;
            this.deleteBt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteBt.Location = new System.Drawing.Point(426, 22);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(100, 38);
            this.deleteBt.TabIndex = 33;
            this.deleteBt.Text = "Xóa";
            this.deleteBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBt.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.updateBt.IconColor = System.Drawing.Color.Black;
            this.updateBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateBt.IconSize = 25;
            this.updateBt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateBt.Location = new System.Drawing.Point(288, 22);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(100, 38);
            this.updateBt.TabIndex = 32;
            this.updateBt.Text = "Sửa";
            this.updateBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // addBt
            // 
            this.addBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBt.ForeColor = System.Drawing.Color.Green;
            this.addBt.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addBt.IconColor = System.Drawing.Color.Green;
            this.addBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBt.IconSize = 25;
            this.addBt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addBt.Location = new System.Drawing.Point(150, 22);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(100, 38);
            this.addBt.TabIndex = 31;
            this.addBt.Text = "Thêm";
            this.addBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // SupplierUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SupplierUC";
            this.Size = new System.Drawing.Size(1132, 541);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox keyCbb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nationCbb;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton refreshBt;
        private FontAwesome.Sharp.IconButton cancelBt;
        private FontAwesome.Sharp.IconButton saveBt;
        private FontAwesome.Sharp.IconButton addBt;
        private FontAwesome.Sharp.IconButton deleteBt;
        private FontAwesome.Sharp.IconButton updateBt;
        private FontAwesome.Sharp.IconButton searchBt;
    }
}
