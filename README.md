Predictor de Tendencia de Activos (Acciones / Criptomonedas)
📝 Descripción del Proyecto

Este proyecto es una aplicación web desarrollada en ASP.NET Core MVC (.NET 8/9) cuyo objetivo es predecir la tendencia futura de un activo financiero (acciones o criptomonedas) a partir de una serie histórica de precios.

La aplicación permite al usuario ingresar datos históricos y seleccionar distintos modos de predicción, utilizando conceptos de estructuras de datos, algoritmos y análisis matemático, para determinar si un activo presenta una tendencia alcista o bajista.

🎯 Objetivo General

Desarrollar una aplicación que analice una serie de precios históricos y aplique distintos algoritmos de predicción para estimar el comportamiento futuro de un activo financiero.

🏠 Funcionalidades Principales
🔹 Home

Pantalla principal del sistema.

Permite ingresar 20 valores históricos de un activo.

Los datos pueden ingresarse:

Mediante un textarea con formato fecha, precio.

O mediante pares de inputs (fecha y valor).

Botón “Calcular predicción” que ejecuta el cálculo según el modo seleccionado.

Muestra los resultados de la predicción al usuario.

🔹 Modos de Predicción

Pantalla donde el usuario puede seleccionar el algoritmo de predicción a utilizar.
El sistema guarda el modo seleccionado en memoria para mantenerlo activo.

Los modos disponibles son:

1️⃣ Media Móvil Simple (SMA Crossover)

Calcula:

SMA corta (últimos 5 valores).

SMA larga (20 valores).

Si SMA corta > SMA larga → Tendencia alcista.

Si SMA corta < SMA larga → Tendencia bajista.

Muestra ambas medias y la tendencia resultante.

2️⃣ Regresión Lineal

Aplica una regresión lineal precio vs tiempo.

Calcula la pendiente de la recta.

Predice el valor del activo para el día siguiente (día 21).

Determina si la tendencia es alcista o bajista según la pendiente.

3️⃣ Momentum (Rate of Change - ROC)

Calcula la velocidad de cambio del precio.

Usa un período fijo de 5 días.

Aplica la fórmula:

ROC = (V[t] / V[t-n] - 1) * 100


Muestra el porcentaje de cambio y la dirección de la tendencia.

🛠️ Arquitectura y Tecnologías

ASP.NET Core MVC (.NET 8 / 9)

Patrón arquitectónico MVC

Separación en capas:

Capa Web

Capa de Lógica de Negocio

Uso de:

ViewModels con validaciones

DTOs para transferencia de datos

Servicios para los cálculos

Persistencia de configuración en memoria (Singleton)

Interfaz desarrollada con Bootstrap

⚙️ Requisitos Técnicos

.NET SDK 8 o 9

Visual Studio / VS Code

Navegador web moderno

🚀 Cómo Ejecutar el Proyecto

Clonar el repositorio:

git clone <url-del-repositorio>


Abrir el proyecto en Visual Studio.

Restaurar dependencias y ejecutar:

dotnet run


Acceder desde el navegador a:

https://localhost:xxxx
