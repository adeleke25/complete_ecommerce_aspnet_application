# Application Freature
Here's a breakdown of the required features:

**CRUD Operations**
Each of these entities should have the basic CRUD functionalities (Create, Read, Update, Delete). Below is how this applies to each entity:

1. **Actors**
Create: Add new actors to the database (name, age, bio, etc.).
Read: Retrieve a list of all actors or details of a single actor.
Update: Modify actor details (e.g., bio, age).
Delete: Remove an actor from the database.
2. **Producers**
Create: Add new producers to the database (name, age, bio, company, etc.).
Read: Retrieve a list of all producers or details of a single producer.
Update: Modify producer details.
Delete: Remove a producer from the database.
3. **Cinemas**
Create: Add new cinemas (name, location, number of screens, etc.).
Read: Retrieve a list of cinemas or specific details of a cinema.
Update: Modify cinema details (e.g., number of screens, location).
Delete: Remove a cinema from the database.
4. **Movies**
Create: Add new movies (title, genre, release date, cast, etc.).
Read: Retrieve a list of movies or specific details of a movie.
Update: Modify movie details (e.g., title, release date).
Delete: Remove a movie from the database.
Cart and Orders Functionality
5. **Adding Items to a Cart**
Create: Add items (e.g., movie tickets) to a cart.
Read: Retrieve the current contents of a user's cart.
Update: Modify the contents of the cart (e.g., change the number of tickets).
Delete: Remove items from the cart.
6. **Orders**
Create: Place an order based on the contents of the cart.
Read: Retrieve a list of past orders or details of a specific order.
Update: Modify an order (if needed, based on business logic).
Delete: Cancel an order (optional, based on the business case).
Authentication Restructure (Key Points)
User Registration:

Secure signup with email, password, and optional roles (e.g., customer, admin).
Email verification for account activation.
Login and Logout:

Secure login with email and password.
Option for OAuth login (Google, Facebook, etc.).
Secure logout functionality.
Password Management:

Ability to reset or change passwords via email.
Password strength validation.
Roles and Permissions:

Admins: Full access to all CRUD operations.
Users: Limited access (e.g., viewing movies, placing orders).
Role-based authentication.
Token-based Authentication:

JWT (JSON Web Token) for session management.
Tokens should have an expiration time for security.
Multi-factor Authentication (Optional):

Support for adding MFA for additional security.
Session Management:

Handle user sessions securely (e.g., token revocation on logout or token refresh).
Account Management:

View and update personal information (profile).
Manage security settings (e.g., enable MFA, change password).
Authorization Middleware:

Middleware to protect routes based on user roles (e.g., admin routes, user routes).



