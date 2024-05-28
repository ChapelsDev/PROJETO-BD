--Trigers suppliee
Create trigger TechHouse.Suppi on TechHouse.Supplier
after UPDATE , insert 
as 
    if EXISTS(select * from TechHouse.Technician where EmployeeID in(SELECT EmployeeID from instead ))
            OR EXISTS(select * FROM TechHouse.Worker WHERE EmployeeID in (SELECT EmployeeID from instead))
    BEGIN 
        RAISERROR('Conflito de Dados' , 16 , 1)
        ROLLBACK TRAN
    END
go

--Triggers technician
Create trigger TechHouse.Technicn on TechHouse.Technician
after UPDATE , insert 
as 
    if EXISTS(select * from TechHouse.Supplier where EmployeeID in(SELECT EmployeeID from instead ))
            OR EXISTS(select * FROM TechHouse.Worker WHERE EmployeeID in (SELECT EmployeeID from instead))
    BEGIN 
        RAISERROR('Conflito de Dados' , 16 , 1)
        ROLLBACK TRAN
    END
go

--Triggers Worker
Create trigger [TechHouse].[Workr] on [TechHouse].[Worker]
after UPDATE , insert 
as 
    if EXISTS(select * from TechHouse.Supplier where EmployeeID in(SELECT EmployeeID from instead ))
            OR EXISTS(select * FROM TechHouse.Worke WHERE EmployeeID in (SELECT EmployeeID from instead))
    BEGIN 
        RAISERROR('Conflito de Dados' , 16 , 1)
        ROLLBACK TRAN
    END
go

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