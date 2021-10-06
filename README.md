# Payroc-ShortenURL

Development Tools used
----------------------
VS Community Edition 2019
SQL Server 2019
C# .NET


Architectural considerations
----------------------------
This is a prototype and is not meant for scalability! 
The functionality is on the Homepage and HomeController. There is a separate Data Access Layer class which deals with Database calls and inserts.
A URL is shortened by mapping it to a shorter URL (localhost or an actual domain) with a forward slash "/" followed by a 7 character alphanumeric string. These characters are generated using a pseudo-random process. There is only one table in the Database. The Data Layer uses LINQ2SQL but in the case of many users visiting the site then perormance may be affected compared to using a dedicated DBMS.
Should also consider security issues with inputting text that is written to the Database.


What was developed
------------------

The Web App and Database can be found on GitHub. The solution is called Payroc ShortenURL. The Database is called "URL Transform." I was able to complete the main MVC app which transformed long URLs into smaller but did not have time to develop the Web Api which could be used to redirect requests using the small URLs to the longer URLs.



Setting up on a localhost
-------------------------

Please use your own connectionstring settings for the web.config file. Copy the Database files to the appropriate folder that your version of SQL Server looks in. 
