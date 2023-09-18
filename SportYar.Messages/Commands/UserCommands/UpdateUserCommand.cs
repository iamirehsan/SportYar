using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Messages.Commands.UserCommands
{
    public class UpdateUserCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string? Province { get; set; }
        public string? City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string RegionId { get; set; }
        public string BanksCardNumber { get; set; }

    }
}
