# ASPNET_CORE_API_LEARNING

Reference: https://github.com/teddysmithdev/pokemon-review-api/tree/master/PokemonReviewApp

Step 1- Create Model Class

Step 2- Declare relationship 

Step 3- DbContext

Step 4- Connect to database (Nuget Manager - Find )

"DefaultConnection": "Data Source=LAPTOP-PVLCOKUM;Initial Catalog=pokemonreview;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

Step 5- Seeding (By creating the inital object to be stored in the database)

Step 6- Open Package Manager Console (Create Migration files)

Command: Add-Migration InitialCreate

(if command is not found, please run dotnet add package Microsoft.EntityFrameworkCore.Tools)

Step 7- To migrate into database

Update-Database

