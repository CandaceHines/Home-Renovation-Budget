using System;

namespace HomeRenoBudget.Models
{
    public enum TotalCost
    {
        A, B, C, D, F
    }

    public class Appliance
    {
        public Guid ID { get; set; }
        public Guid MinCost { get; set; }
        public Guid MaxCost { get; set; }
        public TotalCost? TotalCost { get; set; }
        public Student Budget { get; set; }
    }
}
