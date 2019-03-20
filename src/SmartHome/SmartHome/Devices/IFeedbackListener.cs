using System;
using SmartHome.Devices;

namespace SmartHome
{
    public interface IFeedbackListener
    {
        void TakeFeedback(IDevice device, bool isOn);
    }
}
