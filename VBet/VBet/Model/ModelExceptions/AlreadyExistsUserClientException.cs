using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.ModelExceptions
{
    /// <summary>
    /// Исключение, возникающее при попытке повторно зарегистрировать пользователя на один и тот же адрес
    /// </summary>
    class AlreadyExistsUserClientException : UserClientException
    {
        public AlreadyExistsUserClientException(string message) : base(message) { }
    }
}
