using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

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
                        Arguments = "/C " + command,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                    }
                };

                updateStatusExecution("\n***COMMAND ==> " + command);
                updateStatusExecution("\n***ANSWER ==>\n");

                cmd.OutputDataReceived += new DataReceivedEventHandler((s, e) =>
                {
                    updateStatusExecution(e.Data);
                });
                cmd.ErrorDataReceived += new DataReceivedEventHandler((s, e) =>
                {
                    updateStatusExecution(e.Data);
                });

                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();
                cmd.WaitForExit();
                cmd.Close();
            }
            catch (Exception e)
            {
                updateStatusExecution("***ERROR RUNNING ==> " + command);
                updateStatusExecution("***EXCEPTION ==> '" + e.ToString());
                updateStatusExecution("***STACK TRACE ==> '" + e.StackTrace.ToString());
                updateStatusExecution("\nPRESS CTRL+C WHEN U GET THE EXCEPTION.");
                string project = Console.ReadLine();
            }
        }
        public static void updateStatusExecution(string textR)
        {
            Console.WriteLine(textR);
        }
    }
}