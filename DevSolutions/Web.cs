namespace DevSolutions
{
    public static class Web
    {
        public static string InstallLiveServer()
        {
            string live = "npm install -g live-server";

            return live;
        }

        public static string InstallMailDev()
        {
            string mail = "npm install -g maildev";

            return mail;
        }

        public static string StartLiveServer(string path)
        {
            string live = "&& live-server --port=80 --browser=Chrome";

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + live;
        }

        public static string StartMailDev()
        {
            string mail = "maildev";

            return mail;
        }
    }
}
