USE [TEAM4CMPT291DATABASE]

--delete tables w/ foreign keys first
--delete entity tables last
delete AppearedIn;
delete CustomerPhone;
delete EmployeePhone;
delete MovieQueue;
delete RateActor;
delete Rental;
delete Customer;
delete Employee;
delete Movie;
delete Actor;


-----------TEST DATA----------------------------------------------------------------------------------------------------

----Employee(EmployeeID, SocialSecurityNum, LastName, FirstName, Address, City, State, ZipCode, StartDate)

DBCC CHECKIDENT ('Employee', RESEED, 0);

INSERT INTO Employee (SocialSecurityNum, LastName, FirstName, Address, City, State, ZipCode, StartDate)
VALUES 
    ('123455678', 'Smith', 'John', '14 Larry Lane', 'Calgary', 'Alberta', 'T9M8F0', '2025-03-01'),
    ('123455679', 'Skiba', 'Przemyslaw', '48 Fountain Creek', 'Sherwood Park', 'Alberta', 'T8B 1C9', '2025-12-19'),
    ('123455680', 'Doe', 'Jane', '88 Employee Lane', 'Edmonton', 'Alberta', 'T4P 4A6', '2024-11-03'),
    ('234567890', 'Stewart', 'Ralph', '101 Movie Street', 'Edmonton', 'Alberta', 'T7L 5N8', '2024-11-23'),
    ('103482638', 'Cornelius', 'Jamie', '900 Actor Lane', 'Red Deer', 'Alberta', 'T0P 4R6', '2025-02-02');


INSERT INTO EmployeePhone (EmployeeID, PhoneNumber)
VALUES 
    (1, '1-555-234-1234'),
    (2, '1-555-789-7280'),
    (3, '1-555-234-1678'),
    (4, '1-555-282-9273'),
    (5, '1-555-764-3832');


---Movie( MovieID, MovieName, MovieType, DistributionFee, NumberCopies, Rating)

DBCC CHECKIDENT ('Movie', RESEED, 0);

INSERT INTO Movie (MovieName, MovieType, DistributionFee, NumberOfCopies) 
VALUES ('Iron Man', 'Action', 5.99, 3),
('The Incredible Hulk', 'Action', 5.99, 2),
('Iron Man 2', 'Action', 5.99, 2),
('Thor', 'Action', 6.99, 4),
('Captain America: The First Avenger', 'Action', 8.99, 5),
('The Avengers', 'Action', 6.99, 4); 


---Customer( CustomerID,LastName, FirstName, Address, City, State, ZipCode, Email, AccountNumber, AccountCreateDate, CreditCardNumber, RentalHistory, Rating)

DBCC CHECKIDENT ('Customer', RESEED, 0);

INSERT INTO Customer (LastName, FirstName, Address, City, State, ZipCode, EmailAddress, AccountNumber, AccountCreateDate, CreditCardNumber)
VALUES( 'Samantha', 'Skiba', '48 Fountain Creek Dr.', 'Sherwood Park', 'Alberta', 'T8B1C9',  'samski602@gmail.com', '1', 'March 1, 2025', '1234 5678 9101 1121'),
	 	('Kaden', 'Watt', '11050 104 Ave NW.', 'Edmonton', 'Alberta', 'T5K 2Y9', 'wattk679@gmail.com', '2', 'November 3, 2024', '1234 5678 9101 1122'),
('Prez', 'Skiba', '48 Fountain Creek Dr.', 'Sherwood Park', 'Alberta', 'T8B1C9',
 'prez@gmail.com', '3', 'March 3, 2025', '1234 5678 9101 1121'),
('Smith', 'Stephen', '28 Blackwood Close', 'Edmonton', 'Alberta', 'T9U7T6',
 'Ssmith@gmail.com', '4', 'March 2, 2025', '1234 5678 9101 2738'),
('Reiper', 'Tobias', '23 Tuesday Lane', 'Edmonton', 'Alberta', 'T9U9P7',
 'reiper47@gmail.com', '5', 'February 17, 2025', '1234 5678 9101 3839');


INSERT INTO CustomerPhone (CustomerID, PhoneNumber)
VALUES 
    (1, '1-456-789-1234'),
    (2, '1-456-789-2089'),
    (3, '1-555-780-3749'),
    (4, '1-555-790-2739'),
    (5, '1-456-789-3820');



---Actor(ActorID, ActorName, Gender, DoB, Age, Rating)

DBCC CHECKIDENT ('Actor', RESEED, 0);

		---iron man actors
INSERT INTO Actor (ActorName, Gender, DoB)
VALUES ('Robert Downey Jr.', 'Male', '1965-04-04'),
('Jon Favreau', 'Male', '1966-10-19'),
('Gwyneth Paltrow', 'Female', '1972-08-27'),
( 'Jeff Bridge', 'Male', '1965-04-04'),
('Terrence Howard', 'Male', '1969-05-11'),
('Lesile Bibb', 'Female', '1974-11-17'),
( 'Stan Lee', 'Male', '1922-12-28'),
		---Incredible Hulk actors
