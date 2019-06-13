using System.Collections.Generic;
using System.Threading.Tasks;
using MeetingManager.Domain.Entities;

namespace MeetingManager.Domain.Interfaces.Repositories
{
    public interface IUsersRepository
    {
        Task<List<Users>> GetAsync();
        Task<Users> GetByIdAsync(int id);
        void Add(Users users);
        void Update(Users users);
    }
}
