using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;

using System.IO;

namespace CSharpIntermediateToAdvance
{
    partial class Program
    {
        public interface ILogger
        {
            void LogError(string message);
            void LogInfo(string message);
        }

        static void Main(string[] args)
        {
            /* 
             * ///Section 6
                Interfaces
                Lecture 35
               Interface and Extensibility
*/
            //creating a new orderprocessor object
        }
        //........................................................

        public class DbMigrator
        {
            private readonly ILogger _logger;

            public DbMigrator(ILogger logger) => _logger = logger;

            public void Migrator()
            {
                object p = _logger.LogInfo("Migrating started at " + DateTime.Now);

                //Details of migrating the database

                _logger.LogInfo("Migrating finished at " + DateTime.Now);
            }
        }


        //........................................................
        public class FileLogger : ILogger
        {
            private readonly string _path;

            public FileLogger(string path)
            {
                _path = path;
            }
            public void LogError(string message)
            {
                Log(message, "it is error ");
            }

            public void LogInfo(string message)
            {
                Log(message, "this is info message");
            }

            private void Log(string message, string messageType)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine(messageType + ": " + message);
                }
            }
        }
        //........................................................

        public class ConsoleLogger : ILogger
        {
            public void LogError(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }

            public void LogInfo(string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
            }
        }
    }
}



