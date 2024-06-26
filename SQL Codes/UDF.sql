
CREATE FUNCTION TechHouse.CalcularPrecoComDesconto(@ProductID INT)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @PrecoFinal DECIMAL(10, 2);
    DECLARE @PrecoOriginal DECIMAL(10, 2);
    DECLARE @Desconto DECIMAL(5, 2);

    -- Obter o preço original do produto
    SELECT @PrecoOriginal = Price 
    FROM TechHouse.Products 
    WHERE ProductID = @ProductID;

    -- Verificar se existe uma promoção ativa para o produto
    SELECT @Desconto = DiscountPercentage
    FROM TechHouse.Promotions
    WHERE ProductID = @ProductID
      AND StartDate <= GETDATE()
      AND EndDate >= GETDATE();

    -- Calcular o preço final
    IF @Desconto IS NOT NULL
        SET @PrecoFinal = @PrecoOriginal * (1 - @Desconto / 100);
    ELSE
        SET @PrecoFinal = @PrecoOriginal;

    RETURN @PrecoFinal;
END;
go

--Lista todos os pedidos feitos por um usuário específico.
CREATE FUNCTION TechHouse.PedidosPorUsuario (@UserID INT)
RETURNS TABLE
AS
RETURN
    SELECT *
    FROM TechHouse.Orders
    WHERE UserID = @UserID;
GO

-- Filtrar os produtos por categorias
CREATE FUNCTION TechHouse.FilterProductsByCategory (@CategoryID INT)
RETURNS TABLE
AS
RETURN
(SELECT * 
    FROM TechHouse.Products
    WHERE CategoryID = @CategoryID
);
GO

-- fitlar os employee , pelos tipos
CREATE FUNCTION TechHouse.FilterEmployeesByType (@EmployeeTypeID INT)
RETURNS TABLE
AS
RETURN
(
    SELECT * 
    FROM TechHouse.Employee
    WHERE EmployeeTypeID = @EmployeeTypeID
);
GO
