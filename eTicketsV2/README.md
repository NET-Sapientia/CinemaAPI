# AlgoRythmicsAPI

## Getting started


### 1. Install dependencies
		
- Install the NuGet Packages required by the project
### 2. Install the dotnet tools

 - Open a terminal and run the following command: `dotnet tool restore`
### 3. Setup the Connection String and Logging in the project

 - Create a ***appsettings.Development.json*** file based on **appsettings.json** and add the following value to the **DefaultConnectionString** property:
 `"Data Source=<YOUR COMPUTER USERNAME>\\SQLEXPRESS;Initial Catalog=<YOUR DESIRED CATALOG NAME>;Integrated Security=True;Pooling=False"`
### 4. Run the database migrations

 - Open a terminal and run the following command: `dotnet ef database update`

**You can now build & run the backend project.**
