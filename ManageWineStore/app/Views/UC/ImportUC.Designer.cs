
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cart = new System.Windows.Forms.ListBox();
            this.removeBt = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.abortBt = new FontAwesome.Sharp.IconButton();
            this.confirmBt = new FontAwesome.Sharp.IconButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.wineCbb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBt = new FontAwesome.Sharp.IconButton();
            this.okBtn = new FontAwesome.Sharp.IconButton();
            this.quantityNumericUD = new System.Windows.Forms.NumericUpDown();
            this.mfgNumericUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfgNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cart);
            this.groupBox2.Controls.Add(this.removeBt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(754, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 400);
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
            this.cart.Size = new System.Drawing.Size(372, 354);
            this.cart.TabIndex = 0;
            // 
            // removeBt
            // 
            this.removeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeBt.FlatAppearance.BorderSize = 0;
            this.removeBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.removeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBt.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.removeBt.IconColor = System.Drawing.Color.Red;
            this.removeBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeBt.IconSize = 18;
            this.removeBt.Location = new System.Drawing.Point(3, 370);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(372, 27);
            this.removeBt.TabIndex = 7;
            this.removeBt.UseVisualStyleBackColor = true;
            this.removeBt.Click += new System.EventHandler(this.removeBt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.abortBt);
            this.groupBox3.Controls.Add(this.confirmBt);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(754, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng tiền";
            // 
            // abortBt
            // 
            this.abortBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.abortBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abortBt.ForeColor = System.Drawing.Color.Red;
            this.abortBt.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.abortBt.IconColor = System.Drawing.Color.Red;
            this.abortBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.abortBt.IconSize = 20;
            this.abortBt.Location = new System.Drawing.Point(209, 94);
            this.abortBt.Name = "abortBt";
            this.abortBt.Size = new System.Drawing.Size(88, 23);
            this.abortBt.TabIndex = 10;
            this.abortBt.Text = "Hủy";
            this.abortBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.abortBt.UseVisualStyleBackColor = true;
            this.abortBt.Click += new System.EventHandler(this.abortBt_Click);
            // 
            // confirmBt
            // 
            this.confirmBt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBt.ForeColor = System.Drawing.Color.Green;
            this.confirmBt.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.confirmBt.IconColor = System.Drawing.Color.Green;
            this.confirmBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmBt.IconSize = 20;
            this.confirmBt.Location = new System.Drawing.Point(93, 94);
            this.confirmBt.Name = "confirmBt";
            this.confirmBt.Size = new System.Drawing.Size(88, 23);
            this.confirmBt.TabIndex = 9;
            this.confirmBt.Text = "Xác nhận";
            this.confirmBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.confirmBt.UseVisualStyleBackColor = true;
            this.confirmBt.Click += new System.EventHandler(this.comfirmBt_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(174, 32);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(129, 31);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(303, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = ". 000 VNĐ";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 328);
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
            this.label9.Location = new System.Drawing.Point(477, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = ". 000 VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBt);
            this.groupBox1.Controls.Add(this.okBtn);
            this.groupBox1.Controls.Add(this.quantityNumericUD);
            this.groupBox1.Controls.Add(this.mfgNumericUD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
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
            this.groupBox1.Size = new System.Drawing.Size(754, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hàng";
            // 
            // cancelBt
            // 
            this.cancelBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBt.FlatAppearance.BorderSize = 0;
            this.cancelBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBt.ForeColor = System.Drawing.Color.Red;
            this.cancelBt.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.cancelBt.IconColor = System.Drawing.Color.Red;
            this.cancelBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBt.IconSize = 25;
            this.cancelBt.Location = new System.Drawing.Point(444, 449);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(81, 42);
            this.cancelBt.TabIndex = 27;
            this.cancelBt.Text = "Hủy";
            this.cancelBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // okBtn
            // 
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.Color.Green;
            this.okBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.okBtn.IconColor = System.Drawing.Color.Green;
            this.okBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.okBtn.IconSize = 25;
            this.okBtn.Location = new System.Drawing.Point(285, 449);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(81, 42);
            this.okBtn.TabIndex = 26;
            this.okBtn.Text = "OK";
            this.okBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
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
            // ImportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportUC";
            this.Size = new System.Drawing.Size(1132, 541);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfgNumericUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox cart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.ComboBox wineCbb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown mfgNumericUD;
        private System.Windows.Forms.NumericUpDown quantityNumericUD;
        private System.Windows.Forms.TextBox txtTotal;
        private FontAwesome.Sharp.IconButton cancelBt;
        private FontAwesome.Sharp.IconButton okBtn;
        private FontAwesome.Sharp.IconButton removeBt;
        private FontAwesome.Sharp.IconButton abortBt;
        private FontAwesome.Sharp.IconButton confirmBt;
    }
}
