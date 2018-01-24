
-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `username` varchar(40) NOT NULL,
  `email` varchar(40) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `users`
--

INSERT INTO `users` (`id`, `username`, `email`, `password`) VALUES
(1, 'Just Test', 'test email', '123456'),
(4, 'Billy', 'Boob', 'Bob'),
(5, 'Hannah', 'Boob', 'Henneh'),
(6, '', '', ''),
(7, 'Billy', 'Boob', 'Bob'),
(8, 'Billy', 'Boob', 'Bob'),
(9, 'Jimmy', '', 'Jones'),
(10, 'Jimmy', '', 'Jones'),
(11, 'Dickshit', '', 'Balls');
