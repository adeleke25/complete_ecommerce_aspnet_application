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
### 2. Produce Model
### 3. Cinema Model
### 4. Movie Model


