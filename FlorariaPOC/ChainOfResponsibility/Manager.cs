using System;

namespace ChainOfResponsibility
{
    internal class Manager: Approver
    {
        public override void ProcessRequest(Order order)
        {
            Console.WriteLine(order.Amount > 30000 ? $"{GetType().Name} approved request# {order.Number}" : $"Request# {order.Number} requires an executive meeting!");
        }
    }
}
