using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Interfaces;

namespace TestTask.DAL.Services
{
    public class TaxCalculationSevice : ITaxCalculationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaxCalculationSevice(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<double> Calculate(string zipcode, string stateCode, string vehicleName)
        {
            var tax = await _unitOfWork.Taxes.GetCoefficient(stateCode, vehicleName);
            if (tax == null)
                throw new ValidationException($"Registration not supported for the {vehicleName} in {stateCode}");
            return (await _unitOfWork.Fees.GetFee(zipcode, stateCode)) * tax ?? 1;
        }
    }
}
