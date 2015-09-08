using System.Runtime.Remoting.Messaging;

using Components;
using Components.Reflectors;
using Components.Wheels;

namespace EnigmaMachine
{

    public class SteckerbrettM3
    {

        private Wheel _wheel0;
        private Wheel _wheel1;
        private Wheel _wheel2;
        private Reflector _reflector;

        public delegate void LightUp(char c);

        public event LightUp LightLit;

        // TODO: Go nuts, make the signal events wire based

        public SteckerbrettM3(Wheel wheel0, Wheel wheel1, Wheel wheel2, Reflector reflector)
        {
            _wheel0 = wheel0;
            _wheel1 = wheel1;
            _wheel2 = wheel2;
            _reflector = reflector;
            HookupWheel0();
            HookupWheel1();
            HookupWheel2();
            HookUpReflector();
        }


        private void HookupWheel0()
        {
            _wheel0.WheelTripped += up => WheelTripEvent(up, _wheel1);
            // TODO: Subscribe to input
            // TODO: Send to output
            _wheel0.ReturnSignalSent += position =>
            {
                LightLit?.Invoke((char) (position + 65));
            };
        }


        private void HookupWheel1()
        {
            _wheel1.WheelTripped += up => WheelTripEvent(up, _wheel2);
            _wheel0.SignalSent += _wheel1.SendSignal;
            _wheel2.ReturnSignalSent += _wheel1.SendReturnSignal;
            _wheel1.ReturnSignalSent += _wheel0.SendReturnSignal;
        }

        private void HookupWheel2()
        {
            _wheel1.SignalSent += _wheel2.SendSignal;
            _reflector.SignalSent += _wheel2.SendReturnSignal;
        }

        private void HookUpReflector()
        {
            _wheel2.SignalSent += _reflector.SendSignal;
        }

        public Wheel Wheel0
        {
            get { return _wheel0; }
            set
            {
                if (_wheel0 == null || !_wheel0.Equals(value))
                {
                    _wheel0?.Dispose();
                    _wheel0 = value;
                    HookupWheel0();
                }
            }
        }

        public Wheel Wheel1
        {
            get { return _wheel1; }
            set
            {
                if (_wheel1 == null || !_wheel1.Equals(value))
                {
                    _wheel1?.Dispose();
                    _wheel1 = value;
                    HookupWheel1();
                }
            }
        }

        public Wheel Wheel2
        {
            get { return _wheel2; }
            set
            {
                if (_wheel2 == null || !_wheel2.Equals(value))
                {
                    _wheel2?.Dispose();
                    _wheel2 = value;
                    HookupWheel2();
                }
            }
        }

        public Reflector Reflector
        {
            get { return _reflector; }
            set
            {
                if (_reflector == null || !_reflector.Equals(value))
                {
                    _reflector = value;
                    HookUpReflector();
                }
            }
        }

        private void WheelTripEvent(bool up, Wheel wheel)
        {
            if (up) wheel.Up();
            else wheel.Down();
        }

        public void SendInput(char c)
        {
            c = c.ToString().ToUpper()[0];

            Wheel0.Up();

            Wheel0.SendSignal(c - 65);
        }

    }

}