using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephRueResume.Models
{
    public class jobs
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string jobTitle { get; set; }

    }
}
