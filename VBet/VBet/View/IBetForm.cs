using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model.DatabaseApi.MatchLine.Tables;

namespace VBet.View
{

    public delegate void BetHandler(string teams, string formula, double coeff, double price);
    public delegate void EmptyHandler(string teams);

    public interface IBetForm
    {
        int Id { get; }
        double Cash { get; set; }
        string Teams { get; }
        DateTime StartTime { get; }
        object DataSource { set; }

        event BetHandler PlaceBet;
        event EmptyHandler LoadBets;
    }
}