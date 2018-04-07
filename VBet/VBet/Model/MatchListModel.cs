using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBet.Model.Parser;
using VBet.Model.Parser.MatchParser;

namespace VBet.Model
{
    public class MatchListModel
    {

        /// <summary>
        /// Асинхронно обновляет базу ближайших матчей, с помощью парсинга сайта Parimatch.by
        /// </summary>
        /// <returns></returns>
        public async Task UpdateLineAsync(IUpdater updater)
        {
            updater = new DatabaseParserUpdater();
            updater.OnCompleted += (obj) => { MessageBox.Show("updated"); };

            await updater.UpdateStorageAsync();

        }
    }
}
