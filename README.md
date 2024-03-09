# DotNetWebAPI_InMemoryDatabase

This is a simple .NET Web API project for managing Contatos, created to explore .NET 8 with Entity Framework Core using an in-memory database. The project follows the repository pattern to handle Contato-related operations.

## Table of Contents

- [DotNetWebAPI\_InMemoryDatabase](#dotnetwebapi_inmemorydatabase)
  - [Table of Contents](#table-of-contents)
  - [Introduction](#introduction)
  - [Features](#features)
  - [Prerequisites](#prerequisites)
  - [Getting Started](#getting-started)
  - [Usage](#usage)
  - [Contributing](#contributing)
  - [License](#license)

## Introduction

The project is a RESTful Web API that provides endpoints to perform CRUD operations on Contatos. It utilizes Entity Framework Core with an in-memory database for data storage.

## Features

- **Get All Contatos**: Retrieve a list of all Contatos.
- **Add Contato**: Add a new Contato to the database.
- **Delete Contato**: Delete a Contato by its ID.
- **Update Contato**: Update an existing Contato.
- **Get Contato by ID**: Retrieve a specific Contato by its ID.

## Prerequisites

Before you begin, ensure you have the following prerequisites:

- .NET 8 SDK installed. [Download here](https://dotnet.microsoft.com/download)
- An Integrated Development Environment (IDE) like Visual Studio or Visual Studio Code.
- Git installed. [Download here](https://git-scm.com/downloads)

## Getting Started

1. Clone the repository:

    ```bash
    git clone https://github.com/fernandoguide/CRUD-dotnetcore-8
    ```

2. Open the project in your preferred IDE 
 
 ```bash
        cd CRUD-dotnetcore-8 && docker-compose up -d
  ```

3. 
    ```bash
    git checkout feature/mysql
    ```

4. ```bash
   dotnet restore
   ```

5. ```bash
   dotnet build
   ```

6. ```bash
   dotnet ef migrations add InitialCreate
   ```

7. ```bash
   dotnet ef database update
    ```

8. Build the solution.

9. Run the application.

## Usage

The API provides the following endpoints:

- **GET /api/Contato**: Retrieve a list of all Contatos.

- **POST /api/Contato**: Add a new Contato to the database.

    Example Request:
    ```json
    {
        "Telefone": "11999876654",
        "email": "fdev@gmail.com"
    }
    ```

    Example Response:
    ```json
    {
        "status": "OK"
    }
    ```
- **GET /api/Contato/{id}**: Retrieve a specific contato by its ID.

    Example Response:
    ```json
    {
        "id": 1,
        "Telefone": "11999876654",
        "email": "fdev@gmail.com"
    }
    ```
- **DELETE /api/Contato/{id}**: Delete a Contato by its ID.

- **PUT /api/Contato**: Update an existing Contato.

    Example Request:
    ```json
    {
        "id": 1,
        "Telefone": "11999876654",
        "email": "fdev@gmail.com"
    }
    ```

    Example Response:
    ```json
    {
        "status": "OK"
    }
    ```

Feel free to explore and customize the code to suit your needs.

## Contributing

Contributions are welcome! Fork the repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
