# 🏝️ WhiteLagoon – Kompleksowy System Rezerwacji Willi Wypoczynkowych

Kompleksowa aplikacja webowa do zarządzania ośrodkiem wypoczynkowym oraz rezerwacją willi online, zbudowana w oparciu o wzorzec **Clean Architecture** oraz **ASP.NET Core MVC**. System automatyzuje proces sprawdzania dostępności obiektów, obsługę płatności internetowych oraz generowanie raportów i dokumentów dla administracji. Projekt został zrealizowany z zachowaniem zaawansowanych praktyk inżynierii oprogramowania oraz separacji warstw w ekosystemie .NET.

## 👤 Autor
- Szymon Masalski *(projekt zrealizowany w ramach zaawansowanego studium architektury .NET na bazie szkolenia Bhrugena Patela)*

## 🎯 Zrealizowane Funkcjonalności
Aplikacja posiada wdrożone następujące elementy biznesowe i techniczne:
- **Modele i ORM (Entity Framework Core):** Aplikacja opiera się na relacyjnym modelu danych (m.in. `Villa`, `VillaNumber`, `Amenity`, `Booking`, `ApplicationUser`) zarządzanym w podejściu Code-First. Wdrożono relacje bazodanowe, migracje oraz automatyczną inicjalizację danych startowych (`DbInitializer` / Data Seeding).
- **Operacje CRUD i Zarządzanie Obiektami:** Rozbudowane widoki pozwalające na tworzenie, odczyt, aktualizację i usuwanie willi, przypisywanie im konkretnych numerów pokoi oraz udogodnień (Amenities), a także zarządzanie plikami graficznymi obiektów.
- **Autoryzacja i Role (ASP.NET Core Identity):** Zaimplementowano bezpieczny moduł uwierzytelniania i autoryzacji z podziałem na role:
  - **Niezalogowany:** Przegląd oferty willi, sprawdzanie dostępności w wybranych terminach oraz podgląd szczegółów i udogodnień.
  - **Klient (Customer):** Możliwość rezerwacji willi, opłacenia pobytu online (Stripe), podgląd historii własnych rezerwacji oraz pobieranie potwierdzeń.
  - **Administrator (Admin):** Pełny dostęp do panelu analitycznego (Dashboard), zarządzanie zasobami ośrodka oraz zmiana statusów rezerwacji (m.in. *Approved*, *CheckedIn*, *Completed*, *Cancelled*).
- **Integracja z Zewnętrznym API (Stripe):** Automatyczna obsługa płatności za rezerwacje z wykorzystaniem bezpiecznej bramki płatniczej **Stripe API** (tworzenie sesji zakupowych Checkout, weryfikacja statusu płatności oraz automatyczna obsługa zwrotów przy anulowaniu rezerwacji).
- **Analityczny Panel Administratora i Raporty:** Dedykowany Dashboard wizualizujący kluczowe wskaźniki (przychody, liczba rezerwacji, przyrost klientów) na dynamicznych wykresach kołowych i liniowych (**ApexCharts**) oraz moduł automatycznego generowania faktur i podsumowań rezerwacji do plików **PDF oraz DOCX** (**Syncfusion**).
- **Interfejs Użytkownika:** Estetyczny, nowoczesny wygląd z użyciem ciemnego motywu, dostosowany do urządzeń mobilnych dzięki **Bootstrap 5**, wzbogacony o dynamiczne tabele (**DataTables**) oraz interaktywne powiadomienia (**Toastr**, **SweetAlert2**).

## 🛡️ Architektura i Bezpieczeństwo Danych
- **Architektura Warstwowa (Clean Architecture):** Projekt został fizycznie podzielony na 4 niezależne projekty (`Domain`, `Application`, `Infrastructure`, `Web`), co zapewnia pełną separację logiki biznesowej od warstwy prezentacji oraz bazy danych.
- **Wzorzec Repozytorium i Unit of Work:** Dostęp do bazy danych został odseparowany od kontrolerów poprzez generyczne interfejsy repozytoriów (`IRepository<T>`) oraz wzorzec **Unit of Work**, co gwarantuje spójność transakcyjną operacji zapisu i ułatwia testowanie aplikacji.
- **Walidacja i Spójność Rezerwacji:** System po stronie serwera weryfikuje nakładanie się terminów rezerwacji oraz dynamicznie przelicza dostępność wolnych numerów willi w wybranym przedziale dat, chroniąc przed zjawiskiem *overbookingu*.
- **Zarządzanie Sekretami i Bezpieczeństwo Formularzy:** Klucze API (Stripe, Syncfusion) oraz ciągi połączeniowe (Connection Strings) są odseparowane od kodu źródłowego, a wszystkie akcje modyfikujące dane są zabezpieczone przed atakami CSRF (walidacja tokenów `ValidateAntiForgeryToken`).

## 💻 Technologie
- **Backend:** C#, .NET 8, ASP.NET Core MVC, Entity Framework Core, ASP.NET Core Identity
- **Architektura:** Clean Architecture (Onion), Repository Pattern, Unit of Work, Dependency Injection
- **Baza Danych:** Microsoft SQL Server
- **Frontend:** HTML5, CSS3, Widoki Razor, Bootstrap 5, JavaScript / jQuery, ApexCharts, DataTables
- **Zewnętrzne Integracje:** Stripe API (płatności), Syncfusion (generowanie PDF/Word)
