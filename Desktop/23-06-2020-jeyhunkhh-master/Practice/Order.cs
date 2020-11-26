using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    enum OrderStatus
    {
        Pending,
        Prepering,
        OnWay,
        Delivery
    }

    class Order
    {
        public OrderStatus Status { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
