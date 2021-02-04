using System;
using GGSharpData;

namespace GGSharpTelemetry
{
    /// <summary>
    /// Stores telemetry data relating to the tick system.
    /// </summary>
    public class TelemetryDataTick : TelemetryData
    {
        public TelemetryTickData[] TicksVariable;
        public TelemetryTickData[] TicksFixed;
        public TimeSpan ElapsedSinceSimStartup;

        public struct TelemetryTickData
        {
            public string TickName;
            public TelemetryTicksetData[] TicksetData;
        }

        public struct TelemetryTicksetData
        {
            public string TicksetName;
            public int SubscriberCount;
        }
    }
}