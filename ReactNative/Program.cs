using System;
using System.Diagnostics;

namespace ReactNative
{
    class Program
    {
        static int Menu(string path)
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Iniciar un proyecto nuevo" +
               "\n2. Abrir un proyecto existente" +
               "\n3. Instalar librerias React Native Elements y Vector Icons" +
               "\n4. Salir");
            int menu = int.Parse(Console.ReadLine());

            Console.Clear();
            ExecuteCommand(ShowDirectory(path));

            return menu;
        }
        static string ShowDirectory(string path)
        {
            return "dir " + path;
        }
        static string CreateProject(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "npx react-native init " + project;
        }
        static string StartProject(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string run = "&& npx react-native run-android";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + run;
        }
        static string InstallLibraries(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string libraries = "&& npm i react-native-elements && npm i react-native-vector-icons";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + libraries;
        }
       
        static void ExecuteCommand(string command)
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

        static void Main(string[] args)
        {
            string pathOrigin;

            Console.Write("Introduce la ruta donde almacenas los proyectos: ");
            pathOrigin = Console.ReadLine();

            switch (Menu(pathOrigin))
            {
                case 1:
                    //ExecuteCommand(ShowDirectory(pathOrigin));
                    ExecuteCommand(CreateProject(pathOrigin));
                    break;
                case 2:
                    //ExecuteCommand(ShowDirectory(pathOrigin));
                    ExecuteCommand(StartProject(pathOrigin));
                    break;
                case 3:
                    //ExecuteCommand(ShowDirectory(pathOrigin));
                    ExecuteCommand(InstallLibraries(pathOrigin));
                    break;
                case 4:
                    Console.WriteLine("Hasta pronto!");
                    break;
                default:
                    break;
            }
        }
    }
}
