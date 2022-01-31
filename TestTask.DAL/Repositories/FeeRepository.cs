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
    public class FeeRepository : Repository<Fee>, IFeeRepository
    {
        public FeeRepository(TaxContext context) : base(context) { }

        private IQueryable<Fee> Includes => Set_.Include(x => x.State);

        public async Task<int> GetFee(string zipcode, string stateCode)
        {
            return (await Includes.FirstOrDefaultAsync(x => x.Zipcode == zipcode && x.State.Code == stateCode)).FeeValue;
        }
    }
}
