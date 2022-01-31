using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Init(IEnumerable<T> values);   
    }
}
