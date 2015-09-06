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

        // TODO: Go nuts, make the signal events wire based

        public Wheel Wheel0
        {
            get { return _wheel0; }
            set
            {
                if (_wheel0 == null || !_wheel0.Equals(value))
                {
                    _wheel0?.Dispose();
                    _wheel0 = value;
                    _wheel0.WheelTripped += up => WheelTripEvent(up, _wheel1);
                    // TODO: Subscribe to input
                    // TODO: Send to output
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
                    _wheel1.WheelTripped += up => WheelTripEvent(up, _wheel2);
                    _wheel0.SignalSent += _wheel1.SendSignal;
                    _wheel1.ReturnSignalSent += _wheel0.SendReturnSignal;
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
                    _wheel1.SignalSent += _wheel2.SendSignal;
                    _reflector.SignalSent += _wheel1.SendReturnSignal;
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
                    _wheel2.SignalSent += _reflector.SendSignal;
                }
            }
        }

        private void WheelTripEvent(bool up, Wheel wheel)
        {
            if (up) wheel.Up();
            else wheel.Down();
        }
        
    }

}