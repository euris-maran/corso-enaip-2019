using System;
using SmartHome.Actuators;
using SmartHome.Devices;

namespace SmartHome
{
    class Program : IFeedbackListener
    {
        static void Main(string[] args)
        {
            new Program().Run();
            Console.ReadKey(true);
        }

        public void Run() 
        {
            var smartHub = new SmartHub();

            var kitchenLamp = new Lamp("Kitchen lamp", "K1");
            var salonLamp = new Lamp("Salon lamp", "S1");
            var courtLamp = new Lamp("Court lamp", "C1");

            smartHub.RegisterDevices(kitchenLamp, salonLamp, courtLamp);

            var wallKitchenSwitch = new Switch("K1");
            var floatingKitchenSwitch = new Switch("K1");
            smartHub.RegisterActuators(wallKitchenSwitch, floatingKitchenSwitch);

            var entrySalonSwitch = new Switch("S1");
            var sofaSalonSwitch = new Switch("S1");
            var floatingSalonSwitch = new Switch("S1");
            smartHub.RegisterActuators(entrySalonSwitch, sofaSalonSwitch, floatingSalonSwitch);

            var inHouseCourtSwitch = new Switch("C1");
            var poolCourtSwitch = new Switch("C1");
            smartHub.RegisterActuators(inHouseCourtSwitch, poolCourtSwitch);

            smartHub.RegisterFeedbackListener(this);

            entrySalonSwitch.Click();
            sofaSalonSwitch.Click();

            wallKitchenSwitch.Click();
            poolCourtSwitch.Click();

            floatingKitchenSwitch.Click();
        }

        public void TakeFeedback(IDevice device, bool isOn)
        {
            Console.WriteLine($"Device { device.Description } is now { (isOn ? "ON" : "OFF") }");
        }
    }
}
