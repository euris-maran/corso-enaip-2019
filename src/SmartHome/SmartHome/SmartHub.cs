using System;
using System.Collections.Generic;
using SmartHome.Actuators;
using SmartHome.Devices;

namespace SmartHome
{
    public class SmartHub : IActionListener
    {
        readonly List<IDevice> _devices = new List<IDevice>();
        readonly List<IFeedbackListener> _listeners = new List<IFeedbackListener>();

        public void OnSwitchedOnChanged(IActuator actuator, bool isSwitchedOn)
        {
            foreach (var device in _devices)
            {
                if (device.PairingCode == actuator.PairingCode)
                {
                    device.ChangeStatus(isSwitchedOn);
                    NotifyFeedbackListeners(device, isSwitchedOn);
                }
            }
        }

        public void RegisterActuators(params IActuator[] actuators)
        {
            //TODO check device for pairing code
            foreach (var actuator in actuators)
            {
                actuator.AddActionListener(this);
                if (actuator is IFeedbackListener)
                {
                    RegisterFeedbackListener((IFeedbackListener)actuator);
                }
            }
        }

        public void RegisterDevices(params IDevice[] devices)
        {
            _devices.AddRange(devices);
        }

        public void RegisterFeedbackListener(IFeedbackListener listener)
        {
            _listeners.Add(listener);
        }

        private void NotifyFeedbackListeners(IDevice device, bool status)
        {
            foreach (var listener in _listeners)
            {
                listener.TakeFeedback(device, status);
            }
        }
    }
}
