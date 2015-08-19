using System;
using System.Linq;

namespace Components.Wheels
{

    public abstract class Wheel : IDisposable
    {

        private readonly int _offset;
        protected int Position = 0;

        public delegate void SignalTransfer(int position);

        public delegate void WheelTrippedHandler(bool up);

        public event WheelTrippedHandler WheelTripped;

        protected Wheel(int offset)
        {
            _offset = offset;
        }

        protected abstract WheelWire[] Positions { get; }

        protected abstract int[] TripPositions { get; }

        public void Up()
        {
            if (Position >= Positions.Count() - 1)
            {
                Position = 0;
            }
            else Position++;

            if (TripPositions.Contains(Position)) WheelTripped?.Invoke(true);
        }

        public void Down()
        {
            if (TripPositions.Contains(Position)) WheelTripped?.Invoke(false);

            if (Position == 0)
            {
                Position = Positions.Count() - 1;
            }
            else Position--;
        }

        public void SendSignal(int position, SignalTransfer transfer)
        {
            transfer(Positions[position + _offset].TerminationPosition);
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return Positions[Position].Value.ToString();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose()
        {
            DisposeWheelProcesionHandlers();
        }

        private void DisposeWheelProcesionHandlers()
        {
            if (WheelTripped != null)
            {
                foreach (var d in WheelTripped.GetInvocationList())
                {
                    WheelTripped -= (WheelTrippedHandler) d;
                }
            }
        }

    }

}