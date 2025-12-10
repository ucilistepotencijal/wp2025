USE Fakultet
--2. Ispiši imena i prezimena studenata koji su barem jednom pali na ispitu iz predmeta sa šiframa od 220 do 240.
SELECT s.imeStud, s.prezStud FROM Stud s JOIN ispit i ON s.mbrStud = i.mbrStud WHERE i.sifPred BETWEEN 220 AND 240 AND i.ocjena = 1

--3. Ispiši imena i prezimena studenata koji su na nekom ispitu dobili 3.
SELECT s.imeStud, s.prezStud FROM Stud s JOIN ispit i on s.mbrStud = i.mbrStud WHERE i.ocjena = 3

--4. Ispiši nazive predmeta na koje je izašao barem jedan student.
SELECT DISTINCT p.nazPred FROM pred p JOIN Ispit i ON p.sifPred = i.sifPred;

--5. Ispiši nazive predmeta na koje nije izašao ni􀆟 jedan student.
SELECT p.nazPred FROM pred p LEFT JOIN ispit i ON p.sifPred = i.sifPred WHERE i.sifPred IS NULL

--6. Ispiši oznake dvorana i nazive kolegija za one kolegije koji imaju više od 2 sata predavanja tjedno.
SELECT DISTINCT r.oznDvorana, p.nazPred FROM rezervacija r JOIN pred p on r.sifPred = p.sifPred WHERE p.brojSatiTjedno > 2

--7. Ispiši nazive predmeta i organizacijske jedinice kojima pripadaju za one kolegije koji imaju više od 20 upisanih studenata.
SELECT p.nazPred, oj.nazOrgJed FROM pred p JOIN orgjed oj ON p.sifOrgJed = oj.sifOrgJed WHERE p.upisanoStud >20

--8. Ispiši sve nazive mjesta u kojima barem jedan student stanuje. Imena mjesta smiju se pojavi􀆟 samo jednom.
SELECT DISTINCT m.nazMjesto FROM mjesto m JOIN stud s ON m.pbr = s.pbrStan

--9. Ispiši ime i prezime studenta, te naziv i ocjenu za svaki ispit.
SELECT s.imeStud, s.prezStud, p.nazPred, i.ocjena FROM ispit i JOIN stud s ON i.mbrStud = s.mbrStud 
JOIN pred p ON i.sifPred = p.sifPred

--10. Ispiši nazive kolegija i oznake dvorana u kojima imaju rezerviran termin. Ispišite i naziv organizacijske jedinice kojoj kolegij
--pripada.
SELECT p.nazPred, r.oznDvorana, o.nazOrgJed FROM rezervacija r JOIN pred p ON r.sifPred = p.sifPred JOIN orgjed o ON p.sifOrgJed = o.sifOrgJed

--11. Ispiši podatke o studen􀆟ma i njihovim mjes􀆟ma stanovanja za one studente koji su barem jednom pali na ispitu „Osnove
--baze podataka”.
SELECT s.*, m.nazMjesto FROM stud s JOIN mjesto m ON s.pbrStan = m.pbr JOIN ispit i ON i.mbrStud = s.mbrStud
JOIN pred p ON p.sifPred = i.sifPred WHERE p.nazPred LIKE '%BAZE%' AND i.ocjena = 1

--12. Ispiši ime i prezime nastavnika, mjesto stanovanja i županiju nastavnika te naziv kolegija za nastavnike koji su ispi􀆟vali
--studente koji su dobili ocjenu 2 ili 3 iz tog kolegija.
SELECT DISTINCT n.imeNastavnik, n.prezNastavnik, m.nazMjesto, z.nazZupanija, p.nazPred FROM ispit i
JOIN nastavnik n ON i.sifNastavnik = n.sifNastavnik
JOIN pred p ON i.sifPred = p.sifPred
JOIN mjesto m ON n.pbrStan = m.pbr
JOIN zupanija z ON m.sifZupanija = z.sifZupanija
WHERE i.ocjena = 2 OR i.ocjena = 3


--13. Ispiši ime i prezime studenta, te mjesto i županiju u kojoj su rođeni. Nakon toga dodaj mjesto i županiju u kojoj stanuju.
SELECT s.imeStud,
       s.prezStud,
       m1.nazMjesto AS mjestoRodjenja,
       z1.nazZupanija AS zupanijaRodjenja,
       m2.nazMjesto AS mjestoStanovanja,
       z2.nazZupanija AS zupanijaStanovanja
FROM stud s
JOIN mjesto m1 ON s.pbrRod = m1.pbr
JOIN zupanija z1 ON m1.sifZupanija = z1.sifZupanija
JOIN mjesto m2 ON s.pbrStan = m2.pbr
JOIN zupanija z2 ON m2.sifZupanija = z2.sifZupanija;

