using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.Parser.MatchParser
{
    public class MatchSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://www.parimatch.by";

        public string Prefix { get; set; } = "sport/futbol/{competition}";
    }
}
