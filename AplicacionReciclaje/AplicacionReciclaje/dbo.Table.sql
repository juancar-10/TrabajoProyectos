CREATE TABLE [dbo].[InfoUsuario]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [NombreUsuario] NVARCHAR(50) NULL, 
    [Contraseña] NVARCHAR(50) NULL, 
    [Puntos] NVARCHAR(50) NULL
)
