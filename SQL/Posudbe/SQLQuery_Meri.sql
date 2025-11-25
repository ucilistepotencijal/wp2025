CREATE DATABASE Posudba
GO

USE Posudba
GO

CREATE TABLE vrstaMedija(
	id INT PRIMARY KEY,
	naziv NVARCHAR(50) NOT NULL UNIQUE,
)
GO

CREATE TABLE Prijatelji(
	id INT PRIMARY KEY IDENTITY(1,1),
	ime NVARCHAR(50) NOT NULL,
	prezime NVARCHAR(100) NOT NULL,
	kontakt NVARCHAR(100),
	napomena NVARCHAR(500)
)
GO

CREATE TABLE Medij(
	id INT PRIMARY KEY IDENTITY(1,1),
	vrstaMedija INT FOREIGN KEY REFERENCES vrstaMedija(id) NOT NULL,
	naziv NVARCHAR(100) NOT NULL,
	godina INT,
	izvođač NVARCHAR(200),
	redatelj NVARCHAR(200),
	napomena NVARCHAR(200)
)
GO

CREATE TABLE Posudba(
	id INT PRIMARY KEY IDENTITY(1,1),
	prijateljId	INT FOREIGN KEY REFERENCES Prijatelji(id) NOT NULL,
	medijId INT FOREIGN KEY REFERENCES Medij(id) NOT NULL,
	datumPosudbe DATE NOT NULL,
	datumPovrata DATE,
	napomena NVARCHAR(200)
)
GO

INSERT INTO vrstaMedija (id, naziv) VALUES (1, 'CD')
INSERT INTO vrstaMedija (id, naziv) VALUES (2, 'DVD')
GO

INSERT INTO Prijatelji (ime, prezime, kontakt, napomena) VALUES ('Marko', 'Marković', 'markomarkovic@gmail.com', 'redovito poduđuje')
INSERT INTO Prijatelji (ime, prezime, kontakt) VALUES ('Iva', 'Horvat', '095 677 8990')
INSERT INTO Prijatelji (ime, prezime, kontakt) VALUES ('Darko', 'Radić', 'radicdarko1@gmail.com')
GO

INSERT INTO Medij (vrstaMedija, naziv, godina, izvođač) VALUES (1, 'Fear of the Dark', 1992, 'Iron Maiden')
INSERT INTO Medij (vrstaMedija, naziv, godina, izvođač, redatelj, napomena) VALUES (2, 'Titanic', 1997, NULL, 'James Cameron', 'nemam titlove za ovaj')
INSERT INTO Medij (vrstaMedija, naziv, godina, izvođač) VALUES (1, 'Indestructible', 2003, 'Rancid')
GO

INSERT INTO Posudba (prijateljId, medijId, datumPosudbe, datumPovrata) VALUES (1, 1, '2025-10-20', '2025-10-30')
INSERT INTO Posudba (prijateljId, medijId, datumPosudbe) VALUES (2, 2, '2025-11-20')
INSERT INTO Posudba (prijateljId, medijId, datumPosudbe) VALUES (3, 1, '2025-11-24')
GO

--prijatelji koji nisu vratili medij
SELECT p.ime, p.prezime, vm.naziv, m.naziv, ps.datumPosudbe, DATEDIFF(DAY, ps.datumPosudbe, GETDATE()) AS 'Broj dana'
FROM Posudba ps JOIN Prijatelji p ON ps.prijateljId = p.id
				JOIN Medij m ON ps.medijId = m.id
				JOIN vrstaMedija vm ON M.vrstaMedija = vm.id
				WHERE ps.datumPovrata IS NULL

				--U istom upitu kreirajte i polje koje računa koliko je dana CD ili DVD kod prijatelja - ne znam
--postavljanje na današnji dan
UPDATE Posudba SET datumPovrata = CAST(GETDATE() AS DATE)
WHERE datumPovrata IS NULL