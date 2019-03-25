using Anagrams.Games;
using Anagrams.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program : IUIHandler
    {
        static void Main(string[] args)
        {
            new Program().Play();

            Console.ReadKey(true);
        }

        public int AskForInt(string message = "")
        {
            int? convertedValue = null;
            do
            {
                string input = AskForString(message);
                try
                {
                    convertedValue = int.Parse(input);

                    if (convertedValue <= 0)
                        Console.WriteLine("il valore deve essere positivo");
                }
                catch (Exception)
                {
                    Console.WriteLine("L'input non è valido (selezionare una delle opzioni possibili in base al numero)");
                } 
            }
            while (!convertedValue.HasValue);

            return convertedValue.Value;
        }

        public string AskForString(string message = "")
        {
            if (!string.IsNullOrEmpty(message))
                Console.WriteLine(message);

            return Console.ReadLine();
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        private void Play()
        {

            IWordsRepository repo = new WordsRepository(new FileDictionaryLoader());

            List<IGameplay> games = new List<IGameplay>
            {
                new Training(repo)
            };

            IGameplay game = ChooseGame(games);
            game.Run(this);
        }

        private IGameplay ChooseGame(List<IGameplay> games)
        {
            IGameplay game = null;

            do
            {
                WriteMessage("Giochi disponibili");
                for (int i = 1; i <= games.Count; i++)
                {
                    WriteMessage($"{i}) {games[i - 1].Description}");
                }
                int gameOption = AskForInt();
                try
                {
                    game = games[gameOption - 1];
                }
                catch (Exception)
                {
                    WriteMessage("Opzione non valida (invio per continuare)");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (game == null);

            return game;
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
