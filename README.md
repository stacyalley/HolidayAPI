# Holiday
Federal Holidays project for Chelan PUD.

This API accepts a ISO 8601 formated date and will return a JSON object if the date is a US Federal Holiday between the years 2021-2023.
The information returned will include the name of the holiday, a description of the holiday, and whether the holiday is a fixed or floating holiday.

# Requirements
Requires .NET 6.0

# How to Use

`https://localhost:44306/holiday?queryDate=yyyy-MM-dd`

# API Endpoints
`https://localhost:44306/holiday`

## Example Response
`{"fedHolidayDateID":2,"holiday_date":"2021-01-18","fedHolidayID":2,"fedHoliday":{"fedHolidayID":2,"holiday_name":"Birthday of Martin Luther King, Jr.","holiday_descr":"This holiday is always observed on the third Monday of January.","is_fixed":false}}`

# Libraries Used
Microsoft.EntityFrameworkCore.Sqlite

# Database Schema
[Holiday.pdf](https://github.com/stacyalley/Holiday/files/9701521/Holiday.pdf)

# Assumptions Made
* The date entered is the observed (pay day off for federal employees) holiday
* The request is coming from web app
* The user knows to search for dates in the years 2021-2023
