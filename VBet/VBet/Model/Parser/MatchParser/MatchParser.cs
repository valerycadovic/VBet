using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.Parser.MatchParser
{
    /// <summary>
    /// Парсит документ, представленный в виде DOM
    /// </summary>
    public class MatchParser : IParser<Match[]>
    {
        public Match[] Parse(IHtmlDocument document)
        {
            var matchList = new List<Match>();


            var result = from item in document.QuerySelectorAll("tbody")
                         where item.ClassName != null
                         where !item.ClassName.Contains("props")
                         where !item.ClassName.Contains("spacer")
                         group item.Children[0].Children by item.Children[0].Children;


            foreach (var group in result)
            {
                foreach (var item in group)
                {
                    if (item[2].TextContent.Contains("Хозяева")) continue;


                    Match match = new Match();

                    match.Teams = item[2].Children[0].InnerHtml.Replace("<br>", " - ");
                    string date = item[1].InnerHtml.Replace("<br>", " ");
                    match.StartTime = DateTime.Parse(date.Insert(5, "/" + GetYear(date)));
                   
                    int i = 8;

                    foreach(var coeff in Available.Coeffs)
                    {
                        Coefficient coefficient = new Coefficient();

                        coefficient.Formula = coeff;
                        coefficient.Value = double.Parse(item[i++].TextContent.Replace(".", ","));

                        match.Coeffs.Add(coefficient);
                    }
                    
                    matchList.Add(match);
                }
            }

            return matchList.ToArray();
        }
     
        
        private string GetYear(string date)
        {
            int buf = int.Parse(date[3].ToString() + date[4].ToString());
            if (buf >= DateTime.Now.Month)
                return DateTime.Now.Year.ToString();
            else return (DateTime.Now.Year + 1).ToString();
        }
    }
}
