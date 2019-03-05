using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = CheckBrackets(@"
                namespace Brackets
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            bool ok = CheckBrackets("")

                            Console.ReadLine();
                        }
                        static bool CheckBrackets(string text)
                        {

                        }
                    }
                }");

            string strOk = ok ? "OK" : "KO";
            Console.WriteLine($"Text is { strOk }");

            Console.ReadLine();
        }

        static List<char> openingBrackets = new List<char>() { '(', '[', '{' };
        static List<char> closingBrackets = new List<char>() { ')', ']', '}' };
        static bool CheckBrackets(string text)                 
        {
            //Spostato in inizializzatore
            //openingBrackets.Add('(');
            //openingBrackets.Add('[');
            //openingBrackets.Add('{');

            //Spostato in inizializzatore
            //closingBrackets.Add(')');
            //closingBrackets.Add(']');
            //closingBrackets.Add('}');

            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                //if (currentChar == '(' || currentChar == '[' || currentChar == '{')
                if (openingBrackets.Contains(currentChar))
                {
                    brackets.Push(currentChar);
                }
                //else if (currentChar == ')' || currentChar == ']' || currentChar == '}')
                else if (closingBrackets.Contains(currentChar))
                {
                    //spostato in metodo separato
                    //char correspondingOpeningBracket = ' ';
                    //if (currentChar == ')')
                    //    correspondingOpeningBracket = '(';
                    //else if (currentChar == ']')
                    //    correspondingOpeningBracket = '[';
                    //else if (currentChar == '}')
                    //    correspondingOpeningBracket = '{';

                    if (brackets.Count == 0)
                        return false;

                    if (brackets.Peek() == CorrespondingOpeningBracket(currentChar))
                        brackets.Pop();
                    else
                        return false;
                }
            }

            return brackets.Count == 0;
        }

        static char CorrespondingOpeningBracket(char closingBracket)
        {
            int closingIndex = closingBrackets.IndexOf(closingBracket);
            return openingBrackets[closingIndex];

            char correspondingOpeningBracket = ' ';
            if (closingBracket == ')')
                correspondingOpeningBracket = '(';
            else if (closingBracket == ']')
                correspondingOpeningBracket = '[';
            else if (closingBracket == '}')
                correspondingOpeningBracket = '{';

            return correspondingOpeningBracket;
        }

        #region Alternativa

        static Dictionary<char, char> _brackets = new Dictionary<char, char> {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        /// <summary>
        /// Verifica se il testo passato contiene un numero coerente di parentesi
        /// di apertura e chiusura "(", "[", "{"
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static bool CheckBrackets2(string text)
        {
            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (_brackets.ContainsKey(currentChar))
                {
                    brackets.Push(currentChar);
                }
                else if (_brackets.ContainsValue(currentChar))
                {
                    if (brackets.Count == 0)
                        return false;

                    if (brackets.Peek() == MatchingBracket(currentChar))
                        brackets.Pop();
                }
            }

            return brackets.Count == 0;
        }

        private static char MatchingBracket(char currentChar)
        {
            foreach (var item in _brackets)
            {
                if (item.Value == currentChar)
                    return item.Key;
            }

            return ' ';
        }

        #endregion
    }
}
