using System.Threading.Tasks;
using MeetingManager.Domain.Interfaces;
using MeetingManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace MeetingManager.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        IDbContextTransaction _transaction;
        public MeetingManagerContext Context;

        public void InitializeContext(bool startTransaction)
        {
            Context = new MeetingManagerContext();

            if (startTransaction)
                InitializeTransaction();
        }

        private void InitializeTransaction() =>
            _transaction = Context.Database.BeginTransaction();

        public void Dispose()
        {
            _transaction?.Dispose();
            Context?.Dispose();
        }

        public void Save() =>
            Context?.SaveChanges();

        public async Task SaveAsync() =>
            await Context.SaveChangesAsync();

        public void Commit()
        {
            Context?.SaveChanges();
            _transaction?.Commit();
        }

        public void Rollback() =>
            _transaction?.Rollback();
    }
}