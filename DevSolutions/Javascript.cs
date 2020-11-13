using System;

namespace DevSolutions
{
    public static class Javascript
    {
        public static string Lodash()
        {
            string lod = "npm install -g lodash";

            return lod;
        }

        public static string Underscore()
        {
            string under = "npm install -g underscore";

            return under;
        }

        public static string Browserify(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string browser = "&& npx react-native run-android";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + browser;
        }
    }
}
