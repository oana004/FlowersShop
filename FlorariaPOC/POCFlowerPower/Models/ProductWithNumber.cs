using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using POCFlowerPower.Model;
using System.ComponentModel;

namespace POCFlowerPower.Models
{
    public class ProductWithNumber :Product
    {
        [DisplayName("Number of Products")]
        public int NrOfProducts { get; set; }
        


       
    }
}