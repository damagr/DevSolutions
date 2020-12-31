using System;

namespace DevSolutions
{
    public static class Javascript
    {
        public static string Lodash()
        {
            string lod = "yarn global add lodash && yarn install";

            return lod;
        }

        public static string Underscore()
        {
            string under = "yarn global add underscore && yarn install";

            return under;
        }

        public static string Browserify(string path)
        {
            Console.Write("Indicame que proyecto usaremos: ");
            string project = Console.ReadLine();

            string browser = "&& yarn global add browserify && yarn install";

            return path.Substring(0, 2) + " " + "&& cd " + path + @"\" + project + " " + browser;
        }
    }
}
