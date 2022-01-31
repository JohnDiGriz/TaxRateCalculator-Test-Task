using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Interfaces;

namespace TestTask.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TaxContext _context;

        protected virtual DbSet<T> Set_ { get { return _context.Set<T>(); } }

        public Repository(TaxContext context) {
            _context = context;
        }


        public async Task Init(IEnumerable<T> values)
        {
            await Set_.AddRangeAsync(values);
        }
    }
}
