using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "1";

            do
            {
                Console.Clear();

                Console.WriteLine("\tDesafio do Balta 03\n");

                float alcohol = TextView.GetAlcoholPrice();

                float gasoline = TextView.GetGasolinePrice();

                float result = Calculator.Price.GetResult(alcohol, gasoline);

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                Console.WriteLine("\nResultados:\n");

                ResultData.GetBestChoice(result);

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                option = TextView.GetOption();
            } while (!option.Equals("0"));
        }
    }
}
