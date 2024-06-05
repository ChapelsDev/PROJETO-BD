CREATE TRIGGER TechHouse.Suppi
ON TechHouse.Supplier
AFTER UPDATE, INSERT
AS
BEGIN
    IF EXISTS (
        SELECT * 
        FROM TechHouse.Technician 
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    OR EXISTS (
        SELECT * 
        FROM TechHouse.Worker 
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    BEGIN
        RAISERROR('Conflito de Dados', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO

CREATE TRIGGER TechHouse.Technicn
ON TechHouse.Technician
AFTER UPDATE, INSERT
AS
BEGIN
    IF EXISTS (
        SELECT * 
        FROM TechHouse.Supplier 
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    OR EXISTS (
        SELECT * 
        FROM TechHouse.Worker 
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    BEGIN
        RAISERROR('Conflito de Dados', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO

CREATE TRIGGER TechHouse.Workr
ON TechHouse.Worker
AFTER UPDATE, INSERT
AS
BEGIN
    IF EXISTS (
        SELECT * 
        FROM TechHouse.Supplier 
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    OR EXISTS (
        SELECT * 
        FROM TechHouse.Technician 
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    BEGIN
        RAISERROR('Conflito de Dados', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO

-- Triggers EmployeeTypes
CREATE TRIGGER TechHouse.EmployeeType_Disjoint
ON TechHouse.EmployeeType
AFTER UPDATE, INSERT
AS
BEGIN
    IF NOT EXISTS(
        SELECT * 
        FROM TechHouse.Supplier
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    OR NOT EXISTS(
        SELECT * 
        FROM TechHouse.Technician
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
	OR NOT EXISTS(
        SELECT * 
        FROM TechHouse.Worker
        WHERE EmployeeID IN (SELECT EmployeeID FROM inserted)
    )
    BEGIN
        RAISERROR('Conflito de dados.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO


