using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.FirstNamespace
{
    class Switch
    {
        public void Click()
        {
            Bulb philipsHue400w;
            philipsHue400w = new Bulb(400, 1200);
            int c = philipsHue400w.Consumption;
            //philipsHue400w.Consumption = 400;

            int l = philipsHue400w.Lumen;
            //philipsHue400w.Lumen = 5;

            if (philipsHue400w.TurnedOn)
            {
                philipsHue400w.TurnOff();
            }
            else
            {
                philipsHue400w.TurnOn();
            }

            //philipsHue400w._turnedOn = false;
            //philipsHue400w.TurnedOn = false;

            object ikeaBulb = new Bulb(15, 600);
            object o = new object();
            Bulb ib = (Bulb)ikeaBulb;
            //philipsHue400w = null;
            Device b = (Device)ikeaBulb;
            b.TurnOn();

            //Bulb ob = (Bulb)o;
            //ob.DisplayDescription();

            string d1 = b.DisplayDescription();
            
            Device f = new Fan(300);
            f.TurnOn();
            f.TurnOff();
            Bulb bf = (Bulb)f;

            string d2 = f.DisplayDescription();

        }
    }

    abstract class Device
    {
        public Device(int consumption)
        {
            TurnedOn = false;
            Consumption = consumption;
        }

        public bool TurnedOn { get; private set; }

        public int Consumption { get; private set; }

        public void TurnOn()
        {
            TurnedOn = true;
        }

        public void TurnOff()
        {
            TurnedOn = false;
        }

        //public virtual string DisplayDescription()
        //{
        //    return this.GetType().ToString();
        //}

        public abstract string DisplayDescription();
    }

    class Fan : Device
    {
        public Fan(int consumption) : base(consumption)
        {
            //Consumption = consumption;

            //TurnedOn = false;
        }

        public override string DisplayDescription()
        {
            return $"Sono una ventola e sto consumando { Consumption }";
        }

        //public override string DisplayDescription()
        //{

        //    return $"Sono una ventola ({ base.DisplayDescription() }) e sto consumando { Consumption }";
        //}
    }

    class Bulb : Device
    {
        //int _consumption;
        //readonly int _lumen;

        //bool _turnedOn;

        public override string DisplayDescription()
        {
            return $"Sono una lampadina e sto consumando { Consumption } perché sono al { Intensity }% di intensità";
        }

        public Bulb(int consumption, int lumen) : base(consumption)
        {
            //_lumen = lumen;
            //_consumption = consumption;
            //_lumen = lumen;
            //Consumption = consumption;
            Lumen = lumen;

            //TurnedOn = false;
            //_turnedOn = false;
        }

        public int Intensity { get; private set; }

        public int Lumen { get; }

        public void SetIntensity(int intensity)
        {
            Intensity = intensity;
        }

        //public int Lumen
        //{
        //    get
        //    {
        //        return _lumen;
        //    }
        //    set
        //    {
        //        _lumen = value;
        //    }
        //}

        //public bool TurnedOn
        //{
        //    get
        //    {
        //        return _turnedOn;
        //    }
        //}

        //public int Consumption
        //{
        //    get
        //    {
        //        return _consumption;
        //    }
        //    set
        //    {
        //        _consumption = value;
        //    }
        //}

        //int GetComsumption()
        //{
        //    return _consumption;
        //}

        //void SetConsumption(int value)
        //{
        //    _consumption = value;
        //}

        //public void TurnOn()
        //{
        //    _turnedOn = true;
        //}

        //public void TurnOff()
        //{
        //    _turnedOn = false;
        //}
    }
}
