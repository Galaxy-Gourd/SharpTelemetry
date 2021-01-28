namespace GGSharpTelemetry
{
    /// <summary>
    /// Base class for telemetry modules.
    /// </summary>
    public abstract class TelemetryBase <T>: ITelemetryModule where T : struct
    {
        #region MODULE

        public abstract string ReadTelemetryData();

        #endregion MODULE


        #region FORMAT

        /// <summary>
        /// Formats the data for the telemetry module.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        protected abstract string FormatData(T data);

        #endregion FORMAT
    }
}
