using System;
using System.Diagnostics;
using System.Text;

namespace DevSolutions
{
    public static class CMD
    {
        private static StringBuilder cmdOutput = null;
        private static int numOutputLines = 0;

        /* FUNCIÓN QUE EJECUTA EL COMANDO POR EL CMD */
        public static void ExecuteCommand(string command)
        {
            //Inicializamos el proceso
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";

            // Asignamos la propiedad a false para evitar la redirección
            cmd.StartInfo.UseShellExecute = false;

            // Redireccionamos la salida por pantalla original por una lectura asincrona utilizando un event handler
            cmd.StartInfo.RedirectStandardOutput = true;
            cmdOutput = new StringBuilder();

            // Asignamos nuestro event handler a una lectura asincrona para sacar la ejecución del programa por pantalla
            cmd.OutputDataReceived += CmdOutputHandler;

            // Recireccionamos la entrada de datos de forma sincrona.
            cmd.StartInfo.RedirectStandardInput = true;

            // Inicializamos el proceso
            cmd.Start();

            // Inicializamos la lectura asincrona de las lecturas por pantalla del programa
            cmd.BeginOutputReadLine();

            // Pasamos el comando por la linea de comandos
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();

            // A medida que van saliendo nuevas lineas de ejecución las mostramos
            if(numOutputLines > 0)
            {
                Console.WriteLine(cmdOutput);
            }

            // Finalizamos la entrada de datos y cerramos la ejecución
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        // Event handler encargado de ir cargandose a medida que entran nuevas lineas de ejecución
        private static void CmdOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            // Recogemos la información que sale por pantalla
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                numOutputLines++;

                // Añadimos el texto al colector para la salida por pantalla
                cmdOutput.Append(Environment.NewLine + $"[{numOutputLines}] - {outLine.Data}");
            }
        }

        public static void ExecuteDir(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
    }
}