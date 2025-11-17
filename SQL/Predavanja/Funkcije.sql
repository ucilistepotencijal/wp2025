-- 1. ABS - vraća pozitivnu vrijednost cijelog broja
SELECT ABS(-100) AS 'Pozitivna vrijednost'
SELECT ABS(1)
SELECT ABS(0)

-- 2. CEILING - zaokružuje decimalni broj na prvi veći cijeli broj
SELECT CEILING(14.1)
SELECT CEILING(14.5)

-- 3. FLOOR - zaokružuje decimalni broj na prvi manji cijeli broj
SELECT FLOOR(14.8)
SELECT FLOOR(14.1)

-- 4. POWER  - vraća broj na neku potenciju
SELECT POWER(3,4)

-- 5. RAND - vraća random broj u intervalu od 0 do 1
SELECT RAND()

-- 6. ROUND - zaokružuje decimalni broj na određeni broj decimala
SELECT ROUND(15.652, 2)

-- kombinacija - dvoznamenkasti random broj
SELECT ROUND(RAND(), 2) * 100

-- 7. SQUARE() - vraća kvadrat nekog broja
SELECT SQUARE(12)
SELECT SQUARE(12.12)

-- 8. SQRT() - vraća drugi korijen zadanog broja
SELECT SQRT(25)
SELECT SQRT(25.25)
SELECT SQRT(-25) -- ne radi jer pod korijenom mora biti broj >= 0
