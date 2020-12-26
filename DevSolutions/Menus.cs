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
                 "\n1. React (Abrir proyecto e iniciar proyecto nuevo)" +
                 "\n2. React-Native (Abrir proyecto, iniciar nuevo, instalación librerias y software requerido)" +
                 "\n3. Ionic (Abrir proyecto e iniciar proyecto nuevo)" +
                 "\n4. Utilidades Web (Instalar e iniciar Live-Server/MailDev)" +
                 "\n5. Instalaciones Genéricas (Chocolatey, NodeJs, NPM, Xammp)" +
                 "\n6. Librerias Javascript (lodash, underscore, browserify)" +
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
               "\n1. Arrancar un proyecto existente (Requiere NPM)" +
               "\n2. Iniciar un proyecto nuevo (Requiere Node y NPM)" +
               "\n3. Atrás");

            int reactMenu = int.Parse(Console.ReadLine());

            return reactMenu;
        }

        public static int ReactNativeMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\tMENU REACT\n");
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Arrancar un proyecto existente (Requiere NPM, Node, Java JDK8)" +
               "\n2. Iniciar un proyecto nuevo (Requiere NPM, Node, Java JDK8)" +
               "\n3. Instalar Java8 (Requiere NodeJs)" +
               "\n4. Instalar Android Studio (Requiere Chocolatey)" +
               "\n5. Instalar librerias React Native Elements y Vector Icons (Por proyecto) (Requiere Node)" +
               "\n6. Resetear Caché React Native" +
               "\n7. Atrás");

            int reactMenu = int.Parse(Console.ReadLine());

            return reactMenu;
        }

        public static int IonicMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU IONIC\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Arrancar un proyecto existente (Requiere Ionic)" +
               "\n2. Crear nuevo componente (Requiere Ionic)" +
               "\n3. Iniciar un proyecto nuevo (Requiere Ionic)" +
               "\n4. Instalar Ionic (Requiere NodeJs y NPM)" +
               "\n5. Atrás");

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
               "\n1. Instalar Live-Server (Globalmente) (Requiere Node) (Requiere Google Chrome)" +
               "\n2. Instalar MailDev (Globalmente) (Requiere Node)" +
               "\n3. Iniciar Live-Server (Requiere Live-Server)" +
               "\n4. Iniciar MailDev (Requiere MailDev)" +
               "\n5. Atrás");

            int webMenu = int.Parse(Console.ReadLine());

            return webMenu;
        }
        public static int GenericInstall()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU INSTALACIONES GENÉRICAS\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar Chocolatey (Necesario para el funcionamiento de la APP)" +
               "\n2. Instalar NPM (Global) - (Requiere NodeJs)" +
               "\n3. Instalar NodeJs (Requiere Chocolatey) (Necesario para el funcionamiento de la APP)" +
               "\n4. Instalar Xampp (Requiere Chocolatey)" +
               "\n5. Desinstalar Xampp (Requiere Chocolatey)" +
               "\n6. Atrás");

            int genericMenu = int.Parse(Console.ReadLine());

            return genericMenu;
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
               "\n4. Atrás");

            int nodeMenu = int.Parse(Console.ReadLine());

            return nodeMenu;
        }
    }
}
