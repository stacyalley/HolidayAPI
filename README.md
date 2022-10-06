# Holiday

This API accepts a ISO 8601 formated date and will return a JSON object if the date is a US Federal Holiday in the year 2021, 2022, or 2023.
The information returned will include the name of the holiday, a description of the holiday, and whether the holiday is a fixed or floating holiday.

# Requirements
Requires .NET 6.0   
Solution developed in VS 2022

# How to Use
* Open Solution in Visual Studio 2022. Double click the Holiday solution .sln file to load the Solution projects. The "HolidayAPI" project should be selected as the Solution's Startup Project. Run the project by clicking the "IIS Express" button in Visual Studio. When prompted, select "Yes" to trust the IIS Express SSL Certificate, then click "yes" to allow the installation of the certificate. 
* Build and run project
* Visual Studio will launch a browser session that will initially return an Invalid Response error since no queryDate parameter is supplied. To pass a queryDate parameter to the WebAPI endpoint, append a queryDate parameter with an ISO 8601 compliant date format. For example:  
* Fixed holiday  
`https://localhost:44306/holiday?queryDate=2023-12-25`  
* Floating holiday  
`https://localhost:44306/holiday?queryDate=2021-01-18` 

* For a complete listing of all the holiday dates included in this API, refer to   
[https://www.opm.gov/policy-data-oversight/pay-leave/federal-holidays/](https://www.opm.gov/policy-data-oversight/pay-leave/federal-holidays/)

# API Endpoints
`https://localhost:44306/holiday`

## Example Response
Ok 200 - Returns valid US Federal Holiday with specified elements.  
{  
  "fedHolidayID":2,  
  "holiday_name":"Birthday of Martin Luther King, Jr.",  
  "holiday_descr":"This holiday is always observed on the third Monday of January.",  
  "is_fixed":false  
}
  
Not Found 404 - Indicates date not found  
  
Bad Request 400 - Indicates a missing or malformed date query parameter  

# Libraries Used
Microsoft.EntityFrameworkCore.Sqlite (6.0.9)

# Database Schema
[Holiday.pdf](https://github.com/stacyalley/Holiday/files/9701521/Holiday.pdf)

# Assumptions Made
* The date entered is the observed (paid day off for federal employees) holiday
* API caller is aware of date range in data: 2021, 2022, 2023
* If a requested date is not found in the database the API will return a 404 Not Found response
* If a requested date string cannot be converted to a date the API will return a 400 Bad Request response

# Feedback  
## General Notes: 
While challenging, this project was a great opportunity for me to learn more about each aspect that was required to complete it - from setting up Visual Studio, the SQLite data base, and Git to learning about LINQ and Web APIs. It will be reflected in the Time Spent section that I started from a place of minimal experience in building a API in C#. I know there is still so much more for me to learn, but I had fun with this project and would look forward to gaining more experience.

## Time Spent  
Total - 41 hours

C#/.NET solution  
8 Research  
4 Development   
12 Total (hours)
  
SQLite database  
2 Research  
2 Development  
4 Total (hours)  
  
Web API  
3 Research  
3 Development  
6 Total (hours)  

LINQ/Datacontext  
3 Research  
4 Development  
7 Total (hours)  

Documentation  
4 Research  
2 Development  
6 Total (hours)  

Git repo  
4 Research  
2 Development  
6 Total (hours)  
  
Total  
24 Research  
17 Development  
41 Total (hours)  

## Problems/Issues:
I ran into issues when trying to remove unneeded directories of files from the Git repository.  I did have to start over with a completely new repo.

## Enhancements:
* Better error handling/feed back for dates entered that were not found in the data base.
* Add options to return all federal holidays for a given month/year or  entire year.
* Ability to add more dates to the database



