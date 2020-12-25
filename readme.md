# DevSolutions By damagr & Ferriol-blip  

## Presentación 📕

Esta sencilla aplicación se ha creado para agilizar el proceso de creación, apertura e instalación de proyectos
y librerias de react, react-native y realizar instalaciones de software requerido para trabajar con las asignaturas
de 2º de DAM.

## Funcionalidad 📖

I. Entre un sencillo menú que en algunos casos nos llevará a otros submenús, escogeremos entre las siguientes opciones:  

*_Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan los proyectos no le_*
*_tenemos que indicar el directorio del proyecto en concreto que queremos iniciar, tenemos que indicar_*
*_solamente el directorio que almacena todos los proyectos que tenemos._*

1. React (Abrir proyecto e iniciar proyecto nuevo)  
   1.1. Abrir un proyecto existente (Requiere Chrome)  
   1.2. Iniciar un proyecto nuevo (Requiere Node y NPM)  
2. React-Native (Abrir proyecto, iniciar nuevo, instalación librerias y software requerido)  
   2.1. Abrir un proyecto existente (Requiere NPM, Node, Java JDK8)  
   2.2. Iniciar un proyecto nuevo (Requiere NPM, Node, Java JDK8)  
   2.3. Instalar Java8 (Requiere NodeJs)  
   2.4. Instalar Android Studio (Requiere Chocolatey)  
   2.5. Instalar librerias React Native Elements y Vector Icons (Por proyecto) (Requiere Node)  
3. Ionic (Abrir proyecto e iniciar proyecto nuevo)  
   3.1. Iniciar un proyecto nuevo (Requiere Ionic)  
   3.2. Abrir Ionic en localhost (Requiere Ionic)  
   3.3. Crear nuevo componente (Requiere Ionic)  
   3.4. Instalar Ionic (Requiere NodeJs y NPM)  
4. Utilidades Web (Instalar e iniciar Live-Server/MailDev)  
   4.1. Instalar Live-Server (Globalmente) (Requiere Google Chrome)  
   4.2. Instalar MailDev (Globalmente) (Requiere Node)  
   4.3. Iniciar Live-Server (Requiere Live-Server)  
   4.4. Iniciar MailDev (Requiere MailDev)
5. Instalaciones Genéricas (Chocolatey, NodeJs, NPM, Xammp)  
   5.1. Instalar Chocolatey (Necesario para el funcionamiento de la APP)  
   5.2. Instalar NPM (Global) - (Requiere NodeJs)  
   5.3. Instalar NodeJs (Requiere Chocolatey)    
   5.4. Instalar Xampp (Requiere Chocolatey)    
   5.5. Desinstalar Xampp (Requiere Chocolatey)  
6. Librerias Javascript (lodash, underscore, browserify)  
   6.1. Instalar lodash (Globalmente) (Requiere Node)  
   6.2. Instalar underscore (Globalmente) (Requiere Node)  
   6.3. Instalar browserify (Por proyecto) (Requiere Node)  

II. En caso de realizar la instalación de las librerias de Vector Icons, para que funcionen correctamente los
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

### En caso de tener incidencias con React-Native a la hora de iniciar o ejecutar, proporcionamos un hilo que ha ayudado en ocasiones a partir de la versión de node 15.0.1

+ Revisando este script que creó muy amablemente un señor en github:

    https://gist.github.com/jarretmoses/c2e4786fd342b3444f3bc6beff32098d   


+ En este hilo de stackoverflow se hablan de incidencias relacionadas con el inicio o la ejecución de react:

    https://stackoverflow.com/questions/37612660/react-native-run-android-is-unrecognized  


+ En caso de tener una incidencia que indica:

   ```
   "No apps connected.  Sending "reload" to all React Native apps failed. Make sure your app is running in the simulator
   or on a phone connected via USB"
   ```

   Podemos probar a utilizar la opción del menú de React-Native de "Resetear Caché de React-Native". En caso de no
  solventarse la incidencia, consultar este hilo:  
https://github.com/facebook/react-native/issues/29396

## Licencia ©  

Este código no dispone de licencia. Cualquiera puede descargarlo y modificarlo a su gusto.
