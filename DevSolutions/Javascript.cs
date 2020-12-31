using System;

namespace DevSolutions
{
    public static class Javascript
    {
        public static string Lodash()
        {
            string lod = "yarn global add lodash";

            return lod;
        }

        public static string Underscore()
        {
            string under = "yarn global add underscore";

            return under;
        }

        public static string Browserify(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string browser = "&& yarn global add browserify";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + browser;
        }
    }
}
