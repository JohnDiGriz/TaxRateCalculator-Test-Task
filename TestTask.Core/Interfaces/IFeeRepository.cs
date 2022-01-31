using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Models;

namespace TestTask.Core.Interfaces
{
    public interface IFeeRepository : IRepository<Fee>
    {
        Task<int> GetFee(string zipcode, string stateCode);
    }
}
