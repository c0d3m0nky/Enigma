namespace Components.Wheels
{

    public class M3VI : Wheel
    {

        public M3VI(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 0, 13 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',9),
                new WheelWire('B',15),
                new WheelWire('C',6),
                new WheelWire('D',21),
                new WheelWire('E',14),
                new WheelWire('F',20),
                new WheelWire('G',12),
                new WheelWire('H',5),
                new WheelWire('I',24),
                new WheelWire('J',16),
                new WheelWire('K',1),
                new WheelWire('L',4),
                new WheelWire('M',13),
                new WheelWire('N',7),
                new WheelWire('O',25),
                new WheelWire('P',17),
                new WheelWire('Q',3),
                new WheelWire('R',10),
                new WheelWire('S',0),
                new WheelWire('T',18),
                new WheelWire('U',23),
                new WheelWire('V',11),
                new WheelWire('W',8),
                new WheelWire('X',2),
                new WheelWire('Y',19),
                new WheelWire('Z',22)
            };

    }

}