using System;
using System.Collections.Generic;

namespace StudentInformation.Models
{
    public class Material
    {
        public Guid ID { get; set; }
        public string Material { get; set; }
        public int Cost { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}