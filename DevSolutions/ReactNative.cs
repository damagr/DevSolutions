using System;

namespace DevSolutions
{
    public static class ReactNative
    {
        public static string CreateReactNativeProject(string path)
        {
            Console.Write("Indicame como llamaremos al proyecto: ");
            string project = Console.ReadLine();

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + "&& " + "react-native init " + project + "&& " + "yarn install";
        }
        public static string StartReactNativeProject(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string run = "&& react-native run-android";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + run;
        }

        public static string ResetCacheReactNative(string path)
        {
            Console.Write("Indicame que proyecto tiene la incidencia: ");
            string project = Console.ReadLine();

            string reset = "&& react-native start --reset-cache";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + reset;
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

        public static string ElementsAndVectorIcons(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string libraries = "&& yarn add react-native-elements && yarn add react-native-vector-icons";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + libraries;
        }
    }
}
