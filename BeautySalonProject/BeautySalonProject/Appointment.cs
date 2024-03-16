using BeautySalonProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject
{
    public class Appointment
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime Expiry { get; set; }

        public IEmployee Employee { get; set; }
    }
}
