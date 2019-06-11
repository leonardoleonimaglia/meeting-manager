namespace MeetingManager.Domain.Entities
{
    public class MeetingRooms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public int PeopleLimit { get; set; }
        public bool HasTelevision { get; set; }
        public bool HasWiredNetwork { get; set; }
        public bool HasProjector { get; set; }
    }
}
