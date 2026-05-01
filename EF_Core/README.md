Step-by-Step Logic (The "Why")

1. Install the "Drivers" (NuGet): Just like a printer needs a driver to talk to a PC,
.NET needs specific libraries (SqlServer, Tools) to talk to a Database.

2. Define the "Blueprint" (Model): Create a simple C# class (Student). 
This tells EF Core what data we want to store.

3. Create the "Manager" (DbContext): Create a class that inherits from DbContext. 
This is the "Bridge" that handles all database communication.

4. Set the "Address" (Connection String): In appsettings.json, we tell the app where the SQL Server 
is located and what the database name should be.

5. Register the Service (Program.cs): We tell the .NET 10 "Empty Template" to use our DbContext
and connect it to the SQL string.

6. Run the "Translation" (Migration): We run a command that translates our C# Model
into a SQL CREATE TABLE script.

7. Update the Database: The final step where EF Core actually builds the table in SQL Server.

8. Verify via JSON: Create a Controller that returns Json(students) to prove the connection is live.