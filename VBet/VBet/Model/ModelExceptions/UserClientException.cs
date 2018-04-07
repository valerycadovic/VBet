using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model
{
    /// <summary>
    /// Исключение, возникающее при ошибке работы с базой бользователей
    /// </summary>
    public class UserClientException : Exception
    {
        public UserClientException(string message) : base(message) { }
    }
}
