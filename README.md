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

### 3. Cinema Model
![CinemaModel](https://github.com/user-attachments/assets/cb061994-3860-4eac-a249-5fd181c6015e)
### 4. Movie Model
![MovieModel](https://github.com/user-attachments/assets/7e7d728c-b5a2-4cd8-88d3-f73b47f5ed3f)
### 5. MovieCategoryModel
![MovieCategoryModel](https://github.com/user-attachments/assets/5dc8cc26-069e-485d-9e07-675d6bf4aade)





