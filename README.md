# CSharp Ecommerce Automation Framework

## Overview
Test automation framework written in C# to perform end-to-end testing for an e-commerce website. This comprehensive framework is designed to ensure the robustness and accuracy of the website's functionalities and features.

## Prerequisites
Before setting up the project, ensure you have the following installed:
- .NET (Version 8.0 or later)

## Framework Structure
- **`Tests/`**: Contains all test files and test data.
- **`Base/`**: Contains Driver init and tear down setup.
- **`Pages/`**: Contains Page Object Models for each page of the application.
- **`TestResults/`**: Contains test execution results.
- **`Utilities/`**: Contains helper classes and methods for test data management.
- **`csharp-ecommerce-automation-framework.csproj`**: Contains all the dependencies and configuration for the project.
- **`README.md`**: Contains instructions for setting up and running the framework.
- **`.gitignore`**: Contains the files and directories that should be ignored by Git.

## Setup Instructions
1. **Clone the Repository:**
- Clone the repository to your local machine using the following command:
  ```git clone https://github.com/nikosthermo/csharp-ecommerce-automation-framework.git```
- Navigate to the project directory using the following command:
  ```cd csharp-ecommerce-automation-framework```
2. **Install Dependencies:**
- Install all the dependencies using the following command:
  ```dotnet build```
3. **Run the Tests:**
- Run the following command to verify that the setup was successful:
  ```dotnet test```
- The tests should run and the results should be displayed in the terminal.
