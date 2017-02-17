using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchFight.Model
{
    public static class QueryValidator
    {
        private static Regex _regx;

        static QueryValidator()
        {
            _regx = new Regex(@"");
        }

        public static void Validate(string query)
        {
            
        }
    }
}
