create database melodias
go
use melodias
go

create table rol(
IdRol int identity primary key,
nombre varchar(25)
)

if object_id('usuario') is not null DROP TABLE visita;
go

drop table usuario;
drop table venta;
drop table rol;
drop table detalleVenta;

create table usuario(
CUIT int primary key,
nomYApe varchar(50),
nroContacto varchar (15),
correoElectronico varchar(40) unique,
nombreUsuario varchar (30),
IdRol int,
Constraint FK_rol FOREIGN KEY (IdRol)  REFERENCES rol(IdRol)			

IdMarca int identity primary key,

idMarca int,
Constraint FK_marca FOREIGN KEY (idMarca)  REFERENCES marca(idMarca),					 					     					     					     				     					     

)

select * from usuario;

create table categoria(
IdCategoria int identity primary key,
nombre varchar(25)
)

create table marca(
IdMarca int identity primary key,
nombre varchar(25)
)

create table color(
IdColor int identity primary key,
nombre varchar(25)
)

create table proveedor(
idProveedor int identity primary key,
nombre varchar(25),
correoElectronico varchar(40),
nroContacto varchar (15),
direccion varchar (30),
descripcion varchar (100),
)

create table producto (
idProducto int identity primary key,
idProveedor int,
nombre varchar (30),
idCategoria int,
idMarca int,
idColor int,
cantidad int,
precioU float,
Constraint FK_proveedor FOREIGN KEY (idProveedor)  REFERENCES proveedor(idProveedor),					 					     					     					     				     					     
Constraint FK_categoria FOREIGN KEY (idCategoria)  REFERENCES categoria(idCategoria),					 					     					     					     				     					     
Constraint FK_marca FOREIGN KEY (idMarca)  REFERENCES marca(idMarca),					 					     					     					     				     					     
Constraint FK_color FOREIGN KEY (idColor)  REFERENCES color(idColor),					 					     					     					     				     					     
)

create table cliente(
DNI int primary key,
nombres varchar(25),
apellidos varchar (30),
nroContacto varchar (15),
correoElectronico varchar(40) unique
)

create table metodoPago(
IdMetodoPago int identity primary key,
nombre varchar(25),
recargo float
)

create table venta(
idVenta int identity,
idDetalleVenta int,
CUIT int,
DNI int,
montoTotal float,
fecha datetime,
idMetodoPago int,
Constraint PK_venta PRIMARY KEY (idVenta, idDetalleVenta),
Constraint FK_usuario FOREIGN KEY (CUIT)  REFERENCES usuario(CUIT),
Constraint FK_cliente FOREIGN KEY (DNI)  REFERENCES cliente(DNI),
Constraint FK_metodoPago FOREIGN KEY (idMetodoPago)  REFERENCES metodoPago(idMetodoPago)
)

create table detalleVenta(
idDetalleVenta int identity,
idVenta int,
idProducto int,
Constraint PK_detalleVenta PRIMARY KEY (idDetalleVenta, idVenta),
Constraint FK_producto FOREIGN KEY (idProducto)  REFERENCES producto(idProducto),					 					     					     					     				     					     
)

-------

insert into cliente values
('47247716','Maurizio Giovanni','Pasian Cominotti','3794098200','mauripasian@gmail.com'),
('42369852','Miguel','Zambrano Garcia','3794251436','miguel123@gmail.com'),
('40123456','Claudia','Romero Alvarado','3794147858','clau_romero@gmail.com')

select * from cliente

insert into rol values
('Administrador'),
('Supervisor'),
('Vendedor')

select * from rol
