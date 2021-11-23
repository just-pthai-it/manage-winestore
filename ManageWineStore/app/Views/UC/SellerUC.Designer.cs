
namespace UC
{
    partial class SellerUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWIneId = new System.Windows.Forms.TextBox();
            this.txtWineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBt = new System.Windows.Forms.Button();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMFG = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelBt = new System.Windows.Forms.Button();
            this.okBt = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.removeBt = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.winemarchendiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winemarchendiseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã rượu:";
            // 
            // txtWIneId
            // 
            this.txtWIneId.Location = new System.Drawing.Point(80, 22);
            this.txtWIneId.Name = "txtWIneId";
            this.txtWIneId.Size = new System.Drawing.Size(117, 20);
            this.txtWIneId.TabIndex = 2;
            // 
            // txtWineName
            // 
            this.txtWineName.Location = new System.Drawing.Point(297, 22);
            this.txtWineName.Name = "txtWineName";
            this.txtWineName.Size = new System.Drawing.Size(117, 20);
            this.txtWineName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên rượu:";
            // 
            // searchBt
            // 
            this.searchBt.Location = new System.Drawing.Point(15, 64);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(101, 20);
            this.searchBt.TabIndex = 9;
            this.searchBt.Text = "Search";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.label5);
            this.gb_Search.Controls.Add(this.txtMFG);
            this.gb_Search.Controls.Add(this.searchBt);
            this.gb_Search.Controls.Add(this.label1);
            this.gb_Search.Controls.Add(this.txtWIneId);
            this.gb_Search.Controls.Add(this.label2);
            this.gb_Search.Controls.Add(this.txtWineName);
            this.gb_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_Search.Location = new System.Drawing.Point(0, 0);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Size = new System.Drawing.Size(1132, 90);
            this.gb_Search.TabIndex = 10;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "Bộ lọc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Năm sản xuất:";
            // 
            // txtMFG
            // 
            this.txtMFG.Location = new System.Drawing.Point(540, 22);
            this.txtMFG.Name = "txtMFG";
            this.txtMFG.Size = new System.Drawing.Size(117, 20);
            this.txtMFG.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 90);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.cart);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1132, 451);
            this.splitContainer1.SplitterDistance = 739;
            this.splitContainer1.TabIndex = 11;
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
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(739, 451);
            this.splitContainer2.SplitterDistance = 283;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(739, 283);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cancelBt);
            this.groupBox1.Controls.Add(this.okBt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(44, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(98, 139);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 36;
            this.pictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ảnh:";
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(329, 113);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(50, 23);
            this.cancelBt.TabIndex = 16;
            this.cancelBt.Text = "Hủy";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // okBt
            // 
            this.okBt.Location = new System.Drawing.Point(234, 113);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(50, 23);
            this.okBt.TabIndex = 15;
            this.okBt.Text = "OK";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(286, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(122, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCustomerId);
            this.panel1.Controls.Add(this.removeBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã khách hàng:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(97, 66);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(56, 20);
            this.txtCustomerId.TabIndex = 4;
            // 
            // removeBt
            // 
            this.removeBt.Location = new System.Drawing.Point(325, 12);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(61, 22);
            this.removeBt.TabIndex = 3;
            this.removeBt.Text = "Xoá";
            this.removeBt.UseVisualStyleBackColor = true;
            this.removeBt.Click += new System.EventHandler(this.removeBt_Click);
            // 
            // cart
            // 
            this.cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cart.FormattingEnabled = true;
            this.cart.Location = new System.Drawing.Point(0, 0);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(389, 287);
            this.cart.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_Accept);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng tiền";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(326, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = ". 000 VNĐ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(206, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 22);
            this.button5.TabIndex = 2;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(97, 96);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(82, 22);
            this.btn_Accept.TabIndex = 1;
            this.btn_Accept.Text = "Thanh toán";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(154, 30);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(21, 22);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SellerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gb_Search);
            this.Name = "SellerUC";
            this.Size = new System.Drawing.Size(1132, 541);
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winemarchendiseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWIneId;
        private System.Windows.Forms.TextBox txtWineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMFG;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button okBt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeBt;
        private System.Windows.Forms.ListBox cart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.BindingSource winemarchendiseBindingSource;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label9;
    }
}
