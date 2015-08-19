namespace Components.Wheels
{

    public class M3V : Wheel
    {

        public M3V(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 0 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',21),
                new WheelWire('B',25),
                new WheelWire('C',1),
                new WheelWire('D',17),
                new WheelWire('E',6),
                new WheelWire('F',8),
                new WheelWire('G',19),
                new WheelWire('H',24),
                new WheelWire('I',20),
                new WheelWire('J',15),
                new WheelWire('K',18),
                new WheelWire('L',3),
                new WheelWire('M',13),
                new WheelWire('N',7),
                new WheelWire('O',11),
                new WheelWire('P',23),
                new WheelWire('Q',0),
                new WheelWire('R',22),
                new WheelWire('S',12),
                new WheelWire('T',9),
                new WheelWire('U',16),
                new WheelWire('V',14),
                new WheelWire('W',5),
                new WheelWire('X',4),
                new WheelWire('Y',2),
                new WheelWire('Z',10)
            };
    }

}