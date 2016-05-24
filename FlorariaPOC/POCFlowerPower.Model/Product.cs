using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using System.ComponentModel;

namespace POCFlowerPower.Model
{
    public class Product
    /*CREATE TABLE Product(
ProductId INT IDENTITY (1, 1) NOT NULL,
ProductName VARCHAR(150) NOT NULL, 
Price INT, 
DiscoutVal INT,
ProductFamilyId INT,
ProductDescription VARCHAR (250),
CONSTRAINT [pk_ProductId] PRIMARY KEY CLUSTERED ([ProductId] ASC),
CONSTRAINT [fk_ProductFamilyId] FOREIGN KEY ([ProductFamilyId]) REFERENCES [dbo].[ProductFamily] ([ProductFamilyId]),
)*/
    {

        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        public double Price { get; set; }
        [DisplayName("Discount Value")]
        public double DiscountVal { get; set; }
        public virtual ProductFamily ProductFamily { get; set; }
        [DisplayName("Product Description")]

        public string ProductDescription { get; set; }

        [DisplayName("Product Image")]
        public byte[] ProductImage { get; set; }
    }
}
