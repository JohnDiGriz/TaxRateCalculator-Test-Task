using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Models;

namespace TestTask.Core.Interfaces
{
    public interface ITaxRepository : IRepository<Tax>
    {
        Task<double?> GetCoefficient(string stateCode, string vehicleName);

        Task UpdateValidation(string stateCode, string vehicleName, double? newValue);
    }
}
