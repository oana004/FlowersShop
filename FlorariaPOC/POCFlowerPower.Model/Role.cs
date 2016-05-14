using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCFlowerPower.Model
{  /* CREATE TABLE Roles(
RoleId  INT IDENTITY (1, 1) NOT NULL,
RoleName VARCHAR(55) NOT NULL,
CONSTRAINT [pk_roleId] PRIMARY KEY CLUSTERED ([RoleId] ASC),

)*/
  public class Role
    {

      public int Id { get; set; }
      public string RoleName { get; set; }
    }
}
