using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.Parser
{
    public class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader loader;

        #region Properties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        #endregion

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.Settings = parserSettings;
        }

        public event Action<T, string> OnNewData;
        
        public async Task UpdatePartAsync(string league)
        {
            var source = await loader.GetSourceByUrl(league);
            var domParser = new HtmlParser();
            var document = await domParser.ParseAsync(source);
            var result = parser.Parse(document);

            OnNewData?.Invoke(result, league);

        }

    }
}
