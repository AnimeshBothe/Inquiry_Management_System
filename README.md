Inquiry Management System
The Inquiry Management System is a web application designed using ASP.NET Core Razor Pages. 
It is a fully functional CRUD application that allows users to manage inquiries with efficient pagination for improved performance and user experience.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Features
Core Functionalities

Add Inquiry:
Users can add new inquiries through a user-friendly form that captures all necessary details such as Name, Date of Birth, Gender, Hobbies, Address, State, City, and Pincode.
Data is validated on the client side and saved to the database via Entity Framework Core.

View Inquiries with Pagination:
The system displays inquiries in a paginated table. This ensures only a limited number of records (e.g., 5 per page) are displayed, improving both usability and performance.

Dynamic Pagination Controls:
Pagination links (Next, Previous, and Page Numbers) allow users to navigate between pages seamlessly. 
The system dynamically calculates the total number of pages based on the number of inquiries in the database.

Performance-Oriented Design
Optimized data fetching using LINQ methods like Skip() and Take() ensures only the required data is retrieved for the current page, minimizing database load.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Technologies Used

Frontend
ASP.NET Core Razor Pages: To build dynamic, server-rendered web pages.
HTML5 and CSS3: For structuring and styling the application.
Bootstrap 5: For responsive design and UI components.

Backend
ASP.NET Core 6.0: For the overall web application framework.
Entity Framework Core: To handle database operations like querying and persisting data.

Database
SQL Server: Used as the relational database for storing inquiry records.
