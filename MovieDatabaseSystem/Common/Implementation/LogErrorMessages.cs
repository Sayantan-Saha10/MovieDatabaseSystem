using MovieDatabaseSystem.Common.Interface;
using System.Diagnostics;

namespace MovieDatabaseSystem.Common.Implementation
{
    public class LogErrorMessages : ILogErrorMessages
    {
        public void LogMessage(string errorMessage, string errorDetails)
        {
            Trace.WriteLine(string.Format("{0} Details: {1}", errorMessage, errorDetails), "TraceError");
        }
    }
}