create database Cinema

use Cinema

create table Genre
(
	Id varchar(3) primary key,
	GenreType varchar(100)
)

create table Director
(
	Id varchar(3) primary key,
	DirectorName varchar(100),
	DirectorNationality varchar(100)
)
create table Movie
(
	Id varchar(3) primary key,
	MovieTitle varchar(100),
	ReleaseDate date,
	GenreId varchar(3) foreign key references Genre(Id),
	DirectorId varchar(3) foreign key references Director(Id)
)

create table Actor
(
	Id varchar(3) primary key,
	FullName varchar(100)
)

create table Actor_Movie
(
	ActorId varchar(3) foreign key references Actor(Id),
	MovieId varchar(3) foreign key references Movie(Id),
	constraint PK_ActorMovie primary key (ActorId, MovieId)
)

create table Actor_Director
(
	ActorId varchar(3) foreign key references Actor(Id),
	DirectorId varchar(3) foreign key references Director(Id),
	constraint PK_ActorDirector primary key (ActorId, DirectorId)
)

create table Actor_Genre
(
	ActorId varchar(3) foreign key references Actor(Id),
	GenreId varchar(3) foreign key references Genre(Id),
	constraint PK_ActorGenre primary key (ActorId, GenreId)
)

create table Cinema
(
	Id varchar(3) primary key,
	CinemaName varchar(100),
	CinemaAddress varchar(100)
)

create table MovieSession
(
	Id varchar(3) primary key,
	SessionStart datetime,
	SessionEnd datetime,
	MovieId varchar(3) foreign key references Movie(Id)
)

create table Movie_Cinema
(
	MovieId varchar(3) foreign key references Movie(Id),
	CinemaId varchar(3) foreign key references Cinema(Id),
	constraint PK_MovieCinema primary key (MovieId,CinemaId )
)

create table Cinema_Session
(
	CinemaId varchar(3) foreign key references Cinema(Id),
	SessionId varchar(3) foreign key references MovieSession(Id),
	constraint PK_CinemaSession primary key (CinemaId, SessionId) 
)

alter table MovieSession
add constraint UC_MovieSession unique (SessionStart, MovieId)