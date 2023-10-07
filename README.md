# Notes WebApp

A simple web application designed to manage and organize your notes.

## 📌 Table of Contents

- [Features](#[features])
- [Technologies](#technologies)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Testing](#testing)
- [Contribute](#contribute)
- [License](#license)
- [Contact](#contact)

## 🚀 Features

- **CRUD Functionality**: Easily create, read, update, and delete notes.
- **Responsive Design**: Access your notes from any device.
- **Search & Filter**: Quickly find the notes you're looking for.

## 🛠️ Technologies

- .NET 7.0
- Entity Framework Core
- In-Memory Database (for testing)
- Playwright (for end-to-end testing)
- PostgreSQL
- NUnit
- Blazor
- Asp.net core

## 📥 Setup and Installation

1. Clone the repository:
   git clone https://github.com/tres-bien/Notes_WebApp
2. Move to the project directory
3. Install necessary dependencies
4. Update the database connection string:

Open `appsettings.json` in your preferred editor. Locate the `ConnectionStrings` section and modify the `DefaultConnection` value to point to your database instance.
```json
"ConnectionStrings": {
   "DefaultConnection": "Your_Database_Connection_String_Here"
}
```
💡 Note: Ensure your database instance is running and accessible from your development environment.
5. Run the application

## 🖥️ Usage

After starting the application, open your browser and navigate to the provided local URL. From there, you can create, view, edit, and delete notes as you wish.

## 🧪 Testing

To run the tests:

1. Navigate to the test directory:
   cd Notes.Tests

   
2. Run the tests:
   dotnet test

## 🌐 End-to-End (E2E) Testing

For comprehensive end-to-end testing, we maintain a separate repository that makes use of Playwright. Follow these steps to run the E2E tests:

1. Clone the E2E testing repository:
   git clone https://github.com/tres-bien/Notes_E2ETests
2. Move to the cloned directory:
   cd Notes_E2ETests
3. Install the necessary dependencies
4. Run Notes-WebApp Application
5. Run the E2E tests
