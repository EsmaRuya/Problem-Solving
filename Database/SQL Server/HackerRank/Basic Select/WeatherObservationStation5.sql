-- Query the two cities in STATION with the shortest and longest CITY names, as well as their respective lengths (i.e.: number of characters in the name). If there is more than one smallest or largest city, choose the one that comes first when ordered alphabetically.


SELECT * 
FROM (
    SELECT TOP 1 CITY, LEN(CITY) AS CityLength
    FROM STATION
    ORDER BY LEN(CITY) ASC, CITY ASC
) AS Shortest

UNION

SELECT * 
FROM (
    SELECT TOP 1 CITY, LEN(CITY) AS CityLength
    FROM STATION
    ORDER BY LEN(CITY) DESC, CITY ASC
) AS Longest;
