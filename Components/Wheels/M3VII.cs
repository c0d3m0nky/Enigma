namespace Components.Wheels
{

    public class M3VII : Wheel
    {

        public M3VII(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 0, 13 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',13),
                new WheelWire('B',25),
                new WheelWire('C',9),
                new WheelWire('D',7),
                new WheelWire('E',6),
                new WheelWire('F',17),
                new WheelWire('G',2),
                new WheelWire('H',23),
                new WheelWire('I',12),
                new WheelWire('J',24),
                new WheelWire('K',18),
                new WheelWire('L',22),
                new WheelWire('M',1),
                new WheelWire('N',14),
                new WheelWire('O',20),
                new WheelWire('P',5),
                new WheelWire('Q',0),
                new WheelWire('R',8),
                new WheelWire('S',21),
                new WheelWire('T',11),
                new WheelWire('U',15),
                new WheelWire('V',4),
                new WheelWire('W',10),
                new WheelWire('X',16),
                new WheelWire('Y',3),
                new WheelWire('Z',19)
            };

    }

}