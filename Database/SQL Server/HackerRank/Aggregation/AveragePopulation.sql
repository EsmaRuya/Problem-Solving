-- Query the average population for all cities in CITY, rounded down to the nearest integer.

SELECT CAST ( AVG(POPULATION) AS INT )
FROM CITY;