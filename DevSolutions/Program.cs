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
                    CMD.ExecuteCommand(React.ReactNPM());
                    break;
                case 3:
                    CMD.ExecuteCommand(React.NodejsAndJava8());
                    break;
                case 4:
                    CMD.ExecuteCommand(React.AndroidStudio());
                    break;
                case 5:
                    switch (Menus.ReactMenu())
                    {
                        case 1:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(React.StartProject(pathOrigin));
                            break;
                        case 2:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(React.CreateProject(pathOrigin));
                            break;
                        case 3:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(React.ElementsAndVectorIcons(pathOrigin));
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    switch (Menus.NodeMenu())
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
                            CMD.ExecuteCommand(Web.InstallLiveServer());
                            break;
                        case 5:
                            pathOrigin = AskPath();
                            ShowDirectory(pathOrigin);
                            CMD.ExecuteCommand(Web.StartLiveServer(pathOrigin));
                            break;
                        case 6:
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    switch (Menus.XampMenu())
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
                case 8:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
    }
}
