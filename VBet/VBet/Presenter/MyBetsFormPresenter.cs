using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model;
using VBet.View;
using VBet.View.MessageBoxService;

namespace VBet.Presenter
{
    class MyBetsFormPresenter
    {
        private readonly BetListModel model;
        private readonly IMyBetsForm form;
        private readonly IMessageBoxService messageService;

        public MyBetsFormPresenter(IMyBetsForm form, BetListModel model, IMessageBoxService messageService)
        {
            this.model = model;
            this.messageService = messageService;
            this.form = form;

            this.form.LoadMyBets += Form_LoadMyBets;
        }

        private void Form_LoadMyBets(int id)
        {
            this.form.DataSource = this.model.LoadMyBets(id);
        }
    }
}
