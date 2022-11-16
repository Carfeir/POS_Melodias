create database melodias
go
use melodias
go

if object_id('rol') is not null DROP TABLE rol;
go
if object_id('usuario') is not null DROP TABLE usuario;
go
if object_id('categoria') is not null DROP TABLE categoria;
go
if object_id('marca') is not null DROP TABLE marca;
go
if object_id('color') is not null DROP TABLE color;
go
if object_id('proveedor') is not null DROP TABLE proveedor;
go
if object_id('producto') is not null DROP TABLE producto;
go
if object_id('cliente') is not null DROP TABLE cliente;
go
if object_id('metodoPago') is not null DROP TABLE metodoPago;
go
if object_id('venta') is not null DROP TABLE venta;
go
if object_id('detalleVenta') is not null DROP TABLE detalleVenta;
go

/***************** ROL *****************/
create table rol(
IdRol int identity,
nombre varchar(25),
Constraint PK_rol PRIMARY KEY (IdRol)
)

insert into rol values
('Supervisor'),
('Administrador'),
('Empleado');

select * from rol;

/***************** USUARIO *****************/
create table usuario(
idUsuario int identity,
CUIT varchar(11),
nomYApe varchar(50),
nroContacto varchar (15),
correoElectronico varchar(40),
nombreUsuario varchar (30) unique,
contraseña varchar (30),
IdRol int,
Constraint PK_usuario PRIMARY KEY (idUsuario),
Constraint FK_rol FOREIGN KEY (IdRol)  REFERENCES rol(IdRol)			 					     					     					     				     					     
)

-- 1 Supervisor, 1 Supervisor y Administrador, 1 Admin y 2 Empleados
insert into usuario values
('20472477162', 'Ignacio Perez', '3794362514', 'nachop@gmail.com', 'IgnacioEmple', 'empleignacio', 3),
('20425368942', 'Jorge Sanchez', '3794124587', 'jorgitosz@gmail.com', 'JorgeEmple', 'emplejorge', 3),
('20412547892', 'Santiago Campos', '3794652389', 'santiagocampos@gmail.com', 'SantiAdmin', 'adminsanti', 2),
('20435625312', 'Hernan Gomez', '3794147741', 'h_gomez@gmail.com', 'HernanAdmin', 'admingomez', 2),
('20435625312', 'Hernan Gomez', '3794147741', 'h_gomez@gmail.com', 'HernanSuper', 'supergomez', 1),
('20424514782', 'Miguel Martinez', '3794123123', 'mmartinez@gmail.com', 'MiguelSuper', 'supermiguel', 1);

select * from usuario;

/***************** CATEGORIA *****************/
create table categoria(
IdCategoria int identity,
nombre varchar(25),
Constraint PK_categoria PRIMARY KEY (IdCategoria)
)

insert into categoria values
('Cuerda'),
('Viento'),
('Percusion'),
('Electrico'),
('Idiofono');

select * from categoria;

/***************** MARCA *****************/
create table marca(
IdMarca int identity,
nombre varchar(25),
Constraint PK_marca PRIMARY KEY (IdMarca)
)

insert into marca values
('Alhambra'),
('Akai'),
('Casio'),
('Cort'),
('Dick'),
('Fender');

select * from marca;

/***************** COLOR *****************/
create table color(
IdColor int identity,
nombre varchar(25),
Constraint PK_color PRIMARY KEY (IdColor)
)

insert into color values
('Negro'),
('Blanco'),
('Azul'),
('Rojo'),
('Naranja'),
('Amarillo'),
('Verde');

select * from color;

/***************** PROVEEDOR *****************/
create table proveedor(
idProveedor int identity,
nombre varchar(25),
correoElectronico varchar(40),
nroContacto varchar (15),
direccion varchar (50),
descripcion varchar (100),
Constraint PK_proveedor PRIMARY KEY (idProveedor)
)

