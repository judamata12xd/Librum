USE MASTER;
GO

CREATE DATABASE Biblioteca;
GO

USE Biblioteca;
GO

CREATE TABLE Roles(
    idrol INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombreRol VARCHAR(50) NOT NULL
);

CREATE TABLE Empleado(
    idEmpleado INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    documento VARCHAR(15) UNIQUE NOT NULL,
    nombre VARCHAR(60) NOT NULL,
    usuario VARCHAR(60) UNIQUE NOT NULL,
    clave VARCHAR(255) NOT NULL, 
    idrol INT FOREIGN KEY REFERENCES Roles(idrol)
);

CREATE TABLE Autores(
    idautor INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(60) NOT NULL
);

CREATE TABLE Libro(
    codlibro INT PRIMARY KEY NOT NULL, 
    nombre VARCHAR(150) NOT NULL,
    disponible INT DEFAULT 0, 
    idautor INT FOREIGN KEY REFERENCES Autores(idautor)
);

CREATE TABLE Lectores(
    idlector INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    documento VARCHAR(15) UNIQUE NOT NULL,
    nombre VARCHAR(70) NOT NULL,
    tipoLector VARCHAR(20) NOT NULL, 
    usuario VARCHAR(60) UNIQUE NOT NULL,
    clave VARCHAR(255) NOT NULL,
    idrol INT FOREIGN KEY REFERENCES Roles(idrol)
);

CREATE TABLE Prestamos(
    idPrestamo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    fechaPrestamo DATETIME NOT NULL DEFAULT GETDATE(),
    fechaDevolucionE DATETIME NOT NULL,
    fechaDevolucionR DATETIME NULL,
    estado CHAR(1) DEFAULT 'A', -- 'A' (Activo) o 'R' (Reintegrado)
    codlibro INT FOREIGN KEY REFERENCES Libro(codlibro), 
    idlector INT FOREIGN KEY REFERENCES Lectores(idlector),
    idEmpleado INT FOREIGN KEY REFERENCES Empleado(idEmpleado),
    CONSTRAINT CK_EstadoPrestamo CHECK (estado IN ('A','R'))
);

CREATE TABLE Multa(
    idmulta INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    valor DECIMAL(10,2) NOT NULL,
    estado CHAR(1) NOT NULL DEFAULT 'P', 
    idPrestamo INT FOREIGN KEY REFERENCES Prestamos(idPrestamo),
    CONSTRAINT CK_valor CHECK (valor > 0),
    CONSTRAINT CK_EstadoMulta CHECK (estado IN ('D','P')) 
); -- D: Deuda, P: Pagada

INSERT INTO Roles (nombreRol) VALUES ('Administrador'), ('Bibliotecario'), ('Estudiante'), ('Profesor');

INSERT INTO Empleado (documento, nombre, usuario, clave, idrol)
VALUES 
('100100100', 'Juan Perez ', 'admin', '12345', 1),
('200200200', 'Maria Gomez ', 'mgomez', '12345', 2);

INSERT INTO Lectores (documento, nombre, tipoLector, usuario, clave, idrol)
VALUES 
('300300300', 'Carlos Ruiz', 'Estudiante', 'cruiz', '12345', 3),
('400400400', 'Ana Torres', 'Profesor', 'atorres', '12345', 4);

INSERT INTO Autores (nombre) 
VALUES 
('J.R.R.Tolkien'), 
('Gabriel Garcia Marquez'),
('Stephen King');

INSERT INTO Libro (codlibro, nombre, disponible, idautor)
VALUES 
(101, 'El señor de los anillos', 10, 1),
(102, 'Cien años de soledad', 5, 2),
(103, 'El Resplandor', 3, 3);

INSERT INTO Prestamos (fechaPrestamo, fechaDevolucionE, estado, codlibro, idlector, idEmpleado)
VALUES (GETDATE(), DATEADD(day, 7, GETDATE()), 'A', 101, 1, 1);

