-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 02 nov 2022 om 17:02
-- Serverversie: 10.4.22-MariaDB
-- PHP-versie: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `uitbereidingquiz`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `andwoord`
--

CREATE TABLE `andwoord` (
  `id` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `vraagId` int(20) NOT NULL,
  `tijd` int(20) DEFAULT NULL,
  `strafTijd` int(20) DEFAULT NULL,
  `IsGoedBeandwoord` int(2) DEFAULT NULL,
  `datum` datetime DEFAULT NULL,
  `custom` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tabelstructuur voor tabel `andwoordvs`
--

CREATE TABLE `andwoordvs` (
  `id` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `vraagId` int(20) NOT NULL,
  `IsGoedBeandwoord` int(2) DEFAULT NULL,
  `datum` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


--
-- Tabelstructuur voor tabel `speler`
--

CREATE TABLE `speler` (
  `id` int(50) NOT NULL,
  `naam` varchar(100) DEFAULT NULL,
  `QuizIsCustom` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


--
-- Tabelstructuur voor tabel `vragen`
--

CREATE TABLE `vragen` (
  `id` int(50) NOT NULL,
  `Vraag` varchar(250) NOT NULL,
  `GoedAntwoord` varchar(250) NOT NULL,
  `FoutAntwoord` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `vragen`
--

INSERT INTO `vragen` (`id`, `Vraag`, `GoedAntwoord`, `FoutAntwoord`) VALUES
(1, 'Wat is Microsoft Word?', 'Applicatie software', 'Operating software'),
(2, 'Wat is een IP adres?', 'Een uniek adres van elk apparaat dat met internet verbonden is.', 'Het unieke serienummer van je netwerkhardware.'),
(3, 'Wat is een webserver?', 'Een computer die webpaginas beschikbaar stelt.', 'Een instantie die webadressen beheert.'),
(4, 'Wat betekent HTML?', 'Hyper Text Markup Language', 'Hyper Tool Media Language'),
(5, 'Wat betekent CSS?', 'Cascading Style Sheets', 'Correlating Super Script'),
(6, 'Welk computermerk komt uit China?', 'Lenovo', 'Dell'),
(7, 'Wat kun je met FTP?', 'Bestanden uploaden en downloaden', 'E-mail versturen'),
(8, 'Wat is SEO?', 'Websites optimaliseren voor zoekmachines.', 'Senior Executive Officer = directeur van een bedrijf.'),
(9, 'Welk opslagmedium noemt men intern geheugen?', 'RAM/Werkgeheugen', 'Harde schijf'),
(10, 'Wat is GEEN besturingssysteem?', 'Microsoft Office', 'Ubuntu Linux'),
(11, 'Wat betekent de afkorting CPU?', 'Central Processing Unit', 'Central Processor Unit'),
(12, 'Wat is een invoerapparaat?', 'Een muis', 'Een beeldscherm'),
(13, 'Hoeveel woog de allereerste laptop?', '10,7 kilo', '2,5 kilo'),
(14, 'Hoe noem je het apparaat dat beeld projecteerd op het digiboard', 'Projector', 'Digischijner'),
(15, 'Hoe heet de rijkste baas van een computerbedrijf?', 'Bill Gates', 'Steve Gates'),
(16, 'Welk merk maakt geen computers?', 'Samsung', 'Nokia'),
(17, 'Wat is de sterkste spier in je lichaam o.b.v. kracht per oppervlakte?', 'Kauwspier', 'Hartspier'),
(18, 'Wat is schadelijke software?', 'Virus', 'Hoax'),
(19, 'Waar staat PHP voor?', 'Hypertext Preprocessor', 'Public Hypertext Preprocessor'),
(20, 'Welke super coole mensen hebben deze app gemaakt?', 'Jesper, Tobias en Maarten', 'De docenten'),
(25, 'Hoelang is een chinees', 'HAHA', '169cm'),
(26, 'Hoe heet de president van Rusland', 'Vladimir Putin', 'Obama');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `andwoord`
--
ALTER TABLE `andwoord`
  ADD PRIMARY KEY (`id`),
  ADD KEY `users_scores` (`userId`) USING BTREE,
  ADD KEY `vraag-id` (`vraagId`) USING BTREE;

--
-- Indexen voor tabel `andwoordvs`
--
ALTER TABLE `andwoordvs`
  ADD PRIMARY KEY (`id`),
  ADD KEY `users_scores` (`userId`) USING BTREE,
  ADD KEY `vraag-id` (`vraagId`) USING BTREE;

--
-- Indexen voor tabel `speler`
--
ALTER TABLE `speler`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `vragen`
--
ALTER TABLE `vragen`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `andwoord`
--
ALTER TABLE `andwoord`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- AUTO_INCREMENT voor een tabel `andwoordvs`
--
ALTER TABLE `andwoordvs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- AUTO_INCREMENT voor een tabel `speler`
--
ALTER TABLE `speler`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- AUTO_INCREMENT voor een tabel `vragen`
--
ALTER TABLE `vragen`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `andwoord`
--
ALTER TABLE `andwoord`
  ADD CONSTRAINT `andwoord_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `speler` (`id`),
  ADD CONSTRAINT `andwoord_ibfk_2` FOREIGN KEY (`vraagId`) REFERENCES `vragen` (`id`);

--
-- Beperkingen voor tabel `andwoordvs`
--
ALTER TABLE `andwoordvs`
  ADD CONSTRAINT `andwoordvs_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `speler` (`id`),
  ADD CONSTRAINT `andwoordvs_ibfk_2` FOREIGN KEY (`vraagId`) REFERENCES `vragen` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
