USE [CATALOGO_WEB_DB]
GO

/****** Object:  StoredProcedure [dbo].[storedModificarArticulo]    Script Date: 07/11/2023 13:19:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[storedModificarArticulo] 
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(150),
@idMarca int,
@idcategoria int,
@urlimagen varchar(1000),
@precio money,
@id int

as

update ARTICULOS 
set 
Codigo = @codigo,
Nombre = @nombre,
Descripcion = @descripcion,
IdMarca = @idMarca,
IdCategoria = @idcategoria,
ImagenUrl = @urlimagen, 
Precio = @precio 
where Id = @id
GO

