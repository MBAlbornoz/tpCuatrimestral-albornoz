USE master
DROP DATABASE TP_CUATRIMESTRAL
GO
CREATE DATABASE TP_CUATRIMESTRAL
GO
use TP_CUATRIMESTRAL
GO
CREATE TABLE Personas
(
	id int not null primary key identity(1,1),
	dni_cuit int not null unique,
	nombre varchar(50) not null,
	apellido varchar(50),
	tipo varchar(50) not null --Puede ser Vendedor, Supervisor, Administrador, Proveedor
)
GO
CREATE TABLE Telefonos
(
	idPersona int not null foreign key references Personas(id),
	id int not null unique identity(1,1),
	tipo varchar(30) not null,
	numero int not null unique,
	primary key(idPersona,tipo)
)
GO
CREATE TABLE Emails
(
	idPersona int not null primary key foreign key references Personas(ID),
	email varchar(100) null unique
)
CREATE TABLE Paises
(
	id int not null primary key identity(1,1),
	nombre varchar(50) not null  unique,
)
GO
CREATE TABLE Provincias
(
	id int not null primary key identity(1,1),
	idPais int null foreign key references Paises(id),
	nombre varchar(100) not null unique
)
CREATE TABLE Ciudades
(
	id int not null primary key identity(1,1),
	idProvincia int null foreign key references Provincias(id),
	nombre varchar(50) not null
)
GO
CREATE TABLE Direcciones(

	direccion varchar(100) not null,
	numero int not null,
	departamento int not null,
	idCiudad int null foreign key references Ciudades(id)
)
