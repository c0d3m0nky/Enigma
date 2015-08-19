namespace Components.Wheels
{

    public class M3IV : Wheel
    {

        public M3IV(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 10 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',4),
                new WheelWire('B',18),
                new WheelWire('C',14),
                new WheelWire('D',21),
                new WheelWire('E',15),
                new WheelWire('F',25),
                new WheelWire('G',9),
                new WheelWire('H',0),
                new WheelWire('I',24),
                new WheelWire('J',16),
                new WheelWire('K',20),
                new WheelWire('L',8),
                new WheelWire('M',17),
                new WheelWire('N',7),
                new WheelWire('O',23),
                new WheelWire('P',11),
                new WheelWire('Q',13),
                new WheelWire('R',5),
                new WheelWire('S',19),
                new WheelWire('T',6),
                new WheelWire('U',10),
                new WheelWire('V',3),
                new WheelWire('W',2),
                new WheelWire('X',12),
                new WheelWire('Y',22),
                new WheelWire('Z',1)
            };

    }

}