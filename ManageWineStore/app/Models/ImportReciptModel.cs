using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class ImportReciptModel
    {
        public ImportReciptModel(int id, DateTime createAt,
                                int employeeId, int supplierId, double totalMoney)
        {
            Id = id;
            CreateAt = createAt;
            EmployeeId = employeeId;
            SupplierId = supplierId;
            TotalMoney = totalMoney;
        }

        public int Id { get; set; }
        public System.DateTime CreateAt { get; set; }
        public int EmployeeId { get; set; }
        public int SupplierId { get; set; }
        public double TotalMoney { get; set; }
    }
}
