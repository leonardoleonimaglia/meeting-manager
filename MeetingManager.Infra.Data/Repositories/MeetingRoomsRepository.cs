using System.Collections.Generic;
using System.Threading.Tasks;
using MeetingManager.Domain.Entities;
using MeetingManager.Domain.Interfaces;
using MeetingManager.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MeetingManager.Infra.Data.Repositories
{
    public class MeetingRoomsRepository : IMeetingRoomsRepository
    {
        private readonly UnitOfWork _unitOfWork;

        public MeetingRoomsRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        public async Task<List<MeetingRooms>> GetAsync()
        {
            return await _unitOfWork.Context.Set<MeetingRooms>().ToListAsync();
        }

        public async Task<MeetingRooms> GetByIdAsync(int id)
        {
            return await _unitOfWork.Context.Set<MeetingRooms>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(MeetingRooms meetingRooms)
        {
            _unitOfWork.Context.Set<MeetingRooms>().Add(meetingRooms);
        }

        public void Update(MeetingRooms meetingRooms)
        {
            _unitOfWork.Context.Set<MeetingRooms>().Update(meetingRooms);
        }
    }
}
