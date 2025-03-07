USE [master]
GO
/****** Object:  Database [tallerWest]    Script Date: 11/7/2024 22:34:10 ******/
CREATE DATABASE [tallerWest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tallerWest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\tallerWest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tallerWest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\tallerWest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [tallerWest] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tallerWest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tallerWest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tallerWest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tallerWest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tallerWest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tallerWest] SET ARITHABORT OFF 
GO
ALTER DATABASE [tallerWest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tallerWest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tallerWest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tallerWest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tallerWest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tallerWest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tallerWest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tallerWest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tallerWest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tallerWest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tallerWest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tallerWest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tallerWest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tallerWest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tallerWest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tallerWest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tallerWest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tallerWest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tallerWest] SET  MULTI_USER 
GO
ALTER DATABASE [tallerWest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tallerWest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tallerWest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tallerWest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tallerWest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tallerWest] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [tallerWest] SET QUERY_STORE = ON
GO
ALTER DATABASE [tallerWest] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [tallerWest]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Mensaje] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BitacoraTipo]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BitacoraTipo](
	[Code] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BitacoraTipo] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[IdIdioma] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Palabra]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palabra](
	[IdPalabra] [int] IDENTITY(1,1) NOT NULL,
	[Tag] [varchar](50) NULL,
	[Texto] [varchar](255) NULL,
	[IdIdioma] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPalabra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[NombrePermiso] [varchar](50) NOT NULL,
	[TipoPermiso] [bit] NULL,
 CONSTRAINT [PK_tblPermiso] PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_Permiso](
	[IdPadre] [int] NOT NULL,
	[IdHijo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermisosUsuarios]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisosUsuarios](
	[userName] [nchar](10) NOT NULL,
	[IdPermiso] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[userName] [nchar](10) NOT NULL,
	[password] [nvarchar](15) NULL,
	[DW] [varchar](255) NULL,
	[Nombre] [nchar](10) NULL,
	[Apellido] [nchar](10) NULL,
	[Mail] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VerificadorVertical]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VerificadorVertical](
	[IdVerificadorVertical] [int] IDENTITY(1,1) NOT NULL,
	[Verificador] [varchar](255) NOT NULL,
 CONSTRAINT [PK_tblVerificadorVertical] PRIMARY KEY CLUSTERED 
(
	[IdVerificadorVertical] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VersionadoUsuarioss]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VersionadoUsuarioss](
	[IdVersionadoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nchar](10) NULL,
	[Password] [nvarchar](15) NULL,
	[Nombre] [nchar](10) NULL,
	[Apellido] [nchar](10) NULL,
	[Mail] [varchar](50) NULL,
 CONSTRAINT [PK_VersionadoUsuarioss] PRIMARY KEY CLUSTERED 
(
	[IdVersionadoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_BITACORA_AGREGAR]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_BITACORA_AGREGAR]
	@tipo VARCHAR(50),
	@usuario VARCHAR(50),
	@mensaje VARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Bitacora (fecha, Tipo, Usuario, Mensaje)
	VALUES (GETDATE(), @tipo, @usuario, @mensaje)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BITACORA_OBTENERFILTRADO]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_BITACORA_OBTENERFILTRADO]
    @total bit = 0,
    @pagina int = 0,
    @porPagina int = 10,
    @usuario nvarchar(50) = NULL,
    @desde datetime = NULL,
    @hasta datetime = NULL,
    @tipo int = NULL,
    @buscar nvarchar(255) = NULL
AS
BEGIN

    SET NOCOUNT ON;

    IF @desde IS NULL 
        SELECT @desde = GETDATE()
    IF @hasta IS NULL 
        SELECT @hasta = GETDATE()

    SELECT @buscar = '%' + ISNULL(@buscar, '') + '%'

    SELECT @pagina = @pagina - 1

    IF @total = 1
    BEGIN
        SELECT 'Pagina' = @pagina + 1,
               'PorPagina' = @porPagina,
               'Total' = COUNT(*),
               'TotalPorPagina' = CEILING(CONVERT(float, COUNT(*)) / CONVERT(float, @porPagina))
        FROM Bitacora a 
        WHERE (a.Usuario = @usuario OR @usuario IS NULL)
              AND CONVERT(date, a.Fecha) BETWEEN CONVERT(date, @desde) AND CONVERT(date, @hasta)
              AND (a.Tipo = @tipo OR @tipo = 3 OR @tipo IS NULL)
              AND 
              (
                  a.Usuario LIKE @buscar
                  OR a.Mensaje LIKE @buscar
              )
    END
    ELSE
    BEGIN
        SELECT *
        FROM
        (
            SELECT ROW_NUMBER() OVER (ORDER BY a.Fecha) AS [Index], 
                   a.Id,
                   a.Usuario,
                   a.Fecha,
                   a.Tipo,
                   a.Mensaje
            FROM Bitacora a 
            WHERE (a.Usuario = @usuario OR @usuario IS NULL)
                  AND CONVERT(date, a.Fecha) BETWEEN CONVERT(date, @desde) AND CONVERT(date, @hasta)
                  AND (a.Tipo = @tipo OR @tipo = 3 OR @tipo IS NULL)
                  AND 
                  (
                      a.Usuario LIKE @buscar
                      OR a.Mensaje LIKE @buscar
                  )
        ) z
        WHERE z.[Index] BETWEEN (@porPagina * @pagina) + 1 AND (@porPagina * @pagina) + @porPagina
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Hijos_Obtener]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_Hijos_Obtener]

