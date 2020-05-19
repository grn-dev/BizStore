using Core.Domian;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contract
{
    public interface IOrderRepo:IRepository<Order>
    {
        void SaveOrder(Order order);
        //Order Find(int id);
        void SetTransactionId(int orderId, string token);
        void SetPaymentDone(string factorNumber);

        List<OrderHeader> Search(bool? Shipped);
        void Ship(int orderId);
    }
}
