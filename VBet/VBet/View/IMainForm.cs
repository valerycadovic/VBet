using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBet.View
{
    public delegate double CashHandler();
    public delegate Task UpdateHandler();
    
    public interface IMainForm
    {
        event EventHandler BetClick;
        event UpdateHandler UpdateLine;
        event CashHandler UpdateCash;

        UserStatus Status { get; }
        string UserName { get; }
        double Cash { get; }
        int Id { get; }

    }
}
