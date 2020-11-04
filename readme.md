# React Native - DaMaGr

## Presentación 📕

Esta sencilla aplicación se ha creado para agilizar el proceso de creación, apertura e instalación de proyectos
y librerias de react-native.

## Funcionalidad 📖

1. Introduciremos el disco sobre el que trabajaremos y la ruta sobre la que almacenamos los proyectos.

2. Entre un sencillo menú, escogeremos entre las siguientes opciones:  
    
    1. Crear un nuevo proyecto.
    2. Abrir un proyecto ya creado.
    3. Instalar las librerias de react-native-elements y react-native-vector-icons.
    4. Salir de la aplicación.

3. En caso de realizar la instalación de las librerias, para que funcionen correctamente los iconos, habremos
de leer la documentación aportada a continuación en caso de estar trabajando con Android:

    https://github.com/oblador/react-native-vector-icons#android

    Basicamente debemos modificar el archivo ``android/app/build.gradle`` e introducir en la cabecera del documento:

    ```
    project.ext.vectoricons = [
      iconFontNames: [ 'MaterialIcons.ttf', 'EvilIcons.ttf' ] // Nombre de las fuentes que quieras copiar
    ]
  
      apply from: "../../node_modules/react-native-vector-icons/fonts.gradle"
    ```

## Requisitos 🔑

Como recomendación, debemos instalar chocolatey para tratar de instalar todo por línea de comandos.

1. Documentación para instalar Chocolatey:

    https://chocolatey.org/install

2. Una vez instalado chocolatey instalaremos por la linea de comandos (modo administrador) lo siguiente:

    ```
    choco install -g -y nodejs.install openjdk8

    npm -g react-native-cli
    ```
3. Para realizar la instalación de Android Studio, accederemos a la documentación de reactnative e iremos
al apartado en el que explican como instalarlo ya que tenemos que configurar bastantes cosas y esto nos 
va a requerir tener buena calidad de conexión a internet y espacio en nuestro disco duro. 

    ###¡Importante!
    Cuando lleguemos al punto 4 de la configuración de Android Studio, no seguir configurando más.

    https://reactnative.dev/docs/environment-setup
4. Si hemos cambiado de equipo o hemos realizado un formateo del PC, debemos tener en cuenta que esta APP 
no va a funcionar correctamente, esto es debido a que por algún motivo, en node_modules se almacena en caché
información del antiguo equipo.

    Tenemos dos formas de solucionarlo, extraer nuestro fichero APP.js a un directorio seguro y hacer un
    ```
    npx react-native init nombre_proyecto
    ```
       
     Revisando este script que creó muy amablemente un señor en github:
     
     https://gist.github.com/jarretmoses/c2e4786fd342b3444f3bc6beff32098d

     En este hilo de stackoverflow se habla de ambos temas que he comentado y se soluciona:
     
     https://stackoverflow.com/questions/37612660/react-native-run-android-is-unrecognized

## Licencia ©  

Este código no dispone de licencia.
