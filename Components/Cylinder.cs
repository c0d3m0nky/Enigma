using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public abstract class Cylinder
    {
        
        protected abstract CylinderWire[] Positions { get; }

        public delegate void SignalTransfer(int position);

        public event SignalTransfer SignalSent;

        public abstract void SendSignal(int position);

        public void TransferSignal(int position)
        {
            SignalSent?.Invoke(position);
        }
        
    }
}
