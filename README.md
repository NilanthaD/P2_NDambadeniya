# P2_NDambadeniya
# Introduction </br>
This project is about understanding the bacis of developing dotnet mvc application with c#. 
In this project we have prcticed creating a multi project solution, use c# to create modules, controllers and views. 
Also we practiced the using XUnit to test a funtion. 

# Developing steps
1. Create a new solution using CLI  
    dotnet new sln -o P2_NDambadeniya
2. Create folders for src and tests
    md src
    md tests
3. Create Web MVC in src folder
    cd src
    dotnet new mvc -o Web
4. Add web mvc to the solution
    cd..
    dotnet sln add .\src\web\web.csproj
5. Create xunit test projet on test folder
    cd..
    cd tests
    dotnet new xunit -o Web.Tests
6. Add Web.Test project to the solution
    cd..
    dotnet sln add .\tests\Web.Tests\Web.Tests.csproj
    
7. Then perform the follwings using Visual Studio Community 2017
    Exted the HomeController with a new action
    Create a new controller with action results of text, json, html and a view
    Create a class with a funtion (FindLineCoverage()) in the Controller folder
    Create xunit tests (Fact and Theory tests) to test the created funtion.
    
App running on the browser
![alt text](https://github.com/NilanthaD/P2_NDambadeniya/blob/master/Doc/AppRunningOnTheBrowser.JPG)
