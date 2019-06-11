using MeetingManager.Domain.Interfaces;

namespace MeetingManager.Infra.Data.Factories
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkFactory(IUnitOfWork unitOfWork) =>
            _unitOfWork = unitOfWork;

        public IUnitOfWork StartUnitOfWork()
        {
            ((UnitOfWork)_unitOfWork).InitializeContext(false);

            return _unitOfWork;
        }

        public IUnitOfWork StartUnitOfWorkWithTransaction()
        {
            ((UnitOfWork)_unitOfWork).InitializeContext(true);

            return _unitOfWork;
        }
    }
}
