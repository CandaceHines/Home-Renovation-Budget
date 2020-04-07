using System;
using System.Collections.Generic;

namespace HomeRenoBudget.Models
{
    public class Budget
    {
        public Guid ID { get; set; }
        public string Appliance { get; set; }
        public string Material { get; set; }
        public DateTime ProjectStart { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}