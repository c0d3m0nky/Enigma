using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Reflectors
{
    public class UkwC : Reflector
    {

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',5),
                new CylinderWire('B',21),
                new CylinderWire('C',15),
                new CylinderWire('D',9),
                new CylinderWire('E',8),
                new CylinderWire('F',0),
                new CylinderWire('G',14),
                new CylinderWire('H',24),
                new CylinderWire('I',4),
                new CylinderWire('J',3),
                new CylinderWire('K',17),
                new CylinderWire('L',25),
                new CylinderWire('M',23),
                new CylinderWire('N',22),
                new CylinderWire('O',6),
                new CylinderWire('P',2),
                new CylinderWire('Q',19),
                new CylinderWire('R',10),
                new CylinderWire('S',20),
                new CylinderWire('T',16),
                new CylinderWire('U',18),
                new CylinderWire('V',1),
                new CylinderWire('W',13),
                new CylinderWire('X',12),
                new CylinderWire('Y',7),
                new CylinderWire('Z',11)
            };

    }
}
