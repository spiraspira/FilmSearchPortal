|   | Technical tools       |   | Expectations           |   | Advantages                                            |
| - | --------------------- | - | ---------------------- | - | ----------------------------------------------------- |
| + | .NET 8                | + | OOP                    | - | Docker                                                |
| + | ASP NET Web API       | + | SOLID                  | + | GitHub Actions                                        |
| + | C# 12                 | + | Swagger                | - | Integration tests                                     |
| + | Entity Framework Core | + | Exception Middleware   | + | N-Tier Architecture                                   |
| + | PostgreSQL            | + | Logger (Serilog)       | - | Authentication/authorization (based on Auth0 or Octa) |
| + | xUnit                 | + | Dependency Injection   | - | Auth based on social providers (for ex. Google)       |
|   |                       | + | EF Migrations          | - | React/Angular/Vue/Blazor                              |
|   |                       | + | Many-to-Many relations |   |                                                       |
|   |                       | + | Unit Tests             |   |                                                       |

|   | Models                |   | Endpoints              |   | Relationships                                         |
| - | --------------------- | - | ---------------------- | - | ----------------------------------------------------- |
| + | Actor                 | + | Actor CRUD op.         | + | Several actors can play a role in one film            |
| + | Film                  | + | Film CRUD op.          | + | An actor can play roles in several films              |
| + | FilmActor             | + | FilmActor CRUD op.     | + | Multiple reviews can be placed for one film           |
| + | Review                | + | Review CRUD op.        |   |                                                       |
