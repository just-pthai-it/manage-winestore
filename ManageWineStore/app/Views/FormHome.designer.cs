
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
            this.personalInforBt = new FontAwesome.Sharp.IconButton();
            this.receiptMnBt = new FontAwesome.Sharp.IconButton();
            this.customerMnBt = new FontAwesome.Sharp.IconButton();
            this.accountMnBt = new FontAwesome.Sharp.IconButton();
            this.employeeMnBt = new FontAwesome.Sharp.IconButton();
            this.supplierBt = new FontAwesome.Sharp.IconButton();
            this.storageMnBt = new FontAwesome.Sharp.IconButton();
            this.wineMnBt = new FontAwesome.Sharp.IconButton();
            this.sellBt = new FontAwesome.Sharp.IconButton();
            this.importBt = new FontAwesome.Sharp.IconButton();
            this.workplacePnl = new System.Windows.Forms.Panel();
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
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(531, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "MBH Wine Store";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuGrb
            // 
            this.menuGrb.Controls.Add(this.customerMnBt);
            this.menuGrb.Controls.Add(this.personalInforBt);
            this.menuGrb.Controls.Add(this.receiptMnBt);
            this.menuGrb.Controls.Add(this.accountMnBt);
            this.menuGrb.Controls.Add(this.employeeMnBt);
            this.menuGrb.Controls.Add(this.supplierBt);
            this.menuGrb.Controls.Add(this.storageMnBt);
            this.menuGrb.Controls.Add(this.wineMnBt);
            this.menuGrb.Controls.Add(this.sellBt);
            this.menuGrb.Controls.Add(this.importBt);
            this.menuGrb.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuGrb.Location = new System.Drawing.Point(0, 44);
            this.menuGrb.Name = "menuGrb";
            this.menuGrb.Size = new System.Drawing.Size(144, 542);
            this.menuGrb.TabIndex = 10;
            this.menuGrb.TabStop = false;
            this.menuGrb.Text = "Menu";
            // 
            // personalInforBt
            // 
            this.personalInforBt.FlatAppearance.BorderSize = 0;
            this.personalInforBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.personalInforBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInforBt.ForeColor = System.Drawing.Color.Brown;
            this.personalInforBt.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.personalInforBt.IconColor = System.Drawing.Color.Tomato;
            this.personalInforBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.personalInforBt.IconSize = 35;
            this.personalInforBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalInforBt.Location = new System.Drawing.Point(6, 461);
            this.personalInforBt.Name = "personalInforBt";
            this.personalInforBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.personalInforBt.Size = new System.Drawing.Size(129, 37);
            this.personalInforBt.TabIndex = 11;
            this.personalInforBt.Text = "Thông tin cá nhân";
            this.personalInforBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalInforBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personalInforBt.UseVisualStyleBackColor = true;
            this.personalInforBt.Click += new System.EventHandler(this.personalInforBt_Click);
            // 
            // receiptMnBt
            // 
            this.receiptMnBt.FlatAppearance.BorderSize = 0;
            this.receiptMnBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptMnBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptMnBt.ForeColor = System.Drawing.Color.Brown;
            this.receiptMnBt.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.receiptMnBt.IconColor = System.Drawing.Color.Tomato;
            this.receiptMnBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.receiptMnBt.IconSize = 35;
            this.receiptMnBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receiptMnBt.Location = new System.Drawing.Point(6, 418);
            this.receiptMnBt.Name = "receiptMnBt";
            this.receiptMnBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.receiptMnBt.Size = new System.Drawing.Size(129, 37);
            this.receiptMnBt.TabIndex = 10;
            this.receiptMnBt.Text = "Quản lý hóa đơn";
            this.receiptMnBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receiptMnBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.receiptMnBt.UseVisualStyleBackColor = true;
            this.receiptMnBt.Click += new System.EventHandler(this.ReceiptMnBt_Click);
            // 
            // customerMnBt
            // 
            this.customerMnBt.FlatAppearance.BorderSize = 0;
            this.customerMnBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerMnBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerMnBt.ForeColor = System.Drawing.Color.Brown;
            this.customerMnBt.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.customerMnBt.IconColor = System.Drawing.Color.Tomato;
            this.customerMnBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customerMnBt.IconSize = 35;
            this.customerMnBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerMnBt.Location = new System.Drawing.Point(6, 375);
            this.customerMnBt.Name = "customerMnBt";
            this.customerMnBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.customerMnBt.Size = new System.Drawing.Size(129, 37);
            this.customerMnBt.TabIndex = 8;
            this.customerMnBt.Text = "Thông tin khách hàng";
            this.customerMnBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerMnBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customerMnBt.UseVisualStyleBackColor = true;
            this.customerMnBt.Click += new System.EventHandler(this.customerMnBt_Click);
            // 
            // accountMnBt
            // 
            this.accountMnBt.FlatAppearance.BorderSize = 0;
            this.accountMnBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountMnBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountMnBt.ForeColor = System.Drawing.Color.Brown;
            this.accountMnBt.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.accountMnBt.IconColor = System.Drawing.Color.Tomato;
            this.accountMnBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountMnBt.IconSize = 35;
            this.accountMnBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountMnBt.Location = new System.Drawing.Point(6, 332);
            this.accountMnBt.Name = "accountMnBt";
            this.accountMnBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.accountMnBt.Size = new System.Drawing.Size(129, 37);
            this.accountMnBt.TabIndex = 6;
            this.accountMnBt.Text = "Quản lý tài khoản";
            this.accountMnBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountMnBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accountMnBt.UseVisualStyleBackColor = true;
            this.accountMnBt.Click += new System.EventHandler(this.accountMnBt_Click);
            // 
            // employeeMnBt
            // 
            this.employeeMnBt.FlatAppearance.BorderSize = 0;
            this.employeeMnBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeeMnBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeMnBt.ForeColor = System.Drawing.Color.Brown;
            this.employeeMnBt.IconChar = FontAwesome.Sharp.IconChar.User;
            this.employeeMnBt.IconColor = System.Drawing.Color.Tomato;
            this.employeeMnBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employeeMnBt.IconSize = 35;
            this.employeeMnBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeMnBt.Location = new System.Drawing.Point(6, 289);
            this.employeeMnBt.Name = "employeeMnBt";
            this.employeeMnBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.employeeMnBt.Size = new System.Drawing.Size(129, 37);
            this.employeeMnBt.TabIndex = 13;
            this.employeeMnBt.Text = "Thông tin nhân viên";
            this.employeeMnBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeMnBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeeMnBt.UseVisualStyleBackColor = true;
            this.employeeMnBt.Click += new System.EventHandler(this.employeeMnBt_Click);
            // 
            // supplierBt
            // 
            this.supplierBt.FlatAppearance.BorderSize = 0;
            this.supplierBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supplierBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBt.ForeColor = System.Drawing.Color.Brown;
            this.supplierBt.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.supplierBt.IconColor = System.Drawing.Color.Tomato;
            this.supplierBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.supplierBt.IconSize = 35;
            this.supplierBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierBt.Location = new System.Drawing.Point(6, 246);
            this.supplierBt.Name = "supplierBt";
            this.supplierBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.supplierBt.Size = new System.Drawing.Size(129, 37);
            this.supplierBt.TabIndex = 9;
            this.supplierBt.Text = "Nhà cung cấp";
            this.supplierBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supplierBt.UseVisualStyleBackColor = true;
            this.supplierBt.Click += new System.EventHandler(this.supplierBt_Click);
            // 
            // storageMnBt
            // 
            this.storageMnBt.FlatAppearance.BorderSize = 0;
            this.storageMnBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.storageMnBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageMnBt.ForeColor = System.Drawing.Color.Brown;
            this.storageMnBt.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.storageMnBt.IconColor = System.Drawing.Color.Tomato;
            this.storageMnBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.storageMnBt.IconSize = 35;
            this.storageMnBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storageMnBt.Location = new System.Drawing.Point(6, 203);
            this.storageMnBt.Name = "storageMnBt";
            this.storageMnBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.storageMnBt.Size = new System.Drawing.Size(129, 37);
            this.storageMnBt.TabIndex = 5;
            this.storageMnBt.Text = "Quản lý kho";
            this.storageMnBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storageMnBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.storageMnBt.UseVisualStyleBackColor = true;
            this.storageMnBt.Click += new System.EventHandler(this.storageMnBt_Click);
            // 
            // wineMnBt
            // 
            this.wineMnBt.FlatAppearance.BorderSize = 0;
            this.wineMnBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wineMnBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wineMnBt.ForeColor = System.Drawing.Color.Brown;
            this.wineMnBt.IconChar = FontAwesome.Sharp.IconChar.WineBottle;
            this.wineMnBt.IconColor = System.Drawing.Color.Tomato;
            this.wineMnBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.wineMnBt.IconSize = 35;
            this.wineMnBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wineMnBt.Location = new System.Drawing.Point(6, 160);
            this.wineMnBt.Name = "wineMnBt";
            this.wineMnBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.wineMnBt.Size = new System.Drawing.Size(129, 37);
            this.wineMnBt.TabIndex = 4;
            this.wineMnBt.Text = "Quản lý rượu";
            this.wineMnBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wineMnBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wineMnBt.UseVisualStyleBackColor = true;
            this.wineMnBt.Click += new System.EventHandler(this.wineMnBt_Click);
            // 
            // sellBt
            // 
            this.sellBt.FlatAppearance.BorderSize = 0;
            this.sellBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sellBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBt.ForeColor = System.Drawing.Color.Brown;
            this.sellBt.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.sellBt.IconColor = System.Drawing.Color.Tomato;
            this.sellBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sellBt.IconSize = 35;
            this.sellBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellBt.Location = new System.Drawing.Point(6, 74);
            this.sellBt.Name = "sellBt";
            this.sellBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.sellBt.Size = new System.Drawing.Size(129, 37);
            this.sellBt.TabIndex = 2;
            this.sellBt.Text = "Bán hàng";
            this.sellBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sellBt.UseVisualStyleBackColor = true;
            this.sellBt.Click += new System.EventHandler(this.sellBt_Click);
            // 
            // importBt
            // 
            this.importBt.FlatAppearance.BorderSize = 0;
            this.importBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBt.ForeColor = System.Drawing.Color.Brown;
            this.importBt.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.importBt.IconColor = System.Drawing.Color.Tomato;
            this.importBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.importBt.IconSize = 35;
            this.importBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importBt.Location = new System.Drawing.Point(6, 31);
            this.importBt.Name = "importBt";
            this.importBt.Padding = new System.Windows.Forms.Padding(6, 0, 12, 0);
            this.importBt.Size = new System.Drawing.Size(129, 37);
            this.importBt.TabIndex = 1;
            this.importBt.Text = "Nhập hàng";
            this.importBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importBt.UseVisualStyleBackColor = true;
            this.importBt.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // workplacePnl
            // 
            this.workplacePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workplacePnl.Location = new System.Drawing.Point(144, 44);
            this.workplacePnl.Name = "workplacePnl";
            this.workplacePnl.Size = new System.Drawing.Size(1129, 542);
            this.workplacePnl.TabIndex = 11;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1273, 586);
            this.Controls.Add(this.workplacePnl);
            this.Controls.Add(this.menuGrb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.menuGrb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox menuGrb;
        private System.Windows.Forms.Panel workplacePnl;
        private FontAwesome.Sharp.IconButton importBt;
        private FontAwesome.Sharp.IconButton personalInforBt;
        private FontAwesome.Sharp.IconButton receiptMnBt;
        private FontAwesome.Sharp.IconButton customerMnBt;
        private FontAwesome.Sharp.IconButton accountMnBt;
        private FontAwesome.Sharp.IconButton employeeMnBt;
        private FontAwesome.Sharp.IconButton supplierBt;
        private FontAwesome.Sharp.IconButton storageMnBt;
        private FontAwesome.Sharp.IconButton wineMnBt;
        private FontAwesome.Sharp.IconButton sellBt;
    }
}