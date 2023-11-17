USE [CATALOGO_WEB_DB]
GO

/****** Object:  StoredProcedure [dbo].[storeListar]    Script Date: 07/11/2023 13:19:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




create procedure [dbo].[storeListar] as
select Codigo,Nombre, a.Descripcion,c.Descripcion Categoria,ImagenUrl,Precio,m.Descripcion marca,a.IdCategoria,a.IdMarca,a.Id 
from ARTICULOS a , CATEGORIAS c, MARCAS m 
where a.IdCategoria = c.Id and m.Id = a.IdMarca


GO

