using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFight.Test.Mocks
{
    public class SearchClientMock
    {
        public string GetResultString()
        {
            var stream = File.OpenRead("responseString.txt");
            StreamReader reader = new StreamReader(stream);
            string response = reader.ReadToEnd();
            return response;
        }
    }
}