INSERT INTO Prestamos (fechaPrestamo, fechaDevolucionE, fechaDevolucionR, estado, codlibro, idlector, idEmpleado)
VALUES (DATEADD(day, -15, GETDATE()), DATEADD(day, -8, GETDATE()), DATEADD(day, -9, GETDATE()), 'R', 103, 2, 2);

INSERT INTO Prestamos (fechaPrestamo, fechaDevolucionE, fechaDevolucionR,estado, codlibro, idlector, idEmpleado)
VALUES (DATEADD(day, -20, GETDATE()), DATEADD(day, -10, GETDATE()), NULL, 'A', 102, 1, 2);

INSERT INTO Multa (valor, estado, idPrestamo)
VALUES (15000.00, 'D', 3);
GO


CREATE VIEW vw_HistorialPrestamos AS
SELECT 
    L.documento AS DocumentoLector,
    L.nombre AS NombreLector,
    L.tipoLector AS TipoLector,
    Li.codlibro AS CodigoLibro,
    Li.nombre AS NombreLibro,
    P.fechaPrestamo AS FechaPrestamo,
    P.fechaDevolucionE AS FechaEsperada,
    P.estado AS EstadoPrestamo
FROM Prestamos P
INNER JOIN Lectores L ON P.idlector = L.idlector
INNER JOIN Libro Li ON P.codlibro = Li.codlibro;
GO

CREATE PROCEDURE sp_RegistrarPrestamo
    @codlibro INT,
    @idlector INT,
    @idEmpleado INT,
    @diasPrestamo INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN; 

        DECLARE @disponible INT;
        SELECT @disponible = disponible 
        FROM Libro WITH (UPDLOCK) 
        WHERE codlibro = @codlibro;

        IF @disponible IS NULL OR @disponible <= 0
        BEGIN
            ROLLBACK TRAN;
            THROW 50001, 'No hay inventario disponible para este libro.', 1; 
        END

        IF EXISTS (SELECT 1 FROM Prestamos WITH (UPDLOCK) WHERE codlibro = @codlibro AND idlector = @idlector AND estado = 'A')
        BEGIN
            ROLLBACK TRAN;
            THROW 50002, 'El lector ya tiene un ejemplar de este libro sin devolver.', 1;
        END

        INSERT INTO Prestamos (fechaPrestamo, fechaDevolucionE, estado, codlibro, idlector, idEmpleado)
        VALUES (GETDATE(), DATEADD(day, @diasPrestamo, GETDATE()), 'A', @codlibro, @idlector, @idEmpleado);

        UPDATE Libro SET disponible = disponible - 1 WHERE codlibro = @codlibro;

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 
            ROLLBACK TRAN; 
        
        THROW; 
    END CATCH
END
GO

CREATE PROCEDURE sp_ReintegrarLibro
    @idPrestamo INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;

        DECLARE @fechaEsperada DATETIME, @estado CHAR(1), @codlibro INT;
        
        SELECT @fechaEsperada = fechaDevolucionE, @estado = estado, @codlibro = codlibro 
        FROM Prestamos WITH (UPDLOCK) 
        WHERE idPrestamo = @idPrestamo;

        IF @estado = 'A'
        BEGIN
            UPDATE Prestamos 
            SET estado = 'R', fechaDevolucionR = GETDATE()
            WHERE idPrestamo = @idPrestamo;

            UPDATE Libro 
            SET disponible = disponible + 1 
            WHERE codlibro = @codlibro;

            IF (GETDATE() > @fechaEsperada)
            BEGIN
                DECLARE @diasRetraso INT = DATEDIFF(day, @fechaEsperada, GETDATE());
                IF @diasRetraso = 0 SET @diasRetraso = 1; 
                
                INSERT INTO Multa (valor, estado, idPrestamo)
                VALUES (@diasRetraso * 5000.00, 'D', @idPrestamo);
            END

            COMMIT TRAN; 
        END
        ELSE
        BEGIN
            ROLLBACK TRAN;
            THROW 50003, 'El préstamo no existe o ya fue reintegrado.', 1;
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 
            ROLLBACK TRAN;

        THROW; 
    END CATCH
END
GO

