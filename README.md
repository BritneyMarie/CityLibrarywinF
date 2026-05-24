# City Library Management System

A Windows Forms desktop application for managing a city library's books, members, and book issue/return transactions.

## Features

- **Manage Books** — Add and view books with ISBN, title, author, and edition details.
- **Manage Members** — Register and view library members with unique IDs.
- **Issue & Return Books** — Issue books to members and track return dates.

## Tech Stack

- **Language:** C#
- **Framework:** .NET 8.0 (Windows Forms)
- **Platform:** Windows

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

### Run the Application

```bash
dotnet run --project CityLibrarywinF
```

## Project Structure

```
CityLibrarywinF/
├── Program.cs                    # Application entry point
├── Form1.cs                      # Main form (navigation hub)
├── Manage Books.cs               # Book management form
├── MembersForm.cs                # Member management form
├── IssuesReturnForm.cs           # Book issue/return form
├── books.cs                      # Book model
├── Members.cs                    # Member model
├── Transaction.cs                # Transaction model
└── CityLibrarywinF.csproj        # Project file
```
