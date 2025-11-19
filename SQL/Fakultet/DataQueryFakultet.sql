CREATE DATABASE Fakultet
GO

USE Fakultet
GO

CREATE TABLE zupanija (
    sifZupanija INT PRIMARY KEY NOT NULL,
    nazZupanija VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Mjesto(
    pbr INT PRIMARY KEY,
    nazMjesto NVARCHAR(50) NOT NULL,
    sifZupanija INT FOREIGN KEY REFERENCES zupanija(sifZupanija)
)
GO

CREATE TABLE dvorana (
  oznDvorana NVARCHAR(10) PRIMARY KEY,  
  kapacitet INT,
);
GO

CREATE TABLE Stud(
    mbrStud NVARCHAR(20) PRIMARY KEY,
    imeStud NVARCHAR(50) NOT NULL,
    prezStud NVARCHAR(50) NOT NULL,
    pbrRod INT FOREIGN KEY REFERENCES Mjesto(pbr),
    pbrStan INT FOREIGN KEY REFERENCES Mjesto(pbr) NOT NULL,
    datRodStud DATE,
    oibStud NVARCHAR(11)
)
GO

CREATE TABLE orgjed(
    sifOrgJed INT PRIMARY KEY,
    nazOrgJed NVARCHAR(100) NOT NULL,
    sifNadorgJed INT FOREIGN KEY REFERENCES orgJed(sifOrgJed)
)
GO

CREATE TABLE nastavnik (
    sifNastavnik INT PRIMARY KEY,
    imeNastavnik NVARCHAR(50) NOT NULL,
    prezNastavnik NVARCHAR(100) NOT NULL,
    pbrStan INT FOREIGN KEY REFERENCES Mjesto(pbr) NOT NULL,
    sifOrgjed INT FOREIGN KEY REFERENCES orgjed(sifOrgJed) NOT NULL,
    koef FLOAT NOT NULL,    
)
GO

CREATE TABLE pred(
    sifPred INT PRIMARY KEY,
    kratPred NVARCHAR(50),
    nazPred NVARCHAR(50) NOT NULL,
    sifOrgJed INT FOREIGN KEY REFERENCES OrgJed(sifOrgJed),
    upisanoStud INT,
    brojSatiTjedno INT
)
GO

CREATE TABLE rezervacija(
    oznDvorana NVARCHAR(10) FOREIGN KEY REFERENCES dvorana(oznDvorana),
    oznVrstaDan NVARCHAR(20),
    sat INT NOT NULL,
    sifPred INT FOREIGN KEY REFERENCES pred(sifPred) NOT NULL
)
GO

CREATE TABLE ispit (
    mbrStud NVARCHAR(20) FOREIGN KEY REFERENCES stud(mbrStud) NOT NULL,
    sifPred INT NOT NULL FOREIGN KEY REFERENCES pred(sifPred),
    sifNastavnik INT NOT NULL FOREIGN KEY REFERENCES nastavnik(sifNastavnik),
    datIspit DATE NOT NULL,
    ocjena INT
    )
GO