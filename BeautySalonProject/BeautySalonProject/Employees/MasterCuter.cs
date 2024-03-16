using BeautySalonProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject.Employees
{
    public class MasterCuter : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public string Role { get; set; }
        public int AppointmentFee { set; get; }

        public string CuttingFee()
        {
            throw new NotImplementedException();
        }
    }
}
