﻿using System;
using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PurchaseHistory> PurchaseHistory { get; set; }
        public double CashBalance { get; set; }
    }

    public class PurchaseHistory
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string RestaurantName { get; set; }
        public double TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
