using System;
using System.Collections.Generic;
using SmartHome.Actuators;
using SmartHome.Devices;
using System.Linq;

namespace SmartHome
{
    public class SmartHub : IActionListener
    {
        readonly List<IDevice> _devices = new List<IDevice>();
        readonly List<IFeedbackListener> _listeners = new List<IFeedbackListener>();

        public void OnSwitchedOnChanged(IActuator actuator, bool isSwitchedOn)
        {
            bool check = _devices.Any(d => d.PairingCode == actuator.PairingCode);

            foreach (IDevice device in _devices.Where(d => d.PairingCode == actuator.PairingCode))
            {
                device.ChangeStatus(isSwitchedOn);
                NotifyFeedbackListeners(device, isSwitchedOn);
            }

            //foreach (IDevice device in _devices)
            //{
            //    if (device.PairingCode == actuator.PairingCode)
            //    {
            //        device.ChangeStatus(isSwitchedOn);
            //        NotifyFeedbackListeners(device, isSwitchedOn);
            //    }
            //}
        }

        public void RegisterActuators(params IActuator[] actuators)
        {
            //TODO check device for pairing code
            foreach (IActuator actuator in actuators)
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
            _listeners.ForEach(l => l.TakeFeedback(device, status));
            //foreach (IFeedbackListener listener in _listeners)
            //{
            //    listener.TakeFeedback(device, status);
            //}
        }
    }
}
