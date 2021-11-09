using ManageWineStore.app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormHome : Form
    {
        private AdminModel adminModel = null;
        private EmployeeModel employeeModel = null;
        private List<Button> adminBts = new List<Button>();
        private List<Button> employeeBts = new List<Button>();

        public FormHome()
        {
            InitializeComponent();
        }
        public FormHome(Object user)
        {
            InitializeComponent();
            if (user.GetType() == typeof(AdminModel))
            {
                this.adminModel = (AdminModel)user;
            }
            else
            {
                this.employeeModel = (EmployeeModel)user;
            }
            this.createListButton();
            this.setUp(this.adminModel == null ? this.employeeModel.Name : this.adminModel.Name);
        }

        private void createListButton()
        {
            this.adminBts.Add(this.btn_Infomation);
            this.adminBts.Add(this.btn_Data);
            this.adminBts.Add(this.btn_Finance);

            this.employeeBts.Add(this.btn_Sell);
            this.employeeBts.Add(this.btn_Infomation);
            this.employeeBts.Add(this.btn_Data);

        }
        private void setUp(string name)
        {
            int x = 12, y = 41;
            this.label1.Text = this.label1.Text + " " + name;
            if (this.adminModel == null)
            {
                foreach (Button bt in this.adminBts)
                {
                    bt.Location = new Point(x, y);
                    this.panel1.Controls.Add(bt);
                    y += 43;
                }
            }
            else
            {
                MessageBox.Show("fsddaf");
                foreach (Button bt in this.employeeBts)
                {
                    bt.Location = new Point(x, y);
                    this.panel1.Controls.Add(bt);
                    y += 43;
                }
            }
        }
    }
}
