USE [EvOrg]
;
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/4/2017 12:58:39 a. m. ******/
CREATE TABLE [dbo].[Cliente](
	[DNI] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [int] NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[DireccionSalon]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[DireccionSalon](
	[Id] [int] NOT NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[CP] [int] NULL,
 CONSTRAINT [PK_DireccionSalon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[DireccionServicio]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[DireccionServicio](
	[Id] [int] NOT NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[CP] [int] NULL,
 CONSTRAINT [PK_DireccionServicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Evento]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Evento](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Fecha] [date] NULL,
	[Cant_Invitados] [int] NULL,
	[Distrito] [nvarchar](50) NULL,
	[Tipo] [int] NULL,
	[Salon] [int] NULL,
	[Cliente] [int] NULL,
	[Servicios] [int] NULL,
	[Materiales] [int] NULL,
	[Pasos] [int] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Familia]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Familia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[FamiliaGrupoPatente]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[FamiliaGrupoPatente](
	[Familia] [int] NOT NULL,
	[GrupoPatente] [int] NOT NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_FamiliaGrupoPatente_1] PRIMARY KEY CLUSTERED 
(
	[Familia] ASC,
	[GrupoPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[FamiliaPatente](
	[Familia] [int] NOT NULL,
	[Patente] [int] NOT NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_FamiliaPatente] PRIMARY KEY CLUSTERED 
(
	[Familia] ASC,
	[Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[GrupoPatente]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[GrupoPatente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_GrupoPatente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Material]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Material](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Paso]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Paso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Fecha] [date] NULL,
	[Prioridad] [nvarchar](5) NULL,
	[Tipo] [nvarchar](8) NULL,
 CONSTRAINT [PK_Paso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Patente]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Patente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Formulario] [nvarchar](50) NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_Patente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Salon]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Salon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Capacidad] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [int] NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Servicio]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Servicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[Observacion] [nvarchar](500) NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[TipoEvento](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](500) NULL,
	[Paso] [int] NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[TipoEventoPaso]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[TipoEventoPaso](
	[TipoEv] [int] NOT NULL,
	[Paso] [int] NOT NULL,
 CONSTRAINT [PK_TipoEventoPaso] PRIMARY KEY CLUSTERED 
(
	[TipoEv] ASC,
	[Paso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/4/2017 12:58:40 a. m. ******/
CREATE TABLE [dbo].[Usuario](
	[Id] [nvarchar](16) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [char](32) NULL,
	[Familia] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
;

SET IDENTITY_INSERT [dbo].[Familia] ON 
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (1, N'Administrador')
SET IDENTITY_INSERT [dbo].[Familia] OFF

INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 1, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 2, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 3, 1)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 9, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 10, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 11, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 12, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 13, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 14, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 15, 3)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 16, 3)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 17, 3)

SET IDENTITY_INSERT [dbo].[GrupoPatente] ON 
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (1, N'Patentes del Sistema', NULL)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (2, N'ABM', 1)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (3, N'Seguridad', 1)
SET IDENTITY_INSERT [dbo].[GrupoPatente] OFF

SET IDENTITY_INSERT [dbo].[Patente] ON 
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (9, N'Material', N'ABMMaterial', 2)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (10, N'Cliente', N'ABMCliente', 2)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (11, N'Paso', N'ABMPaso', 2)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (12, N'Salon', N'ABMSalon', 2)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (13, N'Servicio', N'ABMServicio', 2)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (14, N'TipoEvento', N'ABMTipoEvento', 2)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (15, N'Usuario', N'ABMUsuario', 3)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (16, N'Familia', N'ABMFamilia', 3)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (17, N'Patente', N'ABMPatente', 3)
SET IDENTITY_INSERT [dbo].[Patente] OFF

INSERT [dbo].[Usuario] ([Id], [Email], [Password], [Familia]) VALUES (N'Administrador', N'facundo.tripelhorn@gmail.com', N'91F5167C34C400758115C2A6826EC2E3', 1)

ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Cliente] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([DNI])
;
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Cliente]
;
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Salon] FOREIGN KEY([Salon])
REFERENCES [dbo].[Salon] ([Id])
;
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Salon]
;
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_TipoEvento] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TipoEvento] ([Id])
;
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_TipoEvento]
;
ALTER TABLE [dbo].[GrupoPatente]  WITH CHECK ADD  CONSTRAINT [FK_GrupoPatente_GrupoPatente] FOREIGN KEY([Padre])
REFERENCES [dbo].[GrupoPatente] ([Id])
;
ALTER TABLE [dbo].[GrupoPatente] CHECK CONSTRAINT [FK_GrupoPatente_GrupoPatente]
;
ALTER TABLE [dbo].[TipoEventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_TipoEventoPaso_Paso] FOREIGN KEY([Paso])
REFERENCES [dbo].[Paso] ([Id])
;
ALTER TABLE [dbo].[TipoEventoPaso] CHECK CONSTRAINT [FK_TipoEventoPaso_Paso]
;
ALTER TABLE [dbo].[TipoEventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_TipoEventoPaso_TipoEvento] FOREIGN KEY([TipoEv])
REFERENCES [dbo].[TipoEvento] ([Id])
;
ALTER TABLE [dbo].[TipoEventoPaso] CHECK CONSTRAINT [FK_TipoEventoPaso_TipoEvento]
;

