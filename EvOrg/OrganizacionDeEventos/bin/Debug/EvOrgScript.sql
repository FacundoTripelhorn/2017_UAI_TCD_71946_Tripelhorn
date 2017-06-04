USE [EvOrg];
/****** Object:  Table [dbo].[Cliente]    Script Date: 4/6/2017 2:32:30 a. m. ******/
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
/****** Object:  Table [dbo].[DireccionSalon]    Script Date: 4/6/2017 2:32:31 a. m. ******/
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
/****** Object:  Table [dbo].[DireccionServicio]    Script Date: 4/6/2017 2:32:31 a. m. ******/
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
/****** Object:  Table [dbo].[Evento]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[Evento](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cant_Invitados] [int] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Salon] [int] NULL,
	[Cliente] [int] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[EventoPaso]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[EventoPaso](
	[Evento] [int] NOT NULL,
	[Paso] [int] NOT NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_EventoPaso] PRIMARY KEY CLUSTERED 
(
	[Evento] ASC,
	[Paso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Familia]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[Familia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[FamiliaGrupoPatente]    Script Date: 4/6/2017 2:32:31 a. m. ******/
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
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 4/6/2017 2:32:31 a. m. ******/
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
/****** Object:  Table [dbo].[GrupoPatente]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[GrupoPatente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_GrupoPatente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Material]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[Material](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NULL,
	[Precio] [float] NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Paso]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[Paso](
	[Id] [int] NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Prioridad] [nvarchar](5) NULL,
	[Tipo] [nvarchar](8) NULL,
 CONSTRAINT [PK_Paso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Patente]    Script Date: 4/6/2017 2:32:31 a. m. ******/
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
/****** Object:  Table [dbo].[ReservaMaterial]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[ReservaMaterial](
	[Evento] [int] NOT NULL,
	[Material] [int] NOT NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_ReservaMaterial] PRIMARY KEY CLUSTERED 
(
	[Evento] ASC,
	[Material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[ReservaServicio]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[ReservaServicio](
	[Evento] [int] NOT NULL,
	[Servicio] [int] NOT NULL,
	[Descripcion] [nvarchar](500) NULL,
 CONSTRAINT [PK_EventoServicio] PRIMARY KEY CLUSTERED 
(
	[Evento] ASC,
	[Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Salon]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[Salon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Capacidad] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [int] NULL,
	[Descripcion] [nvarchar](1000) NULL,
	[Precio] [float] NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Servicio]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[Servicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[Observacion] [nvarchar](500) NULL,
	[Precio] [float] NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 4/6/2017 2:32:31 a. m. ******/
CREATE TABLE [dbo].[TipoEvento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](500) NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[TipoEventoPaso]    Script Date: 4/6/2017 2:32:31 a. m. ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 4/6/2017 2:32:31 a. m. ******/
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

INSERT [dbo].[Cliente] ([DNI], [Nombre], [Apellido], [Telefono], [Email]) VALUES (39507742, N'Facundo', N'Tripelhorn', 1151385486, N'facundo.tripelhorn@gmail.com')

SET IDENTITY_INSERT [dbo].[DireccionSalon] ON 
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (0, N'Jose Leon Suarez', 325, 1613)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (1, N'asds', 121, 1214)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (2, N'Calle falsa', 123, 1236)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (3, N'Rivadavia', 2514, 1613)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (4, N'jlkjklj', 21231, 1234)
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [CP]) VALUES (5, N'Jose Leon Suarez', 325, 1613)
SET IDENTITY_INSERT [dbo].[DireccionSalon] OFF

INSERT [dbo].[DireccionServicio] ([Id], [Calle], [Numero], [CP]) VALUES (1, N'asdsa', 4546, 45546)

INSERT [dbo].[Evento] ([Id], [Nombre], [Fecha], [Cant_Invitados], [Tipo], [Salon], [Cliente]) VALUES (1, N'Cumple de Juanito', CAST(N'2018-04-16' AS Date), 5000, 0, 1, 39507742)

SET IDENTITY_INSERT [dbo].[Familia] ON 
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (2, N'ABM')
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (3, N'Usuario')
SET IDENTITY_INSERT [dbo].[Familia] OFF

INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 1, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 2, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 3, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (2, 2, 1

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

INSERT [dbo].[Material] ([Id], [Nombre], [Cantidad], [Precio]) VALUES (4564, N'Mantel', 550, NULL)

INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (0, N'Comprar bonetes', N'Alta', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (1, N'Reservar Materiales', N'Baja', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (2, N'Llamar al cliente', N'Baja', N'Genérico')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (3, N'Reservar salón', N'Media', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (4, N'Reservar DJ', N'Alta', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (5, N'jhkjhjk', N'Media', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (6, N'oñkñk', N'Media', N'Concreto')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (7, N'jlkjlkj', N'Baja', N'Concreto')

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
INSERT [dbo].[Salon] ([Id], [Nombre], [Capacidad], [Email], [Telefono], [Direccion], [Descripcion], [Precio]) VALUES (1, N'Salon1', 5000, N'salon1@gmail.com', 46631281, 0, N'asdasdasdasdsadasdas', NULL)
SET IDENTITY_INSERT [dbo].[Salon] OFF

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
REFERENCES [dbo].[Salon] ([Id])
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Salon]

ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_TipoEvento] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TipoEvento] ([Id])
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_TipoEvento]

ALTER TABLE [dbo].[EventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_EventoPaso_Evento] FOREIGN KEY([Evento])
REFERENCES [dbo].[Evento] ([Id])
ALTER TABLE [dbo].[EventoPaso] CHECK CONSTRAINT [FK_EventoPaso_Evento]

ALTER TABLE [dbo].[EventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_EventoPaso_Paso] FOREIGN KEY([Paso])
REFERENCES [dbo].[Paso] ([Id])
ALTER TABLE [dbo].[EventoPaso] CHECK CONSTRAINT [FK_EventoPaso_Paso]

ALTER TABLE [dbo].[FamiliaGrupoPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaGrupoPatente_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id])
ALTER TABLE [dbo].[FamiliaGrupoPatente] CHECK CONSTRAINT [FK_FamiliaGrupoPatente_Familia]

ALTER TABLE [dbo].[FamiliaGrupoPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaGrupoPatente_GrupoPatente] FOREIGN KEY([GrupoPatente])
REFERENCES [dbo].[GrupoPatente] ([Id])
ALTER TABLE [dbo].[FamiliaGrupoPatente] CHECK CONSTRAINT [FK_FamiliaGrupoPatente_GrupoPatente]

ALTER TABLE [dbo].[FamiliaPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaPatente_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id])
ALTER TABLE [dbo].[FamiliaPatente] CHECK CONSTRAINT [FK_FamiliaPatente_Familia]

ALTER TABLE [dbo].[FamiliaPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaPatente_Patente] FOREIGN KEY([Patente])
REFERENCES [dbo].[Patente] ([Id])
ALTER TABLE [dbo].[FamiliaPatente] CHECK CONSTRAINT [FK_FamiliaPatente_Patente]

ALTER TABLE [dbo].[GrupoPatente]  WITH CHECK ADD  CONSTRAINT [FK_GrupoPatente_GrupoPatente] FOREIGN KEY([Padre])
REFERENCES [dbo].[GrupoPatente] ([Id])
ALTER TABLE [dbo].[GrupoPatente] CHECK CONSTRAINT [FK_GrupoPatente_GrupoPatente]

ALTER TABLE [dbo].[Patente]  WITH CHECK ADD  CONSTRAINT [FK_Patente_GrupoPatente] FOREIGN KEY([Padre])
REFERENCES [dbo].[GrupoPatente] ([Id])
ALTER TABLE [dbo].[Patente] CHECK CONSTRAINT [FK_Patente_GrupoPatente]

ALTER TABLE [dbo].[ReservaMaterial]  WITH CHECK ADD  CONSTRAINT [FK_ReservaMaterial_Evento] FOREIGN KEY([Evento])
REFERENCES [dbo].[Evento] ([Id])
ALTER TABLE [dbo].[ReservaMaterial] CHECK CONSTRAINT [FK_ReservaMaterial_Evento]

ALTER TABLE [dbo].[ReservaMaterial]  WITH CHECK ADD  CONSTRAINT [FK_ReservaMaterial_Material] FOREIGN KEY([Material])
REFERENCES [dbo].[Material] ([Id])
ALTER TABLE [dbo].[ReservaMaterial] CHECK CONSTRAINT [FK_ReservaMaterial_Material]

ALTER TABLE [dbo].[ReservaServicio]  WITH CHECK ADD  CONSTRAINT [FK_ReservaServicio_Evento] FOREIGN KEY([Evento])
REFERENCES [dbo].[Evento] ([Id])
ALTER TABLE [dbo].[ReservaServicio] CHECK CONSTRAINT [FK_ReservaServicio_Evento]

ALTER TABLE [dbo].[ReservaServicio]  WITH CHECK ADD  CONSTRAINT [FK_ReservaServicio_Servicio] FOREIGN KEY([Servicio])
REFERENCES [dbo].[Servicio] ([Id])
ALTER TABLE [dbo].[ReservaServicio] CHECK CONSTRAINT [FK_ReservaServicio_Servicio]

ALTER TABLE [dbo].[Salon]  WITH CHECK ADD  CONSTRAINT [FK_Salon_DireccionSalon] FOREIGN KEY([Direccion])
REFERENCES [dbo].[DireccionSalon] ([Id])
ALTER TABLE [dbo].[Salon] CHECK CONSTRAINT [FK_Salon_DireccionSalon]

ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_DireccionServicio] FOREIGN KEY([Direccion])
REFERENCES [dbo].[DireccionServicio] ([Id])
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_DireccionServicio]

ALTER TABLE [dbo].[TipoEventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_TipoEventoPaso_Paso] FOREIGN KEY([Paso])
REFERENCES [dbo].[Paso] ([Id])
ALTER TABLE [dbo].[TipoEventoPaso] CHECK CONSTRAINT [FK_TipoEventoPaso_Paso]

ALTER TABLE [dbo].[TipoEventoPaso]  WITH CHECK ADD  CONSTRAINT [FK_TipoEventoPaso_TipoEvento] FOREIGN KEY([TipoEv])
REFERENCES [dbo].[TipoEvento] ([Id])
ALTER TABLE [dbo].[TipoEventoPaso] CHECK CONSTRAINT [FK_TipoEventoPaso_TipoEvento]

ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id])
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Familia]
;