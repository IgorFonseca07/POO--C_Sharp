using System;
using System.Collections.Generic;

namespace Generics
{
    class CalculationService   //O Generics pode ser tb em métodos e interfaces, como no método abaixo:
    {                          //Repare que essa clase não se apresenta Generica

        public T Max<T>(List<T> list) where T : IComparable  //Como é generico e há uma comparação abaixo, precisa-se
        {                                                    //definir a comparação com CompareTo (IComparable)
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The list can not be empty!");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
