﻿namespace pr37savichev.Data.Models
{
    public class ItemsBasket : Items
    {
        public int Count { get; set; }

        public ItemsBasket(int Count, Items item) : base(item)
        {
            this.Count = Count;
        }
    }
}
