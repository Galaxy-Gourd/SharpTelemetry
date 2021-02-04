using GGSharpData;

namespace GGSharpTelemetry
{
    /// <summary>
    /// Base class for telemetry modules.
    /// </summary>
    public abstract class TelemetryBase<T, S> : ITelemetryModule
        where T : TelemetryData, new()
        where S : ICoreSystem
    {
        #region VARIABLES

        public TelemetryData TelemetryData => ReadTelemetryData();

        /// <summary>
        /// Data for this telemetry class
        /// </summary>
        protected readonly T _data;

        protected readonly S _system;

        #endregion VARIABLES


        #region CONSTRUCTOR

        protected TelemetryBase(S system)
        {
            _data = new T();
            _system = system;
        }

        #endregion CONSTRUCTOR


        #region DATA

        public abstract T ReadTelemetryData();

        #endregion DATA
    }
}
