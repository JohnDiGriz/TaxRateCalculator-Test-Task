using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Core.Interfaces;
using TestTask.Core.Models;

namespace TestTask.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaxContext _context;
        public UnitOfWork(TaxContext context, IFeeRepository fees, ITaxRepository taxes, IRepository<State> states, IRepository<Vehicle> vehicles)
        {
            _context = context;
            Fees = fees;
            Taxes = taxes;
            States = states;
            Vehicles = vehicles;
        }

        public IFeeRepository Fees { get; private set; }
        public ITaxRepository Taxes { get; private set; }
        public IRepository<State> States { get; private set; }
        public IRepository<Vehicle> Vehicles { get; private set; }

        public int Commit()
        {
           return _context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
