using System;
using System.Linq;

namespace Components.Wheels
{

    public abstract class Wheel : Cylinder, IDisposable
    {

        protected int WheelPosition = 0;

        public delegate void WheelTrippedHandler(bool up);

        public event WheelTrippedHandler WheelTripped;

        protected Wheel(char setting)
        {
            WheelPosition = Positions.Select((tp, i) => new { InputPosition = i, Wire = tp }).First(p => p.Wire.Value == setting).InputPosition;
        }

        #region Movement

        protected abstract int[] TripPositions { get; }

        public void Up()
        {
            if (WheelPosition >= Positions.Count() - 1)
            {
                WheelPosition = 0;
            }
            else WheelPosition++;

            if (TripPositions.Contains(WheelPosition)) WheelTripped?.Invoke(true);
        }

        public void Down()
        {
            if (TripPositions.Contains(WheelPosition)) WheelTripped?.Invoke(false);

            if (WheelPosition == 0)
            {
                WheelPosition = Positions.Count() - 1;
            }
            else WheelPosition--;
        }

        #endregion

        #region Signal

        public event SignalTransfer ReturnSignalSent;

        public void SendReturnSignal(int position)
        {
            var adjustedPosition = AdjustPositionForOffset(position);

            ReturnSignalSent?.Invoke(AdjustPositionForOffset(Positions.Select((tp, i) => new { InputPosition = i, Wire = tp }).First(tp => tp.Wire.TerminationPosition == adjustedPosition).InputPosition));
        }

        public override void SendSignal(int position)
        {
            TransferSignal(AdjustPositionForOffset(Positions[AdjustPositionForOffset(position)].TerminationPosition));
        }

        private int AdjustPositionForOffset(int position)
        {
            var result = position + WheelPosition;

            if (result > Positions.Count() - 1) result = result - Positions.Count() + 1;

            return result;
        }

        #endregion

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return Positions[WheelPosition].Value.ToString();
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