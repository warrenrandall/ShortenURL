# ShortenURL

Development Tools used
----------------------
VS Community Edition 2019
SQL Server 2019
C# .NET
LINQ2SQL

Setting up on a localhost
-------------------------

Please use your own connectionstring settings for the web.config file.
Run the provided "Create database and tables.sql" query within MS SQL management Studio when connected to your DB instance.
This creates the database and table required.



Architectural considerations
----------------------------
This is a prototype and is not meant for scalability! (An interesting discussion can be had about it, though. Especially whether the service require registration)
The functionality is on the Homepage and HomeController. There is a separate Data Access Layer class which deals with Database calls and inserts.
A URL is shortened by mapping it to a shorter URL (localhost or an actual domain) with a forward slash "/" followed by a 7 character alphanumeric string. These characters are generated using a pseudo-random process. There is only one table in the Database. The Data Layer uses LINQ2SQL but in the case of many users visiting the site then perormance may be affected compared to using a dedicated DBMS.
There is a limit of 900 characters for the long URL provided.
Although testing it locally forces the domain name to be: localhost:(portnumber) it is clear that a well chosen domain would reduce characters in the short URL.


How to use the Web App
----------------------

Once the solution is loaded in Visual Studio Community Edition 2019 run it and you will be presented with a text field to enter the long URL of another site, a button (to shortern) and the output field on the right. There is also a clear button.
Copy the short URL, open a new tab on your browser, paste it into the address bar and the browser will redirect to the full URL.
