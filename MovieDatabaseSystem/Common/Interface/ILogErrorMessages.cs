using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDatabaseSystem.Common.Interface
{
    public interface ILogErrorMessages
    {
        void LogMessage(string errorMessage, string errorDetails);
    }
}