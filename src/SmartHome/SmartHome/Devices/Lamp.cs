using System;
namespace SmartHome.Devices
{
    public class Lamp : IDevice
    {
        bool _isOn;

        public Lamp(string description, string pairingCode)
        {
            PairingCode = pairingCode;
            Description = description;
        }

        public string PairingCode { get; }

        public string Description { get; }

        public void ChangeStatus(bool switchOn)
        {
            _isOn = switchOn;
        }
    }
}
