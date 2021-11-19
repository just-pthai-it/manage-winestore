
namespace ManageWineStore.app.Views.UC
{
    partial class AccountUC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.searchBtn = new System.Windows.Forms.Button();
            this.keywordTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.accountDgv = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.roleTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usernameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(707, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
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
            this.splitContainer1.Panel1.Controls.Add(this.keywordTxt);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(707, 541);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer2.Panel1.Controls.Add(this.accountDgv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.delBtn);
            this.splitContainer2.Panel2.Controls.Add(this.updateBtn);
            this.splitContainer2.Panel2.Controls.Add(this.addBtn);
            this.splitContainer2.Size = new System.Drawing.Size(707, 479);
            this.splitContainer2.SplitterDistance = 389;
            this.splitContainer2.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(574, 18);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(70, 21);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // keywordTxt
            // 
            this.keywordTxt.Location = new System.Drawing.Point(102, 19);
            this.keywordTxt.Name = "keywordTxt";
            this.keywordTxt.Size = new System.Drawing.Size(238, 20);
            this.keywordTxt.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tên tài khoản:";
            // 
            // accountDgv
            // 
            this.accountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountDgv.Location = new System.Drawing.Point(0, 0);
            this.accountDgv.Name = "accountDgv";
            this.accountDgv.Size = new System.Drawing.Size(707, 389);
            this.accountDgv.TabIndex = 0;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(424, 31);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(100, 38);
            this.delBtn.TabIndex = 29;
            this.delBtn.Text = "Xóa";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(286, 31);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 38);
            this.updateBtn.TabIndex = 28;
            this.updateBtn.Text = "Sửa";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(148, 31);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 38);
            this.addBtn.TabIndex = 27;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(267, 486);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 38);
            this.cancelBtn.TabIndex = 39;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(60, 486);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 38);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // roleTxt
            // 
            this.roleTxt.Location = new System.Drawing.Point(90, 129);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(100, 20);
            this.roleTxt.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vai trò:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(90, 94);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(163, 20);
            this.usernameTxt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên TK:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(90, 58);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã TK:";
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountUC";
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
            ((System.ComponentModel.ISupportInitialize)(this.accountDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox keywordTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView accountDgv;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label1;
    }
}
