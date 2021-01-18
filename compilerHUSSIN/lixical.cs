using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace compilerHUSSIN
{
    class LaxicalLayer
    {
        public static string formatting(string codeText)
        {
            foreach (var symbol in alphbet.symbolsAndOperators)
            {
                codeText = codeText.Replace(symbol.ToString(), " " + symbol + " ").Replace("  ", " ");
            }
            return codeText;
        }
        public static List<string> codeSpilted(string codeText)
        => codeText.Split(' ').ToList();
        public static List<Token> stringToToken(string codeText)
            => codeSpilted(codeText).ConvertAll((part) => new Token(part));
    }
}
