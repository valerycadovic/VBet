using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBet.Model.DatabaseApi.MatchLine;
using VBet.Model.DatabaseApi.UserData;
using VBet.Model.DatabaseApi.UserData.Tables;
using VBet.Model.ModelExceptions;

namespace VBet.Model
{
    public class BetListModel
    {
        public void PlaceBet(string teams, string formula, double coefficient, int id, double price, DateTime date)
        {
            using (UserDataContext db = new UserDataContext())
            {
                BetEntity bet = new BetEntity();

                bet.Holder = db.Users.Find(id);

                if (bet.Holder.Cash >= price)
                {
                    db.Users.Find(id).Cash -= price;
                }
                else throw new NotEnoughMoneyUserClientException("Недостаточно средств!");
                

                bet.Date = date;
                bet.Coeff = coefficient;
                bet.Teams = teams;
                bet.Formula = formula;
                bet.BetPrice = price;
                

                db.Bets.Add(bet);
                db.SaveChanges();
            }

            MessageBox.Show("Готово!");
        }
        
        public object LoadCoeffs(string teams)
        {
            object data;

            using (MatchesContext db = new MatchesContext())
            {
                db.Coeffs.Where(p => p.Holder.Teams == teams).Load();
                data = db.Coeffs.Local.ToBindingList();
            }

            return data;
        }

        public object LoadMyBets(int id)
        {
            object data;

            using (UserDataContext db = new UserDataContext())
            {
                db.Bets.Where(p => p.HolderId == id).Load();
                data = db.Bets.Local.ToBindingList();
            }

            return data;
        }
    }
}
