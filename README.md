# Selenium Page Object Modelling

## Tool used
IDE                 - Visual studio code
Framework           - Dot NET core
Testing framework   - Nunit

## How this project was setup
1. Nunit template using ` dotnet new nunit`
2. Install selenium - `dotnet add package Selenium.WebDriver --version 3.141.0`
3. The resource files like [browser drivers](src/resources/drivers) and [SeleniumConfig.ini](src/SeleniumConfig.ini)
was configured to be copied to bin/ in .csproj file since they are required while running the tests.

## Running tests
In the commandline execute `dotnet test` to run all the tests. The default browser is set as firefox in [SeleniumConfig.ini](src/SeleniumConfig.ini).
This can be tweaked to run other browsers.

All the tests are present in [uiTests](src/uiTests) folder.
Run individual tests with Nunit plugin which can be installed in the IDE.

## What this test does
1. This test opens up a browser loads a website - https://www.axiomatics.com (A Access control solutions comapany)

2. Execute tests

3. Close the browser