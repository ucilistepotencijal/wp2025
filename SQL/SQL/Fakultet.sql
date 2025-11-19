CREATE DATABASE Fakultet
USE Fakultet

CREATE TABLE Zupanija(
nazZupanija NVARCHAR(50) NOT NULL,
sifZupanija INT PRIMARY KEY IDENTITY (1,1)
)

CREATE TABLE mjesto(
pbr INT PRIMARY KEY,
nazMjesto NVARCHAR(50) NOT NULL,
sifZupanija INT NULL,
FOREIGN KEY (sifZupanija) REFERENCES zupanija(sifZupanija)
)
EXEC sp_rename 'mjesto', 'Mjesto'

CREATE TABLE stud(
mbrStud INT PRIMARY KEY IDENTITY(1,1),
imeStud NVARCHAR(50) NOT NULL,
prezStud NVARCHAR(50) NOT NULL,
pbrRod INT NULL,
pbrStan INT NULL,
datRodStud DATE NOT NULL,
oibStud CHAR(11) NOT NULL,
FOREIGN KEY (pbrRod) REFERENCES mjesto(pbr),
FOREIGN KEY (pbrStan) REFERENCES mjesto(pbr)
)

EXEC sp_rename 'stud', 'Stud'

CREATE TABLE OrgJed(
sifOrgJed INT PRIMARY KEY IDENTITY(1,1),
nazOrgJed NVARCHAR(100) NOT NULL,
sifNadorgJed INT NULL,
FOREIGN KEY (sifNadorgJed) REFERENCES orgJed(sifOrgJed)
)

CREATE TABLE Nastavnik(
sifNastavnik INT PRIMARY KEY IDENTITY(1,1),
imeNastavnik NVARCHAR(100) NOT NULL,
prezNastavnik NVARCHAR(100) NOT NULL,
pbrStan INT NULL,
sifOrgJed INT NOT NULL,
koef DECIMAL(2,2) NULL
)

CREATE TABLE Pred(
sifPred INT PRIMARY KEY IDENTITY(1,1),
kratPred NVARCHAR(50) NULL,
nazPred NVARCHAR(50) NOT NULL,
sifOrgJed INT NOT NULL,
upisanoStud INT NULL,
brojSatiTjedno INT NULL,
FOREIGN KEY(sifOrgJed) REFERENCES OrgJed(sifOrgJed)
)

CREATE TABLE Dvorana(
oznDvorana VARCHAR(30) PRIMARY KEY,
kapacitet INT NULL
)

CREATE TABLE Rezervacija(
oznDvorana VARCHAR(30) NOT NULL,
oznVrstaDan NVARCHAR(30) NULL,
sat TIME NULL,
sifPred INT NOT NULL,
FOREIGN KEY(oznDvorana) REFERENCES Dvorana(oznDvorana),
FOREIGN KEY(sifPred) REFERENCES Pred(sifPred)
)

CREATE TABLE ispit (
    mbrStud INT NOT NULL,
    sifPred INT NOT NULL,
    sifNastavnik INT NULL,
    datIspit DATE NOT NULL,
    ocjena INT NULL,
    oznDvorana VARCHAR(30) NOT NULL,
    FOREIGN KEY(sifNastavnik) REFERENCES Nastavnik(sifNastavnik),
    FOREIGN KEY(sifPred) REFERENCES Pred(sifPred),
    FOREIGN KEY(mbrStud) REFERENCES Stud(mbrStud),
    FOREIGN KEY(oznDvorana) REFERENCES Dvorana(oznDvorana)
    )

ALTER TABLE Nastavnik
ALTER COLUMN koef DECIMAL(4,2) NULL;
    -- CHATGPT popunjavanje
-- =====================
-- 1) ŽUPANIJA
-- =====================

SELECT * FROM Zupanija

INSERT INTO Zupanija (nazZupanija)
VALUES
('Grad Zagreb'),
('Zagrebačka'),
('Primorsko-goranska');

-- =====================
-- 2) MJESTO
-- =====================

SELECT * FROM Mjesto

INSERT INTO Mjesto (pbr, nazMjesto, sifZupanija)
VALUES
(10000, 'Zagreb', 1),
(10360, 'Sesvete', 2),
(51000, 'Rijeka', 3),
(51211, 'Matulji', 3);

-- =====================
-- 3) STUDENT
-- =====================

SELECT * FROM Stud

INSERT INTO Stud (imeStud, prezStud, pbrRod, pbrStan, datRodStud, oibStud)
VALUES
('Ivan', 'Horvat', 10000, 10000, '2000-02-10', '12345678901'),
('Marko', 'Marić', 10360, 10000, '1999-11-23', '23456789012'),
('Ana', 'Kovač', 51000, 51211, '2001-05-14', '34567890123'),
('Lucija', 'Novak', 10000, 10360, '2000-07-19', '45678901234');

-- =====================
-- 4) ORGJED – hijerarhija
-- =====================

SELECT * FROM OrgJed

INSERT INTO OrgJed (nazOrgJed, sifNadorgJed)
VALUES
('Fakultet', NULL),
('Matematicki Odjel', 1),
('Informatički Odjel', 1),
('Katedra za Programiranje', 3);

-- =====================
-- 5) NASTAVNIK
-- =====================

SELECT * FROM Nastavnik

