using System;
namespace SmartHome.Devices
{
    public interface IDevice
    {
        string PairingCode { get; }
        string Description { get; }

        void ChangeStatus(bool switchOn);
    }
}
