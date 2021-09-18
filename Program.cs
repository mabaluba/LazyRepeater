using System;
using System.Collections.Generic;
using System.Linq;

namespace LazyRepeater
{
    class Program
    {
        public static void Main()
        {
            static Func<char> MakeLooper(string str)
            {
                int i = -1;
                Func<char> a = () =>
                {
                    i = (i < str.Length - 1) ? ++i : 0;
                    Console.WriteLine(str[i]);//вывод на консоль возвращаемого значения
                    return str[i];
                };
                return a;

                //var ind = str.GetEnumerator();
                /* return () =>
                 {
                     if (!ind.MoveNext())
                     {
                         ind.Reset();
                         ind.MoveNext();
                     }
                     return ind.Current; 
                 };*/

                /*int idx = 0;
                return () => str[idx++ % str.Length];*/
            }


            Func<char> abc = MakeLooper("abc");
            abc();//a
            abc();//b
            abc();//c
            abc();//a
            abc();//b

        }


    }
}
