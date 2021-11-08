
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Data = new System.Windows.Forms.Button();
            this.btn_Finance = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Infomation = new System.Windows.Forms.Button();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Sell);
            this.panel1.Controls.Add(this.btn_Infomation);
            this.panel1.Controls.Add(this.btn_Data);
            this.panel1.Controls.Add(this.btn_Finance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 471);
            this.panel1.TabIndex = 7;
            // 
            // btn_Data
            // 
            this.btn_Data.Location = new System.Drawing.Point(12, 127);
            this.btn_Data.Name = "btn_Data";
            this.btn_Data.Size = new System.Drawing.Size(129, 37);
            this.btn_Data.TabIndex = 7;
            this.btn_Data.Text = "Dữ liệu";
            this.btn_Data.UseVisualStyleBackColor = true;
            // 
            // btn_Finance
            // 
            this.btn_Finance.Location = new System.Drawing.Point(12, 84);
            this.btn_Finance.Name = "btn_Finance";
            this.btn_Finance.Size = new System.Drawing.Size(129, 37);
            this.btn_Finance.TabIndex = 6;
            this.btn_Finance.Text = "Doanh thu";
            this.btn_Finance.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1013, 44);
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
            // btn_Infomation
            // 
            this.btn_Infomation.Location = new System.Drawing.Point(12, 170);
            this.btn_Infomation.Name = "btn_Infomation";
            this.btn_Infomation.Size = new System.Drawing.Size(129, 37);
            this.btn_Infomation.TabIndex = 11;
            this.btn_Infomation.Text = "Thống tin";
            this.btn_Infomation.UseVisualStyleBackColor = true;
            // 
            // btn_Sell
            // 
            this.btn_Sell.Location = new System.Drawing.Point(12, 41);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(129, 37);
            this.btn_Sell.TabIndex = 12;
            this.btn_Sell.Text = "Bán hàng";
            this.btn_Sell.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Data;
        private System.Windows.Forms.Button btn_Finance;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Infomation;
        private System.Windows.Forms.Button btn_Sell;
    }
}