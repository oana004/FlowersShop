using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace POCFlowerPower.Model
{
    public class User
    {


        /*        CREATE TABLE Users(
Id INT IDENTITY (1, 1) NOT NULL,
Username Varchar(100) NOT NULL,
Password Varchar(55) NOT NULL,
FullName Varchar(150) NULL, 
Birthdate DATETIME NULL, 
Email varchar(100) NULL, 
Active BIT,
CONSTRAINT[pk_userId] PRIMARY KEY CLUSTERED([UserId] ASC),
)*/
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Order> OrdersList { get; set; }
        public virtual ICollection<UserRole> UserRolesList { get; set; }
    }
}
