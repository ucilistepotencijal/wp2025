SELECT * FROM Narudzbe AS n
INNER JOIN NarudzbeDetalji AS nd ON nd.NarudzbaId = n.Id
INNER JOIN Proizvodi AS p ON p.Id = nd.ProizvodId

SELECT * FROM Narudzbe AS n
LEFT JOIN NarudzbeDetalji AS nd ON nd.NarudzbaId = n.Id
LEFT JOIN Proizvodi AS p ON p.Id = nd.ProizvodId


SELECT * FROM Narudzbe AS n
RIGHT JOIN NarudzbeDetalji AS nd ON nd.NarudzbaId = n.Id
RIGHT JOIN Proizvodi AS p ON p.Id = nd.ProizvodId

SELECT * FROM Narudzbe AS n
FULL OUTER JOIN NarudzbeDetalji AS nd ON nd.NarudzbaId = n.Id
FULL OUTER JOIN Proizvodi AS p ON p.Id = nd.ProizvodId

--CROSS JOIN
SELECT * FROM Narudzbe, NarudzbeDetalji, Proizvodi

--Isprobati sve joinove na tablici proizvodi i mjere proizvoda
--Izbaciti Id-eve koji su nepotrebni za prikaz

SELECT p.Naziv AS Proizvod, p.Cijena, p.Dostupan, mp.Naziv AS Mjera FROM Proizvodi p
INNER JOIN MjereProizvoda mp ON p.MjeraProizvodaId = mp.Id
SELECT p.Naziv AS Proizvod, p.Cijena, p.Dostupan, mp.Naziv AS Mjera FROM Proizvodi p
LEFT JOIN MjereProizvoda mp ON p.MjeraProizvodaId = mp.Id

SELECT p.Naziv AS Proizvod, p.Cijena, p.Dostupan, mp.Naziv AS Mjera FROM Proizvodi p
RIGHT JOIN MjereProizvoda mp ON p.MjeraProizvodaId = mp.Id
SELECT p.Naziv AS Proizvod, p.Cijena, p.Dostupan, mp.Naziv AS Mjera FROM Proizvodi p
FULL JOIN MjereProizvoda mp ON p.MjeraProizvodaId = mp.Id

--Rekurzivno spajanje
SELECT * FROM KategorijeProizvodi AS kp1
INNER JOIN KategorijeProizvodi AS kp2
ON kp1.ProizvodId = kp2.ProizvodId AND kp1.Id <> kp2.Id

SELECT * FROM Proizvodi
SELECT * FROM KategorijeProizvodi 
SELECT * FROM Kategorije
-- Napraviti UPDATE tablice Proizvodi tako da Proizvodi.Naziv = CONCAT(Proizvodi.Naziv, '-', Kategorije.Naziv)
SELECT Proizvodi.Naziv AS PocetniNaziv, CONCAT(Proizvodi.Naziv, ' - ', Kategorije.Naziv) AS NoviNaziv FROM Proizvodi
INNER JOIN KategorijeProizvodi ON KategorijeProizvodi.ProizvodId = Proizvodi.Id
INNER JOIN Kategorije ON Kategorije.Id = KategorijeProizvodi.KategorijaId

UPDATE p SET p.Naziv = CONCAT(p.Naziv, ' - ', k.Naziv) FROM Proizvodi p
INNER JOIN KategorijeProizvodi kp ON kp.ProizvodId = p.Id
INNER JOIN Kategorije k ON k.Id = kp.KategorijaId