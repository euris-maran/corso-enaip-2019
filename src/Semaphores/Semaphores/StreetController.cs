using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphores
{
    class StreetController
    {
        Street[] _streets = new Street[2];
        private readonly int _yellowSeconds;
        private readonly int _goNoGoSeconds;

        public StreetController(int goNoGoSeconds, int yellowSeconds)
        {
            _yellowSeconds = yellowSeconds;
            _goNoGoSeconds = goNoGoSeconds;

            Street a = new Street("A");
            a.ConnectSemaphore(new Semaphore(Semaphore.RED));
            a.ConnectSemaphore(new Semaphore(Semaphore.RED));

            Street b = new Street("B");
            b.ConnectSemaphore(new Semaphore(Semaphore.GREEN));
            b.ConnectSemaphore(new Semaphore(Semaphore.GREEN));

            _streets[0] = a;
            _streets[1] = b;
        }

        public int NextState()
        {
            int timing;

            string aStreetState = _streets[0].CurrentState;
            string bStreetState = _streets[1].CurrentState;

            if (aStreetState == Semaphore.GREEN)
            {
                _streets[0].NextState();
                timing = _yellowSeconds;
            }
            else if (bStreetState == Semaphore.GREEN)
            {
                _streets[1].NextState();
                timing = _yellowSeconds;
            }
            else
            {
                _streets[0].NextState();
                _streets[1].NextState();
                timing = _goNoGoSeconds;
            }

            return timing;
        }

        public string StateDescription
        {
            get
            {
                return $"Street { _streets[0].Name }: {_streets[0].CurrentState } light; Street { _streets[1].Name }: { _streets[1].CurrentState } light";
            }
        }
    }
}
