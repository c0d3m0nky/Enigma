namespace Components
{

    public class CylinderWire
    {
        public CylinderWire(char value, int terminationPosition)
        {
            Value = value;
            TerminationPosition = terminationPosition;
        }

        public char Value { get; private set; }

        public int TerminationPosition { get; private set; }

    }

}