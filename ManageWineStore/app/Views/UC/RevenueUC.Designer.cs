
namespace ManageWineStore.app.Views.UC
{
    partial class RevenueUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.wineCbb = new System.Windows.Forms.ComboBox();
            this.timeCbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.endYearCbb = new System.Windows.Forms.ComboBox();
            this.startYearCbb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chartTypeCbb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(188, 33);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(735, 398);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại rượu:";
            // 
            // wineCbb
            // 
            this.wineCbb.FormattingEnabled = true;
            this.wineCbb.Location = new System.Drawing.Point(249, 12);
            this.wineCbb.Name = "wineCbb";
            this.wineCbb.Size = new System.Drawing.Size(112, 21);
            this.wineCbb.TabIndex = 2;
            // 
            // timeCbb
            // 
            this.timeCbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeCbb.FormattingEnabled = true;
            this.timeCbb.Items.AddRange(new object[] {
            "Tháng",
            "Quý"});
            this.timeCbb.Location = new System.Drawing.Point(588, 12);
            this.timeCbb.Name = "timeCbb";
            this.timeCbb.Size = new System.Drawing.Size(74, 21);
            this.timeCbb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian:";
            // 
            // yearCbb
            // 
            this.yearCbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCbb.FormattingEnabled = true;
            this.yearCbb.Location = new System.Drawing.Point(775, 12);
            this.yearCbb.Name = "yearCbb";
            this.yearCbb.Size = new System.Drawing.Size(74, 21);
            this.yearCbb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm:";
            // 
            // display
            // 
            this.display.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.display.Location = new System.Drawing.Point(855, 6);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(68, 21);
            this.display.TabIndex = 13;
            this.display.Text = "Hiển thị";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.displayBt_Click);
            // 
            // endYearCbb
            // 
            this.endYearCbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endYearCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endYearCbb.Enabled = false;
            this.endYearCbb.FormattingEnabled = true;
            this.endYearCbb.Location = new System.Drawing.Point(775, 54);
            this.endYearCbb.Name = "endYearCbb";
            this.endYearCbb.Size = new System.Drawing.Size(74, 21);
            this.endYearCbb.TabIndex = 15;
            // 
            // startYearCbb
            // 
            this.startYearCbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startYearCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startYearCbb.Enabled = false;
            this.startYearCbb.FormattingEnabled = true;
            this.startYearCbb.Location = new System.Drawing.Point(588, 54);
            this.startYearCbb.Name = "startYearCbb";
            this.startYearCbb.Size = new System.Drawing.Size(74, 21);
            this.startYearCbb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Năm bắt đầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Năm kết thúc:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(472, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(472, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // chartTypeCbb
            // 
            this.chartTypeCbb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chartTypeCbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartTypeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chartTypeCbb.FormattingEnabled = true;
            this.chartTypeCbb.Items.AddRange(new object[] {
            "Đường",
            "Cột"});
            this.chartTypeCbb.Location = new System.Drawing.Point(775, 6);
            this.chartTypeCbb.Name = "chartTypeCbb";
            this.chartTypeCbb.Size = new System.Drawing.Size(74, 21);
            this.chartTypeCbb.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.startYearCbb);
            this.panel1.Controls.Add(this.endYearCbb);
            this.panel1.Controls.Add(this.yearCbb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.timeCbb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.wineCbb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 94);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartTypeCbb);
            this.panel2.Controls.Add(this.display);
            this.panel2.Controls.Add(this.chart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 447);
            this.panel2.TabIndex = 24;
            // 
            // RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RevenueUC";
            this.Size = new System.Drawing.Size(1132, 541);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wineCbb;
        private System.Windows.Forms.ComboBox timeCbb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yearCbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.ComboBox endYearCbb;
        private System.Windows.Forms.ComboBox startYearCbb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox chartTypeCbb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
