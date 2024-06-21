# C# Calculator Application

## Description

This is a GUI-based calculator application built using C# on Visual Studio for Mac. The calculator supports standard arithmetic operations (Addition, Subtraction, Multiplication, Division), as well as additional functionalities such as calculating squares and square roots. It is integrated with a Microsoft SQL Server database named 'CalculatorDB' for storing and retrieving calculation results.

## Features

- Addition
- Subtraction
- Multiplication
- Division
- Square
- Square Root

## Technologies Used

- C# for application logic and GUI design
- Visual Studio for Mac as the Integrated Development Environment (IDE)
- Microsoft SQL Server Management Studio (SSMS) for database management

## Database Setup

1. Create a database named 'CalculatorDB' in Microsoft SQL Server.
2. Set up tables for each operation (e.g., Addition_table) with appropriate columns to store input values and results.

## CRUD Operations

The application implements CRUD operations to interact with the 'CalculatorDB':
- **Create**: Store calculation results into respective tables.
- **Read**: Retrieve stored calculation results from tables.
- **Update**: Modify existing records if needed (optional).
- **Delete**: Remove records from tables (optional).

## Usage

1. Open the project in Visual Studio for Mac.
2. Build and run the application.
3. Perform calculations using the GUI.
4. Results will be stored in 'CalculatorDB' and can be retrieved as needed.



