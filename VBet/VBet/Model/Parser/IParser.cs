using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.Parser
{
    public interface IParser<T> where T : class
    {
        /// <summary>
        /// Парсит документ, пердставленный в виде DOM
        /// </summary>
        /// <param name="document">документ</param>
        /// <returns>Результат парсинга в виде объекта необходимого класса</returns>
        T Parse(IHtmlDocument document);
    }
}
