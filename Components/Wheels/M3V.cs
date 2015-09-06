namespace Components.Wheels
{

    public class M3V : Wheel
    {

        public M3V(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 0 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',21),
                new CylinderWire('B',25),
                new CylinderWire('C',1),
                new CylinderWire('D',17),
                new CylinderWire('E',6),
                new CylinderWire('F',8),
                new CylinderWire('G',19),
                new CylinderWire('H',24),
                new CylinderWire('I',20),
                new CylinderWire('J',15),
                new CylinderWire('K',18),
                new CylinderWire('L',3),
                new CylinderWire('M',13),
                new CylinderWire('N',7),
                new CylinderWire('O',11),
                new CylinderWire('P',23),
                new CylinderWire('Q',0),
                new CylinderWire('R',22),
                new CylinderWire('S',12),
                new CylinderWire('T',9),
                new CylinderWire('U',16),
                new CylinderWire('V',14),
                new CylinderWire('W',5),
                new CylinderWire('X',4),
                new CylinderWire('Y',2),
                new CylinderWire('Z',10)
            };
    }

}