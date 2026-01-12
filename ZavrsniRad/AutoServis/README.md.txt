# Auto Servis Lak - Sustav za upravljanje servisom

Ovo je web aplikacija izrađena u **ASP.NET Core MVC** okviru, dizajnirana za potrebe automehaničarske radnje. Fokus projekta bio je na modernom korisničkom iskustvu (UX) i backend logici.

## 🛠️ Što je implementirano u sklopu vježbi:

### 1. Vizualni Identitet i UI (Custom CSS)
* **Industrijski dizajn:** Implementirana je paleta boja prikladna za radnu okolinu (čelično plava, industrijska narančasta i tamno crvena).
* **Glassmorphism efekt:** Navigacijska traka i glavni kontejneri koriste prozirnost sa zamućenjem pozadine (`backdrop-filter: blur`).
* **Interaktivnost:** Dodane su mikro-interakcije na gumbima (povećanje i sjaj) te animacije postepenog pojavljivanja elemenata (`fade-in-up`) prilikom učitavanja stranice.

### 2. Funkcionalna C# Logika (Razor)
* **Dinamičko radno vrijeme:** Implementirana je serverska logika u `_Layout.cshtml` koja u stvarnom vremenu provjerava trenutni sat na serveru.
    * Ako je između 08:00 i 16:00, aplikacija prikazuje zeleni indikator **● DOSTUPNI SMO**.
    * Izvan tog vremena, automatski se prebacuje na crveni indikator **○ TRENUTNO ZATVORENO**.
* **Personalizirani kontakt:** Dodan je "Smart Contact" u zaglavlju koji omogućuje direktan poziv klikom na broj (`tel:` protokol).
* **Čišćenje sučelja:** Uklonjene su administrativne opcije za obične korisnike kako bi se osigurao čist i fokusiran pregled za klijenta.

### 3. Struktura stranice
* **Layout optimizacija:** Fiksirana navigacijska traka (`fixed-top`) koja osigurava laku navigaciju kroz Vozila, Termine i Usluge bez obzira na skrolanje.
* **Responzivnost:** Sučelje je prilagođeno za rad na mobilnim uređajima i računalima bez preklapanja elemenata.

## 🚀 Tehnologije
* **Backend:** C# / .NET Core MVC
* **Frontend:** Razor Pages, CSS3, Bootstrap 5
* **Alati:** Visual Studio, Git

## 📋 Upute za pokretanje
1. Klonirajte repozitorij.
2. Osigurajte da je slika pozadine dostupna na putanji `/wwwroot/images/33.jpg`.
3. Pokrenite projekt unutar Visual Studia pritiskom na `F5`.