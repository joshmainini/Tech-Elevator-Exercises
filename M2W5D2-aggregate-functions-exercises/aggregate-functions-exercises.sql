-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)
SELECT name + ',' + district AS "name_and_state", sum(population) AS "population"
FROM city
WHERE district IN('pennsylvania','west virginia', 'kentucky', 'indiana', 'michigan')
GROUP BY district, name
ORDER BY district, name;


-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)
SELECT name + '(' + code + ')' AS "country_and_code", region 
FROM country 
WHERE continent = 'africa';
-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)
SELECT ((GNP * 1000000)/ population) AS "per capita GNP" 
FROM country 
WHERE population != 0
ORDER BY "per capita GNP" DESC;
-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)
SELECT AVG(lifeexpectancy) AS "Average Life Expectancy"
from country
where continent = 'south america';
-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)
SELECT SUM(population) AS "Total Population"
FROM city 
WHERE district = 'california';
-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)
SELECT SUM(population) AS "Total Population"
FROM city 
WHERE countrycode = 'chn';
-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)
SELECT MAX(population) AS "MAX Poplation" 
FROM country 

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)
SELECT MAX(population) AS "MAX Poplation" 
FROM city
-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)
SELECT MAX(population) AS "MAX Poplation" 
FROM city 
WHERE countrycode = 'aus';
-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)
SELECT MIN(population) AS "MIN Population" 
FROM country 
WHERE population != 0;
-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)
SELECT AVG(population) AS Average_USA_Population
FROM city
WHERE countrycode = 'USA'
-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)
SELECT AVG(population) AS Average_CHN_Population
FROM city
WHERE countrycode = 'CHN'
-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")
SELECT SUM(surfacearea) as "Total Surface Area", continent
FROM country
GROUP BY continent
ORDER BY "Total Surface Area" DESC;

-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)
SELECT name, (population / surfacearea) AS "Population Density"
FROM country 
ORDER BY [Population Density] DESC;
-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")
SELECT TOP 10 name,(population / surfacearea) AS "Population Density", lifeexpectancy
FROM country
ORDER BY lifeexpectancy DESC;
-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")
SELECT(gnp - gnpold) AS GNP_difference, ABS(gnp - gnpold) AS Absolute_Value_GNP_Difference, name
FROM country
WHERE gnp != gnpold 
ORDER BY Absolute_Value_GNP_Difference;
-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")
SELECT AVG(population) AS City_Population, city.countrycode
from city 
GROUP BY city.countrycode
ORDER BY City_Population DESC;
-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)
SELECT district, COUNT(name) AS City_Count 
FROM city 
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district;
-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")
SELECT continent,  COUNT(name) AS Country_Count
FROM country
GROUP BY continent
ORDER BY Country_Count DESC;
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")
SELECT COUNT(name) AS City_Count, countrycode
FROM city 
GROUP BY countrycode
ORDER BY City_Count DESC;
-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")
SELECT MAX(population) AS MAX_Population, countrycode
FROM city 
GROUP BY countrycode
ORDER BY MAX_Population DESC;
-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")
SELECT AVG(lifeexpectancy) AS AVG_LifeExpectancy, MIN(lifeexpectancy) AS MIN_LifeExpectancy, MAX(lifeexpectancy) AS MAX_LifeExpectancy, continent
FROM country
WHERE lifeexpectancy IS NOT NULL 
GROUP BY continent
ORDER BY AVG_LifeExpectancy; 