-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 19 nov. 2018 à 09:26
-- Version du serveur :  5.7.19
-- Version de PHP :  7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `pimpmyunicorn`
--

-- --------------------------------------------------------

--
-- Structure de la table `t_elements`
--

DROP TABLE IF EXISTS `t_elements`;
CREATE TABLE IF NOT EXISTS `t_elements` (
  `Id_element` int(11) NOT NULL AUTO_INCREMENT,
  `type_id` int(11) NOT NULL,
  `partie_id` int(11) NOT NULL,
  `elementsImg` text NOT NULL,
  PRIMARY KEY (`Id_element`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `t_parties`
--

DROP TABLE IF EXISTS `t_parties`;
CREATE TABLE IF NOT EXISTS `t_parties` (
  `Id_partie` int(11) NOT NULL AUTO_INCREMENT,
  `partieLibelle` varchar(255) NOT NULL,
  PRIMARY KEY (`Id_partie`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `t_parties`
--

INSERT INTO `t_parties` (`Id_partie`, `partieLibelle`) VALUES
(1, 'Corne'),
(2, 'Queue'),
(3, 'Sabot'),
(4, 'Criniere'),
(5, 'Robe');

-- --------------------------------------------------------

--
-- Structure de la table `t_types`
--

DROP TABLE IF EXISTS `t_types`;
CREATE TABLE IF NOT EXISTS `t_types` (
  `Id_type` int(11) NOT NULL AUTO_INCREMENT,
  `typeLibelles` varchar(255) NOT NULL,
  PRIMARY KEY (`Id_type`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `t_types`
--

INSERT INTO `t_types` (`Id_type`, `typeLibelles`) VALUES
(1, 'Arc_En_Ciel'),
(2, 'Bleu_Paillette'),
(3, 'Noir_Paillette'),
(4, 'Blanc_Paillette');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
