using DevSolutions;
using System;

namespace ReactNative
{
    class Program
    {
        /* FUNCIONES PARA AHORRAR LINEAS*/
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
            CMD.ExecuteCommand("dir " + path);
        }

        /* EJECUCIÓN DEL PROGRAMA */

        static void Main(string[] args)
        {
            string pathOrigin;

            switch (Menus.MainMenu())
            {
                case 1:
                    CMD.ExecuteCommand(Generico.Chocolatey());
                    break;
                case 2:
                    CMD.ExecuteCommand(Generico.NodeJs());
                    break;
                case 3:
                    switch (Menus.ReactMenu())
                    {
                        case 1:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(React.StartReactNativeProject(pathOrigin));
                            break;
                        case 2:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(React.CreateReactNativeProject(pathOrigin));
                            break;
                        case 3:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(React.CreateReactProject(pathOrigin));
                            break;
                        case 4:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(React.ElementsAndVectorIcons(pathOrigin));
                            break;
                        case 5:
                            CMD.ExecuteCommand(React.Java8());
                            break;
                        case 6:
                            CMD.ExecuteCommand(React.ReactNPM());
                            break;
                        case 7:
                            CMD.ExecuteCommand(React.AndroidStudio());
                            break;
                        case 8:
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    switch (Menus.JavascriptLibraries())
                    {
                        case 1:
                            CMD.ExecuteCommand(Javascript.Lodash());
                            break;
                        case 2:
                            CMD.ExecuteCommand(Javascript.Underscore());
                            break;
                        case 3:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(Javascript.Browserify(pathOrigin));
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    switch (Menus.WebTools())
                    {
                        case 1:
                            CMD.ExecuteCommand(Web.InstallLiveServer());
                            break;
                        case 2:
                            CMD.ExecuteCommand(Web.InstallMailDev());
                            break;
                        case 3:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(Web.StartLiveServer(pathOrigin));
                            break;
                        case 4:
                            CMD.ExecuteCommand(Web.StartMailDev());
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    switch (Menus.GenericInstall())
                    {
                        case 1:
                            CMD.ExecuteCommand(Generico.InstallXampp());
                            break;
                        case 2:
                            CMD.ExecuteCommand(Generico.UninstalXampp());
                            break;
                        case 3:
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
    }
}
