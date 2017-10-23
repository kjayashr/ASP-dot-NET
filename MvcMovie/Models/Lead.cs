using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLead.Models
{
    public class Lead
    {
        public int ID { get; set; }
        public string LeadName { get; set; }
        public DateTime StartDate { get; set; }
        public string Type { get; set; }
        public decimal Quote { get; set; }
    }
}
