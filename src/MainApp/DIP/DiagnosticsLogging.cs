namespace MainApp.DIP;
internal class DiagnosticsLogging : ILoggingService
{
    public void LogMessage(string message) => System.Diagnostics.Trace.WriteLine(message);
}
