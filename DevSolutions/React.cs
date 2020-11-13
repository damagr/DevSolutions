using System;

namespace DevSolutions
{
    public static class React
    {
        public static string CreateProject(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "npx react-native init " + project;
        }
        public static string StartProject(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string run = "&& npx react-native run-android";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + run;
        }

        public static string NodejsAndJava8()
        {
            string nodeJava = "choco install -y nodejs.install openjdk8";

            return nodeJava;
        }

        public static string ReactNPM()
        {
            string reactNPM = "npm uninstall -g react-native-cli --remove-dependencies && npm install -g npm";

            return reactNPM;
        }
        public static string AndroidStudio()
        {
            string aStudio = "choco install androidstudio -y";

            return aStudio;
        }

        public static string ElementsAndVectorIcons(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string libraries = "&& npm i react-native-elements && npm i react-native-vector-icons";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + libraries;
        }
    }
}
