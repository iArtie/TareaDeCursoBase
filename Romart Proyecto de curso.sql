Create Database Romart
go
use Romart


--Cuenta Dueño o admin
sp_addlogin 'Administrador','123456','Romart'
sp_addsrvrolemember 'Administrador','sysadmin'

use Romart

sp_adduser 'Administrador','Admon'
sp_addrolemember 'db_ddladmin','Admon'

--Cuenta comprador
sp_addlogin 'Comprador','654321','Romart'
sp_addsrvrolemember 'Lector','processadmin'

use Romart

sp_adduser 'Comprador','Comprador'
sp_addrolemember 'db_denydatawriter','Comprador'
sp_addrolemember 'db_datareader','Comprador'

--Cuenta Empleado

sp_addlogin 'Empleado','Empleado123','Romart'
sp_addsrvrolemember 'Empleado','processadmin'

use Romart

sp_adduser 'Empleado','Empleado'
sp_addrolemember 'db_datawriter','Empleado'
sp_addrolemember 'db_datareader','Empleado'

Create table Dptos(
Id_Depto int identity(1,1) primary key not null,
NombreDepto nvarchar(35) not null
)

Create table Municipios(
Id_Mun int identity(1,1) primary key not null,
NombreMun nvarchar(50) not null,
Id_Depto int foreign key references Dptos(Id_Depto) not null
)

Create table Clientes(
Id_Cliente char(4) primary key not null,
PNC nvarchar(15) not null,
SNC nvarchar(15),
PAC nvarchar(15) not null,
SAC nvarchar(15),
DirC nvarchar(70) not null,
TelC char(8) check(TelC like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Id_Mun int foreign key references Municipios(Id_Mun) not null,
EstadoC bit default 1 not null
)

create table Empleados(
Id_Empleado char(4) primary key not null,
PNE nvarchar(15) not null,
SNE nvarchar(15),
PAE nvarchar(15) not null,
SAE nvarchar(15),
DirE nvarchar(70) not null,
TelE char(8) check(TelE like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Id_Mun int foreign key references Municipios(Id_Mun) not null,
EstadoE bit default 1 not null
)

create table Proveedor(
Id_Prov char(5) primary key not null,
NombreProv nvarchar(35) not null,
DirProv nvarchar(70) not null,
TelP char(8) check(TelP like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Id_Mun int foreign key references Municipios(Id_Mun) not null,
EstadoProv bit default 1 not null
)

create table Productos(
CodProd char(5) primary key not null,
NombreProd nvarchar(40) not null,
DescProd nvarchar(50) not null,
PrecioP float not null,
ExistP int not null,
EstadoProd bit default 1 not null,
Id_Prov char(5) foreign key references Proveedor(Id_Prov) not null
)

create table Ventas(
Id_Venta int identity(1,1) primary key not null,
FechaVenta datetime default getdate() not null,
Id_Cliente char(4) foreign key references Clientes(Id_Cliente) not null,
TotalV float
)


create table Det_Ventas(
Id_Venta int foreign key references Ventas(Id_Venta) not null,
CodProd char(5) foreign key references Productos(CodProd) not null,
cantv int not null,
subtv float,
primary key(Id_Venta,CodProd)
)

create table categoria(
Id_Categoria char(4) primary key not null,
nombre nvarchar(50) not null unique,
estado bit default 1
)

create table Distribuidor(
Id_Distribuidor char(4) primary key not null,
NombreDist nvarchar(45) not null,
Id_Mun int foreign key references Municipios(Id_Mun),
TelfD char(8) check(TelfD like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
DirD nvarchar(50) not null,
SitioWebD nvarchar(60)
)

create table Articulos(
CodArt char(4) primary key not null,
NombreArt nvarchar(35) not null,
DescArt nvarchar(45) not null,
PrecioArt float not null,
CantArt int not null,
Id_Distribuidor char(4) foreign key references Distribuidor(Id_Distribuidor),
Id_Categoria char(4) foreign key references Categoria(Id_Categoria)
)

backup database Romart to disk = 'C:\Users\Public\Downloads\Romart.bak'








