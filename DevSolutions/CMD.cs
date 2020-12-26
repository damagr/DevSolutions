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
                        Arguments = "/K " + command,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                    }
                };

                updateStatusExecution("\nCOMANDO ==> " + command);
                updateStatusExecution("\nRESPUESTA ==>\n");
                cmd.Start();

                if (cmd.StandardOutput.ReadLine().Length == 0)
                {
                    string eLine = cmd.StandardError.ReadLine();
                    updateStatusExecution("***ERROR EJECUTANDO => " + command + "\n\n" + eLine + "\n\nPulsa Ctrl+C para cerrar la ejecución tras leer el error.");
                    cmd.WaitForExit();
                }
                else
                {
                    while (!cmd.StandardOutput.EndOfStream)
                    {
                        string line = cmd.StandardOutput.ReadLine();
                        updateStatusExecution(line);

                        if (cmd.StandardOutput.Peek() != -1)
                        {
                            updateStatusExecution("FINALIZADO");
                            Thread.Sleep(30000);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                updateStatusExecution("ERROR EJECUTANDO ==> '" + command + "'");
                updateStatusExecution("EXCEPCIÓN: '" + e.ToString());
                updateStatusExecution("STACK TRACE: '" + e.StackTrace.ToString());
                updateStatusExecution("\nPulsa Ctrl+C para cerrar la ejecución tras leer la excepción generada.");
                string project = Console.ReadLine();
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