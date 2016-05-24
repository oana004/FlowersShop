using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using System.ComponentModel;

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
       [Required]
       public int CVV { get; set; }
       [Required]
       [DisplayName("Account Number")]
        public string AccountNumber { get; set; }
       [Required]

       [DisplayName("Card Expiration Date")]
        public DateTime CardExpirationDate { get; set; }
       [Required]

       [DisplayName("Card Houlder")]
        public string CardHoulder { get; set; }

        [DisplayName("Transaction Status")]
        public string TrasactionStatus { get; set; }

        [DisplayName("Payment Details")]
        public string PaymentDetails { get; set; }
    }
}
