using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model;
using VBet.Model.Parser.Exceptions;
using VBet.View;
using VBet.View.MessageBoxService;

namespace VBet.Presenter
{
    class MainFormPresenter
    {
        private readonly MatchListModel model;
        private readonly IMainForm mainForm;
        private readonly IMessageBoxService messageService;

        public MainFormPresenter(IMainForm mainForm, MatchListModel model, IMessageBoxService messageService)
        {
            this.mainForm = mainForm;
            this.model = model;
            this.messageService = messageService;

            this.mainForm.UpdateLine += MainForm_UpdateLine;

        }
        

        private async Task MainForm_UpdateLine()
        {
            try
            {
                await model.UpdateLineAsync(new DatabaseParserUpdater());
            }
            catch (ParserLoadHtmlException ex)
            {
                this.messageService.ShowError(ex.Message);
            }
        }
    }
}
