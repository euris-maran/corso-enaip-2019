using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphores
{
    class Semaphore
    {
        public const string RED = "RED";
        public const string YELLOW = "YELLOW";
        public const string GREEN = "GREEN";

        string _currentLight;

        public Semaphore(string initialState)
        {
            _currentLight = initialState;
        }

        public string CurrentState
        {
            get
            {
                return _currentLight;
            }
        }

        public string NextLight()
        {
            if (_currentLight == RED)
                _currentLight = GREEN;
            else if (_currentLight == GREEN)
                _currentLight = YELLOW;
            else
                _currentLight = RED;


            return _currentLight;
        }
    }
}
