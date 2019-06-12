using System.Collections.Generic;
using System.Threading.Tasks;
using MeetingManager.Domain.Entities;
using MeetingManager.Domain.Interfaces;
using MeetingManager.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MeetingManager.Infra.Data.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UnitOfWork _unitOfWork;

        public UsersRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        public async Task<List<Users>> GetAsync()
        {
            return await _unitOfWork.Context.Set<Users>().ToListAsync();
        }

        public async Task<Users> GetByIdAsync(int id) 
        {
            return await _unitOfWork.Context.Set<Users>().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
