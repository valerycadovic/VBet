using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.View
{
    public delegate void LoadMyBetsHandler(int id);

    public interface IMyBetsForm
    {
        int Id { get; }
        object DataSource { set; }

        event LoadMyBetsHandler LoadMyBets;
    }
}
