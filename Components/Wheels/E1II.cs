namespace Components.Wheels
{

    public class E1II : Wheel
    {

        public E1II(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 5 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',0),
                new WheelWire('B',9),
                new WheelWire('C',3),
                new WheelWire('D',10),
                new WheelWire('E',18),
                new WheelWire('F',8),
                new WheelWire('G',17),
                new WheelWire('H',20),
                new WheelWire('I',23),
                new WheelWire('J',1),
                new WheelWire('K',11),
                new WheelWire('L',7),
                new WheelWire('M',22),
                new WheelWire('N',19),
                new WheelWire('O',12),
                new WheelWire('P',2),
                new WheelWire('Q',16),
                new WheelWire('R',6),
                new WheelWire('S',25),
                new WheelWire('T',13),
                new WheelWire('U',15),
                new WheelWire('V',24),
                new WheelWire('W',5),
                new WheelWire('X',21),
                new WheelWire('Y',14),
                new WheelWire('Z',4)
            };

    }

}