-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT F.title 
FROM film F JOIN film_actor FA on FA.film_id = F.film_id
JOIN actor A on A.actor_id = FA.actor_id
WHERE A.actor_id = 44;
-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT F.title 
FROM film F JOIN film_actor FA on FA.film_id = F.film_id
JOIN actor A on A.actor_id = FA.actor_id
WHERE A.actor_id = 135;
-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT F.title 
FROM film F JOIN film_actor FA on FA.film_id = F.film_id
JOIN actor A on A.actor_id = FA.actor_id
WHERE A.actor_id IN( 35,143);
-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT f.title 
FROM film f JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE c.name = 'documentary';
-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT f.title 
FROM film f JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE c.name = 'comedy';
-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT f.title 
FROM film f JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE c.name = 'Children' AND f.rating = 'G';
-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT f.title 
FROM film f JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE c.name = 'Family' AND f.rating = 'G' AND f.length < 120;
-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT F.title 
FROM film F JOIN film_actor FA on FA.film_id = F.film_id
JOIN actor A on A.actor_id = FA.actor_id
WHERE A.actor_id = 103 AND F.rating = 'G';
-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT f.title 
FROM film f JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE c.name = 'sci-fi' AND f.release_year = 2006;
-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT F.title 
FROM film f JOIN film_actor fa on fa.film_id = f.film_id
JOIN actor a on a.actor_id = fa.actor_id JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE A.actor_id = 44 AND c.name = 'Action';
-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT a.address, ci.city, a.district, c.country 
FROM address a JOIN city ci ON ci.city_id = a.city_id
JOIN country c ON c.country_id = ci.country_id
JOIN store s ON s.address_id = a.address_id
WHERE s.address_id in(1,2);
-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT s.store_id,a.address,(st.last_name + ', ' + st.first_name) AS Manager_Name
FROM address a JOIN city ci ON ci.city_id = a.city_id
JOIN store s ON s.address_id = a.address_id
JOIN staff st ON st.store_id = s.store_id
WHERE s.address_id in(1,2);
-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT cu.first_name,cu.last_name, COUNT(r.customer_id) AS rental_count
FROM customer cu JOIN rental r ON r.customer_id = cu.customer_id
GROUP BY cu.first_name, cu.last_name
ORDER BY rental_count DESC;
-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP 10 cu.first_name,cu.last_name, SUM(p.amount) AS Total_Payment
FROM customer cu JOIN payment p ON p.customer_id = cu.customer_id
GROUP BY cu.first_name, cu.last_name
ORDER BY Total_Payment DESC;
-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store 
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT st.store_id, a.address, COUNT(r.rental_id) AS Total_Rentals, SUM(p.amount) AS Total_Sales, AVG(p.amount) AS Average_Sale
FROM store st 
JOIN address a ON st.address_id = a.address_id
JOIN staff s ON st.store_id = s.store_id
JOIN rental r ON r.staff_id = s.staff_id
JOIN payment p ON r.rental_id = p.rental_id
GROUP BY st.store_id, a.address;



-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP 10 f.title, COUNT(r.rental_id) AS Number_of_rentals
FROM film f JOIN inventory i ON i.film_id = f.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
GROUP BY f.title
ORDER BY Number_of_rentals DESC;
-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP 5 cat.name, COUNT(r.rental_id) AS Number_of_rentals
FROM category cat JOIN film_category fc ON fc.category_id = cat.category_id
JOIN inventory i ON i.film_id = fc.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
GROUP BY cat.name
ORDER BY Number_of_rentals DESC;
-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP 5 f.title, COUNT(r.rental_id) AS Number_of_rentals
FROM film f JOIN inventory i ON i.film_id = f.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
JOIN film_category fc ON fc.film_id = i.film_id
JOIN category cat ON cat.category_id = fc.category_id
WHERE cat.name = 'Action'
GROUP BY f.title
ORDER BY Number_of_rentals DESC;
-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT TOP 10 a.first_name + ' ' + a.last_name AS ActorName, COUNT(r.rental_id) AS Number_of_rentals 
from actor a JOIN film_actor fa ON fa.actor_id = a.actor_id
JOIN inventory i ON i.film_id = fa.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
GROUP BY a.first_name, a.last_name
ORDER BY Number_of_rentals DESC;


-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT TOP 5 a.first_name + ' ' + a.last_name AS ActorName, COUNT(r.rental_id) AS Number_of_rentals 
from actor a JOIN film_actor fa ON fa.actor_id = a.actor_id
JOIN inventory i ON i.film_id = fa.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
JOIN film_category fc ON fc.film_id = i.film_id
JOIN category cat ON cat.category_id = fc.category_id
WHERE cat.name = 'comedy'
GROUP BY a.first_name, a.last_name
ORDER BY Number_of_rentals DESC;