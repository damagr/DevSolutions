﻿using DevSolutions;
using System;

namespace Program
{
    class Program
    {
        /* FUNCIONES PARA AHORRAR LINEAS*/
        private static string AskPath()
        {
            string pathOrigin;
            Console.Write("Escribe el directorio donde se almacenan los proyectos: ");
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
            bool finish = false;

            do
            {
                switch (Menus.MainMenu())
                {
                    case 1:
                        switch (Menus.ReactMenu())
                        {
                            case 1:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(React.StartReactProject(pathOrigin));
                                break;
                            case 2:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(React.CreateReactProject(pathOrigin));
                                break;
                            case 3:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (Menus.ReactNativeMenu())
                        {
                            case 1:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(ReactNative.StartReactNativeProject(pathOrigin));
                                break;
                            case 2:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(ReactNative.CreateReactNativeProject(pathOrigin));
                                break;
                            case 3:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(ReactNative.ResetCacheReactNative(pathOrigin));
                                break;
                            case 4:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (Menus.IonicMenu())
                        {
                            case 1:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(Ionic.StartIonic(pathOrigin));
                                break;
                            case 2:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(Ionic.CreateNewComponent(pathOrigin));
                                break;
                            case 3:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(Ionic.CreateIonicProject(pathOrigin));
                                break;
                            case 4:
                                CMD.ExecuteCommand(Ionic.InstallIonicCordova());
                                break;
                            case 5:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (Menus.WebTools())
                        {
                            case 1:
                                pathOrigin = AskPath();
                                ShowDirectory(pathOrigin);
                                CMD.ExecuteCommand(Web.StartLiveServer(pathOrigin));
                                break;
                            case 2:
                                CMD.ExecuteCommand(Web.StartMailDev());
                                break;
                            case 3:
                                CMD.ExecuteCommand(Web.InstallLiveServer());
                                break;
                            case 4:
                                CMD.ExecuteCommand(Web.InstallMailDev());
                                break;
                            case 5:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        finish = true;
                        Console.WriteLine("Bye");
                        break;
                    default:
                        break;
                }
            } while (!finish);
        }
    }
}

