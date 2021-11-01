README for ASP.NET YashvisBookStore Application

Program name: YashvisBookStore,
Program purpose: Create an application for Book Store using ASP.NET Core Program,
Author: Yashvi Raja,
Date Modified: 2021-10-25

Oct 25 – 9:45am Start working on assignment, then open visual studio and start working on create new project named YashvisBookStore and 
turn on the enable Razor runtime compilation white createing project, and modified the launchsetting.json file to do comment sslport to run the app.

modify the startup page to delete options => options.SignIn.RequireConfirmedAccount = true and create repository on GitHub with name YashvisBookStore.

Now open https://bootswatch.com and select one of theme and download it and save it as bootstrap_new.csse. In  project wwwrooot/li/bootstrap/css/ add this file.
Open views/chared/_Layout.cshtml change the file name in link tag.

finish at 10:40am

Nov 1 - 11:25am
Open _Layout.cshtml file change the nav class from navbar-light to navbar dark and bg-white to bg-primary and line 22 and 25 - remove text-dark, 
add additional properties text-white-50 bg-primary to the footer class.

Open LoginPartial.cshtml and remove text-dark.

Add to the _Layout.cshtml page the additional stylesheets and scripts from the CSS_JS.txt file.

In _Layout.cshtml add a drop down to the Nav Bar.

Add three (3) new projects (class library) to the application: YashvisBooks.DataAccess, YashvisBooks.Models, YashvisBooks.Utility. Copy the ‘Data’ folder and paste to .DataAccess project (delete the original)

Install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages

Delete the Migrations folder. Add another package Identity.EntityFrameworkCore, upload changes to github.

Finish at 12:55pm 

start at 1:10pm

Modify the namespace in ApplicatiobDbContext page and delete the class1 file from .DataAccess,
.Models and .Utility project.

try to build project and move on next step

Move Models in to YashvisBooks.Models (delete original), Modify Views > Shared >  Error.cshtml

now right click on Project - Add - Project Reference - .DataAccess and .Models

Rename Models folder to ViewModels and Cchange the ErrorViewModels.cs namespace .Models.ViewModels

try to build project.



