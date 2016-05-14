using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCFlowerPower.Model
{
    public class Order
        /*CREATE TABLE Orders(
OrderId INT IDENTITY (1, 1) NOT NULL,
UserId INT NOT NULL, 
OrderStatus VARCHAR(50), 
OrderDetails VARCHAR(250),
OrderDate DATETIME, 
PaymentId INT, 
CONSTRAINT [pk_OrderId] PRIMARY KEY CLUSTERED ([OrderId] ASC),
CONSTRAINT [fk_OrdeuserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]),
)
*/
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public string OrderStatus { get; set; }
        public string OrderDetails { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Payment Payment { get; set; }

    }
}
