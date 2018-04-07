using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model
{
    static class Available
    {

        public static List<string> Leagues { get { return leagues; } }
        public static List<string> Coeffs { get { return coeffs; } }

        /// <summary>
        /// Список доступных лиг
        /// </summary>
        private static List<string> leagues = new List<string>
        {
                "anglija-premer-liga",
                "ispanija-primera",
                "italija-serija-a"
        };

        /// <summary>
        /// список доступных ставок
        /// </summary>
        private static List<string> coeffs = new List<string>
        {
            "П1",
            "Х",
            "П2"
        };
        
    }
}
