﻿namespace Shop.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public List<Car> cars { get; set; }
    }
}
