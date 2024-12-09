@echo off
REM Salir si ocurre algún error
setlocal enabledelayedexpansion
set "PROJECT_PATH=BgrDigitalServices.VerificacionDatos\src\BgrDigitalServices.VerificacionDatos"
set "OUTPUT_DIR=bin\release\net8.0"
set "ZIP_FILE=verificaDatosUsuario.zip"

echo Restaurando paquetes...
dotnet restore "%PROJECT_PATH%"
IF ERRORLEVEL 1 (
    echo Error restaurando paquetes.
    exit /b 1
)

echo Compilando el proyecto en modo Release...
cd "%PROJECT_PATH%"
dotnet lambda package -c Release -f net8.0 -o "%OUTPUT_DIR%"
IF ERRORLEVEL 1 (
    echo Error compilando el proyecto.
    exit /b 1
)

echo Empaquetando el archivo ZIP...
cd "%OUTPUT_DIR%"
powershell -Command "Compress-Archive -Path * -DestinationPath %ZIP_FILE%"
IF ERRORLEVEL 1 (
    echo Error empaquetando el archivo ZIP.
    exit /b 1
)

echo Paquete creado en: %OUTPUT_DIR%\%ZIP_FILE%