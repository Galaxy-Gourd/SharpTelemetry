using GGSharpTick;

namespace GGSharpTelemetry
{
    /// <summary>
    /// Provides debug telemetry information for the GGCore SharpTick system.
    /// </summary>
    public class TelemetryTick : TelemetryBase<TelemetryDataTick>
    {
        #region VARIABLES

        /// <summary>
        /// The tick system from which this module will collect telemetry information
        /// </summary>
        private readonly CoreTick _coreTick;
        
        //
        private TelemetryDataTick _data;

        #endregion VARIABLES


        #region INITIALIZATION

        public TelemetryTick(CoreTick coreTick)
        {
            _coreTick = coreTick;
        }

        #endregion INITIALIZATION
        
        
        #region DATA

        public override string ReadTelemetryData()
        {
            _data.TicksVariable = GetTickData((TickVariable[])_coreTick.VariableTicks);
            _data.TicksFixed = GetTickData((TickFixed[])_coreTick.FixedTicks);
            
            return FormatData(_data);
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
            }

            return data;
        }

        #endregion UTILITY


        #region FORMAT
        
        protected override string FormatData(TelemetryDataTick data)
        {
             return _data.ToString();
        }

        #endregion FORMAT
    }
}
