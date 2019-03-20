CREATE DATABASE videoteka
GO

USE videoteka
GO

CREATE TABLE clanovi(
clan_id INT NOT NULL
PRIMARY KEY,
ime NVARCHAR(30),
prezime NVARCHAR(30),
adresa NVARCHAR(30),
telefon NVARCHAR(15),
datum_uclanjenja DATETIME
)
GO

CREATE TABLE zandr(
zandr_id INT NOT NULL
PRIMARY KEY,
naziv NVARCHAR(30)
)
GO

CREATE TABLE filmovi(
filmovi_id INT NOT NULL
PRIMARY KEY,
naziv NVARCHAR(30),
reziser NVARCHAR(30),
glavni_glumci NVARCHAR(100),
godina_izdavnja INT,
kolicina_dvd INT,
kolicina_vhs INT,
slika_naslovnice IMAGE,
zandr_id INT
FOREIGN KEY
REFERENCES zandr (zandr_id)
)
GO

CREATE TABLE cjenik(
cjenik_id INT NOT NULL
PRIMARY KEY,
kategorija NVARCHAR(30),
cijena SMALLMONEY
)
GO

CREATE TABLE posudba(
clan_id INT NOT NULL
FOREIGN KEY
REFERENCES clanovi (clan_id),
filmovi_id INT NOT NULL
FOREIGN KEY
REFERENCES filmovi (filmovi_id),
datum_posudbe DATETIME,
datum_povratka DATETIME,
cjenik_id INT NOT NULL
FOREIGN KEY
REFERENCES cjenik (cjenik_id),
CONSTRAINT PK_id PRIMARY KEY
(clan_id, filmovi_id, datum_posudbe)
)
GO