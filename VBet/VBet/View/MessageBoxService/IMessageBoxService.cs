using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.View.MessageBoxService
{
    public interface IMessageBoxService
    {
        void ShowMessage(string message);
        void ShowError(string error);
        void ShowExclamation(string exclamation);
    }
}
