CREATE DATABASE Control_Finanzas;
use Control_Finanzas;
CREATE TABLE Usuario (
No_Usuario INT NOT NULL AUTO_INCREMENT,
Correo VARCHAR (70),
Contraseña VARCHAR (25),
Balance DOUBLE,
Nombres VARCHAR (150),
Apellidos VARCHAR (150),
Direccion VARCHAR (150),
Telefono VARCHAR (15),
PRIMARY KEY (No_Usuario));

CREATE TABLE Registro_Trans (
ID_Mov INT NOT NULL AUTO_INCREMENT,
No_Cuenta_Emi INT,
Banco VARCHAR (25),
Monto DOUBLE,
No_Cuenta_Rec INT,
Fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY (ID_Mov),
FOREIGN KEY (No_Cuenta_Emi) REFERENCES Usuario (No_Usuario),
FOREIGN KEY (No_Cuenta_Rec) REFERENCES Usuario (No_Usuario));

CREATE TABLE Registro_PagoSrv (
ID_Mov INT NOT NULL AUTO_INCREMENT,
No_Cuenta INT,
Categoria VARCHAR (60),
Servicio VARCHAR (25),
Concepto VARCHAR (500),
Monto DOUBLE,
Fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY (ID_Mov),
FOREIGN KEY (No_Cuenta) REFERENCES Usuario (No_Usuario));

CREATE TABLE Guardadito (
    ID_Guardadito INT NOT NULL AUTO_INCREMENT,
    No_Usuario INT NOT NULL,
    Monto DOUBLE NOT NULL,
    Fecha_Inicio TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Fecha_Fin TIMESTAMP NOT NULL,
    PRIMARY KEY (ID_Guardadito),
    FOREIGN KEY (No_Usuario) REFERENCES Usuario (No_Usuario)
);

CREATE TABLE UsuarioSesion (
    ID_Sesion INT AUTO_INCREMENT PRIMARY KEY,
    No_Usuario INT NOT NULL,
    FOREIGN KEY (No_Usuario) REFERENCES Usuario(No_Usuario)
);

ALTER TABLE UsuarioSesion ADD COLUMN Nombre VARCHAR(150);

select * from UsuarioSesion;?
select * from Guardadito;
SELECT * FROM Usuario;
SELECT * FROM V_Mov_Trans;
SELECT * FROM V_Mov_PagoSrv;
SELECT * FROM Registro_Trans;
 
CREATE VIEW V_Mov_Trans AS
SELECT Registro_Trans.ID_Mov, Registro_Trans.No_Cuenta_Emi AS Emisor, Registro_Trans.Banco, Registro_Trans.Monto, Registro_Trans.No_Cuenta_Rec AS Receptor, Registro_Trans.Fecha, Usuario.Balance FROM Registro_Trans 
INNER JOIN Usuario ON Usuario.No_Usuario = Registro_Trans.No_Cuenta_Emi AND Registro_Trans.No_Cuenta_Rec;

CREATE VIEW V_Mov_PagoSrv AS
SELECT Registro_PagoSrv.ID_Mov, Registro_PagoSrv.No_Cuenta, Registro_PagoSrv.Categoria, Registro_PagoSrv.Servicio, Registro_PagoSrv.Concepto, Registro_PagoSrv.Monto, Registro_PagoSrv.Fecha, Usuario.Balance FROM Registro_PagoSrv
INNER JOIN Usuario ON Usuario.No_Usuario = Registro_PagoSrv.No_Cuenta;

INSERT INTO Usuario (Correo, Contraseña, Balance, Nombres, Apellidos, Direccion, Telefono)
VALUES ("angelhdzflores772.AH@gmail.com", "Angel123456", 47567.89, "Angel Gabriel", "Hernandez Flores", "Paseo de los Brezos 711A", "3311089404");

INSERT INTO Usuario (Correo, Contraseña, Balance, Nombres, Apellidos, Direccion, Telefono)
VALUES ("krassianfl772@hotmail.com", "Krass123456", 22890.89, "Krassian", "Flores", "Paseo de los Ahuehuetes 905", "3334856778");

INSERT INTO Usuario (Correo, Contraseña, Balance, Nombres, Apellidos, Direccion, Telefono)
VALUES ("afat3646@gmail.com", "Angel1234", 22890.89, "Angel Alvarado", "Flores", "De los chopos 2200", "3341855966");



DROP TABLE IF EXISTS Usuario;
DROP VIEW IF EXISTS V_Mov_Trans;																								
DROP VIEW IF EXISTS V_Mov_PagoSrv;
DROP TABLE IF EXISTS Registro_Trans;
DROP TABLE IF EXISTS Registro_PagoSrv;

ALTER TABLE Movimientos ADD COLUMN No_Usuario INT NOT NULL;
ALTER TABLE Movimientos ADD COLUMN Balance_Usuario DOUBLE;



ALTER TABLE Movimientos ADD FOREIGN KEY (No_Usuario) REFERENCES Usuario (No_Usuario);
ALTER TABLE Movimientos ADD CONSTRAINT FK_Balance FOREIGN KEY (Balance_Usuario) REFERENCES Usuario (Balance);

COMMIT;