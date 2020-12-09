using System;

namespace DevSolutions
{
    public static class React
    {
        public static string CreateReactProject(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "npx create-react-app " + project;
        }

        public static string StartReactProject()
        {
            string run = "start chrome http://localhost:3000";

            return run;
        }
    }
}
