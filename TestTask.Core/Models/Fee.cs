using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Core.Models
{
    public class Fee
    {
        public int Id { get; set; }

        public string Zipcode { get; set; }

        public int FeeValue { get; set; }

        public int StateId { get; set; }

        public virtual State State { get; set; }
    }
}
