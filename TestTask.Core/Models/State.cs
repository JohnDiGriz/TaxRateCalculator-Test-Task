using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Core.Models
{
    public class State
    {
        public int Id { get; set; }

        public string Code { get; set; }


        public virtual IEnumerable<Fee> Fees { get; set; }

        public virtual IEnumerable<Tax> Taxes { get; set; }
    }
}
