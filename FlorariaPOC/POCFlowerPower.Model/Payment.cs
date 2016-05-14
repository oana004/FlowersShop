using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCFlowerPower.Model
{
   public class Payment
        /*
CREATE TABLE Payment(
PaymentId INT IDENTITY (1, 1) NOT NULL,
CVV INT NULL, 
AccountNumber VARCHAR (20),
CardExpirationDate DATETIME,
CardHolderName VARCHAR(100),
TransactionStatus VARCHAR(50),
PaymentDetails VARCHAR(200)
CONSTRAINT [pk_PaymentId] PRIMARY KEY CLUSTERED ([PaymentId] ASC),
)*/
    {
       public int Id { get; set; }
       public int CVV { get; set; }
       public string AccountNumber { get; set; }
       public DateTime CardExpirationDate { get; set; }
       public string CardHoulder { get; set; }
       public string TrasactionStatus { get; set; }
       public string PaymentDetails { get; set; }
    }
}
