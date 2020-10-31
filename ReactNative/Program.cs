using System;
using System.Diagnostics;

namespace ReactNative
{
    class Program
    {
        static string AccessCreateStart(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            string start = "npx react-native init " + project;
            string run = "npx react-native run-android";
            string finalStart = path.Substring(0,2) + " " + "&& cd " + path + " " + "&& " + start + " " + "&&" + " " + run;

            return finalStart;
        }
        static string AccessStart(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string access = path + @"\" + project;
            string run = "npx react-native run-android";
            string finalAccess = path.Substring(0, 2) + " " + "&& cd " + access + @"\" + " " + "&&" + " " + run;

            return finalAccess;
        }
        static string AccessInstallLibraries(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string access = path + @"\" + project;
            string run = "npm i react-native-elements && npm i react-native-vector-icons";
            string finalAccess = path.Substring(0, 2) + " " + "&& cd " + access + @"\ &&" + " " + run;

            return finalAccess;
        }
        static string showDir(string path)
        {
            string dir = "dir " + path;

            return dir;
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Iniciar un proyecto nuevo" +
               "\n2. Abrir un proyecto existente" +
               "\n3. Instalar librerias React Native Elements y Vector" +
               "\n4. Salir");
            int menu = int.Parse(Console.ReadLine());

            return menu;
        }
        static void ExecuteCommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
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

            switch (Menu())
            {
                case 1:
                    ExecuteCommand(showDir(pathOrigin));
                    ExecuteCommand(AccessCreateStart(pathOrigin));
                    ;
                    break;
                case 2:
                    ExecuteCommand(showDir(pathOrigin));
                    ExecuteCommand(AccessStart(pathOrigin));
                    break;
                case 3:
                    ExecuteCommand(showDir(pathOrigin));
                    ExecuteCommand(AccessInstallLibraries(pathOrigin));
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
