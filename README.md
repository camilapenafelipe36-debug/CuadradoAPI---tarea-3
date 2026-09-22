# Tarea 5 - API, Windows Forms y Blazor

## Descripción

Este proyecto corresponde a la Tarea 5 de Programación IV.

El objetivo es implementar una arquitectura cliente-servidor utilizando una API REST conectada a una base de datos SQL Server y dos aplicaciones cliente:

* Windows Forms
* Blazor WebAssembly

La API se encarga de consultar los datos almacenados en SQL Server y los clientes consumen la información mediante solicitudes HTTP.

## Estructura del proyecto

La solución contiene los siguientes proyectos:

```text
Tarea5
│
├── CuadradoAPI
│   ├── Controllers
│   ├── Data
│   ├── Models
│   ├── Program.cs
│   └── appsettings.json
│
├── CuadradoAPI.WinForms
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   └── Program.cs
│
├── CuadradoAPI.Blazor
│   ├── Pages
│   ├── Layout
│   ├── Program.cs
│   └── wwwroot
│
└── CuadradoAPI.slnx
```

## Base de datos

La API utiliza SQL Server LocalDB.

Servidor:

```text
(localdb)\MSSQLLocalDB
```

Base de datos:

```text
Tarea2DB
```

Tabla utilizada:

```text
Productos
```

La tabla contiene los siguientes campos:

| Campo  | Tipo     |
| ------ | -------- |
| Id     | int      |
| Nombre | nvarchar |
| Precio | decimal  |

## Conexión a SQL Server

La cadena de conexión utilizada por la API es:

```text
Server=(localdb)\MSSQLLocalDB;Database=Tarea2DB;Integrated Security=True;TrustServerCertificate=True;
```

Esta configuración se encuentra en `appsettings.json`.

## API

La API está desarrollada con ASP.NET Core y .NET 8.

Para ejecutar la API:

```powershell
cd "C:\Users\Lenovo 11e\Downloads\Tarea5"
dotnet run
```

La API se ejecuta en:

```text
http://localhost:5000
```

## Endpoint de productos

Para consultar los productos de la base de datos:

```text
GET http://localhost:5000/api/Numeros
```

La respuesta contiene los productos registrados en SQL Server.

Ejemplo:

```json
[
  {
    "id": 1,
    "nombre": "Arroz",
    "precio": 75
  },
  {
    "id": 2,
    "nombre": "Habichuela",
    "precio": 120
  }
]
```

## Endpoint de cálculo

La API también contiene un endpoint para calcular el cuadrado de un número:

```text
GET http://localhost:5000/api/Math/square/5
```

Respuesta:

```json
{
  "numero": 5,
  "cuadrado": 25
}
```

## Windows Forms

La aplicación Windows Forms consume la API mediante HTTP.

Para ejecutarla:

```powershell
cd "C:\Users\Lenovo 11e\Downloads\Tarea5\CuadradoAPI.WinForms"
dotnet run
```

La aplicación permite cargar los productos obtenidos desde la API y mostrarlos en un `DataGridView`.

Es necesario mantener la API ejecutándose en:

```text
http://localhost:5000
```

mientras se utiliza Windows Forms.

## Blazor WebAssembly

La aplicación Blazor WebAssembly también consume los datos de la API.

Para ejecutarla:

```powershell
cd "C:\Users\Lenovo 11e\Downloads\Tarea5\CuadradoAPI.Blazor"
dotnet run
```

La aplicación se ejecuta mediante la dirección que muestre la consola, por ejemplo:

```text
http://localhost:5225
```

La página principal muestra los productos obtenidos desde:

```text
http://localhost:5000/api/Numeros
```

## CORS

La API tiene configurada una política CORS para permitir que la aplicación Blazor pueda realizar solicitudes HTTP hacia la API.

## Compilación de la solución

La solución completa puede compilarse mediante:

```powershell
cd "C:\Users\Lenovo 11e\Downloads\Tarea5"
dotnet build ".\CuadradoAPI.slnx"
```

La solución incluye:

* `CuadradoAPI`
* `CuadradoAPI.WinForms`
* `CuadradoAPI.Blazor`

## Tecnologías utilizadas

* C#
* .NET 8
* ASP.NET Core Web API
* SQL Server LocalDB
* Dapper
* Entity Framework Core
* Windows Forms
* Blazor WebAssembly
* Git
* GitHub

## Autor

Camila Peña Felipe

## Proyecto académico

Programación IV - UASD
