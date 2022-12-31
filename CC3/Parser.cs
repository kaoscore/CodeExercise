using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    public interface IParser
    {
        public string WordParser(string input);
    }

    public class Parser : IParser
    {
        private string ParserHelper(string word)
        {
            var parseString = new StringBuilder();

            switch(word.Length)
            {
                case 1:
                    parseString.Append(word);
                    break;
                case 2:
                    parseString.Append(word[0]);
                    parseString.Append(0);
                    parseString.Append(word[1]);
                    break;
                default:
                    parseString.Append(word[0]);
                    parseString.Append(word.Substring(1, word.Length - 2).Distinct().ToArray().Count());
                    parseString.Append(word[word.Length - 1]);
                    break;
            }
            return parseString.ToString();
        }

        public string WordParser(string input)
        {
            input= input.Trim() + " ";

            var parseString = new StringBuilder();
            var resultString = new StringBuilder();
            var onlyOneWord = true;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    parseString.Append(c);
                }
                else
                {
                    var word = parseString.ToString();
                    resultString.Append(ParserHelper(word));
                    resultString.Append(c);
                    parseString.Clear();
                    onlyOneWord = false;
                }
            }
            if (onlyOneWord)
                resultString.Append(ParserHelper(input));

            return resultString.ToString().Trim();
        }
    }
}
