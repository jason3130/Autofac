﻿using System.Diagnostics;

namespace AutofacTestWebApplication.Services
{
    public class Logger : ILogger
    {
        public void Log(string message, params object[] arguments)
        {
            Debug.WriteLine(message, arguments);
        }
    }
}