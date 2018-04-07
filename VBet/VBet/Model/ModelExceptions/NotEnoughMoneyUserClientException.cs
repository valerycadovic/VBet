using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.ModelExceptions
{
    /// <summary>
    /// Исключение, возникающее при попытке сделать ставку, на которую не хватает средств
    /// </summary>
    class NotEnoughMoneyUserClientException : UserClientException
    {
        public NotEnoughMoneyUserClientException(string message) : base(message) { }
    }
}