('Edward Norton', 'Male', '1969-08-18'),
( 'Lou Ferrigno', 'Male', '1951-11-09'),
('Tim Roth', 'Male', '1961-05-14'),
( 'Liv Tyler', 'Female', '1977-07-01'),
( 'William Hurt', 'Male', '1950-05-20'),
('Tim Blake Nelson', 'Male', '1964-05-11'),
('Ty Burrell', 'Male', '1967-08-22'),
		---iron man 2 actors
('Mickey Rourke', 'Male', '1952-09-09'),
('Scarlett Johansson', 'Female', '1984-11-22'),
('Don Cheadle', 'Male', '1964-11-29'),
('Sam Rockwell', 'Male', '1968-03-05'),
		---Thor actors
( 'Chris Hemsworth', 'Male', '1983-08-11'),
('Natalie Portman', 'Female', '1981-06-09'),
('Tom Hiddleston', 'Male', '1981-02-09'),
('Anthony Hopkins', 'Male', '1937-12-31'),
('Stellan Skarsgard', 'Male', '1951-06-13'),
('Idris Elba', 'Male', '1972-09-06'),
('Kat Dennings', 'Female', '1986-06-13'),
		---Captain America Actors, The first avenger
('Chris Evans', 'Male', '1981-06-13'),
('Hayley Atwell', 'Female', '1982-04-05'),
('Sebastian Stan', 'Male', '1982-08-13'),
('Joe Johnston', 'Male', '1950-05-13'),
('Samuel L. Jackson', 'Male', '1948-12-21'),
('Hugo Weaving', 'Male', '1960-04-04'),
('Stanley Tucci', 'Male','1960-11-11'),
('Tommy Lee Jones', 'Male', '1946-09-15'),
		---The avenger Actors
('Jeremy Renner', 'Male', '1971-01-07'),
('Cobie Smulders', 'Female', '1982-04-03'),
('Mark Ruffalo', 'Male', '1967-11-22'),
('Ashley Johnson', 'Female', '1983-08-09'),
('Linda Cardellini', 'Female', '1975-06-25'),
('Clark Greg', 'Male', '1962-04-02'),
('Jenny Agutter', 'Female', '1952-12-20');

INSERT INTO AppearedIn (MovieID, ActorID)
	VALUES 
	('1', '1'),
	('1', '2'),
	('1', '3'),
	('1', '4'),
	('1', '5'),
	('1', '6'),
	('1', '7'),
		-- Actors in Incredible hulk
	('2', '8'),
	('2', '9'),
	('2', '10'),
	('2', '11'),
	('2', '12'),
	('2', '13'),
	('2', '14'),
		-- Actors in Iron Man 2
	('3', '1'),
	('3', '2'),
	('3', '3'),
	('3', '15'),
	('3', '16'),
	('3', '17'),
	('3', '18'),
		--Thor movie Actors
	('4', '19'),
	('4', '20'),
	('4', '21'),
	('4', '22'),
	('4', '23'),
	('4', '24'),
	('4', '25'),
		--actors in captain america: The first Avenger
	('5', '26'),
	('5', '27'),
	('5', '28'),
	('5', '29'),
	('5', '30'),
	('5', '31'),
	('5', '32'),
	('5', '33'),
		--actors in The avengers
	('6', '16'),
	('6', '26'),
	('6', '19'),
	('6', '1'),
	('6', '30'),
	('6', '21'),
	('6', '27'),
	('6', '3'),
	('6', '23'),
	('6', '34'),
	('6', '35'),
	('6', '36'),
	('6', '37'),
	('6', '38'),
	('6', '39'),
	('6', '40');

DBCC CHECKIDENT ('Rental', RESEED, 0);

INSERT INTO Rental (MovieID, CustomerID, CheckoutDateTime, ReturnDateTime, EmployeeID) 
VALUES (1, 1, '2025-03-01 16:30:00', NULL, 1),
    (2, 1, '2025-04-06 14:22:10', NULL, 1),
    (6, 1, '2025-03-01 17:40:10', '2025-03-03 16:40:10', 2),
    (4, 2, '2024-11-06 13:40:45', '2024-11-11 14:52:23', 3),
    (6, 2, '2024-11-09 14:50:12', '2024-11-11 14:52:56', 5);


INSERT INTO MovieQueue (MovieID, CustomerID, SortOrder)
	VALUES
	(1, 1, 1),
	(2, 1 , 2),
	(3, 1, 3),
	(5, 2, 1),
	(3, 2, 2),
	(1, 2, 3);


INSERT INTO RateActor (RentalID, ActorID, ARate)
VALUES 
	(1, 1, 4),
	(4, 19, 5),
	(5, 39, 4),
	(3, 37, 5),
	(3, 36, 3);

