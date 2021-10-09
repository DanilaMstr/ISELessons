using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;

namespace _2.Lesson_FactoryMethod
{
    public static class Baker
    {
        public static T Create<T>() where T: AbstractFlourProduct, new()
        {
            try
            {
                var newProduct = new T();
                newProduct.Cooking();

                return newProduct;
            }
            catch (TargetInvocationException e)
            {
                var edi = ExceptionDispatchInfo.Capture(e.InnerException);
                edi.Throw();

                return default(T);
            }
        }
    }
}
