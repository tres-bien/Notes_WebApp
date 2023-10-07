# Notes WebApp

A simple web application designed to manage and organize your notes.

## 📌 Table of Contents

- [Features](#features)
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
   
3. Move to the project directory:
   cd Notes-WebApp

5. Install necessary dependencies:
   dotnet restore

7. Run the application:
   dotnet run --project Notes-WebApp.Server

## 🖥️ Usage

After starting the application, open your browser and navigate to the provided local URL. From there, you can create, view, edit, and delete notes as you wish.

## 🧪 Testing

To run the tests:

1. Navigate to the test directory:
   cd Notes.Tests

   
2. Run the tests:
   dotnet test
