using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject.Interfaces
{
    public interface IEmployee
    {
        int Id { set;  get; }

        string Name { set;  get; }

        string Description { set; get; }

        int Salary { set; get; }

        string Role { set; get; }

        int AppointmentFee { set; get; }

        string CuttingFee();

    }
}
