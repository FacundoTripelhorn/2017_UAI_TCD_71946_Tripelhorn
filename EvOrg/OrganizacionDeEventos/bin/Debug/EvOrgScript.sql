USE [EvOrg];
/****** Object:  Table [dbo].[Cliente]    Script Date: 29/5/2017 1:48:13 a. m. ******/
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
) ON [PRIMARY];
/****** Object:  Table [dbo].[DireccionSalon]    Script Date: 29/5/2017 1:48:13 a. m. ******/
CREATE TABLE [dbo].[DireccionSalon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[CP] [int] NULL,
 CONSTRAINT [PK_DireccionSalon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[DireccionServicio]    Script Date: 29/5/2017 1:48:13 a. m. ******/
CREATE TABLE [dbo].[DireccionServicio](
	[Id] [int] NOT NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[CP] [int] NULL,
 CONSTRAINT [PK_DireccionServicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Evento]    Script Date: 29/5/2017 1:48:14 a. m. ******/
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
) ON [PRIMARY];
/****** Object:  Table [dbo].[Familia]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[Familia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[FamiliaGrupoPatente]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[FamiliaGrupoPatente](
	[Familia] [int] NOT NULL,
	[GrupoPatente] [int] NOT NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_FamiliaGrupoPatente_1] PRIMARY KEY CLUSTERED 
(
	[Familia] ASC,
	[GrupoPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[FamiliaPatente](
	[Familia] [int] NOT NULL,
	[Patente] [int] NOT NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_FamiliaPatente] PRIMARY KEY CLUSTERED 
(
	[Familia] ASC,
	[Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[GrupoPatente]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[GrupoPatente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_GrupoPatente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Material]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[Material](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Paso]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[Paso](
	[Id] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Fecha] [date] NOT NULL,
	[Prioridad] [nvarchar](5) NULL,
	[Tipo] [nvarchar](8) NULL,
 CONSTRAINT [PK_Paso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Patente]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[Patente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Formulario] [nvarchar](50) NOT NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_Patente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Salon]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[Salon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Capacidad] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [int] NULL,
	[Descripcion] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Servicio]    Script Date: 29/5/2017 1:48:14 a. m. ******/
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
) ON [PRIMARY];
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[TipoEvento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](500) NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[TipoEventoPaso]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[TipoEventoPaso](
	[TipoEv] [int] NOT NULL,
	[Paso] [int] NOT NULL,
	[Dias] [int] NULL,
 CONSTRAINT [PK_TipoEventoPaso] PRIMARY KEY CLUSTERED 
(
	[TipoEv] ASC,
	[Paso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Usuario]    Script Date: 29/5/2017 1:48:14 a. m. ******/
CREATE TABLE [dbo].[Usuario](
	[Id] [nvarchar](16) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [char](32) NULL,
	[Familia] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

SET IDENTITY_INSERT [dbo].[DireccionSalon] ON 
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (0, N'Jose Leon Suarez', 3095, 1613)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (1, N'asds', 121, 1214)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (2, N'Calle falsa', 123, 1236)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (3, N'Rivadavia', 2514, 1613)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (4, N'jlkjklj', 21231, 1234)
SET IDENTITY_INSERT [dbo].[DireccionSalon] OFF

INSERT [dbo].[DireccionServicio] ([Id], [Calle], [Numero], [CP]) VALUES (1, N'asdsa', 4546, 45546)

SET IDENTITY_INSERT [dbo].[Familia] ON 
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (2, N'ABM')
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (3, N'Usuario')
SET IDENTITY_INSERT [dbo].[Familia] OFF

INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 1, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 2, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 3, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (2, 2, 1)

INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 9, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 10, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 11, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 12, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 13, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 14, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 15, 3)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 16, 3)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 17, 3)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (2, 9, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (2, 10, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (2, 11, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (2, 12, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (2, 13, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (2, 14, 2)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (3, 18, 1)

SET IDENTITY_INSERT [dbo].[GrupoPatente] ON 
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (1, N'Patentes del Sistema', NULL)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (2, N'ABM', 1)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (3, N'Seguridad', 1)
SET IDENTITY_INSERT [dbo].[GrupoPatente] OFF

INSERT [dbo].[Material] ([Id], [Nombre], [Cantidad]) VALUES (4564, N'Mantel', 550)

INSERT [dbo].[Paso] ([Id], [Descripcion], [Fecha], [Prioridad], [Tipo]) VALUES (1, N'Reservar Materiales', CAST(N'2017-06-25' AS Date), N'Baja', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Fecha], [Prioridad], [Tipo]) VALUES (2, N'Llamar al cliente', CAST(N'0001-01-01' AS Date), N'Baja', N'Genérico')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Fecha], [Prioridad], [Tipo]) VALUES (3, N'Reservar salón', CAST(N'2017-07-14' AS Date), N'Media', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Fecha], [Prioridad], [Tipo]) VALUES (4, N'Reservar DJ', CAST(N'2017-05-31' AS Date), N'Alta', N'Concreto')

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
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (18, N'Nuevo Usuario', N'NuevoUsuario', 1)
SET IDENTITY_INSERT [dbo].[Patente] OFF

SET IDENTITY_INSERT [dbo].[Salon] ON 
INSERT [dbo].[Salon] ([Id], [Nombre], [Capacidad], [Email], [Telefono], [Direccion], [Descripcion]) VALUES (1, N'Salon1', 5000, N'salon1@gmail.com', 46631281, 0, N'asdasdasdasdsadasdas')
SET IDENTITY_INSERT [dbo].[Salon] OFF

SET IDENTITY_INSERT [dbo].[Servicio] ON 
INSERT [dbo].[Servicio] ([Id], [Nombre], [Telefono], [Direccion], [Email], [Observacion]) VALUES (5, N'asdas', 1324, 1, N'fsdfdsf', N'sdfsdgsdgsd sdfsd fsdf sd fsdf dsf df ')
SET IDENTITY_INSERT [dbo].[Servicio] OFF

SET IDENTITY_INSERT [dbo].[TipoEvento] ON 
INSERT [dbo].[TipoEvento] ([Id], [Nombre], [Descripcion]) VALUES (0, N'Casamiento', N'Es un casamiento')
SET IDENTITY_INSERT [dbo].[TipoEvento] OFF

INSERT [dbo].[TipoEventoPaso] ([TipoEv], [Paso], [Dias]) VALUES (0, 2, 20)
INSERT [dbo].[Usuario] ([Id], [Email], [Password], [Familia]) VALUES (N'ABM', N'abm@gmail.com', N'E10ADC3949BA59ABBE56E057F20F883E', 2)
INSERT [dbo].[Usuario] ([Id], [Email], [Password], [Familia]) VALUES (N'Administrador', N'facundo.tripelhorn@gmail.com', N'91F5167C34C400758115C2A6826EC2E3', 1)
INSERT [dbo].[Usuario] ([Id], [Email], [Password], [Familia]) VALUES (N'Usuario', N'usuario@gmail.com', N'E10ADC3949BA59ABBE56E057F20F883E', 3)

ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Cliente] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Cliente] ([DNI])
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Cliente]

ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Salon] FOREIGN KEY([Salon])
REFERENCES [dbo].[Salon] ([Id]) ON DELETE SET NULL
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Salon]

ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_TipoEvento] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TipoEvento] ([Id]) ON DELETE SET NULL
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_TipoEvento]

