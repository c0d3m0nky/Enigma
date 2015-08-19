namespace Components.Wheels
{

    public class E1I : Wheel
    {

        public E1I(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 17 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',4),
                new WheelWire('B',10),
                new WheelWire('C',12),
                new WheelWire('D',5),
                new WheelWire('E',11),
                new WheelWire('F',6),
                new WheelWire('G',3),
                new WheelWire('H',16),
                new WheelWire('I',21),
                new WheelWire('J',25),
                new WheelWire('K',13),
                new WheelWire('L',19),
                new WheelWire('M',14),
                new WheelWire('N',22),
                new WheelWire('O',24),
                new WheelWire('P',7),
                new WheelWire('Q',23),
                new WheelWire('R',20),
                new WheelWire('S',18),
                new WheelWire('T',15),
                new WheelWire('U',0),
                new WheelWire('V',8),
                new WheelWire('W',1),
                new WheelWire('X',17),
                new WheelWire('Y',2),
                new WheelWire('Z',9)
            };

    }

}