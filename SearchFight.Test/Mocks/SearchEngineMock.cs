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




    }
}
