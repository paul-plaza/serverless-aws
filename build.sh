#!/bin/bash

# Salir si ocurre algún error
set -e

# Variables
PROJECT_PATH="BgrDigitalServices.VerificacionDatos/src/BgrDigitalServices.VerificacionDatos"
OUTPUT_DIR="bin/release/net8.0"
ZIP_FILE="verificaDatosUsuario.zip"

echo "Restaurando paquetes..."
dotnet restore "$PROJECT_PATH"

echo "Compilando el proyecto en modo Release..."
cd "$PROJECT_PATH"
dotnet lambda package -c Release -f net8.0 -o "$OUTPUT_DIR"

echo "Empaquetando el archivo ZIP..."
cd "$OUTPUT_DIR"
zip -r "$ZIP_FILE" *

echo "Paquete creado en: $OUTPUT_DIR/$ZIP_FILE"