using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RubiconeX_Serv.DataAccsess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
        [Key] public int Id { get; set; }
        public int PhoneNumberPreFix { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronumic { get; set; }
        public string AvatarUrl { get; set; }
        public string Introdution { get; set; }
        public UserRoleRto Role { get; set; }




        [NotMapped]
        public string GetFullName
        {
            get => LastName + " " + FirstName + " " + Patronumic;
        }
    }
}
}