as
BEGIN

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [IdPermiso]
      ,[NombrePermiso]
      
  FROM [tallerWest].[dbo].[Permiso]

  where TipoPermiso= 'false';


END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Idioma_Alta]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Idioma_Alta]
@nombre varchar(50)

AS
BEGIN

	SET NOCOUNT ON;

  
INSERT INTO dbo.Idioma(Nombre) values (@nombre)

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Idioma_Listar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Idioma_Listar]

AS
BEGIN

	SET NOCOUNT ON;

  
SELECT * from Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Idioma_Obtener]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Idioma_Obtener] 
	@idioma varchar(255)
AS
BEGIN

	SET NOCOUNT ON;

  
select IdIdioma, Nombre from dbo.Idioma where Nombre = @idioma;
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Idioma_Verificar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_Idioma_Verificar] 
	@idioma varchar(255)
AS
BEGIN

	SET NOCOUNT ON;

  
select count(*) from dbo.Idioma where Nombre = @idioma;
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Obtener_Arbol_Menu]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_Obtener_Arbol_Menu] 
	@IdPadre varchar(255)
AS
BEGIN

	SET NOCOUNT ON;

  
with r as (
                        select sm.IdPadre, sm.IdHijo  
						from Permiso_Permiso SM
                        where sm.IdPadre =@IdPadre


                        UNION ALL 

                        select Permiso_Permiso.IdPadre,Permiso_Permiso.IdHijo
						from Permiso_Permiso 
                        inner join  r on r.IdHijo= Permiso_Permiso.IdPadre
                        )
                        select r.IdPadre,r.IdHijo,p.IdPermiso,p.TipoPermiso,p.NombrePermiso--, Procesos.IdProceso,Procesos.Proceso
                        from  r 
                        inner join Permiso p on r.IdHijo = p.IdPermiso 
						--left join tblPermisoProceso ps on ps.IdPermiso= p.IdPermiso
						--left join tblProcesos as Procesos on ps.IdProceso=Procesos.IdProceso 
						

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Padres_Obtener]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_Padres_Obtener]

as
BEGIN

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [IdPermiso]
      ,[NombrePermiso]
      
  FROM [tallerWest].[dbo].[Permiso]

  where TipoPermiso= 'true';


END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Palabra_Alta]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Palabra_Alta]
    @tag VARCHAR(50),
    @texto VARCHAR(50),
    @idIdioma INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Palabra (Tag, Texto, IdIdioma)
    VALUES (@tag, @texto, @idIdioma);
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Palabra_Modificar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Palabra_Modificar]
    @idPalabra INT,
    @texto varchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Palabra
    SET Texto = @texto
    WHERE IdPalabra = @idPalabra;

    -- Opcional: Puedes agregar aquí cualquier lógica adicional necesaria

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Palabras_Idioma_Listar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Palabras_Idioma_Listar]
@idIdioma int

AS
BEGIN

	SET NOCOUNT ON;

  
select * from dbo.Palabra P
where P.IdIdioma = @idIdioma;

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Permiso_Agregar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_Permiso_Agregar]

@IdPadre int,
@IdHijo int
AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO Permiso_Permiso (IdPadre, IdHijo) VALUES (@IdPadre, @IdHijo)

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Permiso_Alta]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_Permiso_Alta]

@permiso varchar(255),
@tipopermiso bit

AS
BEGIN

	SET NOCOUNT ON;

INSERT INTO Permiso(NombrePermiso,TipoPermiso) values(@permiso,@tipopermiso);


