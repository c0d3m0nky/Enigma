namespace Components.Wheels
{

    public class M3VIII : Wheel
    {

        public M3VIII(int offset) : base(offset) { }

        protected override int[] TripPositions { get; } = { 0, 13 };

        protected override WheelWire[] Positions { get; } =
            {
                new WheelWire('A',5),
                new WheelWire('B',10),
                new WheelWire('C',16),
                new WheelWire('D',7),
                new WheelWire('E',19),
                new WheelWire('F',11),
                new WheelWire('G',23),
                new WheelWire('H',14),
                new WheelWire('I',2),
                new WheelWire('J',1),
                new WheelWire('K',9),
                new WheelWire('L',18),
                new WheelWire('M',15),
                new WheelWire('N',3),
                new WheelWire('O',25),
                new WheelWire('P',17),
                new WheelWire('Q',0),
                new WheelWire('R',12),
                new WheelWire('S',4),
                new WheelWire('T',22),
                new WheelWire('U',13),
                new WheelWire('V',8),
                new WheelWire('W',20),
                new WheelWire('X',24),
                new WheelWire('Y',6),
                new WheelWire('Z',21)
            };

    }

}