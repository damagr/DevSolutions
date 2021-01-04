# DevSolutions By damagr & Ferriol-blip  

## Presentación 📕

Esta aplicación se ha creado para agilizar el proceso de creación, apertura e instalación de proyectos
y librerias de react, react-native y realizar instalaciones de software requerido para trabajar con las asignaturas
de 2º de DAM.

La aplicación generalmente requiere de Chocolatey y NodeJs para el correcto funcionamiento.

## Funcionalidad 📖

I. Entre un sencillo menú que en algunos casos nos llevará a otros submenús, escogeremos entre las siguientes opciones:  

*_Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan los proyectos no le_*
*_tenemos que indicar el directorio del proyecto en concreto que queremos iniciar, tenemos que indicar_*
*_solamente el directorio que almacena todos los proyectos que tenemos._*

1. React (Abrir proyecto e iniciar proyecto nuevo)  
   1.1. Arrancar un proyecto existente  
   1.2. Iniciar un proyecto nuevo  
2. React-Native (Abrir proyecto e iniciar nuevo)  
   2.1. Arrancar un proyecto existente  
   2.2. Iniciar un proyecto nuevo    
3. Ionic (Abrir proyecto e iniciar proyecto nuevo)  
   3.1. Arrancar Ionic en localhost  
   3.2. Crear nuevo componente  
   3.3. Iniciar un proyecto nuevo  
   3.4. Instalar Ionic  
4. Utilidades Web (Instalar e iniciar Live-Server/MailDev)  
   4.1. Iniciar Live-Server  
   4.2. Iniciar MailDev  
   4.3. Instalar Live-Server (Globalmente)  
   4.4. Instalar MailDev (Globalmente)  

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

+ Puede pasar que tengamos incidencias con el emulador de Android Studio, podemos eliminarlo y crear uno nuevo si no funciona la limpieza de cach��.

## Licencia ©  

Leer el License.md
