using System;
using _06Enum1.Entities.Enums;

namespace _06Enum1.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }

    public override string ToString() => Id + ", " + Moment + ", " + Status;
}