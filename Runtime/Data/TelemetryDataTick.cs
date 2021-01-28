using System;

namespace GGSharpTelemetry
{
    public struct TelemetryDataTick
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