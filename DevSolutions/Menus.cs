using System;

namespace DevSolutions
{
    public static class Menus
    {
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL\n");
            Console.WriteLine("Selecciona una opción del menú: " +
                 "\n1. Instalar Chocolatey (Requerido)" +
                 "\n2. Instalar NPM (Global)" +
                 "\n3. Instalar Node y Java8" +
                 "\n4. Instalar Android Studio" +
                 "\n5. React-Native (Abrir proyecto, Iniciar nuevo, Librerias)" +
                 "\n6. Node (Librerias, iniciar live-server)" +
                 "\n7. Xamp (Instalar y desinstalar)" +
                 "\n8. Salir");

            int mainMenu = int.Parse(Console.ReadLine());

            return mainMenu;
        }

        public static int ReactMenu()
        {
            Console.Clear();
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Abrir un proyecto existente (Hace falta tener instaladas NPM, Node, Java8)" +
               "\n2. Iniciar un proyecto nuevo (Hace falta tener instaladas NPM, Node, Java8)" +
               "\n3. Instalar librerias React Native Elements y Vector Icons (Por proyecto) (Requiere Node)" +
               "\n4. Salir");

            int reactMenu = int.Parse(Console.ReadLine());

            return reactMenu;
        }

        public static int NodeMenu()
        {
            Console.Clear();
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
            "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
            "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar lodash (Globalmente) (Requiere Node)" +
               "\n2. Instalar underscore (Globalmente) (Requiere Node)" +
               "\n3. Instalar browserify (Por proyecto) (Requiere Node)" +
               "\n4. Instalar Live-Server (Globalmente) (Requiere Google Chrome)" +
               "\n5. Iniciar Live-Server (Requiere Live-Server)" +
               "\n6. Salir");

            int NodeMenu = int.Parse(Console.ReadLine());

            return NodeMenu;
        }

        public static int XampMenu()
        {
            Console.Clear();
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar Xampp (Requiere Chocolatey)" +
               "\n2. Desinstalar Xampp (Requiere Chocolatey)" +
               "\n3. Salir");

            int XampMenu = int.Parse(Console.ReadLine());

            return XampMenu;
        }
    }
}
