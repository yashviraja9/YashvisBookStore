README for ASP.NET YashvisBookStore Application

Program name: YashvisBookStore,
Program purpose: Create an application for Book Store using ASP.NET Core Program,
Author: Yashvi Raja,
Date Modified: 2021-10-25

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Oct 25 – 9:45am Start working on assignment, then open visual studio and start working on create new project named YashvisBookStore and 
turn on the enable Razor runtime compilation white createing project, and modified the launchsetting.json file to do comment sslport to run the app.

modify the startup page to delete options => options.SignIn.RequireConfirmedAccount = true and create repository on GitHub with name YashvisBookStore.


Now open https://bootswatch.com and select one of cosmo theme and download it and save it as bootstrap_new.csse. In  project wwwrooot/li/bootstrap/css/ add this file.
Open views/chared/_Layout.cshtml change the file name in link tag.
Update the changes to github repository.

finish at 10:40am

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Nov 1 - 11:25am
Open _Layout.cshtml file change the nav class from navbar-light to navbar dark and bg-white to bg-primary and line 22 and 25 - remove text-dark, 
add additional properties text-white-50 bg-primary to the footer class.

Open LoginPartial.cshtml and remove text-dark. Add to the _Layout.cshtml page the additional stylesheets and scripts from the CSS_JS.txt file.
In _Layout.cshtml add a drop down to the Nav Bar.

Add three (3) new projects (class library) to the application: YashvisBooks.DataAccess, YashvisBooks.Models, YashvisBooks.Utility. Copy the ‘Data’ folder and paste to 
.DataAccess project (delete the original)

Install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages. Delete the Migrations folder. Add another package Identity.EntityFrameworkCore,
upload changes to github.

Finish at 12:55pm 

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

start at 1:10pm

Modify the namespace in ApplicatiobDbContext page and delete the class1 file from .DataAccess,
.Models and .Utility project. try to build project and move on next step

Move Models in to YashvisBooks.Models (delete original), Modify Views > Shared >  Error.cshtml. 

Now right click on Project - Add - Project Reference - .DataAccess and .Models. Rename Models folder to ViewModels and change the ErrorViewModels.cs namespace .Models.ViewModels, 
now try to build project.

Modify Startup.cs service ‘AddContext’ with the using YashvisBookStore.DataAccess.Data; statement Run the application and review errors.
Remove the using YashvisBookStore.Data statement.

Open Error.cshtml, correct any default reference to ErrorViewModel to the new YashvisBookStore.Models.ViewModels.ErrorViewModel.
When all errors are resolved run the application and review the browser presentation.

In the Utility project, create a static details class called SD.cs, Modify the properties of the class, Add project reference to the main project
by right click on project add > project prefrence. In the DataAccess project add project references to Models and Utility.

Move to next step. Add a ‘Customers’ area to Areas, Change the routes in Startup.cs like the one outlined in the ScaffoldingReadMe.txt

Move the HomeController.cs to the Area > Customer > Controller folder and delete Data and Models. Edit the HomeController.cs to explicitly define that the controller is in the Customer Area. 
Move Views > Home and modify the HomeController namespace. Run the application.

Views are now in Areas, but master page is defined in _ViewStart, Copy _ViewImport and _ViewStart to Customer Area. 
Modify the _ViewStart.cshtml to reflect the new path. Run the application now.

Update the changes to github repository.

finish at 2:50pm

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

start at 9:30pm

Add a new Admin area in Areas. Add the view files _ViewImports and _ViewStart and delete the Data and Models folder. Delete the Controllers folder.

try to run the application but i got error :
An unhandled exception occurred while processing the request.
InvalidOperationException: The constraint reference 'Customer' could not be resolved to a type. 
Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'.

Update changes to GitHub repository.

Finish at 9:50pm

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Nov 03 : 9:25am

I solved error by modified statup page.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Nov 08 : 10:55am - Start Part - 2.1 - Create the DB

To prepare for the next part, ‘build’ the application and confirm there are no errors, Review appsettings.json, modify the database name and save.

Use the NuGet Package Manager Console to  add-migration AddDefaultIdentityMigration, but i get error for does not match migrations.
Change to the correct default project (.DataAccess) and add run again. now it build succeeded.


Review the AddDefaultIdentityMigration.cs file for the SQL-like syntax, statements, columns and primary key constraints, tables related the ASP.NET Identity.

Once the migration is complete, the database needs to be updated. In the PM console, update the database now.

Review the updated database in the SQL Server Object Explorer. Check for errors, run the application. push commits to GitHub.

Add a new table to the DB by creating a Category model and push it to the DB: Add a new class file to the .Models project and modify it.

add-migration AddCategoryToDb via the PM Console- , The new migration file will be empty because it hasn’t been added to the Application DB Context

Update this and note the added using statement, re-run the add-migration, but i get error that The name 'AddCategoryToDb' is used by an existing migration, so i deleted already existed and 
and add that migration again, review the changes to the AddCategoryToDb (resolve the duplication error that will occur).

Update the database, confirm the new Categories table via the SQL SOE and push commits to GitHub.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------

12:55pm Start Part 2.2 - Repository 

