-- Kreiranje tablica
CREATE DATABASE Trgovina
USE Trgovina

CREATE TABLE Skladista(
	Id	INT PRIMARY KEY IDENTITY(1,1),
	Naziv	NVARCHAR(50) NOT NULL,
	Lokacija	NVARCHAR(50) NULL
)

CREATE TABLE Proizvodi(
	Id	INT PRIMARY KEY IDENTITY(1,1),
	Naziv	NVARCHAR(50) NOT NULL,
	JedinicnaCijena	FLOAT NOT NULL,
	SkladisteId	INT FOREIGN KEY REFERENCES Skladista(Id)
)

-- Popunjavanje tablice skladišta
INSERT INTO Skladista VALUES ('Skladište br. 1', 'Valpovo, Hrvatska')
INSERT INTO Skladista VALUES ('Skladište br. 2', 'Belišće, Hrvatska')

INSERT INTO Proizvodi VALUES ('Mlijeko', 0.79, 1)
INSERT INTO Proizvodi VALUES ('Kruh', 1.29, 1)
INSERT INTO Proizvodi VALUES ('Sol', 1.69, 1)

-- Ispis podataka
SELECT * FROM Skladista

SELECT Naziv, Lokacija FROM Skladista

SELECT * FROM Proizvodi

SELECT * FROM Proizvodi 
INNER JOIN Skladista ON Proizvodi.SkladisteId = Skladista.Id

SELECT Proizvodi.Naziv, Proizvodi.JedinicnaCijena, 
Skladista.Naziv, Skladista.Lokacija FROM Proizvodi 
INNER JOIN Skladista ON Proizvodi.SkladisteId = Skladista.Id

-- Izmjene tablica - dodavanje atributa
ALTER TABLE Proizvodi ADD Kolicina INT NULL

--Izmjene podataka - dodavanje količine na svim redovima
UPDATE Proizvodi SET Kolicina = 100

-- Izmjena atributa u tablici
ALTER TABLE Proizvodi ALTER COLUMN Kolicina INT NOT NULL

-- Kreiranje tablice za narudžbu
CREATE TABLE Narudzbe(
	Id						INT PRIMARY KEY IDENTITY (1,1),
	DatumNarudzbe			DATETIME NOT NULL,
	PredvidjeniDatumDostave	DATETIME NOT NULL,
	Dostavljeno				BIT
)

-- Junction tablica - veza Narudzbi i Proizvoda
CREATE TABLE NarudzbeProizvodi(
	Id			INT PRIMARY KEY IDENTITY (1,1),
	NarudzbaId	INT FOREIGN KEY REFERENCES Narudzbe(Id),
	ProizvodId	INT FOREIGN KEY REFERENCES Proizvodi(Id),
	Kolicina	INT NOT NULL
)

-- Brisanje kolumne iz tablice
ALTER TABLE Proizvodi DROP COLUMN Kolicina

--Dodavanje tablice Kupci
CREATE TABLE Kupci(
	Id		INT PRIMARY KEY IDENTITY (1,1),
	Ime		NVARCHAR(50) NOT NULL,
	Prezime NVARCHAR(50) NOT NULL,
	Email	NVARCHAR(50) NULL,
	Adresa	NVARCHAR(250) NOT NULL,
	Telefon NVARCHAR(50) NULL,
	Napomena NVARCHAR(MAX) NULL	
)

ALTER TABLE Narudzbe ADD KupacId INT FOREIGN KEY REFERENCES Kupci(Id)

-- U tablici proizvoda postaviti da tim podatka za jediničnu cijenu bude DECIMAL(18,2) NOT NULL
ALTER TABLE Proizvodi ALTER COLUMN JedinicnaCijena DECIMAL(18,2) NOT NULL

CREATE TABLE MjereProizvoda(
	Id	INT PRIMARY KEY IDENTITY (1,1),
	Naziv	NVARCHAR(10) NOT NULL
)

ALTER TABLE Proizvodi ADD MjeraProizvodaId INT FOREIGN KEY REFERENCES MjereProizvoda(Id) 

-- 3. predavanje
USE Trgovina

-- Punjenje tablice MjereProizvoda
INSERT INTO MjereProizvoda VALUES('kom')
INSERT INTO MjereProizvoda (Naziv) VALUES('kg')
INSERT INTO MjereProizvoda (Naziv) VALUES('g')
INSERT INTO MjereProizvoda (Naziv) VALUES('dag')
INSERT INTO MjereProizvoda (Naziv) VALUES('m')
INSERT INTO MjereProizvoda (Naziv) VALUES('l')

SELECT * FROM Proizvodi
SELECT * FROM MjereProizvoda

-- izmjena podataka u tablici proizvodi
UPDATE Proizvodi SET MjeraProizvodaId = 6 WHERE Naziv = 'Mlijeko'
UPDATE Proizvodi SET MjeraProizvodaId = 2 WHERE MjeraProizvodaId IS NULL

--Punjenje tablice korisnika
INSERT INTO Kupci (Ime, Prezime, Email, Adresa, Telefon, Napomena) VALUES
('Pero', 'Perić', 'pero@gmail.com', 'Perin put 10', '123456789', 'Pero ima velikog psa'),
('Iva', 'Ivić', 'iva@gmail.com', 'Ivina cesta 11', '987654321', NULL)

--Punjenje tablice Narudžbe
INSERT INTO Narudzbe (DatumNarudzbe, PredvidjeniDatumDostave, Dostavljeno, KupacId) VALUES
('2025-11-14', '2025-11-15', 0, 1),
('2025-11-14', '2025-11-14', 1, 2)

--Punjenje tablice NarudzbeProizvodi
INSERT INTO NarudzbeProizvodi (NarudzbaId, ProizvodId, Kolicina) VALUES
(1, 1, 2),
(1, 2, 1),
(2, 3, 4)

--Izmjena podataka u tablici
SELECT * FROM Proizvodi
UPDATE Proizvodi SET Naziv = 'Crni kruh' WHERE Id = 2

-- Punjenje i brisanje podataka u tablici
INSERT INTO Proizvodi VALUES ('Mlijeko', 0.79, 1, 6) --ne moramo eksplicitno navoditi kolone samo ako punimo sve atribute
DELETE FROM Proizvodi WHERE Id > 3

-- brisanje podataka iz tablice
SELECT * FROM NarudzbeProizvodi
TRUNCATE Table NarudzbeProizvodi

-- brisanje podataka i same tablice
DROP TABLE NarudzbeProizvodi