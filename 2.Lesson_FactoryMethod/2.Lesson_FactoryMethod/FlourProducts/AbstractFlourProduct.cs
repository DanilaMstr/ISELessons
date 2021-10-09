using System;
using System.Collections.Generic;

namespace _2.Lesson_FactoryMethod
{
    public abstract class AbstractFlourProduct
    {
        public decimal Price { get; set; }

        public DateTime ValidFor { get; set; }

        public List<string> Recipe { get; set; } = new List<string>();

        public abstract void Cooking();
    }
}
