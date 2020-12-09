using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolutions
{
    public static class Ionic
    {
        public static string CreateIonicProject(string path)
        {
            Console.Write("Te recordamos las plantillas disponibles para ionic, en caso de no querer ninguna escoge la 'blank':\n" +
                "tabs\n" +
                "sidemenu\n" +
                "blank\n");
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();
            Console.Write("Indicame que plantilla requiere este proyecto: ");
            string template = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "ionic start " + project + " " + template;
        }

        public static string StartIonic(string path)
        {
            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "ionic serve && start chrome http://localhost:8100";
        }

        public static string InstallIonicCordova()
        {
            string reactNPM = "npm install -g ionic cordova";

            return reactNPM;
        }
    }
}
