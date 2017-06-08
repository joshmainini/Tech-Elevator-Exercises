-- Write queries to return the following:
-- The following changes are applied to the "pagila" database.**
use [DVD_store ]
-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT into actor
(first_name, last_name)
VALUES
('Hampton','Avenue')
INSERT into actor
(first_name, last_name)
VALUES
('Lisa','Byway')
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece", to the film table. The movie was released in 2008 in English. 
-- Since its an epic, the run length is 3hrs and 18mins. There are no special 
-- features, the film speaks for itself, and doesn't need any gimmicks.	
INSERT film
(title, description, release_year, language_id, original_language_id, rental_duration, rental_rate, length, replacement_cost,rating)
VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece', 2008, 1, 1, 5,5,198,30, 'R');

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly 
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT film_actor
VALUES 
(201, 1001) 
INSERT film_actor
VALUES 
(202, 1001) 

-- 4. Add Mathmagical to the category table.
INSERT category
VALUES 
('Mathmagical');
-- 5. Assign the Mathmagical category to the following films, "Euclidean PI", 
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
INSERT INTO film_category
VALUES(1001, 17)
UPDATE film_category
SET category_id = 17 
WHERE film_id IN (714, 996, 1001, 494, 274);

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films 
-- accordingly.
-- (5 rows affected)
UPDATE film 
SET rating = 'G'
FROM film_category JOIN film ON film_category.film_id = film.film_id
WHERE film_category.category_id = 17;
-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory
VALUES 
(1001, 1);

INSERT INTO inventory
VALUES 
(1001, 2);

-- 8. The Feds have stepped in and have impounded all copies of the pirated film, 
-- "Euclidean PI". The film has been seized from all stores, and needs to be 
-- deleted from the film table. Delete "Euclidean PI" from the film table. 
-- (Did it succeed? Why?)
DELETE FROM film
WHERE title = 'euclidean PI';

--The DELETE statement conflicted with the REFERENCE constraint "FK__film_acto__film___47DBAE45". The conflict occurred in database "DVD_store ", table "dbo.film_actor", column 'film_id'.
--The statement has been terminated.

-- 9. Delete Mathmagical from the category table. 
-- (Did it succeed? Why?)
DELETE FROM category
WHERE category.category_id = 17;

--The DELETE statement conflicted with the REFERENCE constraint "FK__film_cate__categ__49C3F6B7". The conflict occurred in database "DVD_store ", table "dbo.film_category", column 'category_id'.

-- 10. Delete all links to Mathmagical in the film_category tale. 
-- (Did it succeed? Why?)
DELETE FROM film_category
WHERE film_id = 1001;
DELETE FROM film_category
WHERE film_category.category_id = 17;

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI". 
-- (Did either deletes succeed? Why?)
DELETE FROM category
WHERE category.category_id = 17;

DELETE FROM film
WHERE title = 'euclidean PI';

-- 12. Check database metadata to determine all constraints of the film id, and 
-- describe any remaining adjustments needed before the film "Euclidean PI" can 
-- be removed from the film table.
DELETE FROM inventory
WHERE film_id = 1001;

DELETE FROM film_actor 
WHERE film_id = 1001;

DELETE FROM film
WHERE title = 'euclidean PI';