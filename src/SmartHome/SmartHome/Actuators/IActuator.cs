using System;
namespace SmartHome.Actuators
{
    public interface IActuator
    {
        string PairingCode { get; }

        void AddActionListener(IActionListener actionListener);
    }
}
