using System;

namespace MeetingManager.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
