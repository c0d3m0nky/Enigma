namespace Components.Wheels
{

    public class M3VIII : Wheel
    {

        public M3VIII(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 0, 13 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',5),
                new CylinderWire('B',10),
                new CylinderWire('C',16),
                new CylinderWire('D',7),
                new CylinderWire('E',19),
                new CylinderWire('F',11),
                new CylinderWire('G',23),
                new CylinderWire('H',14),
                new CylinderWire('I',2),
                new CylinderWire('J',1),
                new CylinderWire('K',9),
                new CylinderWire('L',18),
                new CylinderWire('M',15),
                new CylinderWire('N',3),
                new CylinderWire('O',25),
                new CylinderWire('P',17),
                new CylinderWire('Q',0),
                new CylinderWire('R',12),
                new CylinderWire('S',4),
                new CylinderWire('T',22),
                new CylinderWire('U',13),
                new CylinderWire('V',8),
                new CylinderWire('W',20),
                new CylinderWire('X',24),
                new CylinderWire('Y',6),
                new CylinderWire('Z',21)
            };

    }

}