using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assets.Models.Users
{
    public class ApplicationUser : BaseEntity
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth  { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}
