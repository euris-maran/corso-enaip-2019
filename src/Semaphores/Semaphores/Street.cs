using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphores
{
    class Street
    {
        public Street(string name)
        {
            Name = name;
        }

        List<Semaphore> _semaphores = new List<Semaphore>();

        public string Name { get; }

        public string CurrentState
        {
            get
            {
                string state = null;
                foreach (var semaphore in _semaphores)
                {
                    //if (state != null && state != semaphore.CurrentState)
                    //errore
                    state = semaphore.CurrentState;
                }

                return state;
            }
        }

        public void NextState()
        {
            foreach (var semaphore in _semaphores)
            {
                semaphore.NextLight();
            }
        }

        public void ConnectSemaphore(Semaphore s)
        {
            _semaphores.Add(s);
        }
    }
}
