using System;

namespace MeetingManager.Domain.Entities
{
    public class Reservations
    {
        public int Id { get; set; }
        public int WhoBooked { get; set; }
        public int MeetingRoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