END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Permiso_Eliminar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_Permiso_Eliminar]

@IdPadre int,
@IdHijo int
AS
BEGIN

	SET NOCOUNT ON;
	DELETE FROM Persona_Persona WHERE IdPadre = @IdPadre and IdHijo = @IdHijo

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_PermisosUsuario_Obtener]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_PermisosUsuario_Obtener]
@userName nchar(10)
as
BEGIN


select per.* from Usuario as u 
inner join PermisosUsuarios as p on p.userName=u.userName 
inner join Permiso as per on p.IdPermiso=per.IdPermiso


where u.userName=@userName


END
GO
/****** Object:  StoredProcedure [dbo].[SP_USER_ALTA]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USER_ALTA]
	@Usuario nvarchar(50),
    @Password nvarchar(32),
	@DW varchar(255),
    @Nombre nchar(10),
    @Apellido nchar(10),
    @Mail varchar(50)


AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO dbo.Usuario(userName, password,DW,Nombre,Apellido,Mail)
	values(@usuario, @Password, @DW,@Nombre,@Apellido, @Mail);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_USER_MODIFICAR]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USER_MODIFICAR]

	@Usuario nvarchar(50),
    @Password nvarchar(32) 
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.Usuario
    SET Password = @Password
    WHERE Username = @Usuario;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_USER_MODIFICAR_Datos]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USER_MODIFICAR_Datos]

	@Usuario nvarchar(50),
    @Nombre nchar(10),
	@Apellido nchar(10),
	@Mail varchar(50)
AS
BEGIN

DECLARE @userName nchar(10);
DECLARE @nombreAnt nchar(10);
DECLARE @apellidoAnt nchar(10);
DECLARE @emailAnt nchar(10);

SET NOCOUNT ON;


SELECT  @Usuario = U.userName,
		@nombreAnt = U.Nombre,
		@apellidoAnt = U.Apellido,
		@emailAnt = U.Mail
		
FROM Usuario U
where U.userName = @usuario;

	UPDATE dbo.Usuario
    SET Nombre = @Nombre, Apellido=@Apellido,Mail=@Mail
    WHERE Username = @Usuario;

INSERT INTO VersionadoUsuarioss(userName, Nombre, Apellido, Mail)
values(@Usuario, @nombreAnt, @apellidoAnt, @emailAnt);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_USER_VALIDAR_PASS]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_USER_VALIDAR_PASS]
    @Usuario nvarchar(20),
    @Password nvarchar(15) 
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Count int;

    SELECT @Count = COUNT(*)
    FROM Usuario
    WHERE userName = @Usuario AND password = @Password;

    SELECT @Count AS 'Count';
END
GO
/****** Object:  StoredProcedure [dbo].[SP_USER_VALIDAR_USUARIO]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_USER_VALIDAR_USUARIO]
    @Usuario NVARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Count int;
    SELECT @Count = COUNT(*)
    FROM Usuario
    WHERE userName = @Usuario;

    SELECT @Count AS 'Count';
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Usuario_Listar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Usuario_Listar] 
AS
BEGIN

	SET NOCOUNT ON;

  
select * from dbo.Usuario;
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Usuarios_Permiso_Agregar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_Usuarios_Permiso_Agregar]

@IdPermiso int,
@userName nchar(10)
AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO PermisosUsuarios(userName, IdPermiso) VALUES (@userName, @IdPermiso)

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Usuarios_Permiso_Eliminar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[Sp_Usuarios_Permiso_Eliminar]

@IdPermiso int,
@userName nchar(10)
AS
BEGIN

	SET NOCOUNT ON;
	DELETE FROM PermisosUsuarios WHERE IdPermiso = @IdPermiso and userName = @userName

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Verif_Alta]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Verif_Alta]
@verificador varchar(255)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.VerificadorVertical(Verificador) VALUES (@verificador)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Verif_Modificar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_Verif_Modificar]
@verificador varchar(255)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE VerificadorVertical
    SET Verificador = @verificador
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Verif_Verificar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_Verif_Verificar] 
@verificador varchar(255)
AS
BEGIN

	SET NOCOUNT ON;

  
select count(*) from VerificadorVertical where Verificador = @verificador;
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Version_Listar]    Script Date: 11/7/2024 22:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Version_Listar] 

@Usuario nchar(10)

AS
BEGIN

	SET NOCOUNT ON;

select * from VersionadoUsuarioss V
where V.userName = @Usuario;
END
GO
USE [master]
GO
ALTER DATABASE [tallerWest] SET  READ_WRITE 
GO
