using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchFight.Model;

namespace SearchFight.Test.Mocks
{
    public class SearchEngineMock
    {
        public string SearchEngineName
        {
            get { return "Google"; }
        }

        public string Address
        {
            get { return "https://www.google.com"; }
        }

        public SearchClientMock Client { get; set; }
        public SearchResultParserMock Parser { get; set; }

        public long ProcessQuery(string query)
        {
            string response = Client.GetResultString();
            string result = Parser.Parse(response);

            return long.Parse(result.Replace(",", "").Replace(".", ""));
        }

    }
}
