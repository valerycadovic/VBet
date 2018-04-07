using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBet.Model.DatabaseApi.MatchLine;
using VBet.Model.DatabaseApi.MatchLine.Tables;
using VBet.Presenter;
using VBet.View;
using VBet.View.MessageBoxService;

namespace VBet
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (MatchesContext db = new MatchesContext())
            //{
            //    MatchEntity match = new MatchEntity();
            //    CoeffEntity coeff = new CoeffEntity();

            //    match.League = "EPL";
            //    match.StartTime = DateTime.Parse("10/12/2017 19:30");
            //    match.Teams = "Манчестер Юнайтед - Манчестер Сити";

            //    coeff.Formula = "П1";
            //    coeff.Coefficient = 3.25;
            //    coeff.Holder = match;

            //    db.Matches.Add(match);
            //    db.SaveChanges();

            //    db.Coeffs.Add(coeff);
            //    db.SaveChanges();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var startForm = new AuthorizationForm();
            var model = new Model.UserListModel();
            var messageService = new MessageBoxService();

            var AuthPresenter = new AuthorizationFormPresenter(startForm, model, messageService);

            Application.Run(startForm);
        }
    }
}
