# Holiday
Federal Holidays project for Chelan PUD.

This API accepts a ISO 8601 formated date and will return a JSON object if the date is a US Federal Holiday in the year 2021, 2022, or 2023.
The information returned will include the name of the holiday, a description of the holiday, and whether the holiday is a fixed or floating holiday.

# Requirements
Requires .NET 6.0   
Solution developed in VS 2022

# How to Use
* Open Solution in Visual Studio 2022. Double click the Holiday solution .sln file to load the Solution projects. The "HolidayAPI" project should be selected as the Solution's Startup Project. Run the project by clicking the "IIS Express" button in Visual Studio. When prompted, select "Yes" to trust the IIS Express SSL Certificate, then click "yes" to allow the installation of the certificate. 
* Build and run project
* Visual Studio will launch a browser session that will initially return an Invalid Response error since no queryDate parameter is supplied. To pass a queryDate parameter to the WebAPI endpoint, append a queryDate parameter with an ISO 8601 compliant date format. For example:
`https://localhost:44306/holiday?queryDate=2021-01-18`

* For a complete listing of all the holiday dates included in this API, refer to   
[https://www.opm.gov/policy-data-oversight/pay-leave/federal-holidays/](https://www.opm.gov/policy-data-oversight/pay-leave/federal-holidays/)

# API Endpoints
`https://localhost:44306/holiday`

## Example Response
Ok 200 - Returns valid US Federal Holiday with specified elements.  
{"fedHolidayID":2,  
"holiday_name":"Birthday of Martin Luther King, Jr.",  
"holiday_descr":"This holiday is always observed on the third Monday of January.",  
"is_fixed":false}
  
Not Found 404 - Indicates date not found  
  
Bad Request 400 - Indicates a missing or malformed date query parameter  

# Libraries Used
Microsoft.EntityFrameworkCore.Sqlite

# Database Schema
[Holiday.pdf](https://github.com/stacyalley/Holiday/files/9701521/Holiday.pdf)

# Assumptions Made
* The date entered is the observed (pay day off for federal employees) holiday
* The request is coming from web app
* The user knows to search for dates in the years 2021-2023
