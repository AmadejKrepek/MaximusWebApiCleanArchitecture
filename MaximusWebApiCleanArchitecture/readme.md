# First Command
dotnet ef migrations add InitialCreate --project Persistence --startup-project MaximusWebApiCleanArchitecture

# Second Command
dotnet ef database update --project Persistence --startup-project MaximusWebApiCleanArchitecture