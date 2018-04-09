# Tools & technologies
Visual Studio 2010, .NET Framework 4.0, Winforms, C#.NET, ADO.NET, MS Access 2010, Stylecop 4.3

# Pattern
1. Developed using layered-architecture approach
	1. Physical Layers
		1. Presentation Layer
		2. Data Layer
	2. Logical Layers
		1. Business Service
		2. Data Access
		3. Data Model
2. Written code is stylecop compliant.
3. Coding and naming conventions are as per MSDN standards.

# Forms
1. Simple login screen
	1. Username: *demo*
	2. Password: *demo123*
1. Registration form to register new club members
2. Search / Manage screen
	1. Retrieve data based on search parameters or retrieves all data 
		1. Search parameters include Occupation (AND/OR) Marital Status			
	2. Print preview and Print functionality provided to print report
	3. Export functionality to export to excel
	4. Update/Delete Social club members

# External library useds
1. A light weight class library named `DataGridViewPrinter.dll` used for print functionality
(This library is taken from a open source project)

# Other details
1. Database `SocialClub.accdb` is located in application startup path (bin folder)
2. Database driver `Microsoft.ACE.OLEDB.12.0` used for Database communication

# How to use the code
1. Check Visual studio 2010 is installed
2. If yes, Open the solution file
3. Run the application
	1. In case of exception, try changing the following in your machine and check if it runs
		1. Startup project -> properties -> build -> platform target -> x86

# Source
[Code Project](https://www.codeproject.com/Articles/607868/Social-Club-Sample-application-using-WinForms-Csha)
Author: _John-ph_ 
