
namespace ManageWineStore.app.Views.UC
{
    partial class ImportUC
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cart = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.abortBt = new System.Windows.Forms.Button();
            this.comfirmBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.wineCbb = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mfgNumericUD = new System.Windows.Forms.NumericUpDown();
            this.quantityNumericUD = new System.Windows.Forms.NumericUpDown();
            this.removeBt = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfgNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(813, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(319, 541);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cart);
            this.groupBox2.Location = new System.Drawing.Point(816, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // cart
            // 
            this.cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cart.FormattingEnabled = true;
            this.cart.Location = new System.Drawing.Point(3, 16);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(310, 272);
            this.cart.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.abortBt);
            this.groupBox3.Controls.Add(this.comfirmBt);
            this.groupBox3.Location = new System.Drawing.Point(816, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 206);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng tiền";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(240, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = ". 000 VNĐ";
            // 
            // abortBt
            // 
            this.abortBt.Location = new System.Drawing.Point(179, 172);
            this.abortBt.Name = "abortBt";
            this.abortBt.Size = new System.Drawing.Size(88, 22);
            this.abortBt.TabIndex = 6;
            this.abortBt.Text = "Hủy";
            this.abortBt.UseVisualStyleBackColor = true;
            this.abortBt.Click += new System.EventHandler(this.abortBt_Click);
            // 
            // comfirmBt
            // 
            this.comfirmBt.Location = new System.Drawing.Point(70, 172);
            this.comfirmBt.Name = "comfirmBt";
            this.comfirmBt.Size = new System.Drawing.Size(82, 22);
            this.comfirmBt.TabIndex = 5;
            this.comfirmBt.Text = "Xác nhận";
            this.comfirmBt.UseVisualStyleBackColor = true;
            this.comfirmBt.Click += new System.EventHandler(this.comfirmBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại rượu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá trị HH:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(356, 321);
            this.txtCost.Name = "txtCost";
            this.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCost.Size = new System.Drawing.Size(122, 20);
            this.txtCost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Năm SX:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã nhà CC:";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(356, 150);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(122, 20);
            this.txtSupplierId.TabIndex = 15;
            // 
            // wineCbb
            // 
            this.wineCbb.FormattingEnabled = true;
            this.wineCbb.Location = new System.Drawing.Point(356, 95);
            this.wineCbb.Name = "wineCbb";
            this.wineCbb.Size = new System.Drawing.Size(122, 21);
            this.wineCbb.TabIndex = 16;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(257, 480);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(81, 37);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(443, 480);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(81, 37);
            this.cancelBt.TabIndex = 19;
            this.cancelBt.Text = "Hủy";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = ". 000 VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Giá niêm yết:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(356, 373);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = ". 000 VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantityNumericUD);
            this.groupBox1.Controls.Add(this.mfgNumericUD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cancelBt);
            this.groupBox1.Controls.Add(this.okBtn);
            this.groupBox1.Controls.Add(this.wineCbb);
            this.groupBox1.Controls.Add(this.txtSupplierId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hàng";
            // 
            // mfgNumericUD
            // 
            this.mfgNumericUD.Location = new System.Drawing.Point(356, 204);
            this.mfgNumericUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.mfgNumericUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mfgNumericUD.Name = "mfgNumericUD";
            this.mfgNumericUD.Size = new System.Drawing.Size(122, 20);
            this.mfgNumericUD.TabIndex = 24;
            this.mfgNumericUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // quantityNumericUD
            // 
            this.quantityNumericUD.Location = new System.Drawing.Point(356, 261);
            this.quantityNumericUD.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.quantityNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUD.Name = "quantityNumericUD";
            this.quantityNumericUD.Size = new System.Drawing.Size(122, 20);
            this.quantityNumericUD.TabIndex = 25;
            this.quantityNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // removeBt
            // 
            this.removeBt.Location = new System.Drawing.Point(1059, 300);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(61, 22);
            this.removeBt.TabIndex = 8;
            this.removeBt.Text = "Xoá";
            this.removeBt.UseVisualStyleBackColor = true;
            this.removeBt.Click += new System.EventHandler(this.removeBt_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(105, 54);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(129, 20);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0";
            // 
            // ImportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeBt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportUC";
            this.Size = new System.Drawing.Size(1132, 541);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfgNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox cart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button abortBt;
        private System.Windows.Forms.Button comfirmBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.ComboBox wineCbb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mfgNumericUD;
        private System.Windows.Forms.NumericUpDown quantityNumericUD;
        private System.Windows.Forms.Button removeBt;
        private System.Windows.Forms.TextBox txtTotal;
    }
}
