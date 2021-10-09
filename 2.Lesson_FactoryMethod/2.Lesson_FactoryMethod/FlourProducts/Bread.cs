using System;

namespace _2.Lesson_FactoryMethod.FlourProducts
{
    public class Bread : AbstractFlourProduct
    {
        public override void Cooking()
        {
            for (int i = 1; i < 3; i++)
                Recipe.Add($"Bread step {i}");

            Console.WriteLine("Start");
            foreach (var element in Recipe)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Complete");
        }
    }
}
