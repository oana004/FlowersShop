using System;

namespace ChainOfResponsibility
{
    class Accountant: Approver
    {
        public override void ProcessRequest(Order order)
        {
            if(order.Amount < 25000.0)
            {
                Console.WriteLine($"{GetType().Name} approved request# {order.Number}");
            }
            else
            {
                Successor?.ProcessRequest(order);
            }
        }
    }
}
