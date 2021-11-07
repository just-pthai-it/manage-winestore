﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWineStore.app.Models
{
    class JobModel
    {
        public JobModel(int id, string jobName, double salary)
        {
            Id = id;
            JobName = jobName;
            Salary = salary;
        }

        public int Id { get; set; }
        public string JobName { get; set; }
        public double Salary { get; set; }
    }
}
