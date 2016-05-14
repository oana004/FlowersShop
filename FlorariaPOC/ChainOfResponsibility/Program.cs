using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            Approver john = new Manager();
            Approver mary = new Accountant();

            mary.SetSuccessor(john);

            var ordersList = new List<Order>
            {
                new Order(101, 10000, "Small Bouquet"),
                new Order(102, 25000, "Big Bouquet"),
                new Order(103, 700000, "XXL Bouquet")
            };

            foreach(var order in ordersList)
            {
                mary.ProcessRequest(order);
            }

            Console.ReadKey();
        }
    }
}
