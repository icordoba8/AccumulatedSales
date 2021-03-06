USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_ACUMULADO_VENTAS_DEPARTAMENTOS]    Script Date: 6/07/2021 9:29:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ACUMULADO_VENTAS_DEPARTAMENTOS]
	@FECHA_INICIAL DATE,
	@FECHA_FINAL DATE
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT  
		D.CODDEP,
		D.NOMBRE,
		SUM(I.SUBTOTAL) AS TOTAL
	FROM  PEDIDO P
	 INNER JOIN ITEMS I ON P.NUMPEDIDO = I.NUMPEDIDO
	 INNER JOIN CLIENTE CL ON P.CLIENTE = CL.CODCLI
	 INNER JOIN CIUDAD CT ON  CL.CIUDAD = CT.CODCIU
	 INNER JOIN DEPARTAMENTO D ON  CT.DEPARTAMENTO = D.CODDEP
	  WHERE CAST(P.FECHA AS DATE) BETWEEN  @FECHA_INICIAL AND @FECHA_FINAL

	 GROUP BY D.CODDEP,D.NOMBRE 
	 ORDER BY D.NOMBRE ASC

END

USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_CLIENTE]    Script Date: 6/07/2021 9:34:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_BUSCAR_CLIENTE]
	@SEARCH varchar(128)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT  
		LTRIM(RTRIM(CLIENTE.CODCLI)),
		CLIENTE.NOMBRE,
		CIUDAD.NOMBRE AS CIUAD
		
	FROM  CLIENTE 
	 INNER JOIN CIUDAD  ON  CLIENTE.CIUDAD = CIUDAD.CODCIU
	
	  WHERE LOWER(CLIENTE.NOMBRE) LIKE '%'+ LOWER(@SEARCH)+'%' 

	 ORDER BY CLIENTE.NOMBRE ASC

END




USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_CLIENTE]    Script Date: 6/07/2021 9:34:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_BUSCAR_CLIENTE]
	@SEARCH varchar(128)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT  
		LTRIM(RTRIM(CLIENTE.CODCLI)),
		CLIENTE.NOMBRE,
		CIUDAD.NOMBRE AS CIUAD
		
	FROM  CLIENTE 
	 INNER JOIN CIUDAD  ON  CLIENTE.CIUDAD = CIUDAD.CODCIU
	
	  WHERE LOWER(CLIENTE.NOMBRE) LIKE '%'+ LOWER(@SEARCH)+'%' 

	 ORDER BY CLIENTE.NOMBRE ASC

END


USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_PRODUCTO]    Script Date: 6/07/2021 9:35:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_BUSCAR_PRODUCTO]
	@SEARCH varchar(128)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT  
		LTRIM(RTRIM(PRODUCTO.CODPROD)),
		PRODUCTO.NOMBRE,
		PRODUCTO.PRECIO
		
	FROM  PRODUCTO 
	
	  WHERE PRODUCTO.NOMBRE LIKE '%'+@SEARCH+'%' 

	 ORDER BY PRODUCTO.NOMBRE ASC

END


USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAR_VENDEDOR]    Script Date: 6/07/2021 9:35:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_BUSCAR_VENDEDOR]
	@SEARCH varchar(128)
	
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT  
	LTRIM(RTRIM(VENDEDOR.CODVEND)),
		
		VENDEDOR.NOMBRE
		
	FROM  VENDEDOR 
	
	  WHERE VENDEDOR.ESTADO ='Activo' AND  VENDEDOR.NOMBRE LIKE '%'+@SEARCH+'%' 

	 ORDER BY VENDEDOR.NOMBRE ASC

END


USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_COMISIONES]    Script Date: 6/07/2021 9:35:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
ALTER PROCEDURE [dbo].[SP_COMISIONES]
	@MES char(10),
	@ANO char(10)
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT  
		V.NOMBRE,
		SUM(I.SUBTOTAL)  AS VENTAS,
		CAST(SUM(I.SUBTOTAL) * 10/100  AS numeric(18, 0))   AS COMISION
	FROM  PEDIDO P
	 INNER JOIN ITEMS I ON P.NUMPEDIDO = I.NUMPEDIDO
	 INNER JOIN CLIENTE CL ON P.CLIENTE = CL.CODCLI
	 INNER JOIN VENDEDOR V ON  P.VENDEDOR = V.CODVEND
	 
	  WHERE   YEAR(P.FECHA)  =@ANO AND  Month(P.FECHA) = @MES
	  

	 GROUP BY V.NOMBRE
	 ORDER BY V.NOMBRE ASC

END


USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_ITEM]    Script Date: 6/07/2021 9:35:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER PROCEDURE [dbo].[SP_CREAR_ITEM]

	@NUMPEDIDO char(10),
	@PRODUCTO char(10),
	@PRECIO  numeric(18, 0),
	@CANTIDAD  numeric(18, 0),
	@STATUS char(2) output
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRY  
	   DECLARE @PRODUCTO_EXISTE  numeric(18, 0)

	    SET @PRODUCTO_EXISTE = (SELECT CANTIDAD FROM   ITEMS  WHERE NUMPEDIDO = @NUMPEDIDO AND PRODUCTO = @PRODUCTO )
	    SET @PRODUCTO_EXISTE = ISNULL(@PRODUCTO_EXISTE,0)
		IF @PRODUCTO_EXISTE >0  
			UPDATE ITEMS SET CANTIDAD = @CANTIDAD+ @PRODUCTO_EXISTE WHERE NUMPEDIDO = @NUMPEDIDO AND PRODUCTO = @PRODUCTO
		ELSE
			INSERT INTO ITEMS(NUMPEDIDO, PRODUCTO, PRECIO,CANTIDAD)  VALUES(@NUMPEDIDO,@PRODUCTO,@PRECIO,@CANTIDAD)
		SET @STATUS = 1
	END TRY  
	BEGIN CATCH  
		SET @STATUS = 0
	END CATCH  

	RETURN   @STATUS
    
END


USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_CREAR_PEDIDO]    Script Date: 6/07/2021 9:35:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_CREAR_PEDIDO]
	
	@CLIENTE char(10),
	@VENDEDOR  char(10),
	@NUMPEDIDO  char(10) output
AS
BEGIN
	SET NOCOUNT ON;


	SET @NUMPEDIDO = (SELECT TOP 1 CAST(NUMPEDIDO AS int)+1 AS NUMPEDIDO  FROM PEDIDO ORDER BY NUMPEDIDO DESC)
	SET @NUMPEDIDO = ISNULL(@NUMPEDIDO,'10001')

	INSERT INTO PEDIDO(NUMPEDIDO,CLIENTE,FECHA,VENDEDOR)  VALUES(@NUMPEDIDO,@CLIENTE,GETDATE(),@VENDEDOR)

	RETURN  @NUMPEDIDO
    
END


USE [TESAmerica]
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_ITEMS]    Script Date: 6/07/2021 9:35:46 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER PROCEDURE [dbo].[SP_GET_ITEMS]

	@NUMPEDIDO char(10)
AS
BEGIN

		SELECT 
		   
			PRODUCTO.NOMBRE,
			ITEMS.PRECIO,
			ITEMS.CANTIDAD,
			ITEMS.SUBTOTAL,
			ITEMS.PRODUCTO
			
		FROM ITEMS 
		 INNER JOIN PRODUCTO ON ITEMS.PRODUCTO = PRODUCTO.CODPROD
		WHERE NUMPEDIDO = @NUMPEDIDO
		RETURN 

END







