using ContactTracing_API.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ContactTracing_API.Data.Models
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public int BirthDate { get; set; }

        public string Province { get; set; }

        public string Region { get; set; }

        public string City { get; set; }

        public string Barangay { get; set; }

        public string Gender { get; set; }

        public string MobileNumber { get; set; }

        public string Password { get; set; }

        public Status Status { get; set; }
    }
}
