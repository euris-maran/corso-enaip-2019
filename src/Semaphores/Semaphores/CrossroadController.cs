using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphores
{
    class CrossroadController
    {
        Stop[] _Stops = new Stop[2];
        private readonly int _yellowSeconds;
        private readonly int _goNoGoSeconds;

        public CrossroadController(int goNoGoSeconds, int yellowSeconds)
        {
            _yellowSeconds = yellowSeconds;
            _goNoGoSeconds = goNoGoSeconds;

            Stop a = new Stop("A");
            a.ConnectSemaphore(new Semaphore(Semaphore.RED));
            a.ConnectSemaphore(new Semaphore(Semaphore.RED));

            Stop b = new Stop("B");
            b.ConnectSemaphore(new Semaphore(Semaphore.GREEN));
            b.ConnectSemaphore(new Semaphore(Semaphore.GREEN));

            _Stops[0] = a;
            _Stops[1] = b;
        }

        public int NextState()
        {
            int timing;

            string aStopState = _Stops[0].CurrentState;
            string bStopState = _Stops[1].CurrentState;

            if (aStopState == Semaphore.GREEN)
            {
                _Stops[0].NextState();
                timing = _yellowSeconds;
            }
            else if (bStopState == Semaphore.GREEN)
            {
                _Stops[1].NextState();
                timing = _yellowSeconds;
            }
            else
            {
                _Stops[0].NextState();
                _Stops[1].NextState();
                timing = _goNoGoSeconds;
            }

            return timing;
        }

        public string StateDescription
        {
            get
            {
                return $"Stop { _Stops[0].Name }: {_Stops[0].CurrentState } light; Stop { _Stops[1].Name }: { _Stops[1].CurrentState } light";
            }
        }
    }
}
