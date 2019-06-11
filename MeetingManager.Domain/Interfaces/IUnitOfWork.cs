using System;
using System.Threading.Tasks;

namespace MeetingManager.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        Task SaveAsync();
        void Commit();
        void Rollback();
    }
}
