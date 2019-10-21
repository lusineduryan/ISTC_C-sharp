use Cinema

insert Genre
values
	('G01', 'Action'),
	('G02', 'Comedy'),
	('G03', 'Thriller'),
	('G04', 'Drama'),
	('G05', 'Crime')

insert Director
values
	('D01', 'Zack Snyder', 'American'),
	('D02', 'Tim Miller', 'American'),
	('D03', 'James Wan', 'Australian'),
	('D04', 'Rajkumar Hirani', 'Indian'),
	('D05', 'Ridley Scott', 'British'),
	('D06', 'Todd Phillips', 'American'),
	('D07', 'Sam Mendes', 'British'),
	('D08', 'Christopher Nolan', 'British')

insert Movie
values
	('M01', 'Superman vs Batman', '2016-03-25', 'G01', 'D01'),
	('M02', 'Deadpool', '2016-02-12', 'G02', 'D02'),
	('M03', 'Furious 7', '2015-04-03', 'G03', 'D03'),
	('M04', 'PK', '2014-12-19', 'G04', 'D04'),
	('M05', 'Gladiator', '2000-05-05', 'G01', 'D05'),
	('M06', 'The Hangover', '2009-06-05', 'G02', 'D06'),
	('M07', '3 Idiots', '2009-12-25', 'G04', 'D04'),
	('M08', 'Spectre', '2015-11-06', 'G03', 'D07'),
	('M09', 'Batman Begins', '2005-06-15', 'G01', 'D08'),
	('M10', 'The Dark Knight', '2008-07-18', 'G05', 'D08')

insert Actor
values
	('A01', 'Christian Bale'),
	('A02', 'Ryan Reynolds'),
	('A03', 'Michelle Rodriguez'),
	('A04', 'Russell Crow'),
	('A05', 'Monica Belucci')

insert Cinema
values
	('C01', 'Kinopark', '34 Arshakunyats Av'),
	('C02', 'CinemaStar', '3 Tsitsernakaberd Hwy')

insert MovieSession
values
	('S01', '2019-10-18 15:30:00', '2019-10-18 17:30:00', 'M01'),
	('S02', '2019-10-18 17:30:00', '2019-10-18 19:30:00', 'M03'),
	('S03', '2019-10-18 19:30:00', '2019-10-18 21:30:00', 'M09')

insert Actor_Director
values
	('A01', 'D03'),
	('A01', 'D05'),
	('A05', 'D01')

insert Actor_Genre
values
	('A01', 'G03'),
	('A01', 'G05'),
	('A02', 'G01'),
	('A02', 'G02'),
	('A03', 'G01'),
	('A03', 'G05')

insert Actor_Movie
values
	('A01', 'M09'),
	('A01', 'M10'),
	('A02', 'M02'),
	('A04', 'M05'),
	('A05', 'M08')

insert Movie_Cinema
values
	('M05', 'C01'),
	('M05', 'C02'),
	('M07', 'C01'),
	('M07', 'C02')

insert Cinema_Session
values	
	('C01', 'S01'),
	('C01', 'S02'),
	('C01', 'S03'),
	('C02', 'S01'),
	('C02', 'S02')