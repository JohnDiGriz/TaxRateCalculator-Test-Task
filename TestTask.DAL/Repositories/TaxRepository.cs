using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Interfaces;
using TestTask.Core.Models;

namespace TestTask.DAL.Repositories
{
    public class TaxRepository : Repository<Tax>, ITaxRepository
    {
        public TaxRepository(TaxContext context) : base(context) { }

        private IQueryable<Tax> Includes => Set_.Include(x => x.State).Include(x=>x.Vehicle);

        public async Task<double?> GetCoefficient(string stateCode, string vehicleName)
        {
            return (await Includes.FirstOrDefaultAsync(x => x.State.Code == stateCode && x.Vehicle.Name == vehicleName)).Coefficient;
        }

        public async Task UpdateValidation(string stateCode, string vehicleName, double? newValue)
        {
            var el = await Includes.FirstOrDefaultAsync(x => x.State.Code == stateCode && x.Vehicle.Name == vehicleName);
            el.Coefficient = newValue;
            Set_.Update(el);
        }
    }
}
