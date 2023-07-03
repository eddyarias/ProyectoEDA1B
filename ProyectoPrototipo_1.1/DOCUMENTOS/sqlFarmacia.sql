--drop database db_farmacia;
--drop table Producto

DROP DATABASE db_farmacy
DROP TABLE PROFUCTO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'db_farmacia')
BEGIN
    CREATE DATABASE db_farmacia;
END

USE db_farmacia;

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Producto')
BEGIN
    DROP TABLE Producto;
END

CREATE TABLE Producto (
    codigo INT PRIMARY KEY,
    nombre NVARCHAR(255),
    tipo NVARCHAR(255),
    cantidad INT,
    lote NVARCHAR(50),
    PVP DECIMAL(18, 2),
    precio_unitario DECIMAL(18, 2),
    fecha_caducidad DATETIME,
    descuento DECIMAL(18, 2)
);

INSERT INTO Producto (codigo, nombre, tipo, cantidad, lote, PVP, precio_unitario, fecha_caducidad, descuento)
VALUES
    (1, 'Paracetamol 500mg', 'Medicamento', 10, 'Lote A', 9.99, 8.99, '2023-06-30', 0.5),
    (2, 'Ibuprofeno 400mg', 'Medicamento', 5, 'Lote B', 19.99, 17.99, '2023-07-15', 1.0),
    (3, 'Omeprazol 20mg', 'Medicamento', 2, 'Lote C', 5.99, 4.99, '2023-06-25', 0.2),
    (4, 'Loratadina 10mg', 'Medicamento', 8, 'Lote D', 14.99, 12.99, '2023-07-10', 0.75),
    (5, 'Amoxicilina 500mg', 'Medicamento', 3, 'Lote E', 7.99, 6.99, '2023-06-28', 0.3),
    (6, 'Vitamina C 1000mg', 'Suplemento', 10, 'Lote F', 11.99, 10.99, '2023-07-05', 0.25),
    (7, 'Aspirina 500mg', 'Medicamento', 5, 'Lote G', 22.99, 20.99, '2023-07-20', 0.8),
    (8, 'Cetirizina 10mg', 'Medicamento', 2, 'Lote H', 6.99, 5.99, '2023-06-29', 0.15),
    (9, 'Vitamina D3 1000UI', 'Suplemento', 8, 'Lote I', 16.99, 14.99, '2023-07-12', 0.7),
    (10, 'Gel Antibacterial 60ml', 'Producto de higiene', 3, 'Lote J', 8.99, 7.99, '2023-06-27', 0.35);

select * from Producto;