INSERT INTO Nastavnik (imeNastavnik, prezNastavnik, pbrStan, sifOrgJed, koef)
VALUES
('Petar', 'Petrić', 10000, 2, 1.20),
('Marija', 'Maričić', 10360, 3, 1.15),
('Igor', 'Igić', 51000, 4, 1.25);

-- =====================
-- 6) PREDMET
-- =====================
SELECT * FROM Pred

INSERT INTO Pred (kratPred, nazPred, sifOrgJed, upisanoStud, brojSatiTjedno)
VALUES
('MAT1', 'Matematika 1', 2, 120, 4),
('INF1', 'Uvod u Informatiku', 3, 150, 3),
('PROG', 'Programiranje', 4, 130, 5),
('BPI', 'Baze Podataka', 4, 110, 4);

-- =====================
-- 7) DVORANA
-- =====================

SELECT * FROM Dvorana;

INSERT INTO Dvorana (oznDvorana, kapacitet)
VALUES
('DV-1', 50),
('DV-2', 80),
('LAB-1', 25),
('A1', 120);

-- =====================
-- 8) REZERVACIJA DVORANA
-- =====================

SELECT * FROM Rezervacija

INSERT INTO Rezervacija (oznDvorana, oznVrstaDan, sat, sifPred)
VALUES
('DV-1', 'Ponedjeljak', '10:00', 1),
('DV-2', 'Utorak', '12:00', 2),
('LAB-1', 'Srijeda', '09:00', 3),
('A1', 'Četvrtak', '14:00', 4);

-- =====================
-- 9) ISPIT
-- =====================

SELECT * FROM ispit

--Greška Msg 547 za FK__ispit__sifNastav__… znači da vrijednost koju pokušavaš ubaciti u sifNastavnik ne postoji u tablici Nastavnik.
--Pogledala sam koja sifNastavnika postoji (3,4,5 i to ubacila)
SELECT sifNastavnik, imeNastavnik, prezNastavnik FROM Nastavnik; 

INSERT INTO ispit (mbrStud, sifPred, sifNastavnik, datIspit, ocjena, oznDvorana)
VALUES
(1, 1, 3, '2024-01-15', 4, 'A1'),
(2, 3, 4, '2024-01-16', 5, 'LAB-1'),
(3, 2, 5, '2024-01-20', 3, 'DV-2')

--Pregled svih tablica
DECLARE @sql NVARCHAR(MAX) = '';
SELECT @sql = @sql + 'SELECT TOP 10 * FROM [' + TABLE_SCHEMA + '].[' + TABLE_NAME + '];' + CHAR(13)
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;
EXEC sp_executesql @sql;

--2. Ispiši imena i prezimena studenata koji su barem jednom pali na ispitu
UPDATE ispit SET ocjena = 1 WHERE mbrStud = 1;
SELECT imeStud, prezStud FROM Stud s JOIN ispit i ON s.mbrStud = i.mbrStud WHERE i.ocjena < 2

--3. Ispiši imena i prezimena studenata koji su na nekom ispitu dobili 3.
SELECT imeStud, prezStud FROM Stud s JOIN ispit i on s.mbrStud = i.mbrStud WHERE i.ocjena = 3

--4. Ispiši nazive predmeta na koje je izašao barem jedan student.
SELECT * FROM Pred
SELECT * FROM ispit
SELECT DISTINCT p.nazPred FROM Pred p JOIN ispit i ON p.sifPred = i.sifPred

--5. Ispiši nazive predmeta na koje nije izašao niti jedan student


6. Ispiši oznake dvorana i nazive kolegija za one kolegije koji imaju više od 2 sata predavanja tjedno.
7. Ispiši nazive predmeta i organizacijske jedinice kojima pripadaju za one kolegije koji imaju više od 20 upisanih studenata.
8. Ispiši sve nazive mjesta u kojima barem jedan student stanuje. Imena mjesta smiju se pojaviti samo jednom.
9. Ispiši ime i prezime studenta, te naziv i ocjenu za svaki ispit.
10. Ispiši nazive kolegija i oznake dvorana u kojima imaju rezerviran termin. Ispišite i naziv organizacijske jedinice kojoj
kolegij pripada.
11. Ispiši podatke o studentima i njihovim mjestima stanovanja za one studente koji su barem jednom pali na ispitu „Osnove
baze podataka”.
12. Ispiši ime i prezime nastavnika, mjesto stanovanja i županiju nastavnika te naziv kolegija za nastavnike koji su ispitivali
studente koji su dobili ocjenu 2 ili 3 iz tog kolegija.
13. Ispiši ime i prezime studenta, te mjesto i županiju u kojoj su rođeni. Nakon toga dodaj mjesto i županiju u kojoj stanuju.
14. Ispiši nazive mjesta u kojima je barem jedan student i rođen i stanuje. Imena mjesta smiju se pojaviti samo jednom.
15. Ispiši podatke o nastavnicima koji su ispitivali studente koji stanuju u istoj županiji u kojoj stanuje i nastavnik.
16. Ispiši podatke o studentima koji studiraju u mjestu različitom od mjesta rođenja, ali koje se nalazi u istoj županiji u kojoj
su i rođeni.
17. Ispiši podatke o studentima i nastavnicima koji imaju ista prezimena.

