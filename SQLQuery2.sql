CREATE DATABASE autenticacion;
use autenticacion;
go
-- Crear la tabla ConfiguracionEmpresa
CREATE TABLE ConfiguracionEmpresa (
    IDEmpresa INT PRIMARY KEY IDENTITY(1,1),
    NombreEmpresa NVARCHAR(100)
);

-- Crear la tabla Usuarios con una clave for�nea que hace referencia a ConfiguracionEmpresa
CREATE TABLE Usuarios (
    IDUsuario INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario NVARCHAR(50),
    Contrase�a NVARCHAR(100),
    Habilitado BIT,
    IntentosFallidosInicioSesion INT,
    UltimaFechaInicioSesion DATETIME,
    IDEmpresa INT,  -- Agregar columna para la clave for�nea
    FOREIGN KEY (IDEmpresa) REFERENCES ConfiguracionEmpresa(IDEmpresa) -- Definir la clave for�nea
);

--Crear la tabla de elementos de menu principal*/
CREATE TABLE ElementosMenu (
    IDElementoMenu INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Orden INT DEFAULT 0
);

--Crear la tabla de elementos de submenu*/
CREATE TABLE SubElementosMenu (
    IDSubElementoMenu INT  PRIMARY KEY IDENTITY(1,1),
    IDElementoMenu INT,
    Nombre VARCHAR(100) NOT NULL,
    Orden INT DEFAULT 0,
    Accion VARCHAR(255),
    FOREIGN KEY (IDElementoMenu) REFERENCES ElementosMenu(IDElementoMenu)
);

INSERT INTO ConfiguracionEmpresa (NombreEmpresa)
VALUES 
('Cl�nica Veterinaria PetCare'),
('Hospital Animalia'),
('Veterinaria Amigos Peludos'),
('Centro de Salud Animal HappyPaws'),
('Cuidado Animal VetVida');

SELECT * FROM Usuarios;
SELECT * FROM ConfiguracionEmpresa;
SELECT * FROM SubElementosMenu;
SELECT * FROM ElementosMenu;


INSERT INTO ElementosMenu (Nombre, Orden) VALUES ('Gesti�n de Pacientes', 1);
INSERT INTO ElementosMenu (Nombre, Orden) VALUES ('Administraci�n Financiera', 2);
INSERT INTO ElementosMenu (Nombre, Orden) VALUES ('Comunicaci�n y Usuarios', 3);


INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (1, 'Registro de Pacientes', 1)
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (1, 'Historial Medico', 2)
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (1, 'Citas y Agenda', 3)
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (1, 'Imagenes y Documentos', 4)
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (1, 'Medicamentos', 5)
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (1, 'Laboratorio y Resultados', 6)


INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (2, 'Facturaci�n y Pagos', 1);
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (2, 'Inventario de Medicamentos', 2);
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (2, 'Reservas de Productos', 3);


INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (3, 'Comunicaci�n Cliente-Veterinario', 1);
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (3, 'Administraci�n de Usuarios', 2);
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (3, 'Integraci�n con Equipos M�dicos', 3);
INSERT INTO SubElementosMenu (IDElementoMenu, Nombre, Orden)
VALUES (3, 'Sistema de Alertas', 4);

