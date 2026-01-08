eShift – Package Delivery Management System (Desktop Application)

Overview

eShift is a C# Windows Forms–based desktop application designed to manage package delivery operations efficiently.
The system digitizes core logistics processes such as customer management, job tracking, load handling, and delivery status updates using a structured SQL Server database.

This project was developed as an individual application development project, following real-world CRUD and database-driven design principles.


Key Objectives
	•	Replace manual package delivery tracking with a digital system
	•	Improve accuracy in job, load, and customer management
	•	Provide role-based access for administrators and staff
	•	Ensure reliable data storage using SQL Server

 Technologies Used
	•	Language: C#
	•	Framework: .NET (Windows Forms)
	•	Database: Microsoft SQL Server
	•	IDE: Visual Studio
	•	Architecture: Desktop-based, database-driven application

 Core Features

 Authentication
	•	Secure Admin Login
	•	Controlled access to system functions

 Customer Management
	•	Add, update, delete, and view customer records
	•	Centralized customer data handling

 Job & Load Management
	•	Create transport jobs with pickup and drop locations
	•	Assign and manage loads
	•	Automatically calculate total load weight

 Product Handling
	•	Add multiple products per job
	•	Store product type and weight details

 Status Tracking
	•	Track job status (Pending, Assigned, In Transit, Completed)
	•	Improve operational visibility

 Database Design
	•	Normalized relational database
	•	Core tables include:
	•	Admin
	•	Customer
	•	Job
	•	Load
	•	Product
	•	Feedback

Primary keys use IDENTITY for scalability and integrity.



 How to Run the Project
	1.	Clone the repository
	2.	Open the solution file (.sln) in Visual Studio
	3.	Restore NuGet packages (if required)
	4.	Configure SQL Server connection string in the application
	5.	Run the database scripts to create tables
	6.	Build and run the application


 Project Purpose

This project demonstrates:
	•	Strong understanding of C# Windows Forms
	•	Practical SQL Server integration
	•	Real-world CRUD operations
	•	Desktop application architecture

It was built for academic (CW) purpose.
