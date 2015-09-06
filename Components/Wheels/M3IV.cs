namespace Components.Wheels
{

    public class M3IV : Wheel
    {

        public M3IV(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 10 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',4),
                new CylinderWire('B',18),
                new CylinderWire('C',14),
                new CylinderWire('D',21),
                new CylinderWire('E',15),
                new CylinderWire('F',25),
                new CylinderWire('G',9),
                new CylinderWire('H',0),
                new CylinderWire('I',24),
                new CylinderWire('J',16),
                new CylinderWire('K',20),
                new CylinderWire('L',8),
                new CylinderWire('M',17),
                new CylinderWire('N',7),
                new CylinderWire('O',23),
                new CylinderWire('P',11),
                new CylinderWire('Q',13),
                new CylinderWire('R',5),
                new CylinderWire('S',19),
                new CylinderWire('T',6),
                new CylinderWire('U',10),
                new CylinderWire('V',3),
                new CylinderWire('W',2),
                new CylinderWire('X',12),
                new CylinderWire('Y',22),
                new CylinderWire('Z',1)
            };

    }

}