using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Events.Models
{
    public class UsersModel
    {
        [ForeignKey("CityID")]
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string City { get; set; }

        public bool isAdmin { get; set; }
    }
}
