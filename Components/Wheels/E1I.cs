namespace Components.Wheels
{

    public class E1I : Wheel
    {

        public E1I(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 17 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',4),
                new CylinderWire('B',10),
                new CylinderWire('C',12),
                new CylinderWire('D',5),
                new CylinderWire('E',11),
                new CylinderWire('F',6),
                new CylinderWire('G',3),
                new CylinderWire('H',16),
                new CylinderWire('I',21),
                new CylinderWire('J',25),
                new CylinderWire('K',13),
                new CylinderWire('L',19),
                new CylinderWire('M',14),
                new CylinderWire('N',22),
                new CylinderWire('O',24),
                new CylinderWire('P',7),
                new CylinderWire('Q',23),
                new CylinderWire('R',20),
                new CylinderWire('S',18),
                new CylinderWire('T',15),
                new CylinderWire('U',0),
                new CylinderWire('V',8),
                new CylinderWire('W',1),
                new CylinderWire('X',17),
                new CylinderWire('Y',2),
                new CylinderWire('Z',9)
            };

    }

}