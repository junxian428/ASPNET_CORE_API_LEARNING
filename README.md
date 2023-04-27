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

Command: Update-Database

___________________________________________________________________________

Step 8- Run database seed otherwise database no initial data



    Directory: C:\Users\junxian428\source\repos\SSLAPI\SSLAPI


Mode                 LastWriteTime         Length Name

----                 -------------         ------ ----

d-----         4/26/2023   9:27 PM                bin

d-----         4/26/2023   9:37 PM                Controllers

d-----         4/27/2023   8:12 AM                Data

d-----         4/27/2023   8:45 AM                Migrations

d-----         4/27/2023   8:23 AM                Models

d-----         4/27/2023   8:45 AM                obj

d-----         4/26/2023   9:27 PM                Properties

-a----         4/26/2023   9:27 PM            127 appsettings.Development.json

-a----         4/26/2023  10:25 PM            444 appsettings.json

-a----         4/27/2023   8:32 AM           1185 Program.cs

-a----         4/27/2023   8:22 AM           5949 Seed.cs

-a----         4/27/2023   8:45 AM            747 SSLAPI.csproj



PS C:\Users\junxian428\source\repos\SSLAPI\SSLAPI> dotnet run seeddata



Step 9- Check database
