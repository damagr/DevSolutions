namespace DevSolutions
{
    public static class Generico
    {
        public static string Chocolatey()
        {
            string choco = "@powershell Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))";

            return choco;
        }

        public static string NodeJs()
        {
            string node = "choco install -y nodejs.install";

            return node;
        }
        public static string InstallXampp()
        {
            string xampp = "choco install -y bitnami-xampp ";

            return xampp;
        }

        public static string UninstalXampp()
        {
            string xampp = "choco uninstall bitnami-xampp -y --remove-dependencies";

            return xampp;
        }
    }
}
