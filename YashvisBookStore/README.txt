README for ASP.NET YashvisBookStore Application

Program name: YashvisBookStore,
Program purpose: Create an application for Book Store using ASP.NET Core Program,
Author: Yashvi Raja,
Date Modified: 2021-10-25

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Oct 25 – 9:45am Start working on assignment, then open visual studio and start working on create new project named YashvisBookStore and 
turn on the enable Razor runtime compilation white createing project, and modified the launchsetting.json file to do comment sslport to run the app.

modify the startup page to delete options => options.SignIn.RequireConfirmedAccount = true and create repository on GitHub with name YashvisBookStore.


Now open https://bootswatch.com and select one of cosmo theme and download it and save it as bootstrap_new.csse. In  project wwwrooot/li/bootstrap/css/ add this file.
Open views/chared/_Layout.cshtml change the file name in link tag.
Update the changes to github repository.

finish at 10:40am

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

start at 9:30pm

Add a new Admin area in Areas. Add the view files _ViewImports and _ViewStart and delete the Data and Models folder. Delete the Controllers folder.

try to run the application but i got error :
An unhandled exception occurred while processing the request.
InvalidOperationException: The constraint reference 'Customer' could not be resolved to a type. 
Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'.

Update changes to GitHub repository.

Finish at 9:50pm

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Nov 03 : 9:25am

I solved error by modified statup page.
