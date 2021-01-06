﻿using ExemploEnum.Entities.Enuns;
using System;

namespace ExemploEnum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
