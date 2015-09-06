namespace Components.Wheels
{

    public class E1II : Wheel
    {

        public E1II(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 5 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',0),
                new CylinderWire('B',9),
                new CylinderWire('C',3),
                new CylinderWire('D',10),
                new CylinderWire('E',18),
                new CylinderWire('F',8),
                new CylinderWire('G',17),
                new CylinderWire('H',20),
                new CylinderWire('I',23),
                new CylinderWire('J',1),
                new CylinderWire('K',11),
                new CylinderWire('L',7),
                new CylinderWire('M',22),
                new CylinderWire('N',19),
                new CylinderWire('O',12),
                new CylinderWire('P',2),
                new CylinderWire('Q',16),
                new CylinderWire('R',6),
                new CylinderWire('S',25),
                new CylinderWire('T',13),
                new CylinderWire('U',15),
                new CylinderWire('V',24),
                new CylinderWire('W',5),
                new CylinderWire('X',21),
                new CylinderWire('Y',14),
                new CylinderWire('Z',4)
            };

    }

}