
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCFlowerPower.Model
{
    public class OrderProduct
        /* CREATE TABLE OrderProducts(
OrderProdId INT IDENTITY (1, 1) NOT NULL,
ProductId INT NOT NULL,
OrderId INT NOT NULL,
NumberOfProducts INT, 
CONSTRAINT [pk_OrderProdId] PRIMARY KEY CLUSTERED ([OrderProdId] ASC),
CONSTRAINT [fk_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId]),
CONSTRAINT [fk_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]),
)
*/
    {
        public int Id { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

        [DisplayName("Number of Products")]
        public int NumberOfProducts  { get; set; }
        
    }
}
