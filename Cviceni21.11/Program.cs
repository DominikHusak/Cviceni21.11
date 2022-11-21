using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni21._11
{
    internal class Program
    {
        public static IEnumerable<string> KrasovaJezera()
        {
            yield return "Horní macošské jezírko";
            yield return "Dolní macošské jezírko";
            yield return "jezírko v Hranické propasti";
            yield return "Bozkovské podzemní jezero";
            yield return "Točnické jezírko";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Výpis jezer za použití cyklu foreach");
            foreach (string jezero in KrasovaJezera())
            {
                Console.WriteLine(jezero);
            }
            Console.WriteLine();
            Console.WriteLine("Výpis jezer pomocí enumerátoru (iterátoru) ");
            IEnumerator<string> enumerator = KrasovaJezera().GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            foreach (int a in Prvocisla(0, 67))
            {
                Console.WriteLine(a);
            }
        }
        public static IEnumerable<int> Stalisort(IList<int> list)
        {
            int predchozi = list[0];
            yield return list[0];

            for (int i = 1; i < list.Count; i++ )
            {
                if (predchozi < list[i])
                {
                    predchozi++;
                }

            }
        }

        public static IEnumerable<int> Prvocisla(int firstNum, int lastNum)
        {


            for(int num = firstNum; num < lastNum; num++)
            {
                bool jePrvocislo = true;   
                if (num < 2) jePrvocislo = false;
                if (num % 2 == 0) jePrvocislo = false;
                if (num == 2) jePrvocislo = true;
               

                int max = (int)Math.Sqrt(num);

                for (int i = 3; i <= max; i += 2)
                {
                    if (num % i == 0)
                    {
                        jePrvocislo = false;
                    }
                }

                if(jePrvocislo) yield return num;
            }
        }
    }
}
