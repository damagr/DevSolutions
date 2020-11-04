using System;
using System.Diagnostics;

namespace ReactNative
{
    class Program
    {
        /* FUNCIONES PARA AHORRAR LINEAS*/
        private static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Abrir un proyecto existente (Hace falta tener instaladas las opciones 4, 5 y 6 del menú)" +
               "\n2. Iniciar un proyecto nuevo (Hace falta tener instaladas las opciones 4, 5 y 6 del menú)" +
               "\n3. Instalar Chocolatey" +
               "\n4. Instalar Node y Java8 (Requiere Chocolatey) (Necesario para trabajar con React-Native)" +
               "\n5. Instalar NPM (Globalmente) (Necesario para trabajar con React-Native)" +
               "\n6. Instalar Android Studio (Requiere Chocolatey) (Necesario para trabajar con React-Native)" +
               "\n7. Instalar librerias React Native Elements y Vector Icons (Por proyecto) (Requiere Node)" +
               "\n8. Instalar lodash (Globalmente) (Requiere Node)" +
               "\n9. Instalar underscore (Globalmente) (Requiere Node)" +
               "\n10. Instalar browserify (Por proyecto) (Requiere Node)" +
               "\n11. Instalar Live-Server (Globalmente) (Requiere Google Chrome)" +
               "\n12. Iniciar Live-Server (Requiere Live-Server)" +
               "\n13. Instalar Xampp (Requiere Chocolatey)" +
               "\n14. Desinstalar Xampp (Requiere Chocolatey)" +
               "\n15. Salir");
            int menu = int.Parse(Console.ReadLine());

            return menu;
        }
        private static string AskPath()
        {
            string pathOrigin;
            Console.Write("Introduce la ruta donde almacenas los proyectos: ");
            pathOrigin = Console.ReadLine();
            return pathOrigin;
        }
        private static void ShowDirectory(string path)
        {
            Console.Clear();
            ExecuteCommand("dir " + path);
        }

        /* FUNCIÓN QUE EJECUTA EL COMANDO POR EL CMD */
        private static void ExecuteCommand(string command)
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

        /* OPCIONES DEL MENÚ */

        private static string CreateProject(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "npx react-native init " + project;
        }
        private static string StartProject(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string run = "&& npx react-native run-android";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + run;
        }

        private static string Chocolatey()
        {
            string choco = "@powershell Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))";

            return choco;
        }

        private static string NodejsAndJava8()
        {
            string nodeJava = "choco install -y nodejs.install openjdk8";

            return nodeJava;
        }

        private static string ReactNPM()
        {
            string reactNPM = "npm uninstall -g react-native-cli --remove-dependencies && npm install -g npm";

            return reactNPM;
        }
        private static string AndroidStudio()
        {
            string aStudio = "choco install androidstudio -y";

            return aStudio;
        }

        private static string ElementsAndVectorIcons(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string libraries = "&& npm i react-native-elements && npm i react-native-vector-icons";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + libraries;
        }

        private static string Lodash()
        {
            string lod = "npm install -g lodash";

            return lod;
        }

        private static string Underscore()
        {
            string under = "npm install -g underscore";

            return under;
        }

        private static string Browserify(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string browser = "&& npx react-native run-android";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + browser;
        }

        private static string InstallLiveServer()
        {
            string live = "npm install -g live-server";

            return live;
        }

        private static string StartLiveServer(string path)
        {
            string live = "&& live-server --port=80 --browser=Chrome";

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + live;
        }
        private static string InstallXampp()
        {
            string xampp = "choco install -y bitnami-xampp ";

            return xampp;
        }

        private static string UninstalXampp()
        {
            string xampp = "choco uninstall bitnami-xampp -y --remove-dependencies";

            return xampp;
        }

        /* EJECUCIÓN DEL PROGRAMA */

        static void Main(string[] args)
        {
            string pathOrigin;

            switch (Menu())
            {
                case 1:
                    pathOrigin = AskPath();
                    ShowDirectory(pathOrigin);
                    ExecuteCommand(StartProject(pathOrigin));
                    break;
                case 2:
                    pathOrigin = AskPath();
                    ShowDirectory(pathOrigin);
                    ExecuteCommand(CreateProject(pathOrigin));
                    break;
                case 3:
                    ExecuteCommand(Chocolatey());
                    break;
                case 4:
                    ExecuteCommand(NodejsAndJava8());
                    break;
                case 5:
                    ExecuteCommand(ReactNPM());
                    break;
                case 6:
                    ExecuteCommand(AndroidStudio());
                    break;
                case 7:
                    pathOrigin = AskPath();
                    ShowDirectory(pathOrigin);
                    ExecuteCommand(ElementsAndVectorIcons(pathOrigin));
                    break;
                case 8:
                    ExecuteCommand(Lodash());
                    break;
                case 9:
                    ExecuteCommand(Underscore());
                    break;
                case 10:
                    pathOrigin = AskPath();
                    ShowDirectory(pathOrigin);
                    ExecuteCommand(Browserify(pathOrigin));
                    break;
                case 11:
                    ExecuteCommand(InstallLiveServer());
                    break;
                case 12:
                    pathOrigin = AskPath();
                    ShowDirectory(pathOrigin);
                    ExecuteCommand(StartLiveServer(pathOrigin));
                    break;
                case 13:
                    ExecuteCommand(InstallXampp());
                    break;
                case 14:
                    ExecuteCommand(UninstalXampp());
                    break;
                case 15:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
    }
}
