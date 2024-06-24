namespace MainApp.OCP;
internal class LoggingService : ILoggingService
{
    public void LogMessage(string message) => Console.WriteLine(message);
}
