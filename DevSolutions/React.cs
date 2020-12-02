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
        public static string CreateReactNativeProject(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "npx react-native init " + project;
        }
        public static string StartReactNativeProject(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string run = "&& npx react-native run-android";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + run;
        }

        public static string AndroidStudio()
        {
            string aStudio = "choco install androidstudio -y";

            return aStudio;
        }

        public static string Java8()
        {
            string java = "choco install -y openjdk8";

            return java;
        }

        public static string ReactNPM()
        {
            string reactNPM = "npm uninstall -g react-native-cli --remove-dependencies && npm install -g npm";

            return reactNPM;
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
