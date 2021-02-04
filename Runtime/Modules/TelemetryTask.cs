using GGSharpTask;

namespace GGSharpTelemetry
{
    public class TelemetryTask : TelemetryBase<TelemetryDataTask, ICoreTask>
    {
        #region CONSTRUCTION

        public TelemetryTask(ICoreTask system) : base(system)
        {
            
        }

        #endregion CONSTRUCTION
        
        
        #region DATA

        public override TelemetryDataTask ReadTelemetryData()
        {
            return _data;
        }
        
        #endregion DATA
    }
}