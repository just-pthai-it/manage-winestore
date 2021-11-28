
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
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.nameWine1Cbb = new System.Windows.Forms.ComboBox();
            this.quarterCbb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearCbb1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearCbb2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quarterCbb2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameWine2Cbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.runBt = new System.Windows.Forms.Button();
            this.refreshBt = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // revenueChart
            // 
            chartArea1.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.revenueChart.Legends.Add(legend1);
            this.revenueChart.Location = new System.Drawing.Point(277, 165);
            this.revenueChart.Name = "revenueChart";
            this.revenueChart.Size = new System.Drawing.Size(627, 294);
            this.revenueChart.TabIndex = 0;
            this.revenueChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sản phẩm:";
            // 
            // nameWine1Cbb
            // 
            this.nameWine1Cbb.FormattingEnabled = true;
            this.nameWine1Cbb.Location = new System.Drawing.Point(338, 99);
            this.nameWine1Cbb.Name = "nameWine1Cbb";
            this.nameWine1Cbb.Size = new System.Drawing.Size(112, 21);
            this.nameWine1Cbb.TabIndex = 2;
            // 
            // quarterCbb1
            // 
            this.quarterCbb1.FormattingEnabled = true;
            this.quarterCbb1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.quarterCbb1.Location = new System.Drawing.Point(558, 99);
            this.quarterCbb1.Name = "quarterCbb1";
            this.quarterCbb1.Size = new System.Drawing.Size(74, 21);
            this.quarterCbb1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quý:";
            // 
            // yearCbb1
            // 
            this.yearCbb1.FormattingEnabled = true;
            this.yearCbb1.Location = new System.Drawing.Point(700, 99);
            this.yearCbb1.Name = "yearCbb1";
            this.yearCbb1.Size = new System.Drawing.Size(74, 21);
            this.yearCbb1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm";
            // 
            // yearCbb2
            // 
            this.yearCbb2.FormattingEnabled = true;
            this.yearCbb2.Location = new System.Drawing.Point(700, 126);
            this.yearCbb2.Name = "yearCbb2";
            this.yearCbb2.Size = new System.Drawing.Size(74, 21);
            this.yearCbb2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Năm";
            // 
            // quarterCbb2
            // 
            this.quarterCbb2.FormattingEnabled = true;
            this.quarterCbb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.quarterCbb2.Location = new System.Drawing.Point(558, 126);
            this.quarterCbb2.Name = "quarterCbb2";
            this.quarterCbb2.Size = new System.Drawing.Size(74, 21);
            this.quarterCbb2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quý:";
            // 
            // nameWine2Cbb
            // 
            this.nameWine2Cbb.FormattingEnabled = true;
            this.nameWine2Cbb.Location = new System.Drawing.Point(338, 126);
            this.nameWine2Cbb.Name = "nameWine2Cbb";
            this.nameWine2Cbb.Size = new System.Drawing.Size(112, 21);
            this.nameWine2Cbb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sản phẩm:";
            // 
            // runBt
            // 
            this.runBt.Location = new System.Drawing.Point(836, 100);
            this.runBt.Name = "runBt";
            this.runBt.Size = new System.Drawing.Size(68, 20);
            this.runBt.TabIndex = 13;
            this.runBt.Text = "Hiển thị";
            this.runBt.UseVisualStyleBackColor = true;
            // 
            // refreshBt
            // 
            this.refreshBt.BackColor = System.Drawing.SystemColors.Control;
            this.refreshBt.FlatAppearance.BorderSize = 0;
            this.refreshBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.refreshBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBt.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.refreshBt.IconColor = System.Drawing.Color.DodgerBlue;
            this.refreshBt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refreshBt.IconSize = 20;
            this.refreshBt.Location = new System.Drawing.Point(877, 124);
            this.refreshBt.Name = "refreshBt";
            this.refreshBt.Size = new System.Drawing.Size(27, 22);
            this.refreshBt.TabIndex = 14;
            this.refreshBt.UseVisualStyleBackColor = false;
            // 
            // RevenueUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBt);
            this.Controls.Add(this.runBt);
            this.Controls.Add(this.yearCbb2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quarterCbb2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameWine2Cbb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yearCbb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quarterCbb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameWine1Cbb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.revenueChart);
            this.Name = "RevenueUC";
            this.Size = new System.Drawing.Size(1132, 541);
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nameWine1Cbb;
        private System.Windows.Forms.ComboBox quarterCbb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yearCbb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearCbb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox quarterCbb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nameWine2Cbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button runBt;
        private FontAwesome.Sharp.IconButton refreshBt;
    }
}
