using ManageWineStore.app.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ManageWineStore.app.Views.UC
{
    public partial class RevenueUC : UserControl
    {
        private RevenueController revenueController = new RevenueController();

        public RevenueUC()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.loadCbbData();
            this.loadWineCbbData();

            this.timeCbb.SelectedIndex = 0;
            this.yearCbb.SelectedIndex = 0;
            this.startYearCbb.SelectedIndex = 0;
            this.endYearCbb.SelectedIndex = 0;
            this.chartTypeCbb.SelectedIndex = 0;
        }

        private void loadWineCbbData()
        {
            this.wineCbb.DisplayMember = "wine_name";
            this.wineCbb.ValueMember = "id";
            DataTable dataTable = this.revenueController.getWines();
            DataRow newRow = dataTable.NewRow();
            newRow[0] = "0";
            newRow[1] = "Tất cả";
            dataTable.Rows.InsertAt(newRow, 0);

            this.wineCbb.DataSource = dataTable;
        }

        private void loadCbbData()
        {
            int year = int.Parse(DateTime.Now.ToString("yyyy"));
            for (int i = 0; i < 10; i++)
            {
                this.yearCbb.Items.Add((year - i).ToString());
                this.startYearCbb.Items.Add((year - i).ToString());
                this.endYearCbb.Items.Add((year - i).ToString());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.timeCbb.Enabled = !this.radioButton2.Checked;
            this.yearCbb.Enabled = !this.radioButton2.Checked;

            this.startYearCbb.Enabled = this.radioButton2.Checked;
            this.endYearCbb.Enabled = this.radioButton2.Checked;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
            {
                return;
            }

            this.radioButton2.Checked = true;
            this.radioButton1.Checked = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                return;
            }

            this.radioButton1.Checked = true;
            this.radioButton2.Checked = false;
        }



        private void displayBt_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                return;
            }

            DataTable dataTable = this.getRevenue();
            var objChart = chart.ChartAreas[0];

            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Title = dataTable.Columns.Count == 5 ? "Quý" : "Tháng";

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = -50000;
            objChart.AxisY.Maximum = 50000;
            objChart.AxisY.Title = "Doanh thu (.000 vnđ)";

            StripLine stripline = new StripLine();
            stripline.Interval = 0;
            stripline.IntervalOffset = 0;
            stripline.StripWidth = 1;
            stripline.BackColor = Color.Red;
            chart.ChartAreas["ChartArea1"].AxisY.StripLines.Add(stripline);

            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;


            double startOffset = -0.5;
            double endOffset = 0.5;
            chart.ChartAreas[0].AxisX.CustomLabels.Clear();
            chart.Series.Clear();
            bool flag = false;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string location = this.radioButton1.Checked == true ? this.yearCbb.Text : "Nhiều năm";
                chart.Series.Add(location);
                chart.Series[location].ChartArea = "ChartArea1";

                chart.Series[location].ChartType = chartTypeCbb.Text == "Đường" ? System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line :
                                                                                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart.Series[location].BorderWidth = 3;
                chart.Series[location].IsValueShownAsLabel = true;
                chart.Series[location].Points.AddXY(0, 0);
                chart.ChartAreas[0].AxisX.CustomLabels.Add(startOffset++, endOffset++, "0");

                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    if (!flag)
                    {
                        if (radioButton1.Checked)
                        {
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(startOffset++, endOffset++, 
                                (j+1) == 13 || ((j+1) == 5 && dataTable.Columns.Count == 5 ) ? "Cả năm" : (j+1).ToString());

                        }
                        else
                        {
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(startOffset++, endOffset++, dataTable.Columns[j].ColumnName);
                        }
                    }

                    chart.Series[location].Points.AddXY(j + 1, Double.Parse(dataTable.Rows[i][j].ToString()));
                }
                flag = true;
            }
        }

        private DataTable getRevenue()
        {
            if (this.radioButton2.Checked == true)
            {
                return this.getYearRevenue();
            }

            return this.revenueController.getRevenue1(this.wineCbb.SelectedValue.ToString(), this.timeCbb.Text, this.yearCbb.Text);
        }

        private DataTable getYearRevenue()
        {
            DataTable dataTable = new DataTable();
            dataTable.Rows.InsertAt(dataTable.NewRow(), 0);
            for (int i = int.Parse(this.startYearCbb.Text); i <= int.Parse(this.endYearCbb.Text); i++)
            {
                DataTable dt = this.revenueController.getRevenue2(this.wineCbb.SelectedValue.ToString(), i.ToString());
                dataTable.Columns.Add(i.ToString(), typeof(System.String));
                dataTable.Rows[0][i.ToString()] = dt.Rows[0][0].ToString();
            }

            return dataTable;
        }

        private bool validate()
        {
            if (this.radioButton2.Checked)
            {
                if (int.Parse(this.startYearCbb.Text) > int.Parse(this.endYearCbb.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin");
                    return false;
                }
            }

            return true;
        }
    }
}
