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

    npm install -g react-native-cli
   
    npm install -g npm
    ```
3. Para realizar la instalación de Android Studio, accederemos a la documentación de reactnative e iremos
al apartado en el que explican como instalarlo ya que tenemos que configurar bastantes cosas y esto nos 
va a requerir tener buena calidad de conexión a internet y espacio en nuestro disco duro. 

    ###¡Importante!
    Cuando lleguemos al punto 4 de la configuración de Android Studio, no seguir configurando más.

    https://reactnative.dev/docs/environment-setup

## Licencia ©  

Este código no dispone de licencia.
