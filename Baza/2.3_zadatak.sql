CREATE DATABASE skladiste
GO

USE skladiste
GO

CREATE TABLE skladisno_mjesto(
skladiste_id INT NOT NULL
PRIMARY KEY,
naziv NCHAR(30),
mjesto NCHAR(20),
)
GO

CREATE TABLE radnik(
radnik_id INT NOT NULL
PRIMARY KEY,
ime NCHAR(30),
prezime NCHAR(30),
skladiste_id INT
FOREIGN KEY
REFERENCES skladisno_mjesto (skladiste_id)
)
GO

CREATE TABLE proizvod(
proizvod_id INT NOT NULL
PRIMARY KEY,
naziv NCHAR(30),
skladiste_id INT
FOREIGN KEY
REFERENCES skladisno_mjesto (skladiste_id)
)
GO

CREATE TABLE voditelji(
radnik_id INT NOT NULL
FOREIGN KEY
REFERENCES radnik (radnik_id),
skladiste_id INT NOT NULL
FOREIGN KEY
REFERENCES skladisno_mjesto (skladiste_id)
CONSTRAINT PK_id PRIMARY KEY
(radnik_id, skladiste_id)
)
GO