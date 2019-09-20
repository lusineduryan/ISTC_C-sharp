create database ProgrammingLanguages
create table MainCharacteristics
(
ID int primary key identity,
LangName varchar(10),
LatestVersion decimal,
NumberOfUsers bigint,
ReleaseDate date,
Ranking smallint,
)

alter table MainCharacteristics
add Complexity varchar(20), Issuer varchar(50), Licesnse varchar(50), Website varchar(50)

alter table MainCharacteristics
add check (Ranking > 20)

alter table MainCharacteristics
alter column Complexity varchar(50)
