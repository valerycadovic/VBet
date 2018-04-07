using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VBet.Model.Parser.Exceptions;

namespace VBet.Model.Parser
{
    public class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        /// <summary>
        /// Получение исходного кода страницы по её URL
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<string> GetSourceByUrl(string address)
        {
            string source = string.Empty;

            var currentUrl = url.Replace("{competition}", address);

            try
            {
                var response = await client.GetAsync(currentUrl);

                if (response != null && response.StatusCode == HttpStatusCode.OK)
                {
                    source = await response.Content.ReadAsStringAsync();
                }
            }
            catch
            {
                throw new ParserLoadHtmlException("Ошибка доступа");
            }

           
            return source;
        }
    }
}
