namespace GGSharpTelemetry
{
    public interface ITelemetryModule
    {
        /// <summary>
        /// Returns the current data for the telemetry module.
        /// </summary>
        TelemetryData TelemetryData { get; }
    }
}