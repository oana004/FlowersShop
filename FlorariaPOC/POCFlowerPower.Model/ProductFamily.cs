using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace POCFlowerPower.Model
{

    /*CREATE TABLE ProductFamily(
ProductFamilyId  INT IDENTITY (1, 1) NOT NULL,
FamilyName VARCHAR(150) NULL,
Specifications VARCHAR (250) NULL,
CONSTRAINT [pk_ProductFamilyId] PRIMARY KEY CLUSTERED ([ProductFamilyId] ASC),
)*/
    public class ProductFamily
    {
        public int Id { get; set; }
        [Required]
        public string FamilyName { get; set; }
        public string Specifications { get; set; }

        public virtual ICollection<Product> ProductsList { get; set; }

    }
}

