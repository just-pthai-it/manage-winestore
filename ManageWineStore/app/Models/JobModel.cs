using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class JobModel
    {
        public JobModel(int id, string job_name, double salary)
        {
            this.id = id;
            this.job_name = job_name;
            this.salary = salary;
        }

        public int id { get; set; }
        public string job_name { get; set; }
        public double salary { get; set; }
    }
}
