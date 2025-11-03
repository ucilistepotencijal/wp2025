

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorApp
{
    static class Kalkulator
    {
        /// <summary>
        /// Adds two decimal numbers and returns the result.
        /// </summary>
        /// <param name="prvi">The first decimal number.</param>
        /// <param name="drugi">The second decimal number.</param>
        /// <returns>The sum of the two decimal numbers.</returns>
        public static decimal Zbroji(decimal prvi, decimal drugi)
        {
            return prvi + drugi;
        }

        /// <summary>
        /// Računa kub broja
        /// </summary>
        /// <param name="broj"></param>
        /// <returns>x^3</returns>
        public static double Kub(double broj)
        {
            return Math.Pow(broj, 3); //1. način: broj * broj * broj;
        }

        /// <summary>
        /// Vraća udlajenost točaka (x1,x2) i (y1,y2)
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="y1"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double UdaljenostTocaka(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        /// <summary>
        /// Pretvara temperaturu iz stupnjeva Celzijusa u Fahrenheite
        /// </summary>
        /// <param name="stupnjevi"></param>
        /// <returns></returns>
        public static double CelzijFahrenheit(int stupnjevi)
        {
            return ((9 / 5) * stupnjevi + 32);
        }
    }
}