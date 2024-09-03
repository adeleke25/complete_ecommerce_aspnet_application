# Movie Ticket Booking System
The Movie Ticket Booking System is a web application that allows users to book movie tickets, manage their cart, and place orders. It provides essential features for both customers and administrators. Let’s dive into the key functionalities:

# Features
## CRUD Operations:
Manage actor details (name, age, bio).
Handle producer information (name, bio, company).
Maintain cinema details (name, location, screens).
Track movie information (title, genre, release date, cast).
## Cart and Orders Functionality:
### Cart:
Add items (e.g., movie tickets) to the cart.
View, update, or remove items from the cart.
### Orders:
Place orders based on the cart contents.
View, update, or cancel past orders.
## Authentication Restructure:
### User Registration:
Secure signup process with email verification.
Optional roles (customer/admin).
### Login and Logout:
Secure login using passwords or OAuth options.
Proper logout functionality.
### Password Management:
Password reset, strength validation, and change functionality.
### Roles and Permissions:
Admins have full access; users have limited access based on roles.
### Token-based Authentication:
JWT-based session management with token expiration.
### Multi-factor Authentication (Optional):
Support for MFA to enhance security.
### Session Management:
Secure handling of sessions (token revocation, refresh).
### Account Management:
Manage personal information, security settings, and password changes.
### Authorization Middleware:
Role-based route protection (e.g., admin routes, user routes).


# Getting Started
## Add Innitial Models:
### 1. Actor Model
![ActorModel](https://github.com/user-attachments/assets/523ae78e-f000-42c8-a69a-971c59bb4a1e)
### 2. Produce Model
![ProductModel](https://github.com/user-attachments/assets/74d4fc83-5a67-4bf3-949f-001e076424de)
### 3. Cinema Model
![CinemaModel](https://github.com/user-attachments/assets/cb061994-3860-4eac-a249-5fd181c6015e)
### 4. Movie Model
![MovieModel](https://github.com/user-attachments/assets/7e7d728c-b5a2-4cd8-88d3-f73b47f5ed3f)
### 5. MovieCategoryModel
![MovieCategoryModel](https://github.com/user-attachments/assets/5dc8cc26-069e-485d-9e07-675d6bf4aade)

## Add DbContext file:
DbContext is a central class in Entity Framework (EF), an Object-Relational Mapping (ORM) framework for .NET applications. It acts as a bridge between the application and the database, enabling CRUD (Create, Read, Update, Delete). It's called the Translated file because  it serves as the Translator between the models and the DB. Models are used to SEND & GET from DB.But for DB(SQL) to understand the code (C#) and vice-versa, you need a file in between which is DBContext which understand both C# and SQL languages.
operations on entities in an object-oriented manner
## Key Responsibilities of DbContext:
### Database Interaction: It provides APIs to query the database, execute commands, and track changes to entities.
### Entity Management: It manages the lifecycle of entities, such as adding, updating, and deleting objects.
### Change Tracking: It keeps track of changes made to objects so that when you call SaveChanges(), it knows which entities need to be inserted, updated, or deleted in the database.
### Data Access: It allows for querying the database using LINQ (Language Integrated Query) and also allows execution of raw SQL queries when needed.
### Migration Support: It can handle database migrations, making it easy to evolve your database schema over time as your application's model changes.

![DALL·E 2024-08-15 21 56 56 - A simple and clear diagram showing a bridge between a  NET application and a database  The  NET application is represented by a labeled box Applicati](https://github.com/user-attachments/assets/c14c5a58-0898-45fc-9839-afcff4837199)

## Explanation:
### Top Box - "Application": This represents the .NET application. Inside the application, you perform various operations like creating, reading, updating, and deleting (CRUD) records.

### Bottom Cylinder - "Database": This cylindrical shape represents the database where the actual data is stored. The database contains tables and records that hold your application's data.

### Middle Bridge - "DbContext": The DbContext is visualized as a bridge between the application and the database. It allows the application to interact with the database in an object-oriented way, enabling developers to perform operations on entities (like Product, Customer, etc.) without directly writing SQL queries.

### Arrows Flowing Between Layers: The arrows represent the flow of data between the application, the DbContext, and the database. For example:

### From Application to Database: When you create, update, or delete data in your application, the changes are sent through the DbContext to the database.
### From Database to Application: When you query or read data, the data is fetched from the database and returned to the application through the DbContext.

## STEPS:

### 1. Create eticketDbContext class in the Data folder and Inject the base class (DbCOntext) which is important for this file to be the official traslator betwee the C# models & SQL code. 
### Note that you have import the namespace. To import the namespace, in have first install Ms.EntityFrameworkCore package.
### 2. Define a constructor with DbContextOptions parameter named eticketDbContext
### 3. Add DbContext service to the container in Programe.cs file
### 4. Configure model Relationships. Add relationshiop property to the models accordingly:
#### A. ProducerModel- public List<Movie> Movies { get; set; } .....One to Many
#### B. CinamaModel- public List<Movie> Movies { get; set; }
#### C. ActorModel-   public List<Actor_Movie> Actor_Movie { get; set; }
#### D. MovieModel-   public List<Actor_Movie> Actor_Movie { get; set; }
![DbContext](https://github.com/user-attachments/assets/00d09a82-a90d-42e1-beec-2b1827074edd)

## Configure SQLServer:
### 1. From ServerExplorer, RightClick Data Connections => Create New QSL =>
### 2. Add first Migration
![Db_Migration_Shema](https://github.com/user-attachments/assets/a214a235-2a99-4771-82d6-aa9998df177d)
### 3. Datababe_Relationship_Diagrame
![Relationship_Diagram](https://github.com/user-attachments/assets/f28105e0-d9d9-438c-878d-7f5907b0cbc0)

## Data Seeding:
### After we have established the relationships between entities by adding appDBContext file and configure the SQLServer by creating the DB also adding the DB tables using the migrations, it is time to update these tables with some dumy data:
#### 1. Add a class file in Data Folder called AppdDBInitializer ==> Add a static class named seed
#### 2. Create application services
#### 3. Inside application services,  Create a reference to AppDBContext file. This is because that is the file we use to send to abd Get from DB
#### 4. Add all Dummy data
![Dummy5](https://github.com/user-attachments/assets/317a9fc1-38fa-4459-b677-0ca27e45b86e)
![Dummy4](https://github.com/user-attachments/assets/de3b78fe-9b98-492e-a5ef-b9514296df5a)
![Dummy3](https://github.com/user-attachments/assets/25fe7ec1-66f4-4f55-8a62-8bbfc5b1ae7f)
![Dummy2](https://github.com/user-attachments/assets/d362ea83-b394-48d0-95d8-13e601239ed1)
![Dummy1](https://github.com/user-attachments/assets/2614e3e9-c1a0-40dd-8a3e-e7a757a0db78)

## Adding MVC Controllers:
Controllers are a crucial part of the MVC architecture. They are responsible for handling user input and interactions. Here’s a breakdown of their role:
### 1. Receive Input: Controllers receive input from the user through the View.
### 2. Process Data: They process this input, often interacting with the Model to retrieve or update data.
### 3. Update View: Finally, they update the View to reflect any changes in the data.
For example, in a web application, if a user submits a form, the Controller will handle this request, process the data (perhaps saving it to a database via the Model), and then update the View to show a confirmation message or the updated data


                
 





