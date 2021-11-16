
namespace Views
{
    partial class FormHome
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuGrb = new System.Windows.Forms.GroupBox();
            this.importBt = new System.Windows.Forms.Button();
            this.profileBt = new System.Windows.Forms.Button();
            this.accountMnBt = new System.Windows.Forms.Button();
            this.storageMnBt = new System.Windows.Forms.Button();
            this.sellBt = new System.Windows.Forms.Button();
            this.wineMnBt = new System.Windows.Forms.Button();
            this.employeeMnBt = new System.Windows.Forms.Button();
            this.revenueBt = new System.Windows.Forms.Button();
            this.pnl_Workplace = new System.Windows.Forms.Panel();
            this.menuGrb.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1370, 44);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb_Task
            // 
            //this.menuGrb.Controls.Add(this.importBt);
            //this.menuGrb.Controls.Add(this.profileBt);
            //this.menuGrb.Controls.Add(this.accountMnBt);
            //this.menuGrb.Controls.Add(this.storageMnBt);
            //this.menuGrb.Controls.Add(this.sellBt);
            //this.menuGrb.Controls.Add(this.wineMnBt);
            //this.menuGrb.Controls.Add(this.employeeMnBt);
            //this.menuGrb.Controls.Add(this.revenueBt);
            this.menuGrb.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuGrb.Location = new System.Drawing.Point(0, 44);
            this.menuGrb.Name = "gb_Task";
            this.menuGrb.Size = new System.Drawing.Size(141, 517);
            this.menuGrb.TabIndex = 10;
            this.menuGrb.TabStop = false;
            this.menuGrb.Text = "Tasks";
            // 
            // btn_Import
            // 
            this.importBt.Location = new System.Drawing.Point(6, 31);
            this.importBt.Name = "btn_Import";
            this.importBt.Size = new System.Drawing.Size(129, 37);
            this.importBt.TabIndex = 1;
            this.importBt.Text = "Nhập hàng";
            this.importBt.UseVisualStyleBackColor = true;
            this.importBt.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Profile
            // 
            this.profileBt.Location = new System.Drawing.Point(6, 332);
            this.profileBt.Name = "btn_Profile";
            this.profileBt.Size = new System.Drawing.Size(129, 37);
            this.profileBt.TabIndex = 8;
            this.profileBt.Text = "Thông tin";
            this.profileBt.UseVisualStyleBackColor = true;
            // 
            // btn_Account
            // 
            this.accountMnBt.Location = new System.Drawing.Point(6, 289);
            this.accountMnBt.Name = "btn_Account";
            this.accountMnBt.Size = new System.Drawing.Size(129, 37);
            this.accountMnBt.TabIndex = 7;
            this.accountMnBt.Text = "Quản lý tài khoản";
            this.accountMnBt.UseVisualStyleBackColor = true;
            // 
            // btn_Storage
            // 
            this.storageMnBt.Location = new System.Drawing.Point(6, 246);
            this.storageMnBt.Name = "btn_Storage";
            this.storageMnBt.Size = new System.Drawing.Size(129, 37);
            this.storageMnBt.TabIndex = 6;
            this.storageMnBt.Text = "Quản lý kho";
            this.storageMnBt.UseVisualStyleBackColor = true;
            // 
            // btn_Sell
            // 
            this.sellBt.Location = new System.Drawing.Point(6, 74);
            this.sellBt.Name = "btn_Sell";
            this.sellBt.Size = new System.Drawing.Size(129, 37);
            this.sellBt.TabIndex = 2;
            this.sellBt.Text = "Bán hàng";
            this.sellBt.UseVisualStyleBackColor = true;
            this.sellBt.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // btn_Wine
            // 
            this.wineMnBt.Location = new System.Drawing.Point(6, 203);
            this.wineMnBt.Name = "btn_Wine";
            this.wineMnBt.Size = new System.Drawing.Size(129, 37);
            this.wineMnBt.TabIndex = 5;
            this.wineMnBt.Text = "Quản lý rượu";
            this.wineMnBt.UseVisualStyleBackColor = true;
            // 
            // btn_Employee
            // 
            this.employeeMnBt.Location = new System.Drawing.Point(6, 160);
            this.employeeMnBt.Name = "btn_Employee";
            this.employeeMnBt.Size = new System.Drawing.Size(129, 37);
            this.employeeMnBt.TabIndex = 4;
            this.employeeMnBt.Text = "Quản lý nhân viên";
            this.employeeMnBt.UseVisualStyleBackColor = true;
            // 
            // btn_Revenue
            // 
            this.revenueBt.Location = new System.Drawing.Point(6, 117);
            this.revenueBt.Name = "btn_Revenue";
            this.revenueBt.Size = new System.Drawing.Size(129, 37);
            this.revenueBt.TabIndex = 3;
            this.revenueBt.Text = "Quản lý doanh thu";
            this.revenueBt.UseVisualStyleBackColor = true;
            // 
            // pnl_Workplace
            // 
            this.pnl_Workplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Workplace.Location = new System.Drawing.Point(141, 44);
            this.pnl_Workplace.Name = "pnl_Workplace";
            this.pnl_Workplace.Size = new System.Drawing.Size(1229, 517);
            this.pnl_Workplace.TabIndex = 11;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.pnl_Workplace);
            this.Controls.Add(this.menuGrb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.menuGrb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox menuGrb;
        private System.Windows.Forms.Button importBt;
        private System.Windows.Forms.Button profileBt;
        private System.Windows.Forms.Button accountMnBt;
        private System.Windows.Forms.Button storageMnBt;
        private System.Windows.Forms.Button sellBt;
        private System.Windows.Forms.Button wineMnBt;
        private System.Windows.Forms.Button employeeMnBt;
        private System.Windows.Forms.Button revenueBt;
        private System.Windows.Forms.Panel pnl_Workplace;
    }
}