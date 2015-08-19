namespace Components.Wheels
{

    public class E1III : Wheel
    {

        public E1III(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 21 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',1),
                new WheelWire('B',3),
                new WheelWire('C',5),
                new WheelWire('D',7),
                new WheelWire('E',9),
                new WheelWire('F',11),
                new WheelWire('G',2),
                new WheelWire('H',15),
                new WheelWire('I',17),
                new WheelWire('J',19),
                new WheelWire('K',23),
                new WheelWire('L',21),
                new WheelWire('M',25),
                new WheelWire('N',13),
                new WheelWire('O',24),
                new WheelWire('P',4),
                new WheelWire('Q',8),
                new WheelWire('R',22),
                new WheelWire('S',6),
                new WheelWire('T',0),
                new WheelWire('U',10),
                new WheelWire('V',12),
                new WheelWire('W',20),
                new WheelWire('X',18),
                new WheelWire('Y',16),
                new WheelWire('Z',14)
            };

    }

}