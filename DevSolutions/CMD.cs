using System;
using System.Diagnostics;

namespace DevSolutions
{
    public static class CMD
    {
        /* FUNCIÓN QUE EJECUTA EL COMANDO POR EL CMD */
        public static void ExecuteCommand(string command)
        {
            try
            {
                Process cmd = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = "/K " + command,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                updateStatusExecution("***COMMAND RECEIVED: " + command);
                updateStatusExecution("***ANSWER:");
                cmd.Start();
                while (!cmd.StandardOutput.EndOfStream)
                {
                    string line = cmd.StandardOutput.ReadLine();
                    updateStatusExecution(line);
                }
            }
            catch (Exception e)
            {
                updateStatusExecution("***Error while executing '" + command + "'");
                updateStatusExecution("***Exception: '" + e.ToString());
                updateStatusExecution("***Stack Trace: '" + e.StackTrace.ToString());
            }
        }
        private static void updateStatusExecution(string textR)
        {
            Console.WriteLine(textR);
        }
        public static void ExecuteDir(string command)
        {
            try
            {
                Process cmd = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = "/C " + command,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                updateStatusExecution("***COMMAND RECEIVED: " + command);
                updateStatusExecution("***ANSWER:");
                cmd.Start();
                while (!cmd.StandardOutput.EndOfStream)
                {
                    string line = cmd.StandardOutput.ReadLine();
                    updateStatusExecution(line);
                }
            }
            catch (Exception e)
            {
                updateStatusExecution("***Error while executing '" + command + "'");
                updateStatusExecution("***Exception: '" + e.ToString());
                updateStatusExecution("***Stack Trace: '" + e.StackTrace.ToString());
            }
        }
    }
}