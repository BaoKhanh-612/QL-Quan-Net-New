using System;
using System.Collections.Generic;

namespace Quan_Li_Tiem_Net
{
    public class PurchaseHistoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

    public static class PurchaseHistory
    {
        public static List<PurchaseHistoryItem> Items { get; } = new List<PurchaseHistoryItem>();
    }
}
