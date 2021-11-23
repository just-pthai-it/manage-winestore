
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
            this.ReceiptMnBt = new System.Windows.Forms.Button();
            this.supplierBt = new System.Windows.Forms.Button();
            this.customerMnBt = new System.Windows.Forms.Button();
            this.importBt = new System.Windows.Forms.Button();
            this.profileBt = new System.Windows.Forms.Button();
            this.accountMnBt = new System.Windows.Forms.Button();
            this.storageMnBt = new System.Windows.Forms.Button();
            this.sellBt = new System.Windows.Forms.Button();
            this.wineMnBt = new System.Windows.Forms.Button();
            this.employeeMnBt = new System.Windows.Forms.Button();
            this.revenueBt = new System.Windows.Forms.Button();
            this.workplacePnl = new System.Windows.Forms.Panel();
            this.personalInforBt = new System.Windows.Forms.Button();
            this.menuGrb.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1273, 44);
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
            // menuGrb
            // 
            this.menuGrb.Controls.Add(this.personalInforBt);
            this.menuGrb.Controls.Add(this.ReceiptMnBt);
            this.menuGrb.Controls.Add(this.supplierBt);
            this.menuGrb.Controls.Add(this.customerMnBt);
            this.menuGrb.Controls.Add(this.importBt);
            this.menuGrb.Controls.Add(this.profileBt);
            this.menuGrb.Controls.Add(this.accountMnBt);
            this.menuGrb.Controls.Add(this.storageMnBt);
            this.menuGrb.Controls.Add(this.sellBt);
            this.menuGrb.Controls.Add(this.wineMnBt);
            this.menuGrb.Controls.Add(this.employeeMnBt);
            this.menuGrb.Controls.Add(this.revenueBt);
            this.menuGrb.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuGrb.Location = new System.Drawing.Point(0, 44);
            this.menuGrb.Name = "menuGrb";
            this.menuGrb.Size = new System.Drawing.Size(141, 542);
            this.menuGrb.TabIndex = 10;
            this.menuGrb.TabStop = false;
            this.menuGrb.Text = "Menu";
            // 
            // ReceiptMnBt
            // 
            this.ReceiptMnBt.Location = new System.Drawing.Point(6, 418);
            this.ReceiptMnBt.Name = "ReceiptMnBt";
            this.ReceiptMnBt.Size = new System.Drawing.Size(129, 37);
            this.ReceiptMnBt.TabIndex = 10;
            this.ReceiptMnBt.Text = "Quản lý hóa đơn";
            this.ReceiptMnBt.UseVisualStyleBackColor = true;
            this.ReceiptMnBt.Click += new System.EventHandler(this.ReceiptMnBt_Click);
            // 
            // supplierBt
            // 
            this.supplierBt.Location = new System.Drawing.Point(6, 246);
            this.supplierBt.Name = "supplierBt";
            this.supplierBt.Size = new System.Drawing.Size(129, 37);
            this.supplierBt.TabIndex = 9;
            this.supplierBt.Text = "Nhà cung cấp";
            this.supplierBt.UseVisualStyleBackColor = true;
            this.supplierBt.Click += new System.EventHandler(this.supplierBt_Click);
            // 
            // customerMnBt
            // 
            this.customerMnBt.Location = new System.Drawing.Point(6, 375);
            this.customerMnBt.Name = "customerMnBt";
            this.customerMnBt.Size = new System.Drawing.Size(129, 37);
            this.customerMnBt.TabIndex = 9;
            this.customerMnBt.Text = "Thông tin khách hàng";
            this.customerMnBt.UseVisualStyleBackColor = true;
            this.customerMnBt.Click += new System.EventHandler(this.customerMnBt_Click);
            // 
            // importBt
            // 
            this.importBt.Location = new System.Drawing.Point(6, 31);
            this.importBt.Name = "importBt";
            this.importBt.Size = new System.Drawing.Size(129, 37);
            this.importBt.TabIndex = 1;
            this.importBt.Text = "Nhập hàng";
            this.importBt.UseVisualStyleBackColor = true;
            this.importBt.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // profileBt
            // 
            this.profileBt.Location = new System.Drawing.Point(6, 375);
            this.profileBt.Name = "profileBt";
            this.profileBt.Size = new System.Drawing.Size(129, 37);
            this.profileBt.TabIndex = 8;
            this.profileBt.Text = "Thông tin cá nhân";
            this.profileBt.UseVisualStyleBackColor = true;
            // 
            // accountMnBt
            // 
            this.accountMnBt.Location = new System.Drawing.Point(6, 332);
            this.accountMnBt.Name = "accountMnBt";
            this.accountMnBt.Size = new System.Drawing.Size(129, 37);
            this.accountMnBt.TabIndex = 7;
            this.accountMnBt.Text = "Quản lý tài khoản";
            this.accountMnBt.UseVisualStyleBackColor = true;
            this.accountMnBt.Click += new System.EventHandler(this.accountMnBt_Click);
            // 
            // storageMnBt
            // 
            this.storageMnBt.Location = new System.Drawing.Point(6, 203);
            this.storageMnBt.Name = "storageMnBt";
            this.storageMnBt.Size = new System.Drawing.Size(129, 37);
            this.storageMnBt.TabIndex = 6;
            this.storageMnBt.Text = "Quản lý kho";
            this.storageMnBt.UseVisualStyleBackColor = true;
            this.storageMnBt.Click += new System.EventHandler(this.storageMnBt_Click);
            // 
            // sellBt
            // 
            this.sellBt.Location = new System.Drawing.Point(6, 74);
            this.sellBt.Name = "sellBt";
            this.sellBt.Size = new System.Drawing.Size(129, 37);
            this.sellBt.TabIndex = 2;
            this.sellBt.Text = "Bán hàng";
            this.sellBt.UseVisualStyleBackColor = true;
            this.sellBt.Click += new System.EventHandler(this.sellBt_Click);
            // 
            // wineMnBt
            // 
            this.wineMnBt.Location = new System.Drawing.Point(6, 160);
            this.wineMnBt.Name = "wineMnBt";
            this.wineMnBt.Size = new System.Drawing.Size(129, 37);
            this.wineMnBt.TabIndex = 5;
            this.wineMnBt.Text = "Quản lý rượu";
            this.wineMnBt.UseVisualStyleBackColor = true;
            this.wineMnBt.Click += new System.EventHandler(this.wineMnBt_Click);
            // 
            // employeeMnBt
            // 
            this.employeeMnBt.Location = new System.Drawing.Point(6, 289);
            this.employeeMnBt.Name = "employeeMnBt";
            this.employeeMnBt.Size = new System.Drawing.Size(129, 37);
            this.employeeMnBt.TabIndex = 4;
            this.employeeMnBt.Text = "Thông tin nhân viên";
            this.employeeMnBt.UseVisualStyleBackColor = true;
            this.employeeMnBt.Click += new System.EventHandler(this.employeeMnBt_Click);
            // 
            // revenueBt
            // 
            this.revenueBt.Location = new System.Drawing.Point(6, 117);
            this.revenueBt.Name = "revenueBt";
            this.revenueBt.Size = new System.Drawing.Size(129, 37);
            this.revenueBt.TabIndex = 3;
            this.revenueBt.Text = "Quản lý doanh thu";
            this.revenueBt.UseVisualStyleBackColor = true;
            // 
            // workplacePnl
            // 
            this.workplacePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workplacePnl.Location = new System.Drawing.Point(141, 44);
            this.workplacePnl.Name = "workplacePnl";
            this.workplacePnl.Size = new System.Drawing.Size(1132, 542);
            this.workplacePnl.TabIndex = 11;
            // 
            // personalInforBt
            // 
            this.personalInforBt.Location = new System.Drawing.Point(6, 461);
            this.personalInforBt.Name = "personalInforBt";
            this.personalInforBt.Size = new System.Drawing.Size(129, 37);
            this.personalInforBt.TabIndex = 11;
            this.personalInforBt.Text = "Thông tin cá nhân";
            this.personalInforBt.UseVisualStyleBackColor = true;
            this.personalInforBt.Click += new System.EventHandler(this.personalInforBt_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 586);
            this.Controls.Add(this.workplacePnl);
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
        private System.Windows.Forms.Panel workplacePnl;
        private System.Windows.Forms.Button supplierBt;
        private System.Windows.Forms.Button customerMnBt;
        private System.Windows.Forms.Button ReceiptMnBt;
        private System.Windows.Forms.Button personalInforBt;
    }
}