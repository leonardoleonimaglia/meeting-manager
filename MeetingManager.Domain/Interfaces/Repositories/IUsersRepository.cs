using System.Threading.Tasks;
using MeetingManager.Domain.Entities;

namespace MeetingManager.Domain.Interfaces.Repositories
{
    public interface IUsersRepository
    {
        Task<Users> GetByIdAsync(int id);
    }
}
