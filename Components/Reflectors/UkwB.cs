using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Reflectors
{
    public class UkwB : Reflector
    {

        protected override CylinderWire[] Positions { get; } =
            {
                new CylinderWire('A',24),
                new CylinderWire('B',17),
                new CylinderWire('C',20),
                new CylinderWire('D',7),
                new CylinderWire('E',16),
                new CylinderWire('F',18),
                new CylinderWire('G',11),
                new CylinderWire('H',3),
                new CylinderWire('I',15),
                new CylinderWire('J',23),
                new CylinderWire('K',13),
                new CylinderWire('L',6),
                new CylinderWire('M',14),
                new CylinderWire('N',10),
                new CylinderWire('O',12),
                new CylinderWire('P',8),
                new CylinderWire('Q',4),
                new CylinderWire('R',1),
                new CylinderWire('S',5),
                new CylinderWire('T',25),
                new CylinderWire('U',2),
                new CylinderWire('V',22),
                new CylinderWire('W',21),
                new CylinderWire('X',9),
                new CylinderWire('Y',0),
                new CylinderWire('Z',19)
            };

    }
}