After creating the Category.cs and adding it to the ApplicationDbContext it’s time to implement the Repository, a generic way of accessing common functionality, in the .DataAccess project.

Add a new folder name it Repository and add an IRepository folder inside it. Add a new item of type interface to the folder and name it IRepository.cs 

Modify so it can be used on the Category class to do all the CRUD operations by adding using statements.
Methods to use for CRUD: Get item from the DB, List of Categories, Add objects, Remove objects

Implement the class that implements the repository, add Repository.cs class in Repository folder.

Include the using statement, View the potential fixes and implement interface, Modify the code to create the constructors and dependency injection (DI).

Create individual repos for category and all potential models to be added in the future, CategoryRepository.cs
and ICategoryRepository.cs.

Modify CategoryRepository (note the using statements and the message for formal parameters – review in Repository.cs the method pointing to the ApplicationDBContext)

Modify ICategoryRepository interface, Review and modify the error now in CategoryRepository.cs (implement the interface to update), Complete the remaining modifications.

Build, fix any error and push commits to GitHub.

Implement a stored procedure repository and map multiple repositories in a Unit of Work

Add a new interface in the IRepository folder - ISP_Call.cs – that extends IDisposable, Include the methods shown and install the NuGet package for Dapper. Now implement this with a new class in the Repository folder.

Add a new class (SP_Call.cs) in the Repository folder, select the appropriate using statement and implement the ISP_Call interface

Add a connection to the database, note the additional using statements, Update the implementation of the ISP_Call interface, Now add the wrapper for Unit of Work.

Add a new interface (IUnitOfWork) to the IRepository folder and update the code.

Now implement this inside the UnitOfWork, Modify the code (make sure the public class implements the interface -  UnitOfWork : IUnitOfWork)

To make it accessible by the project, register it Startup.cs in the ConfigureServices method, add using statement.

try to build but i get error in startup page,
2111100948 - error - Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0311	The type 'YashvisBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' in the generic type or method 'ServiceCollectionServiceExtensions.AddScoped<TService, 
TImplementation>(IServiceCollection)'. There is no implicit reference conversion from 'YashvisBooks.DataAccess.Repository.UnitOfWork' to 'YashvisBooks.DataAccess.Repository.IRepository.IUnitOfWork'.
YashvisBookStore	C:\Users\W0766432\Source\Repos\YashvisBookStore\YashvisBookStore\Startup.cs	39	Active

so i just comment out the statement that throw an error and i push commits to GitHub.

Finish at 2:22pm
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Start Nov 10 : 9:25am

Start part -  2.3 Category CRUD

Add a new MVC Controller - Empty inside Areas/Admin, Name it CategoryController.cs
Modify the code to use the IUnitOfWork from the .DataAccess project and the IRepository folder by asdding using statement.

Add a new folder in the Areas/View with the same name as the Controller.

Add a new ‘Index’ view to the folder and modify with the generic HTML code from the Category Index View.txt file found in the Assignment 2 - Files folder 
Save and run the application

In _Layout.cshtml, move the ‘Category’ link to the Content Management drop-down. Review the changes to the navigation, Push to GitHub.

Modify the Index.cshtml to add the icons in the Category section from Font Awesome and confirm.

Delete it and add the JavaScript from the Assignment 2 files folder in to the wwwroot/js folder, note the ‘div’ is now in the return portion of the category.js file

In Index.cshtml add the @section call to the category.js script and run the project.

when i try to run the project and click on category i get this error:

An unhandled exception occurred while processing the request.
InvalidOperationException: Unable to resolve service for type 'YashvisBooks.DataAccess.Repository.IRepository.IUnitOfWork'
while attempting to activate 'YashvisBookStore.Areas.Admin.Controllers.CategoryController'.

---------------------------------------------------------------------------------------------------------------------------------------------------------------

Start Nov 15 : 11:25 am

Time to apply the code to activate the ‘Edit’ and ‘Delete’ buttons and ‘Create New Category’ using the Upsert action

Add the IAction result to the controller and add a View, Copy and add the html from the Category Upsert View.txt

Create a partial view for the EDIT | BACK. In the general Views > Shared folder, add the partial view for _CreateAndBackToListButton.cshtml and add the asp-action.
Create another parital view for _EditAndBackToListButton and note the code addition of the @model razor statement

Modify the Upsert.cshtml, Add the asp-action to the Index.cshtml page and run the application, Navigate to Category > Create New Category.

Modify Upsert.cshtml so TITLE now uses the @title variable and refresh the application. Add the @section call to Scripts to validate input on the client-side and test.

Now create an Upsert POST action method in the CategoryController.cs, Note the Save method is not available, now add the void Save() method to the IUnitOfWork interface.

Remove the _db.SaveChanges() method in the CategoryRepository.cs and move the _unitOfWork.Save() method with the return RedirectToaction method.

Check for errors and test whether the application can update and create a category. Add the API call for HTTPDelete in the CategoryController.cs

Then implement the HTTPDelete with a delete method in category.js to add functionality to the application and call the API.

Add the delete functionality in category.js with including the onclick event to the Delete function, Add the Delete(url) function code.

Finish at - 12:50 - total : 1 hr : 25 mins.

-------------------------------------------------------------------------------------------------------------------------------------------------------------

