using System;
using System.Threading.Tasks;
using Hotels.Data;

namespace Hotels.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get;}
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}