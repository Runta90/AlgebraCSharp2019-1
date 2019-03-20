CREATE DATABASE zaposlenici
GO

USE zaposlenici
GO

CREATE TABLE radnici (
radnik_id BIGINT NOT NULL,
PRIMARY KEY,
ime NVARCHAR(50) NOT NULL,
odjel_id NCHAR(10) NOT NULL
REFERENCES odjeli(odjel_id)
)
GO

CREATE TABLE odjeli(
odjel_id NCHAR(10) NOT NULL
PRIMARY KEY,
naziv_odjela NVARCHAR(50) NOT NULL,
lokacija_odjela NVARCHAR(50) NOT NULL,
)
GO

CREATE TABLE sefovi(
zaposlenik_id BIGINT
FOREIGN KEY
REFERENCES radnici(radnik_id),
odjel_id NCHAR(10)
FOREIGN KEY
REFERENCES odjeli(odjel_id),
CONSTRAINT PK_id PRIMARY KEY
(radnik_id, odjel_id)
)
GO