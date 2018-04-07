using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.ModelExceptions
{
    /// <summary>
    /// Исключение, возникающее при введении пустой строки
    /// </summary>
    public class EmptyParameterException : UserClientException
    {
        public EmptyParameterException(string message) : base(message) { }
    }
}
