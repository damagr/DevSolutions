using System;

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
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string run = "&& ionic serve";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + run;
        }

        public static string InstallIonicCordova()
        {
            return "yarn global add ionic cordova";
        }

        public static string CreateNewComponent(string path)
        {
            Console.Write("Indicame como llamaremos al componente: ");
            string name = Console.ReadLine();

            string component = "ionic g page " + name + " " + "--spec=false";

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + component;


        }
    }
}
