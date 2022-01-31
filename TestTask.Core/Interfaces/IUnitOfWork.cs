using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Core.Models;

namespace TestTask.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IFeeRepository Fees { get; }

        ITaxRepository Taxes { get; }

        IRepository<State> States { get; }

        IRepository<Vehicle> Vehicles { get; }

        int Commit();
    }
}
