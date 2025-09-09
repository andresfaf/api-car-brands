# Web API Desarrollada con .NET 8 y PostGresSQL
## Sistema que lista marcas de carros

## 🚀 Tecnologías usadas
- .NET 8
- Maspter -> Mapeo (Entities <> DTOs)
- PostgresSQL
- XUnit
- Entity Framework Core
- Docker


## 📁 Estructura del proyecto
Arquitectura por capas para desacoplar el código, aplicando buenas practicas, y generando la base para una arquitectura que se pueda escalar sin problemas, se usaron los patrones DTO y Repository.

````markdown
CarBrandsSolution.sln
├── CarBrands.API              → Web api, Arranque de la app
├── CarBrands.Application      → Lógica de negocio, validaciones, interfaces, DTO
├── CarBrands.Domain           → Entidades de dominio, nucleo de la app
├── CarBrands.Infrastructure   → Acceso a datos, usa EFC
├── CarBrands.Tests            → Tests XUnit
`````

## 🧠 Funcionalidades principales

- ✅ Agregar registros por defecto a la base de datos
- ✅ Listar las marcas de carros

## 🛠️ Cómo ejecutar el proyecto
1. Pararse en la raiz del proyecto, donde esta el archivo .sln
2. Tener instalado Docker
3. Ejecutar el comando
   ```bash
   docker-compose -f compose.yml up
   ```
   Esto levantara los servicios de la base de datos postgres y de la API
3. Probarla en la siguiente url [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html)
