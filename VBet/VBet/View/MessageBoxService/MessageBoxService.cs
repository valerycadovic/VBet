using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBet.View.MessageBoxService
{
    public class MessageBoxService : IMessageBoxService
    {
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