ALTER TABLE [dbo].[FamiliaGrupoPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaGrupoPatente_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[FamiliaGrupoPatente] CHECK CONSTRAINT [FK_FamiliaGrupoPatente_Familia]

ALTER TABLE [dbo].[FamiliaGrupoPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaGrupoPatente_GrupoPatente] FOREIGN KEY([GrupoPatente])
REFERENCES [dbo].[GrupoPatente] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[FamiliaGrupoPatente] CHECK CONSTRAINT [FK_FamiliaGrupoPatente_GrupoPatente]

ALTER TABLE [dbo].[FamiliaPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaPatente_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[FamiliaPatente] CHECK CONSTRAINT [FK_FamiliaPatente_Familia]

ALTER TABLE [dbo].[FamiliaPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaPatente_Patente] FOREIGN KEY([Patente])
REFERENCES [dbo].[Patente] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[FamiliaPatente] CHECK CONSTRAINT [FK_FamiliaPatente_Patente]

ALTER TABLE [dbo].[GrupoPatente]  WITH CHECK ADD  CONSTRAINT [FK_GrupoPatente_GrupoPatente] FOREIGN KEY([Padre])
REFERENCES [dbo].[GrupoPatente] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[GrupoPatente] CHECK CONSTRAINT [FK_GrupoPatente_GrupoPatente]

ALTER TABLE [dbo].[Patente]  WITH CHECK ADD  CONSTRAINT [FK_Patente_GrupoPatente] FOREIGN KEY([Padre])
REFERENCES [dbo].[GrupoPatente] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Patente] CHECK CONSTRAINT [FK_Patente_GrupoPatente]

ALTER TABLE [dbo].[Salon]  WITH CHECK ADD  CONSTRAINT [FK_Salon_DireccionSalon] FOREIGN KEY([Direccion])
REFERENCES [dbo].[DireccionSalon] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Salon] CHECK CONSTRAINT [FK_Salon_DireccionSalon]

ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_DireccionServicio] FOREIGN KEY([Direccion])
REFERENCES [dbo].[DireccionServicio] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_DireccionServicio]

ALTER TABLE [dbo].[TipoEventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_TipoEventoPaso_Paso] FOREIGN KEY([Paso])
REFERENCES [dbo].[Paso] ([Id]) ON DELETE SET NULL
ALTER TABLE [dbo].[TipoEventoPaso] CHECK CONSTRAINT [FK_TipoEventoPaso_Paso]

ALTER TABLE [dbo].[TipoEventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_TipoEventoPaso_TipoEvento] FOREIGN KEY([TipoEv])
REFERENCES [dbo].[TipoEvento] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[TipoEventoPaso] CHECK CONSTRAINT [FK_TipoEventoPaso_TipoEvento]

ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id]) ON DELETE SET NULL
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Familia]

;

