using MeetingManager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetingManager.Domain.Interfaces.Repositories
{
    public interface IMeetingRoomsRepository
    {
        Task<List<MeetingRooms>> GetAsync();
        Task<MeetingRooms> GetByIdAsync(int id);
        void Add(MeetingRooms meetingRooms);
        void Update(MeetingRooms meetingRooms);
    }
}
