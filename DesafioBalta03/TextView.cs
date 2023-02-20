using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta03
{
    internal static class TextView
    {
        public static float GetAlcoholPrice()
        {
            Console.Write("Informe o preço do ácool (em R$): ");
            return float.Parse(Console.ReadLine().Replace(',', '.'));
        }

        public static float GetGasolinePrice()
        {
            Console.Write("Informe o preço da gasolina (em R$): ");
            return float.Parse(Console.ReadLine().Replace(',', '.'));
        }

        public static string GetOption()
        {
            Console.Write("Deseja refazer (1 para Sim / 0 para Não): ");
            return Console.ReadLine();
        }
    }
}
