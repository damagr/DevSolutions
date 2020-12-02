# DevSolutions By damagr & Ferriol-blip  

## Presentación 📕

Esta sencilla aplicación se ha creado para agilizar el proceso de creación, apertura e instalación de proyectos
y librerias de react-native.

## Funcionalidad 📖

I. Entre un sencillo menú que en algunos casos nos llevará a otros submenús, escogeremos entre las siguientes opciones:  

*_Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan los proyectos no le_*
*_tenemos que indicar el directorio del proyecto en concreto que queremos iniciar, tenemos que indicar_*
*_solamente el directorio que almacena todos los proyectos que tenemos._*

1. Instalar Chocolatey (Necesario para el funcionamiento de la APP)
2. Instalar NodeJs (Requiere Chocolatey) (Necesario para el funcionamiento de la APP)
3. React  
    3.1. Abrir un proyecto existente (Hace falta tener instaladas NPM, Node, Java8)  
    3.2. Iniciar un proyecto nuevo (React-Native) (Hace falta tener instaladas NPM, Node, Java8)  
    3.3. Iniciar un proyecto nuevo (React) (Hace falta tener instaladas NPM, Node)
    3.3. Instalar librerias React Native Elements y Vector Icons (Por proyecto) (Requiere Node)  
    3.4. Instalar Java8 (Requiere NodeJs)  
    3.5. Instalar NPM (Global) - (Requiere NodeJs)  
    3.6. Instalar Android Studio (Requiere Chocolatey)  
4. Librerias Javascript  
    4.1. Instalar lodash (Globalmente) (Requiere Node)  
    4.2. Instalar underscore (Globalmente) (Requiere Node)  
    4.3. Instalar browserify (Por proyecto) (Requiere Node)  
5. Utilidades Web  
    5.1. Instalar Xampp (Requiere Chocolatey)  
    5.2. Desinstalar Xampp (Requiere Chocolatey)  
6. Instalaciones genéricas  
    6.1. Instalar Live-Server (Globalmente) (Requiere Google Chrome)  
    6.2. Iniciar Live-Server (Requiere Live-Server)  

II. En caso de realizar la instalación de las librerias de la opción 7, para que funcionen correctamente los
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

#### ¡Importante!

Cuando lleguemos al punto 4 de la configuración de Android Studio, no seguir configurando más.

+ Documentación configuración Android Studio:

    https://reactnative.dev/docs/environment-setup

### En caso de tener incidencias con React a la hora de iniciar o ejecutar, proporcionamos un hilo que ha ayudado en ocasiones a partir de la versión de node 15.0.1

+ Revisando este script que creó muy amablemente un señor en github:

    https://gist.github.com/jarretmoses/c2e4786fd342b3444f3bc6beff32098d

+ En este hilo de stackoverflow se hablan de incidencias relacionadas con el inicio o la ejecución de react:

    https://stackoverflow.com/questions/37612660/react-native-run-android-is-unrecognized

## Licencia ©  

Este código no dispone de licencia.
