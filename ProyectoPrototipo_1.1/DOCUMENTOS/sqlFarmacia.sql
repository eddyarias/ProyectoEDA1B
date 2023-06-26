--drop database db_farmacia;
--drop table Producto


IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'db_farmacia')
BEGIN
    CREATE DATABASE db_farmacia;
END

USE db_farmacia; --para usar la base de datos. antes de intentar hacer cualquier accion (por ejemplo: drop)

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Proveedor')
BEGIN
    CREATE TABLE Proveedor (
        ruc INT PRIMARY KEY,
        razon_social VARCHAR(200),
        nombre VARCHAR(100),
        apellido VARCHAR(100),
        email VARCHAR(100),
        ciudad VARCHAR(100),
        direccion VARCHAR(200),
        telefono VARCHAR(20),
        rubro VARCHAR(100),
        observaciones VARCHAR(200),
        informacion_bancaria VARCHAR(200),
        calificacion VARCHAR(50)
    )

	INSERT INTO Proveedor (ruc, razon_social, nombre, apellido, email, ciudad, direccion, telefono, rubro, observaciones, informacion_bancaria, calificacion)
VALUES
    (1, 'Proveedor1', 'Juan', 'Pérez', 'proveedor1@example.com', 'Ciudad1', 'Dirección1', '123456789', 'Farmacia', 'Observaciones1', 'Información bancaria1', 'Buena'),
    (2, 'Proveedor2', 'María', 'Gómez', 'proveedor2@example.com', 'Ciudad2', 'Dirección2', '987654321', 'Farmacia', 'Observaciones2', 'Información bancaria2', 'Regular'),
    (3, 'Proveedor3', 'Carlos', 'López', 'proveedor3@example.com', 'Ciudad3', 'Dirección3', '555555555', 'Farmacia', 'Observaciones3', 'Información bancaria3', 'Buena'),
    (4, 'Proveedor4', 'Ana', 'Martínez', 'proveedor4@example.com', 'Ciudad4', 'Dirección4', '111111111', 'Farmacia', 'Observaciones4', 'Información bancaria4', 'Excelente'),
    (5, 'Proveedor5', 'Pedro', 'Sánchez', 'proveedor5@example.com', 'Ciudad5', 'Dirección5', '999999999', 'Farmacia', 'Observaciones5', 'Información bancaria5', 'Regular');
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Producto')
BEGIN
    CREATE TABLE Producto (
        codigo INT PRIMARY KEY,
        cantidad INT,
        descripcion NVARCHAR(255),
        lote NVARCHAR(50),
        PVP DECIMAL(18, 2),
        precio_unitario DECIMAL(18, 2),
        fecha_cad DATE,
        descuento DECIMAL(18, 2),
        iva DECIMAL(18, 2)
    );
	INSERT INTO Producto (codigo, cantidad, descripcion, lote, PVP, precio_unitario, fecha_cad, descuento, iva)
VALUES
    (1, 10, 'Paracetamol 500mg', 'Lote A', 9.99, 8.99, '2023-06-30', 0.5, 0.18),
    (2, 5, 'Ibuprofeno 400mg', 'Lote B', 19.99, 17.99, '2023-07-15', 1.0, 0.18),
    (3, 2, 'Omeprazol 20mg', 'Lote C', 5.99, 4.99, '2023-06-25', 0.2, 0.18),
    (4, 8, 'Loratadina 10mg', 'Lote D', 14.99, 12.99, '2023-07-10', 0.75, 0.18),
    (5, 3, 'Amoxicilina 500mg', 'Lote E', 7.99, 6.99, '2023-06-28', 0.3, 0.18),
    (6, 10, 'Vitamina C 1000mg', 'Lote F', 11.99, 10.99, '2023-07-05', 0.25, 0.18),
    (7, 5, 'Aspirina 500mg', 'Lote G', 22.99, 20.99, '2023-07-20', 0.8, 0.18),
    (8, 2, 'Cetirizina 10mg', 'Lote H', 6.99, 5.99, '2023-06-29', 0.15, 0.18),
    (9, 8, 'Vitamina D3 1000UI', 'Lote I', 16.99, 14.99, '2023-07-12', 0.7, 0.18),
    (10, 3, 'Gel Antibacterial 60ml', 'Lote J', 8.99, 7.99, '2023-06-27', 0.35, 0.18);
END



select * from Proveedor;
select * from Producto;
