using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.Parser.Exceptions
{
    /// <summary>
    /// Исключение ошибки загрузки данных с сайта
    /// </summary>
    public class ParserLoadHtmlException : ParserException
    {
        public ParserLoadHtmlException(string message) : base(message) { }
    }
}
