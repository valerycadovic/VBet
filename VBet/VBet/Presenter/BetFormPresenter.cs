using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model;
using VBet.Model.DatabaseApi.MatchLine;
using VBet.Model.DatabaseApi.MatchLine.Tables;
using VBet.Model.ModelExceptions;
using VBet.View;
using VBet.View.MessageBoxService;

namespace VBet.Presenter
{
    public class BetFormPresenter
    {
        private readonly IBetForm betForm;
        private readonly BetListModel model;
        private readonly IMessageBoxService messageService;

        public BetFormPresenter(IBetForm betForm, BetListModel model, IMessageBoxService messageService)
        {
            this.betForm = betForm;
            this.model = model;
            this.messageService = messageService;

            this.betForm.PlaceBet += BetForm_PlaceBet;
            this.betForm.LoadBets += BetForm_LoadBets;
        }

        private void BetForm_LoadBets(string teams)
        {
            this.betForm.DataSource = this.model.LoadCoeffs(teams);
        }

        private void BetForm_PlaceBet(string teams, string formula, double coeff, double price)
        {
            try
            {
                if (betForm.StartTime > DateTime.Now.AddHours(-1))
                    model.PlaceBet(teams, formula, coeff, betForm.Id, price, betForm.StartTime);
                else throw new TooLateToBetUserClientException("Матч стартует раньше, чем через час или уже стартовал.");

                betForm.Cash -= price;
            }
            catch (Exception ex)
            {
                messageService.ShowExclamation(ex.Message);
            }
        }
    }
}
