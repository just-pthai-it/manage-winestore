using ManageWineStore.app.Models;
using ManageWineStore.app.Views.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC;

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
            this.adminBts.Add(this.revenueBt);
            this.adminBts.Add(this.wineMnBt);
            this.adminBts.Add(this.employeeMnBt);
            this.adminBts.Add(this.storageMnBt);
            this.adminBts.Add(this.accountMnBt);
            this.adminBts.Add(this.profileBt);

            this.employeeBts.Add(this.importBt);
            this.employeeBts.Add(this.sellBt);
            this.employeeBts.Add(this.wineMnBt);
            this.employeeBts.Add(this.storageMnBt);
            this.employeeBts.Add(this.profileBt);
        }
        private void setUp(string name)
        {
            int x = 12, y = 41;
            this.label1.Text = this.label1.Text + " " + name;
            if (this.adminModel != null)
            {
                foreach (Button bt in this.adminBts)
                {
                    bt.Location = new Point(x, y);
                    this.menuGrb.Controls.Add(bt);
                    y += 43;
                }
            }
            else
            {
                foreach (Button bt in this.employeeBts)
                {
                    bt.Location = new Point(x, y);
                    this.menuGrb.Controls.Add(bt);
                    y += 43;
                }
            }
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            this.workplacePnl.Controls.Clear();
        }
        private void sellBt_Click(object sender, EventArgs e)
        {
            this.workplacePnl.Controls.Clear();
            SellerUC seller = new SellerUC(1);
            seller.Dock = DockStyle.Fill;
            this.workplacePnl.Controls.Add(seller);
        }

        private void employeeMnBt_Click(object sender, EventArgs e)
        {
            this.workplacePnl.Controls.Clear();
            EmployeeUC employee = new EmployeeUC();
            employee.Dock = DockStyle.Fill;
            this.workplacePnl.Controls.Add(employee);
        }

        private void storageMnBt_Click(object sender, EventArgs e)
        {
            this.workplacePnl.Controls.Clear();
            StorageUC storage = new StorageUC();
            storage.Dock = DockStyle.Fill;
            this.workplacePnl.Controls.Add(storage);
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.adminModel = null;
            this.employeeModel = null;
        }

    }
}
