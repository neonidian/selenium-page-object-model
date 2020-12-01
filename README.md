# Selenium Page Object Modelling

## Running tests

1. Install dotnet core (See project file for version of .NET core)

2. In the commandline execute `dotnet restore` to download and update dependencies required for this project.

3. In the commandline execute `dotnet test` to run all the tests. The default browser is set as firefox in [SeleniumConfig.ini](src/SeleniumConfig.ini).
This can be tweaked to run other browsers.

4. All the tests are present in [uiTests](src/uiTests) folder.
Run individual tests with Nunit plugin which can be installed in the IDE.

## What this test does

1. This test opens up firefox browser and loads a website - https://www.axiomatics.com (Access control solutions company)

2. Opens up a one of the header menu to list a subset of the menu

3. Selects one of the sub-menu to navigate to a page and verify if the page is displayed

## Tool used

* IDE                 - Visual studio code

* Framework           - Dot NET core

* Testing framework   - Nunit

## How this project was setup

1. Nunit template using ` dotnet new nunit`

2. Package reference for external libraries and the browser drivers are set up in the project file
