using System;
namespace SmartHome.Actuators
{
    public interface IActionListener
    {
        void OnSwitchedOnChanged(IActuator actuator, bool isSwitchedOn);
    }
}
