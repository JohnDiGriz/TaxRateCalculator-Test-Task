using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Core.Models
{
    public class Tax
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public int StateId { get; set; }

        public double? Coefficient { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual State State { get; set; }
    }
}
