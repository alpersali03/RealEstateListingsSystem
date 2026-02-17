🏠 Real Estate Listings System

A simple ASP.NET Core MVC web application created to demonstrate understanding of ASP.NET Core MVC, Entity Framework Core, and SQL Server. The application allows users to manage real estate listings, view agents, and browse property types through a clean and responsive interface.

This project was developed as part of the ASP.NET Fundamentals course at SoftUni.

ℹ️ Application Features
Properties

Users can:

View all properties

View detailed property information

Create new property listings

Edit existing property listings

Delete property listings

Agents

Users can:

View all agents

View agent details

Property Types

Users can:

View all property types

Navigation

Users can navigate easily between:

Properties

Agents

Property Types

using the main navigation menu.

🗄 Database Structure

The application uses a relational database with the following entities:

Property

Id

Title

Description

Price

Size

Address

PropertyTypeId

AgentId

Agent

Id

FullName

Email

PhoneNumber

PropertyType

Id

Name

Relationships:

One Agent → Many Properties

One PropertyType → Many Properties

🧪 Seeded Sample Data

When the project runs for the first time, sample data is automatically seeded, including:

Agents:

Ivan Petrov

Maria Georgieva

Property Types:

Apartment

House

Studio

Properties:

Multiple example listings for testing

⚒️ Built With

ASP.NET Core MVC (.NET 6)

Entity Framework Core

Microsoft SQL Server

Razor Views

Bootstrap 5

Dependency Injection

Data Validation (Client-side and Server-side)

🏗 Architecture

The project follows the MVC architecture pattern:

Models
Controllers
Views
Data
Configuration
Common


Key components:

Models define the database structure

Controllers handle user requests

Views render the user interface

Entity Framework Core handles database access

Dependency Injection manages services