--14. Ispiši nazive mjesta u kojima je barem jedan student i rođen i stanuje. Imena mjesta smiju se pojavi􀆟 samo jednom.
SELECT DISTINCT m.nazMjesto FROM stud s JOIN mjesto m ON s.pbrRod = m.pbr
WHERE s.pbrRod = s.pbrStan


--15. Ispiši podatke o nastavnicima koji su ispi􀆟vali studente koji stanuju u istoj županiji u kojoj stanuje i nastavnik.
SELECT DISTINCT n.imeNastavnik, n.prezNastavnik FROM ispit i
JOIN nastavnik n ON i.sifNastavnik = n.sifNastavnik
JOIN stud s ON i.mbrStud = s.mbrStud
JOIN mjesto mS ON s.pbrRod = mS.pbr
JOIN mjesto mN on n.pbrStan = mN.pbr
WHERE mS.sifZupanija = mN.sifZupanija

--16. Ispiši podatke o studen􀆟ma koji studiraju u mjestu različitom od mjesta rođenja, ali koje se nalazi u istoj županiji u kojoj
--su i rođeni.

SELECT s.*
FROM stud s
JOIN mjesto mRod ON s.pbrRod = mRod.pbr
JOIN zupanija zRod ON mRod.sifZupanija = zRod.sifZupanija
JOIN mjesto mStan ON s.pbrStan = mStan.pbr
JOIN zupanija zStan ON mStan.sifZupanija = zStan.sifZupanija
WHERE s.pbrRod <> s.pbrStan
AND zRod.sifZupanija = zStan.sifZupanija
  

--17. Ispiši podatke o studen􀆟ma i nastavnicima koji imaju ista prezimena.
SELECT   
    n.imeNastavnik AS imenastavnika,
    n.prezNastavnik AS prezimenastavnika,
    s.imeStud AS imestudenta,
    s.prezStud AS prezimestudenta
FROM nastavnik n
JOIN Stud s ON n.prezNastavnik = s.prezStud;

--FUNKCIJE
--1. Ispiši ime i prezime te mjesto rođenja studenata kojima ime počinje slovom F.
SELECT 
    s.imeStud,
    s.prezStud,
    m.nazMjesto AS mjesto_rodjenja
FROM Stud s
JOIN Mjesto m ON s.pbrRod = m.pbr
WHERE s.imeStud LIKE 'F%';

--2. Ispiši ime i prezime nastavnika koji živi u mjestu koje na trećem mjestu naziva ima slovo Z.
SELECT imeNastavnik, prezNastavnik FROM nastavnik n JOIN Mjesto m ON n.pbrStan = m.pbr
WHERE SUBSTRING(nazMjesto, 3, 1) = 'Z'

--3. Ispiši ime i prezime studenata te imena i prezimena nastavnika koji u imenu na petom mjestu imaju isto slovo.
SELECT s.imeStud, s.prezStud, n.imeNastavnik, n.prezNastavnik FROM Stud s JOIN ispit i ON s.mbrStud = i.mbrStud JOIN nastavnik n ON i.sifNastavnik = n.sifNastavnik
WHERE SUBSTRING(imeStud, 5, 1) = SUBSTRING(imeNastavnik, 5,1)

--4. Ispiši nazive županija kojima je duljina imena duža od 13 znakova, a kraća od 20 znakova.
SELECT nazZupanija FROM zupanija WHERE LEN(nazZupanija) > 13 AND LEN(nazZupanija) < 20

--5. Ispiši ime i prezime studenata koji su rođeni u svibnju. MONTH()
SELECT imeStud, prezStud
FROM stud
WHERE MONTH(datRodStud) = 5

--6. Ispiši imena i prezimena studenata koji su na ispit izašli između 10. i 20. u mjesecu. DAY()
SELECT s.imeStud, s.PrezStud FROM ispit i JOIN stud s ON i.mbrStud = s.mbrStud
WHERE DAY(I.datIspit) BETWEEN 10 AND 20

--7. Pronađi podatke o onim nastavnicima koji su u lipnju ispi􀆟vali studente čije je mjesto rođenja isto mjestu nastavnikova
--stanovanja. Ispiši ime i prezime nastavnika, naziv mjesta u kojem stanuje, ime i prezime studenta te naziv mjesta u kojem
--je student rođen.
SELECT n.imeNastavnik, n.prezNastavnik, mn.nazMjesto, s.imeStud, s.prezStud, ms.nazMjesto FROM nastavnik n JOIN ispit i ON i.sifNastavnik = n.sifNastavnik JOIN Mjesto mn ON mn.pbr = n.pbrStan
JOIN Stud s ON s.mbrStud = i.mbrStud JOIN Mjesto ms ON ms.pbr = s.pbrRod WHERE MONTH(i.datIspit) = 6 AND ms.nazMjesto = mn.nazMjesto



