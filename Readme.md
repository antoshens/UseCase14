#### Application description

Our ASP.NET 6 MVC application, aptly named "UseCase14", serves as a potent tool that makes formatting dates, numbers,
and units of measurement a breeze for users, dependent on the culture provided in the URL.
The core functionality of the app is to help developers to get familiar of most common use cases and the setup vest practices of how to use i18n in .NET 6.
The UseCase14 is built using the robust and scalable ASP.NET 6 MVC framework, promising excellent performance and reliability.

This application offers an intuitive interface and straightforward functionality.
Simply provide the data and specify the culture in the URL, and the application takes care of the rest.
The app supports 3 cultures: en-US, uk-UA, fr-FR.

#### How to run it locally
To run the "UseCase14" application on your local machine, follow the steps outlined below:

* Prerequisites: Make sure that you have the .NET 6 SDK installed on your machine. If not, download it from the official Microsoft website.

* Clone or Download the Repository: Use a git command git clone https://github.com/antoshens/UseCase14 in your terminal or command prompt to clone the application repository onto your local machine. If you don't have git installed, you can download the repository as a ZIP file from the GitHub page and extract it.

* Navigate to the Application Directory: Use the command cd [repository_directory] to navigate into the root directory of the application where the .sln file resides.

* Restore the Packages: Run the command dotnet restore to restore the NuGet packages referenced in the project.

* Build the Application: Run the command dotnet build to build the application. This will compile the application and report any compilation errors.

* Run the Application: Finally, run the application using the command dotnet run. The application should now be running on your local machine.

* Open in Browser: Open your preferred web browser and visit http://localhost:5000 (or the URL displayed in your terminal after running the application). You can then test the application by appending the required culture in the URL (e.g., http://localhost:5000/?test/culturetest/en-US).

*Remember, the application uses the given culture in the URL to correctly format dates, numbers, and units of measurement. Adjust your input data as needed to explore the application's functionality*

#### Examples of URLS on how to change locale
To change the locale in the "UseCase14" application, you can append the desired culture directly in the URL. Here are two examples:

1. United States Locale: If you wish to format your dates, numbers, and units of measurement according to the United States' conventions, you would use the culture code en-US.
The URL would look like this:
http://localhost:5000/?test/culturetest/en-US

2. French Locale: If you wish to use French region, use the culture code fr-FR. The URL would then be:
http://localhost:5000/?test/culturetest/fr-FR