insert into proveedor values
('Todomusica SA', 'todomusica@gmail.com', '01155448000', 'Av. Warnes 2280, Buenos Aires', 'Principal proveedor de Melodias'),
('MJ Music', 'ventas@mjmusic.com.ar', '01147932400', 'Av. Santa Fé 1882, Buenos Aires', 'Principal proveedor de instrumentos de cuerdas de Melodias'),
('Import Music', 'ventas@importmusic.com.ar', '01148509170', 'Lola Mora 421, Buenos Aires', 'Principal proveedor de guitarras de Melodias');

select * from proveedor;

/***************** PRODUCTO *****************/
create table producto (
idProducto int identity,
idProveedor int,
nombre varchar (30),
idCategoria int,
idMarca int,
idColor int,
cantidad int,
precioU float,
Constraint PK_producto PRIMARY KEY (idProducto),
Constraint FK_proveedor FOREIGN KEY (idProveedor)  REFERENCES proveedor(idProveedor),					 					     					     					     				     					     
Constraint FK_categoria FOREIGN KEY (idCategoria)  REFERENCES categoria(idCategoria),					 					     					     					     				     					     
Constraint FK_marca FOREIGN KEY (idMarca)  REFERENCES marca(idMarca),					 					     					     					     				     					     
Constraint FK_color FOREIGN KEY (idColor)  REFERENCES color(idColor),					 					     					     					     				     					     
)

insert into producto values
(1, 'Teclado KC49', 4, 1, 1, 5, 65550.99),
(1, 'Tambor ssDG', 3, 4, 3, 2, 55599.99),
(2, 'Bajo BD1-CD', 4, 3, 5, 1, 68999.99),
(3, 'Guitarra KM07', 1, 2, 2, 2, 71000.99),
(1, 'Flauta Dulce ZZZ', 2, 2, 3, 0, 15000);

select * from producto;

/***************** CLIENTE *****************/
create table cliente(
idCliente int identity,
DNI varchar(8),
nomYape varchar(50),
nroContacto varchar (15),
correoElectronico varchar(40) unique,
direccion varchar (50),
Constraint PK_cliente PRIMARY KEY (idCliente)
)

insert into cliente values
('47247716','Maurizio Giovanni Pasian Cominotti','3794098200','mauripasian@gmail.com', 'Salta 1234'),
('42369852','Miguel Zambrano Garcia','3794251436','miguel123@gmail.com', 'Junin 125'),
('40123456','Claudia Romero Alvarado','3794147858','clau_romero@gmail.com', 'Belgrano 456');

select * from cliente;

/***************** METODO PAGO *****************/
create table metodoPago(
IdMetodoPago int identity,
nombre varchar(25),
Constraint PK_metodoPago PRIMARY KEY (IdMetodoPago)
)

insert into metodoPago values
('Efectivo'),
('Tarjeta');

select * from metodoPago;

/***************** Venta *****************/
create table venta(
idVenta int identity,
idDetalleVenta int,
idUsuario int,
idCliente int,
montoTotal float,
fecha DATE,
idMetodoPago int,
Constraint PK_venta PRIMARY KEY (idVenta, idDetalleVenta),
Constraint FK_usuario FOREIGN KEY (idUsuario)  REFERENCES usuario(idUsuario),
Constraint FK_cliente FOREIGN KEY (idCliente)  REFERENCES cliente(idCliente),
Constraint FK_metodoPago FOREIGN KEY (idMetodoPago)  REFERENCES metodoPago(idMetodoPago)
)

insert into venta values
(1,6,1,131101.98, '20201004', 1),
(2,6,2,55599.99, '20201108', 1),
(3,7,2, 209000.97, '20200210', 2);

select * from venta

/***************** Detalle Venta *****************/
create table detalleVenta(
idDetalleVenta int identity,
idVenta int,
idProducto int,
cantidad int,
Constraint PK_detalleVenta PRIMARY KEY (idDetalleVenta, idVenta),
Constraint FK_producto FOREIGN KEY (idProducto)  REFERENCES producto(idProducto),					 					     					     					     				     					     
)

insert into detalleVenta values
(1, 1, 2),
(2, 2, 1),
(3, 3, 1),
(3, 4, 1);

select * from detalleVenta;
