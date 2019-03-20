using System;
using System.Collections.Generic;
using SmartHome.Devices;

namespace SmartHome.Actuators
{
    public abstract class Actuator : IActuator
    {
        readonly List<IActionListener> _actionListeners = new List<IActionListener>();

        protected Actuator(string pairingCode)
        {
            PairingCode = pairingCode;
        }

        public string PairingCode { get; }

        public void AddActionListener(IActionListener actionListener)
        {
            _actionListeners.Add(actionListener);
        }

        protected void OnSwitchedOnChanged(bool isSwitchedOn)
        {
            foreach (var listener in _actionListeners)
            {
                listener.OnSwitchedOnChanged(this, isSwitchedOn);
            }
        }
    }
}
