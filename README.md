# PizzaStore  Minimal API

Welcome to the PizzaStore API! This is a minimal API built with ASP.NET Core that allows you to manage pizzas in our store. It supports basic CRUD operations (Create, Read, Update, Delete) and comes with Swagger documentation for easy exploration.

## Getting Started

### Prerequisites

To run this API, ensure you have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later recommended)

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/mabass2110/Minimal-api.git
    ```

2. Navigate into the project directory:

    ```bash
    cd Minimal-api
    ```

3. Restore the project dependencies:

    ```bash
    dotnet restore
    ```

4. Run the application:

    ```bash
    dotnet run
    ```

### API Endpoints

The API exposes the following endpoints:

- **GET** `/`  
  Returns a "Hello World!" message.

- **GET** `/pizzas/{id}`  
  Retrieves a pizza by its ID.  
  **Example:** `/pizzas/1`

- **GET** `/pizzas`  
  Retrieves a list of all pizzas.

- **POST** `/pizzas`  
  Creates a new pizza.  
  **Request Body:**
  ```json
  {
    "name": "Margherita",
    "ingredients": ["cheese", "tomato"],
    "price": 12.99
  }
