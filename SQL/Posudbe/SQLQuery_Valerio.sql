CREATE DATABASE MEDIOTHEKA
GO

USE MEDIOTHEKA
GO

CREATE TABLE Media (
    id INT IDENTITY(1,1) PRIMARY KEY,
    naslov NVARCHAR(255) NOT NULL,
    tip NVARCHAR(10) CHECK(tip IN('CD', 'DVD'))NOT NULL,
    zanr NVARCHAR(100),
    godina INT
)
GO

CREATE TABLE Prijatelji (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ime NVARCHAR(100) NOT NULL,
    prezime NVARCHAR(100) NOT NULL,
    telefon NVARCHAR(50),
    email NVARCHAR(100)
)
GO
CREATE TABLE Posudbe (
    id INT IDENTITY(1,1) PRIMARY KEY,
    mediaid INT FOREIGN KEY REFERENCES Media(id) NOT NULL,
    prijateljid INT FOREIGN KEY REFERENCES Prijatelji(id) NOT NULL,
    datumposudbe DATE NOT NULL,
    datumpovrata DATE,
)
GO

INSERT INTO Media (naslov, tip, zanr, godina) VALUES
('Metallica – Black Album', 'CD', 'Metal', 1991),
('Interstellar', 'DVD', 'Sci-Fi', 2014),
('Adele – 21', 'CD', 'Pop', 2011)
GO

INSERT INTO Prijatelji (ime, prezime, telefon, email) VALUES
('Marko', 'Horvat', '091111111', 'marko@example.com'),
('Ivana', 'Kovač', '092222222', 'ivana@example.com'),
('Petar', 'Marić', '093333333', 'petar@example.com');
GO

INSERT INTO Posudbe (mediaid, prijateljid, datumposudbe, datumpovrata) VALUES
(1, 1, '2025-01-10', NULL),      -- Marko ima Metallica CD (nije vraćeno)
(2, 2, '2025-01-05', '2025-01-20'), -- Ivana posudila Interstellar, pa vratila
(3, 3, '2025-02-01', NULL);      -- Petar ima Adele CD (još nije vratio)
GO

SELECT 
    p.ime,
    p.prezime,
    m.naslov AS medij,
    ps.datumposudbe,
    DATEDIFF(DAY, ps.datumposudbe, GETDATE()) AS danakodprijatelja
FROM Posudbe ps
JOIN Prijatelji p ON ps.prijateljid = p.id
JOIN Media m ON ps.mediaid = m.id
WHERE ps.datumpovrata IS NULL;
GO

UPDATE Posudbe
SET datumpovrata = CAST(GETDATE() AS DATE)
WHERE datumpovrata IS NULL
GO
