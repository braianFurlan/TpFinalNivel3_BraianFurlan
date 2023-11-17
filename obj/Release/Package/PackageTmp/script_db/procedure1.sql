USE [CATALOGO_WEB_DB]
GO

/****** Object:  StoredProcedure [dbo].[storedAltaArticulo]    Script Date: 07/11/2023 13:19:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[storedAltaArticulo]

@Codigo varchar(50),
@Nombre varchar (50),
@Descripcion varchar(50),
@idMarca int,
@idCategoria int,
@ImagenUrl varchar(300),
@precio money 
as
insert into ARTICULOS values (@Codigo, @Nombre, @Descripcion, @idMarca, @idCategoria , @ImagenUrl, @precio)
GO

