using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject.Interfaces
{
    public interface ICustomer
    {
        int ID { get; set; }

        string Name { get; set; }

        string Surname { get; set; }

        string PhoneNumber { get; set; }

        string Address { get; set; }
    }
}
