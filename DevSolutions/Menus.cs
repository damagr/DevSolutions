using System;

namespace DevSolutions
{
    public static class Menus
    {
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU PRINCIPAL\n");
            Console.WriteLine("Selecciona una opción del menú: " +
                 "\n1. Instalar Chocolatey (Necesario para el funcionamiento de la APP)" +
                 "\n2. Instalar NodeJs (Requiere Chocolatey) (Necesario para el funcionamiento de la APP)" + 
                 "\n3. React (Abrir proyecto, iniciar nuevo, instalación librerias y dependencias)" +
                 "\n4. Librerias Javascript (lodash, underscore, browserify)" +
                 "\n5. Utilidades Web (Instalar/iniciar Live-Server)" +
                 "\n6. Instalaciones genéricas (Instalar/desinstalar Xampp)" +
                 "\n7. Salir");

            int mainMenu = int.Parse(Console.ReadLine());

            return mainMenu;
        }

        public static int ReactMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\tMENU REACT\n");
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Abrir un proyecto existente (Hace falta tener instaladas NPM, Node, Java8)" +
               "\n2. Iniciar un proyecto nuevo (Hace falta tener instaladas NPM, Node, Java8)" +
               "\n3. Instalar librerias React Native Elements y Vector Icons (Por proyecto) (Requiere Node)" +
               "\n4. Instalar Java8 (Requiere NodeJs)" +
               "\n5. Instalar NPM (Global) - (Requiere NodeJs)" +
               "\n6. Instalar Android Studio (Requiere Chocolatey)" +
               "\n7. Salir");

            int reactMenu = int.Parse(Console.ReadLine());

            return reactMenu;
        }

        public static int JavascriptLibraries()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU JAVASCRIPT\n");
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
            "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
            "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar lodash (Globalmente) (Requiere Node)" +
               "\n2. Instalar underscore (Globalmente) (Requiere Node)" +
               "\n3. Instalar browserify (Por proyecto) (Requiere Node)" +
               "\n4. Salir");

            int nodeMenu = int.Parse(Console.ReadLine());

            return nodeMenu;
        }

        public static int GenericInstall()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU INSTALACIONES GENÉRICAS\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar Xampp (Requiere Chocolatey)" +
               "\n2. Desinstalar Xampp (Requiere Chocolatey)" +
               "\n3. Salir");

            int genericMenu = int.Parse(Console.ReadLine());

            return genericMenu;
        }

        public static int WebTools()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\tMENU WEB\n");
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar Live-Server (Globalmente) (Requiere Google Chrome)" +
               "\n2. Iniciar Live-Server (Requiere Live-Server)" +
               "\n3. Salir");

            int webMenu = int.Parse(Console.ReadLine());

            return webMenu;
        }
    }
}
