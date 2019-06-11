namespace MeetingManager.Domain.Interfaces
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork StartUnitOfWork();
        IUnitOfWork StartUnitOfWorkWithTransaction();
    }
}
