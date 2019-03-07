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

            Bulb ikeaBulb = new Bulb(15, 600);

            philipsHue400w = null;
            Bulb b = philipsHue400w;
            b.TurnOff();
        }
    }

    class Bulb
    {
        int _consumption;
        //int _lumen;

        bool _turnedOn;

        public Bulb(int consumption, int lumen)
        {
            _consumption = consumption;
            //_lumen = lumen;
            Lumen = lumen;

            _turnedOn = false;
        }

        public int Lumen { get; }
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

        public bool TurnedOn
        {
            get
            {
                return _turnedOn;
            }
        }

        public int Consumption
        {
            get
            {
                return _consumption;
            }
            set
            {
                _consumption = value;
            }
        }

        //int GetComsumption()
        //{
        //    return _consumption;
        //}

        //void SetConsumption(int value)
        //{
        //    _consumption = value;
        //}

        public void TurnOn()
        {
            _turnedOn = true;
        }

        public void TurnOff()
        {
            _turnedOn = false;
        }
    }
}
