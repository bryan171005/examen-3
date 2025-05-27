create database examen3
use examen3

CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    Precio varchar(20) NOT NULL,
    Cantidad INT NOT NULL,
    FechaRegistro DATE not null
);
INSERT INTO Productos (Nombre, Descripcion, Precio, Cantidad, FechaRegistro)
VALUES
('Llanta Michelin 15"', 'Llanta todo terreno, rin 15', '1450.00', 20, '2025-05-01'),
('Aceite Castrol 5W30', 'Aceite sintético para motor', '320.00', 50, '2025-05-05'),
('Filtro de aire', 'Filtro para autos compactos', '180.00', 35, '2025-05-10'),
('Batería LTH 12V', 'Batería para auto estándar', '1850.00', 12, '2025-05-15'),
('Anticongelante Prestone', 'Botella 4L anticongelante verde', '250.00', 25, '2025-05-20');
select*from Productos
