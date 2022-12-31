using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    public class Application
    {
        private readonly IParser _parser;
        public Application(IParser parser)
        {
            _parser= parser;
        }

        public string ParseSentence(string sentence)
        {
            return _parser.WordParser(sentence);
        }
    }
}
