using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Core.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Tax> Taxes { get; set; }
    }
}
