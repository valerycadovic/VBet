using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.Parser.Exceptions
{
    /// <summary>
    /// Исключение ошибки парсера
    /// </summary>
    public class ParserException : Exception
    {
        public ParserException(string message) : base(message) { }
    }
}
