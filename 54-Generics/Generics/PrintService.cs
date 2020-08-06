using System;

namespace Generics
{
    class PrintService<T> //Você pode parametrizar sua classe para definir de que tipo ela será no programa principal!
    {                     //Assim você pode usar todos esses recursos aqui em qualquer tipo que você instanciar!

        private T[] Values = new T[10];
        private int Count = 0;

        public void AddValue(T value)
        {
            if (Count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            Values[Count] = value;
            Count++;
        }

        public T First()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return Values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < Count; i++)
            {
                if (i == (Count - 1))
                {
                    Console.Write(Values[i]);
                }
                else
                {
                    Console.Write(Values[i] + ", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
