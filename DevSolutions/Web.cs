namespace DevSolutions
{
    public static class Web
    {
        public static string InstallLiveServer()
        {
            string live = "npm install -g live-server";

            return live;
        }

        public static string StartLiveServer(string path)
        {
            string live = "&& live-server --port=80 --browser=Chrome";

            return path.Substring(0, 2) + " " + "&& cd " + path + " " + live;
        }
    }
}
