
CREATE TABLE `cliente` (
  `correo` VARCHAR(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `edad` INT (3) NOT NULL
);
ALTER TABLE `cliente`
	ADD PRIMARY KEY (`correo`);
CREATE TABLE `casaApuestas` (
  `correo` VARCHAR(50) NOT NULL,
  `SaldoActual` double(50) NOT NULL,
  `NombreBanco` VARCHAR(50) NOT NULL,
  `NumTarjeta` INT (10) NOT NULL
);
ALTER TABLE `casaApuesta`
  ADD CONSTRAINT `FK_correos` FOREIGN KEY (`correo`) REFERENCES `cliente` (`correo`);

CREATE TABLE `evento`(
	`NombreLocal` VARCHAR(50) NOT NULL,
	`NombreVis` VARCHAR(50) NOT NULL,
	`Fecha` DATETIME NOT NULL,
	`idEvent` INT(9) NOT NULL
);
ALTER TABLE `evento`
	ADD PRIMARY KEY (`idEvent`);
CREATE TABLE `Mercado`(
	`OverU1` DOUBLE(20) NOT NULL,
	`OverU2` DOUBLE(20) NOT NULL,
	`OverU3` DOUBLE(20) NOT NULL,
	`idMerc` INT(9) NOT NULL
);
ALTER TABLE `evento`
  ADD CONSTRAINT `FK_merc` FOREIGN KEY (`idMerc`) REFERENCES `evento` (`idEvent`);
CREATE TABLE `Cuota`(
	CuotaO DOUBLE(20) NOT NULL,
	CuotaU DOUBLE(20) NOT NULL
);	
CREATE TABLE `Dinero`(
	DineroO DOUBLE(20) NOT NULL,
	DineroU DOUBLE(20) NOT NULL
);	
	
  