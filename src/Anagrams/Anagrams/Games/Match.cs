using Anagrams.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Games
{
    public class Match : IGameplay
    {
        int _rounds = 5;
        int _points = 0;

        static readonly TimeSpan TIMEOUT = TimeSpan.FromSeconds(10);
        private readonly IWordsRepository _wordsRepository;

        public string Description => "Scrivi un anagramma della parola proposta entro un tempo massimo.";

        public Match(IWordsRepository wordsRepository)
        {
            _wordsRepository = wordsRepository;
        }

        public void Run(IUIHandler uiHandler)
        {
            for (int i = 0; i < _rounds; i++)
            {
                uiHandler.WriteMessage();
                uiHandler.WriteMessage($"Turno { i + 1 }");
                uiHandler.WriteMessage("La parola è...");

                string word = _wordsRepository.GetRandomWord(5);
                uiHandler.WriteMessage(word.ToUpper());

                uiHandler.WriteMessage();
                uiHandler.WriteMessage("GO!!!!");
                DateTime startTime = DateTime.Now;

                DateTime? endTime = null;
                do
                {
                    string candidateWord = uiHandler.AskForString();

                    if (_wordsRepository.IsAnagram(word, candidateWord))
                    {
                        endTime = DateTime.Now;
                        uiHandler.WriteMessage($"Giusto! { candidateWord } è un anagramma di { word }");
                        break;
                    }
                    else
                    {
                        uiHandler.WriteMessage($"Non è corretto! Ti restano { TimeLeft(startTime) } secondi");
                    }
                }
                while (!TimeIsOver(startTime));

                int roundPoints = CalculateRoundPoints(startTime, endTime);
                uiHandler.WriteMessage($"Turno {i + 1} terminato. Hai conquistato { roundPoints } punti e in totale sei a { _points }");

                uiHandler.WriteMessage();
                uiHandler.AskForString("(invio per iniziare il prossimo turno)");
            }

            uiHandler.WriteMessage();
            uiHandler.WriteMessage($"Il gioco è terminato. Hai totalizzato { _points } punti");
        }

        private double TimeLeft(DateTime startTime)
        {
            var timeLeft = (TIMEOUT - (DateTime.Now - startTime)).TotalSeconds;

            return timeLeft < 0 ? 0 : timeLeft;
        }

        private int CalculateRoundPoints(DateTime startTime, DateTime? endTime)
        {
            int roundPoints = 0;

            if (endTime.HasValue)
            {
                TimeSpan elapsed = endTime.Value - startTime;
                if (elapsed <= TimeSpan.FromSeconds(5))
                {
                    roundPoints = 10;
                }
                else if (elapsed <= TimeSpan.FromSeconds(6))
                {
                    roundPoints = 6;
                }
                else if (elapsed <= TimeSpan.FromSeconds(7))
                {
                    roundPoints = 4;
                }
                else if (elapsed <= TimeSpan.FromSeconds(8))
                {
                    roundPoints = 2;
                }
                else if (elapsed <= TimeSpan.FromSeconds(9))
                {
                    roundPoints = 1;
                }
            }

            _points += roundPoints;

            return roundPoints;
        }

        private bool TimeIsOver(DateTime startTime)
        {
            return DateTime.Now - startTime > TIMEOUT;
        }
    }
}
