namespace GGSharpTelemetry
{
    public interface ITelemetryModule
    {
        #region METHODS

        /// <summary>
        /// Returns formatted telemetry data for the module.
        /// </summary>
        /// <returns></returns>
        string ReadTelemetryData();

        #endregion METHODS
    }
}