> [!NOTE]
> NOTA IMPORTANTE

>[!TIP]
>ES UN TIP IMPORTANTE

>[!IMPORTANT]
>ESCUCHA ESTO

>[!WARNING]
>ESCUCHA ESTO

>[!CAUTION]
>ESCUCHA ESTO


# Nombre del Proyecto 🚀

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![Version](https://img.shields.io/badge/version-1.0.0-blue)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

## Descripción 📝
Breve descripción del proyecto. Explica qué hace, cuál es su propósito y por qué es útil.

---

## **Arquitectura de la Solución 🏗️**

### Diagrama de Arquitectura
Si tienes un diagrama de arquitectura, puedes agregarlo aquí. Por ejemplo:

![Diagrama de Arquitectura](/docs/architecture.png)

### Componentes Principales
1. **API**: Descripción del servicio de API.
2. **Base de Datos**: Descripción de la base de datos utilizada.
3. **Frontend**: Descripción del cliente o interfaz de usuario (si aplica).
4. **Servicios Externos**: Descripción de servicios externos utilizados (si aplica).

---

## **Endpoints de la API 🌐**

A continuación se describen los endpoints disponibles en la API.

### Autenticación
- **POST /api/auth/login**: Iniciar sesión.
  - Parámetros:
    ```json
    {
      "username": "string",
      "password": "string"
    }
    ```
  - Respuesta:
    ```json
    {
      "token": "string"
    }
    ```

### Tarjetas de Crédito
- **GET /api/cards/{cardNumber}**: Obtener información de una tarjeta.
  - Parámetros:
    - `cardNumber`: Número de la tarjeta.
  - Respuesta:
    ```json
    {
      "cardNumber": "string",
      "cardHolderName": "string",
      "balance": 1000.00,
      "availableBalance": 800.00
    }
    ```

- **POST /api/cards/{cardNumber}/transactions**: Agregar una transacción.
  - Parámetros:
    ```json
    {
      "amount": 100.00,
      "description": "Compra en Tienda X"
    }
    ```
  - Respuesta:
    ```json
    {
      "transactionId": "string",
      "status": "success"
    }
    ```

---

## **Cómo Probar la Aplicación 🧪**

### Requisitos Previos
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
- [Postman](https://www.postman.com/downloads/) (opcional, para probar la API)

### Pasos para Ejecutar el Proyecto
1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu_usuario/tu_repositorio.git
