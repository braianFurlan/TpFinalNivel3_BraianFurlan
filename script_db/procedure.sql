USE [CATALOGO_WEB_DB]
GO

/****** Object:  StoredProcedure [dbo].[insertarNuevo]    Script Date: 07/11/2023 13:19:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[insertarNuevo]

@email varchar(50),
@pass varchar(50)
as
insert into USERS (email,pass,admin) output inserted.Id values (@email,@pass,0)
GO

