using System;

namespace DevSolutions
{
    public static class Menus
    {
        public static int MainMenu() 
        {
            Console.WriteLine("\t\t\t\t\t\tMENU PRINCIPAL\n");
            Console.WriteLine("Selecciona una opción del menú: " +
                 "\n1. React (Abrir proyecto e iniciar proyecto nuevo)" +
                 "\n2. React-Native (Abrir proyecto, iniciar nuevo, liberar caché de React)" +
                 "\n3. Ionic (Abrir proyecto, iniciar proyecto nuevo, crear componentes)" +
                 "\n4. Utilidades Web (Instalar e iniciar Live-Server/MailDev)" +
                 "\n5. Salir");

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
               "\n1. Arrancar un proyecto existente" +
               "\n2. Iniciar un proyecto nuevo" +
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
               "\n1. Arrancar un proyecto existente" +
               "\n2. Iniciar un proyecto nuevo" +
               "\n3. Resetear Caché React Native" +
               "\n4. Atrás");

            int reactMenu = int.Parse(Console.ReadLine());

            return reactMenu;
        }

        public static int IonicMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU IONIC\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Arrancar un proyecto existente" +
               "\n2. Crear nuevo componente" +
               "\n3. Iniciar un proyecto nuevo" +
               "\n4. Instalar Ionic" +
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
               "\n1. Iniciar Live-Server" +
               "\n2. Iniciar MailDev" +
               "\n3. Instalar Live-Server (Globalmente)" +
               "\n4. Instalar MailDev (Globalmente)" +
               "\n5. Atrás");

            int webMenu = int.Parse(Console.ReadLine());

            return webMenu;
        }
    }
}
