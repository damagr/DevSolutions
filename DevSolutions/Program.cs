using System;
using System.Diagnostics;

namespace ReactNative
{
    class Program
    {
        private static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Abrir un proyecto existente (Hace falta tener instaladas las opciones 4, 5 y 6 del menú)" +
               "\n2. Iniciar un proyecto nuevo (Hace falta tener instaladas las opciones 4, 5 y 6 del menú)" +
               "\n3. Instalar Chocolatey" +
               "\n4. Instalar Node y Java8 (Hace falta tener instalado Chocolatey)" +
               "\n5. Instalar React Native y NPM (Globalmente)" +
               "\n6. Instalar Android Studio (Hace falta tener instalado Chocolatey)" +
               "\n7. Instalar librerias React Native Elements y Vector Icons (Por proyecto)" +
               "\n8. Instalar lodash (Globalmente) (Hace falta tener instalado Node)" +
               "\n9. Instalar underscore (Globalmente) (Hace falta tener instalado Node)" +
               "\n10. Instalar browserify (Por proyecto) (Hace falta tener instalado Node)" +
               "\n11. Instalar Live-Server (Globalmente) (Hace falta tener instalado Google Chrome)" +
               "\n12. Iniciar Live-Server (Hace falta tener instalada la opción 11)" +
               "\n13. Instalar Xampp (Hace falta tener instalado Chocolatey)" +
               "\n14. Desinstalar Xampp (Hace falta tener instalado Chocolatey)" +
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
            string reactNPM = "npm install -g react-native-cli && npm install -g npm";

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
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string live = "&& live-server --port=80 --browser=Chrome";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + live;
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

        static void Main(string[] args)
        {
            string pathOrigin;

            switch (Menu())
            {
                case 1:
                    pathOrigin = AskPath();
                    ShowDirectory(pathOrigin);
                    ExecuteCommand(CreateProject(pathOrigin));
                    break;
                case 2:
                    pathOrigin = AskPath();
                    ShowDirectory(pathOrigin);
                    ExecuteCommand(StartProject(pathOrigin));
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
