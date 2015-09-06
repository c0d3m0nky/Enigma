namespace Components.Wheels
{

    public class E1III : Wheel
    {

        public E1III(char setting) : base(setting) { }

        protected override int[] TripPositions { get; } = { 21 };

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',1),
                new CylinderWire('B',3),
                new CylinderWire('C',5),
                new CylinderWire('D',7),
                new CylinderWire('E',9),
                new CylinderWire('F',11),
                new CylinderWire('G',2),
                new CylinderWire('H',15),
                new CylinderWire('I',17),
                new CylinderWire('J',19),
                new CylinderWire('K',23),
                new CylinderWire('L',21),
                new CylinderWire('M',25),
                new CylinderWire('N',13),
                new CylinderWire('O',24),
                new CylinderWire('P',4),
                new CylinderWire('Q',8),
                new CylinderWire('R',22),
                new CylinderWire('S',6),
                new CylinderWire('T',0),
                new CylinderWire('U',10),
                new CylinderWire('V',12),
                new CylinderWire('W',20),
                new CylinderWire('X',18),
                new CylinderWire('Y',16),
                new CylinderWire('Z',14)
            };

    }

}