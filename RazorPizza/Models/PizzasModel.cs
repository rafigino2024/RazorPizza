﻿namespace RazorPizza.Models
{
    public class PizzasModel
    {
        public string? ImageTitle { get; set; }
        public string? PizzaName { get; set; }
        public float BasicPrice { get; set; }
        public bool Tomatosauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mashroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public float FinalPrice { get; set; }

    }
}
