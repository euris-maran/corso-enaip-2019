using System;
using SmartHome.Devices;

namespace SmartHome.Actuators
{
    public class Switch : Actuator, IFeedbackListener
    {
        bool _isOn;

        public Switch(string pairingCode) : base(pairingCode)
        {
        }

        public void TakeFeedback(IDevice device, bool isOn)
        {
            if (device.PairingCode == PairingCode)
            {
                _isOn = isOn;
            }
        }

        public void Click()
        {
            _isOn = !_isOn;
            OnSwitchedOnChanged(_isOn);
        }
    }
}
