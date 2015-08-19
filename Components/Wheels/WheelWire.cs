namespace Components.Wheels
{

    public class WheelWire
    {
        public WheelWire(char value, int terminationPosition)
        {
            Value = value;
            TerminationPosition = terminationPosition;
        }

        public char Value { get; private set; }

        public int TerminationPosition { get; private set; }

    }

}