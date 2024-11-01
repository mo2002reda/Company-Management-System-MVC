<h1>Company Management System (MVC)</h1>

<h6>The Company Management System is a robust MVC-based application designed to streamline company operations through a user-friendly dashboard.</h6>
 <h6>This system supports CRUD operations, allowing for efficient data management, and is built with a layered architecture for better maintainability, scalability, and security.</h6>

<h3>Key Features</h3>
<h6>1)CRUD Operations: The system offers full Create, Read, Update, Delete (CRUD) operations across various entities, enabling seamless data manipulation and management within the application.</h6>

<h3>Technology Highlights</h3>
<h6>AutoMapper & DTOs :Leverages AutoMapper to efficiently map data between models and Data Transfer Objects (DTOs), reducing manual mapping and simplifying code. </h6>

<h6>3-Tier Architecture : Implements a 3-tier architecture to separate the business logic from the data access layer, enhancing modularity and maintainability. </h6>

<h6>Repository Pattern : Abstracts data access logic to make the system data-agnostic and easier to maintain.</h6>

<h6>Generic Repositories : Uses Generic Repositories to maximize code reusability and reduce duplication, allowing for consistent data operations across entities.</h6>

<h6>Unit of Work : Introduces a Unit of Work pattern to encapsulate database transactions, preventing direct database access from controllers and securing data by managing requests centrally.

<h4>Multi-Dashboard Access </h4>
<h5>This application includes two dashboards:</h5>
<h6>Admin Dashboard: Allows administrators to manage user permissions and roles.</h6>

<h6>User Dashboard: Enables authorized users to manage designated tasks within the system.</h6>
<h6>Identity for Registration : Implements Identity to support secure and reliable user registration and authentication processes.</h6>

<h3>Getting Started</h3>
<h6>
  1).NET 6 SDK or compatible version
  
2)SQL Server or another compatible database system Installation

3)Clone the repository to your local environment.

4)Configure database connection settings in appsettings.json.

5)Run migrations and seeding (if applicable) to initialize the database.
6) Build and run the application.</h6>
<h3>Usage</h3>
<h6>Once set up, the Company Management System provides role-based access to company management functionalities. The system ensures that administrators can oversee user permissions, while users can efficiently manage their designated data.</h6>

