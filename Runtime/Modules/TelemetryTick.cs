using GGSharpData;
using GGSharpTick;

namespace GGSharpTelemetry
{
    /// <summary>
    /// Calculates debug telemetry information for the GGCore SharpTick system.
    /// </summary>
    public class TelemetryTick : TelemetryBase<TelemetryDataTick, ICoreTick>
    {
        #region CONSTRUCTION

        public TelemetryTick(ICoreTick system) : base(system)
        {
            
        }

        #endregion CONSTRUCTION
        
        
        #region DATA

        public override TelemetryDataTick ReadTelemetryData()
        {
            _data.TicksVariable = GetTickData((TickVariable[])_system.VariableTicks);
            _data.TicksFixed = GetTickData((TickFixed[])_system.FixedTicks);

            return _data;
        }

        #endregion DATA


        #region UTILITY

        /// <summary>
        /// Returns all of the variable tick names for the given tick system.
        /// </summary>
        private TelemetryDataTick.TelemetryTickData[] GetTickData(TickBase[] ticks)
        {
            TelemetryDataTick.TelemetryTickData[] data = 
                new TelemetryDataTick.TelemetryTickData[ticks.Length];

            for (int i = 0; i < ticks.Length; i++)
            {
                TelemetryDataTick.TelemetryTickData d = new TelemetryDataTick.TelemetryTickData();
                d.TickName = ticks[i].TickName;

                d.TicksetData = new TelemetryDataTick.TelemetryTicksetData[ticks[i].ticksets.Count];
                for (int e = 0; e < ticks[i].ticksets.Count; e++)
                {
                    TelemetryDataTick.TelemetryTicksetData ticksetData = new TelemetryDataTick.TelemetryTicksetData
                    {
                        TicksetName = ticks[i].ticksets[e].ticksetName,
                        SubscriberCount = ticks[i].ticksets[e].subscriberCount
                    };
                    d.TicksetData[e] = ticksetData;
                }

                data[i] = d;
            }

            return data;
        }

        #endregion UTILITY
    }
}
