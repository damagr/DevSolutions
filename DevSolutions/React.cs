using System;

namespace DevSolutions
{
    public static class React
    {
        public static string CreateReactProject(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "create-react-app " + project;
        }

        public static string StartReactProject(string path)
        {

            Console.Write("Indicame que proyecto quieres arrancar: ");
            string project = Console.ReadLine();
            string run = "&& yarn start";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + run;
        }
    }
}
