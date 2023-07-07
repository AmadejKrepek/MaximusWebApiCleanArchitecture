# First Command
dotnet ef migrations add InitialCreate --project Persistence --startup-project MaximusWebApiCleanArchitecture

# Remove Command
dotnet ef migrations remove InitialCreate --project Persistence --startup-project MaximusWebApiCleanArchitecture

# Second Command
dotnet ef database update --project Persistence --startup-project MaximusWebApiCleanArchitecture

# Create SQL script for the whole migrations - output to console
dotnet ef migrations script --project Persistence --startup-project MaximusWebApiCleanArchitecture

# Create SQL script for the migrations - output to file
dotnet ef migrations script --project Persistence --startup-project MaximusWebApiCleanArchitecture --output run.sql --idempotent
