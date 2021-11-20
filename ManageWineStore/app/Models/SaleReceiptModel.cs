using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class SaleReceiptModel
    {
        public SaleReceiptModel(DateTime createAt, 
                            int employeeId, int customerId, double totalMoney)
        {
            CreateAt = createAt;
            EmployeeId = employeeId;
            CustomerId = customerId;
            TotalMoney = totalMoney;
        }

        public int Id { get; set; }
        public System.DateTime CreateAt { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public double TotalMoney { get; set; }
    }
}
