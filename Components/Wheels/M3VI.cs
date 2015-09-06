namespace Components.Wheels
{

    public class M3VI : Wheel
    {

        public M3VI(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 0, 13 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',9),
                new CylinderWire('B',15),
                new CylinderWire('C',6),
                new CylinderWire('D',21),
                new CylinderWire('E',14),
                new CylinderWire('F',20),
                new CylinderWire('G',12),
                new CylinderWire('H',5),
                new CylinderWire('I',24),
                new CylinderWire('J',16),
                new CylinderWire('K',1),
                new CylinderWire('L',4),
                new CylinderWire('M',13),
                new CylinderWire('N',7),
                new CylinderWire('O',25),
                new CylinderWire('P',17),
                new CylinderWire('Q',3),
                new CylinderWire('R',10),
                new CylinderWire('S',0),
                new CylinderWire('T',18),
                new CylinderWire('U',23),
                new CylinderWire('V',11),
                new CylinderWire('W',8),
                new CylinderWire('X',2),
                new CylinderWire('Y',19),
                new CylinderWire('Z',22)
            };

    }

}