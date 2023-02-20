using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta03
{
    internal static class ResultData
    {
        public static void GetBestChoice(float result)
        {
            if (result <= 0.65)
            {
                Console.WriteLine($"O coeficiente foi de {result * 100}%");
                Console.WriteLine($"Portanto é mais eficiente abastecer com gasolina!");
            }
            else 
            {
                if (result >= 0.65 && result <= 0.72)
                {
                    Console.WriteLine($"O coeficiente foi de {result * 100}%");
                    Console.WriteLine($"Portanto é mais eficiente abastecer com álcool!");
                } else
                {
                    Console.WriteLine($"O coeficiente foi de {result * 100}%");
                    Console.WriteLine($"Portantp é mais eficiente abastecer tanto com álcool como com gasolina!");
                }
            }
        }
    }
}
