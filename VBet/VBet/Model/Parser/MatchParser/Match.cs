using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.Parser.MatchParser
{
    /// <summary>
    /// Информация о матче
    /// </summary>
    public class Match
    {
        public Match()
        {
            Coeffs = new List<Coefficient>();
        }

        public string Teams { get; set; }

        public DateTime StartTime { get; set; }

        public List<Coefficient> Coeffs { get; set; }
    }
}
