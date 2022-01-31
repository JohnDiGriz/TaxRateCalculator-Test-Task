using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Core.Interfaces
{
    public interface ITaxCalculationService
    {
        Task<double> Calculate(string zipcode, string stateCode, string vehicleName);
    }
}
