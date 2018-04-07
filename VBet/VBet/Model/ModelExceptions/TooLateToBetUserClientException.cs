using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.ModelExceptions
{
    /// <summary>
    /// Исключение, вызываемое при попытке поставить на матч, который начнется раньше, чем через 1 час или уже начался
    /// </summary>
    class TooLateToBetUserClientException : UserClientException
    {
        public TooLateToBetUserClientException(string message) : base(message) { }
    }
}
