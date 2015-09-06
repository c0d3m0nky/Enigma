namespace Components.Wheels
{

    public class M3VII : Wheel
    {

        public M3VII(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 0, 13 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',13),
                new CylinderWire('B',25),
                new CylinderWire('C',9),
                new CylinderWire('D',7),
                new CylinderWire('E',6),
                new CylinderWire('F',17),
                new CylinderWire('G',2),
                new CylinderWire('H',23),
                new CylinderWire('I',12),
                new CylinderWire('J',24),
                new CylinderWire('K',18),
                new CylinderWire('L',22),
                new CylinderWire('M',1),
                new CylinderWire('N',14),
                new CylinderWire('O',20),
                new CylinderWire('P',5),
                new CylinderWire('Q',0),
                new CylinderWire('R',8),
                new CylinderWire('S',21),
                new CylinderWire('T',11),
                new CylinderWire('U',15),
                new CylinderWire('V',4),
                new CylinderWire('W',10),
                new CylinderWire('X',16),
                new CylinderWire('Y',3),
                new CylinderWire('Z',19)
            };

    }

}