using _2.Lesson_FactoryMethod.FlourProducts;

namespace _2.Lesson_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = Baker.Create<Cake>();
            var product2 = Baker.Create<Pancake>();
            var product3 = Baker.Create<Bread>();
        }
    }
}
