USE Fakultet
INSERT INTO zupanija VALUES (1, 'Zagrebačka')
INSERT INTO zupanija VALUES (9, 'Ličko-Senjska')
INSERT INTO zupanija VALUES (10, 'Virovitičko-Podravska')
INSERT INTO zupanija VALUES (14, 'Osječko-Baranjska')
INSERT INTO zupanija VALUES (21, 'Grad Zagreb')

SELECT * FROM zupanija

INSERT INTO mjesto VALUES (10000, 'Zagreb', 21)
INSERT INTO mjesto VALUES (33000, 'Virovitica', 10)
INSERT INTO mjesto VALUES (21240, 'Trilj', 9)
INSERT INTO mjesto VALUES (31000, 'Osijek', 14)
INSERT INTO mjesto (pbr, nazMjesto, sifZupanija) VALUES (31551, 'Belišće', 14)

SELECT * FROM mjesto m JOIN zupanija z ON m.sifZupanija=z.sifZupanija

INSERT INTO stud (mbrStud, imeStud, prezStud, pbrRod, pbrStan, datRodStud, oibStud)
VALUES
(252-3, 'Ivan', 'Horvat', 33000, 10000, '2002-02-10', '12345678901'),
(252-5, 'Marko', 'Marić', 21240, 10000, '1999-11-23', '23456789012'),
(236-9,'Ana', 'Kovač', 31551, 31000, '2004-05-14', '34567890123'),
(526-5, 'Lucija', 'Novak', 10000, 10000, '2000-07-19', '45678901234')

SELECT * FROM stud s JOIN Mjesto m ON s.pbrRod = m.pbr JOIN Mjesto m2 ON s.pbrStan = m2.pbr JOIN zupanija z ON z.sifZupanija = m.sifZupanija

INSERT INTO dvorana VALUES (20, 25)
INSERT INTO dvorana VALUES (30, 48)
INSERT INTO dvorana VALUES (40, 99)

SELECT * FROM dvorana

INSERT INTO orgjed (sifOrgJed, nazOrgJed) VALUES (1, 'Katedra za računalstvo')
INSERT INTO orgjed VALUES (11, 'Odjel za razvoj softvera', 1)

SELECT * FROM orgjed

INSERT INTO pred (sifPred, nazPred, brojSatiTjedno) VALUES (230, 'Web programiranje', 12)
INSERT INTO pred (sifPred, nazPred) VALUES (220, 'Razvoj web sučelja')
INSERT INTO pred (sifPred, nazPred, brojSatiTjedno) VALUES (250, 'Baze podataka', 22)
INSERT INTO pred (sifPred, nazPred, brojSatiTjedno) VALUES (240, 'Internetski marketing', 30)

SELECT * FROM pred

INSERT INTO rezervacija (oznDvorana, sat, sifPred) VALUES (20, 6, 230)
INSERT INTO rezervacija (oznDvorana, sat, sifPred) VALUES (30, 8, 240)
INSERT INTO rezervacija (oznDvorana, sat, sifPred) VALUES (40, 12, 250)
SELECT * FROM rezervacija

INSERT INTO nastavnik VALUES (100, 'Ivo', 'Ivić', 31551, 11, 2.5)
INSERT INTO nastavnik VALUES (102, 'Josip', 'Anić', 31551, 11, 2.5)
INSERT INTO nastavnik VALUES (105, 'Ana', 'Marković', 31551, 11, 2.5)
INSERT INTO nastavnik VALUES (110, 'Marko', 'Josipović', 31551, 11, 2.5)
INSERT INTO nastavnik VALUES (210, 'Igor', 'Ivanović', 10000, 11, 3.5)

SELECT * FROM nastavnik

INSERT INTO ispit VALUES (249, 230, 210, '2025-11-19', 5)
INSERT INTO ispit VALUES (227, 240, 210, '2025-11-19', 4)
INSERT INTO ispit VALUES (521, 250, 210, '2025-11-19', 4)
INSERT INTO ispit VALUES (247, 250, 102, '2025-11-19', 3)
INSERT INTO ispit VALUES (227, 250, 102, '2025-11-19', 1)
INSERT INTO ispit VALUES (521, 240, 102, '2025-11-19', 2)

SELECT * FROM ispit i JOIN pred p ON i.sifPred=p.sifPred JOIN nastavnik n ON n.sifNastavnik = i.sifNastavnik

