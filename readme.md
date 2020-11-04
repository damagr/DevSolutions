# DevSolutions - DaMaGr

## Presentación 📕

Esta sencilla aplicación se ha creado para agilizar el proceso de creación, apertura e instalación de proyectos
y librerias de react-native.

## Funcionalidad 📖

1. Introduciremos el disco sobre el que trabajaremos y la ruta sobre la que almacenamos los proyectos.

2. Entre un sencillo menú, escogeremos entre las siguientes opciones:  

    *_Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan los proyectos no le_*
    *_tenemos que indicar el directorio del proyecto en concreto que queremos iniciar, tenemos que indicar_*
    *_solamente el directorio que almacena todos los proyectos que tenemos._*
    
    1. Abrir un proyecto existente (Abriremos un proyecto de react-native con el emulador de Android)
    2. Iniciar un proyecto nuevo (Crearemos un proyecto de React-Native)
    3. Instalar Chocolatey
    4. Instalar Node y Java8 **(Requiere Chocolatey) (Necesario para trabajar con React-Native)**
    5. Instalar NPM (Globalmente) **(Necesario para trabajar con React-Native)**
    6. Instalar Android Studio (Requiere Chocolatey) **(Necesario para trabajar con React-Native)**
    7. Instalar librerias React Native Elements y Vector Icons (Por proyecto) **(Requiere Node)**
    8. Instalar lodash (Globalmente) **(Requiere Node)**
    9. Instalar underscore (Globalmente) **(Requiere Node)**
    10. Instalar browserify (Por proyecto) **(Requiere Node)**
    11. Instalar Live-Server (Globalmente) **(Requiere Google Chrome)**
    12. Iniciar Live-Server **(Requiere Live-Server)**
    13. Instalar Xampp **(Requiere Chocolatey)**
    14. Desinstalar Xampp **(Requiere Chocolatey)**
    15. Salir

3. En caso de realizar la instalación de las librerias de la opción 7, para que funcionen correctamente los
 iconos, habremos de leer la documentación aportada a continuación en caso de estar trabajando con Android:

    https://github.com/oblador/react-native-vector-icons#android

    Basicamente debemos modificar el archivo ``android/app/build.gradle`` e introducir en la cabecera del documento:

    ```
    project.ext.vectoricons = [
      iconFontNames: [ 'MaterialIcons.ttf', 'EvilIcons.ttf' ] // Nombre de las fuentes que quieras copiar
    ]
  
      apply from: "../../node_modules/react-native-vector-icons/fonts.gradle"
    ```

## Requisitos 🔑

Para poder trabajar con React debemos instalar las opciones 3, 4, 5 y 6 **obligatoriamente**. A continuación,
proporcionamos una documentación para realizar al configuración correcta de Android Studio (opción 6)  

Para realizar la instalación de Android Studio, accederemos a la documentación de reactnative e iremos
al apartado en el que explican como instalarlo ya que tenemos que configurar bastantes cosas y esto nos 
va a requerir tener buena calidad de conexión a internet y espacio en nuestro disco duro. 

####¡Importante!

Cuando lleguemos al punto 4 de la configuración de Android Studio, no seguir configurando más.

+ Documentación configuración Android Studio:

    https://reactnative.dev/docs/environment-setup

###En caso de tener incidencias con React a la hora de iniciar o ejecutar, proporcionamos un hilo que ha ayudadoen ocasiones a partir de la versión de node 15.0.1

+ Revisando este script que creó muy amablemente un señor en github:

    https://gist.github.com/jarretmoses/c2e4786fd342b3444f3bc6beff32098d

+ En este hilo de stackoverflow se hablan de incidencias relacionadas con el inicio o la ejecución de react:

    https://stackoverflow.com/questions/37612660/react-native-run-android-is-unrecognized

## Licencia ©  

Este código no dispone de licencia.
