## Requisitos Previos
- Docker instalado en tu máquina.

## Pasos para tener Docker - MySql
### 1. Descargar MySQL para Docker

Primero, descarga la imagen de MySQL para Docker con el siguiente comando:

```bash
docker pull mysql
```
### 2. Ejecutar MySQL en un contenedor Docker
Asegúrate de tener Docker instalado y en funcionamiento. Luego, ejecuta el siguiente comando para iniciar un contenedor MySQL:
```bash
docker container run -d -p 3309:3306 --name sistemaVentas -e MYSQL_ROOT_PASSWORD=my-secret-pw -e MYSQL_DATABASE=sisVentas mysql
```
#### Explicación:

- `--name:` Nombre del contenedor.
- `MYSQL_ROOT_PASSWORD:` Establece la contraseña para el usuario root.
- `MYSQL_DATABASE:` Crea una base de datos inicial.
- `-p 3309:3306:` Mapea el puerto 3309 del contenedor al puerto 3306 de tu máquina.
- `mysql:` Utiliza la última versión de la imagen de MySQL.
Más información sobre Docker y MySQL: [Docker MySQL](https://hub.docker.com/_/mysql)

## Código CSharp
> [!IMPORTANT]
> En el archivo `App.config` en la línea 20 debes cambiar el Password por el que pusiste en la sentencia anterior de docker.

### Pasos Adicionales para Restaurar Paquetes NuGet
1. **Abrir el Proyecto en Visual Studio**
    - Abre la solución (`.sln`) y el proyecto (`.csproj`) en Visual Studio.
2. **Restaurar Paquetes NuGet**
    - En Visual Studio, ve a `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution`.
    - Haz clic en `Restore` para restaurar todos los paquetes NuGet definidos en `packages.config`.

Esto asegurará que todas las dependencias de tu proyecto se descarguen y configuren correctamente.

## Previsualización de la interfaz
#### Interfaz donde se guardan los datos
![1](https://github.com/user-attachments/assets/f5dce43a-12cc-4f87-8d0d-268f2901622f)

#### Interfaz donde se consultan los datos
![2](https://github.com/user-attachments/assets/f20b6086-7ddd-457b-9cc0-fe724cf411cc)
