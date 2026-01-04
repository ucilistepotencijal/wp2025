CREATE DATABASE POSUDBE2
GO
USE POSUDBE2
GO

CREATE TABLE Prijatelji(
id INT PRIMARY KEY IDENTITY(1,1),
ime NVARCHAR(50) NOT NULL,
prezime NVARCHAR(50) NOT NULL,
kontakt NVARCHAR(100) NOT NULL,
napomena NVARCHAR(250) NOT NULL
)
GO
CREATE TABLE vrstaMedija(
id INT PRIMARY KEY NOT NULL,
naziv NVARCHAR(100) NOT NULL
)
GO
CREATE TABLE Mediji(
id INT PRIMARY KEY IDENTITY(1,1),
vrstaMedijaID INT FOREIGN KEY REFERENCES vrstaMedija(id),
naziv NVARCHAR(100) NOT NULL,
godina NVARCHAR(10) NOT NULL,
izvođač NVARCHAR(100),
redatelj NVARCHAR(100)
)
GO
CREATE TABLE Posudba(
id INT PRIMARY KEY IDENTITY(1,1),
prijateljId INT FOREIGN KEY REFERENCES Prijatelji(id),
medijiId INT FOREIGN KEY REFERENCES Mediji(id),
datumPosudbe DATE NOT NULL,
datumPovrata DATE,
napomena NVARCHAR(250) NOT NULL
)
GO

INSERT INTO vrstaMedija (id, naziv) VALUES (1, 'CD')
INSERT INTO vrstaMedija (id, naziv) VALUES (2, 'DVD')
SELECT * FROM vrstaMedija
GO

INSERT INTO Prijatelji (ime, prezime, kontakt, napomena) VALUES ('Pero', 'Perić', '0987654321', 'Uvijek vrati na vrijeme')
INSERT INTO Prijatelji (ime, prezime, kontakt, napomena) VALUES ('Iva', 'Ivić', 'iva.ivic@gmail.com', '')
INSERT INTO Prijatelji (ime, prezime, kontakt, napomena) VALUES ('Marko', 'Marković', '0986421357', 'Ne vraća na vrijeme')
SELECT * FROM Prijatelji
GO

--DELETE FROM Prijatelji WHERE id < 4

INSERT INTO Mediji (naziv, godina, izvođač) VALUES ('Without me', '2002', 'EMINEM')
INSERT INTO Mediji (naziv, godina, redatelj) VALUES ('Bad Boys', '1995', 'Michael Bay')
INSERT INTO Mediji (naziv, godina, redatelj) VALUES ('Titanic', '1997', 'James Cameron')
SELECT * FROM Mediji m JOIN vrstaMedija v ON m.vrstaMedijaID = v.id
UPDATE Mediji SET vrstaMedijaID = 2
GO

INSERT INTO Posudba (datumPosudbe, datumPovrata, napomena, prijateljId, medijiId) VALUES ('2025-10-31', '2025-11-02', 'Vraćeno na vrijeme', 4,1)
INSERT INTO Posudba (datumPosudbe, datumPovrata, napomena, prijateljId, medijiId) VALUES ('2025-10-31', '2025-11-08', '', 5,1)
INSERT INTO Posudba (datumPosudbe, datumPovrata, napomena, prijateljId, medijiId) VALUES ('2025-10-01', '2025-11-24', 'Predugo čekam', 6,1)
SELECT * FROM Posudba p JOIN Prijatelji pri ON p.prijateljId = pri.id JOIN Mediji m ON p.medijiId = m.id
--DELETE FROM Posudba
GO

