using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCFlowerPower.Model
{
    public class UserRole

        /*CREATE TABLE UserRoles(
UserRoleId INT IDENTITY (1, 1) NOT NULL,
UserId INT NOT NULL,
RoleId INT NOT NULL, 
Active BIT, 
RegistrationDate DATETIME,
CONSTRAINT [pk_userRoleId] PRIMARY KEY CLUSTERED ([UserRoleId] ASC),
CONSTRAINT [fk_userId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]),
CONSTRAINT [fk_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([RoleId]),
)*/
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}


   
