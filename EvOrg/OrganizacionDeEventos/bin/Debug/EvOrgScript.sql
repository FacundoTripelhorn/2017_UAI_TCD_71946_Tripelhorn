USE [EvOrg];
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[Diccionario]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[Diccionario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Clave] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Diccionario_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[DireccionSalon]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[DireccionSalon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[Localidad] [nvarchar](50) NULL,
 CONSTRAINT [PK_DireccionSalon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[DireccionServicio]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[DireccionServicio](
	[Id] [int] NOT NULL,
	[Calle] [nvarchar](50) NULL,
	[Numero] [int] NULL,
	[Localidad] [nvarchar](50) NULL,
 CONSTRAINT [PK_DireccionServicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Evento]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[EventoPaso]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[Familia]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[Familia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[FamiliaGrupoPatente]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[GrupoPatente]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[GrupoPatente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Padre] [int] NULL,
 CONSTRAINT [PK_GrupoPatente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Idioma]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[Idioma](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[IdiomaDiccionario]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[IdiomaDiccionario](
	[Idioma] [int] NOT NULL,
	[Diccionario] [int] NOT NULL,
	[Valor] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_IdiomaDiccionario] PRIMARY KEY CLUSTERED 
(
	[Idioma] ASC,
	[Diccionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Material]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[MaterialTemporal]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[MaterialTemporal](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MaterialTemporal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[Paso]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[Patente]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[ReservaMaterial]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[ReservaMaterial](
	[Evento] [int] NOT NULL,
	[Material] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_ReservaMaterial_1] PRIMARY KEY CLUSTERED 
(
	[Evento] ASC,
	[Material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[ReservaServicio]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[Salon]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[Servicio]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 16/7/2017 10:53:46 p. m. ******/
CREATE TABLE [dbo].[TipoEvento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](500) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
/****** Object:  Table [dbo].[TipoEventoPaso]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/7/2017 10:53:46 p. m. ******/
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

SET IDENTITY_INSERT [dbo].[Diccionario] ON 
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (1, N'Aceptar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (2, N'Agregar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (3, N'Agregar descripcion')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (4, N'Agregar paso')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (5, N'Apellido')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (6, N'Borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (7, N'Borrar evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (8, N'Borrar paso')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (9, N'Buscar cliente')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (10, N'Buscar material')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (11, N'Calle')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (12, N'Cambiar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (13, N'Cancelar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (14, N'Cantidad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (15, N'Cantidad de invitados')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (16, N'Clave')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (17, N'Cliente')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (18, N'Contraseña')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (19, N'Datos del cliente')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (20, N'Datos del evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (21, N'Datos del servicio')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (22, N'Descripcion')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (23, N'DNI')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (24, N'Elegir evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (25, N'Eliminar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (26, N'Email')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (27, N'Enviar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (28, N'Familia')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (29, N'Fecha')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (30, N'Fecha limite')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (31, N'Guardar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (32, N'Id')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (33, N'Idioma')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (34, N'Imprimir')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (35, N'Ingrese el nombre')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (36, N'Ingrese el nombre de la familia')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (37, N'Lista de clientes')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (38, N'Lista de familias')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (39, N'Lista de materiales')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (40, N'Lista de pasos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (41, N'Lista de salones')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (42, N'Lista de tipos de evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (43, N'Lista de usuarios')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (44, N'Localidad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (45, N'Material')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (46, N'Materiales')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (47, N'Materiales reservados')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (48, N'Modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (49, N'Modificar evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (50, N'Nombre')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (51, N'Nombre de usuario')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (52, N'Numero')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (53, N'Observacion')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (54, N'Paso')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (55, N'Precio')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (56, N'Precio unitario')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (57, N'Prioridad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (58, N'Repita la contraseña')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (59, N'Reservar material')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (60, N'Reservar servicio')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (61, N'Salón')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (62, N'Seleccionar evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (63, N'Seleccionar salon')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (64, N'Seleccionar tipo y fecha del evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (65, N'Seleccione el formulario')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (66, N'Seleccione las patentes')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (67, N'Servicios contratados')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (68, N'Tarea nueva')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (69, N'Tarea terminada')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (70, N'Tareas del día')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (71, N'Telefono')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (72, N'Terminar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (73, N'Tipo de evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (74, N'Total')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (75, N'Total de materiales')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (76, N'Total de servicios')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (77, N'Total del salon')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (78, N'Valor')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (79, N'Ver disponibilidad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (80, N'Ver evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (81, N'Ver pasos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (82, N'Archivo')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (83, N'Ver')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (84, N'Opciones')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (85, N'Evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (86, N'Datos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (87, N'Seguridad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (88, N'Organizar evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (89, N'Generar presupuesto')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (90, N'Servicio')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (91, N'Patente')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (92, N'Usuario')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (93, N'Disponibilidad de materiales')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (94, N'Eventos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (95, N'Crear idioma')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (96, N'El email ingresado es incorrecto')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (97, N'El numero de telefono ingresado es incorrecto')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (98, N'Nombre o apellido ingresados incorrectos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (99, N'Por favor complete todos los campos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (100, N'DNI incorrecto, no puede contener letras')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (101, N'Debe ingresar un id, un nombre de material, una cantidad y un precio')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (102, N'Baja')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (103, N'Media')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (104, N'Alta')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (105, N'Ingrese los datos del paso')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (106, N'Seleccione un evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (107, N'La Familia tiene que tener un nombre')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (108, N'Error al eliminar el elemento seleccionado')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (109, N'El nombre de usuario tiene que tener al menos 6 caracteres y solo puede contener letras y números')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (110, N'La contraseña tiene que tener al menos 6 caracteres y solo puede contener letras y números')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (111, N'Las contraseñas no coinciden')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (112, N'Cerrando sesion')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (113, N'Ingrese usuario y contraseña por favor')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (114, N'Gestionar idiomas')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (115, N'Seleccionar servicio')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (116, N'Direccion')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (117, N'Capacidad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (118, N'Lista de servicios')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (119, N'Dias')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (120, N'Cambiar valor')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (121, N'Agregar patente')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (122, N'Agregar grupo de patentes')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (123, N'Eliminar elemento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (124, N'Nombre del evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (125, N'Ver todos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (126, N'Filtrar por localidad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (127, N'El nombre de usuario ingresado ya existe')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (128, N'El DNI del cliente ingresado ya existe')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (129, N'El nombre o el id del material ingresado ya existe')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (130, N'El paso ingresado ya existe en el evento seleccionado')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (131, N'El nombre del servicio ingresado ya existe')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (132, N'El nombre del tipo de evento ingresado ya existe')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (133, N'El paso ingresado ya existe en el tipo de evento seleccionado')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (134, N'El nombre de familia ingresado ya existe')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (135, N'El nombre del grupo de patentes ingresado ya existe')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (136, N'Ingrese la localidad')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (137, N'Para ver el nuevo idioma cierre sesión y vuelva a iniciar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (138, N'Seleccione el paso que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (139, N'Seleccione el paso que desea borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (140, N'Seleccione el cliente que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (141, N'Seleccione el cliente que desea borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (142, N'Seleccione el material que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (143, N'Seleccione el material que desea borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (144, N'Seleccione el salón que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (145, N'Seleccione el salón que desea borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (146, N'Seleccione el servicio que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (147, N'Seleccione el servicio que desea borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (148, N'Seleccione el tipo de evento que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (149, N'Seleccione el tipo de evento que desea borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (150, N'Seleccione el usuario que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (151, N'Seleccione el usuario que desea borrar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (152, N'Seleccione el elemento que desea eliminar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (153, N'Ingrese los datos del usuario')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (154, N'Ingrese los datos del material a reservar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (155, N'Ingrese el DNI del cliente')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (156, N'Ingrese los datos del evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (157, N'Ingrese un nombre y seleccione un formulario para la patente nueva')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (158, N'Ingrese un nombre para el grupo de patentes nuevo')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (159, N'No se le pueden agregar grupos de patente al elemento seleccionado, seleccione un grupo')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (160, N'No se le pueden agregar patentes al elemento seleccionado, seleccione un grupo')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (161, N'Seleccione la familia que desea eliminar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (162, N'Seleccione la familia que desea modificar')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (163, N'Seleccione un elemento del árbol para agregarle una patente')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (164, N'Seleccione un elemento del árbol para agregarle un grupo de patentes')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (165, N'El cliente seleccionado tiene eventos relacionados ¿Desea borrar el cliente junto con sus eventos?')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (166, N'El material seleccionado tiene reservas pendientes ¿Desea eliminar el material y cancelar las reservas?')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (167, N'El salón seleccionado posee eventos relacionados ¿Desea eliminarlo de todas formas?')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (168, N'El servicio seleccionado posee reservas pendientes ¿Desea eliminarlo de todas formas y cancelar las reservas?')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (169, N'Como el tipo de evento seleccionado tiene eventos relacionados se deshabilitará hasta que se realicen o cancelen estos eventos')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (170, N'Generico')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (171, N'Concreto')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (172, N'Seleccione un tipo de evento')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (173, N'Seleccione un salón')
INSERT [dbo].[Diccionario] ([Id], [Clave]) VALUES (174, N'La familia seleccionada no se puede eliminar, tiene usuarios asociados')
SET IDENTITY_INSERT [dbo].[Diccionario] OFF

SET IDENTITY_INSERT [dbo].[DireccionSalon] ON 
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [Localidad]) VALUES (3, N'asdasd', 1212, N'asda')
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [Localidad]) VALUES (1003, N'Suipacha', 1172, N'CABA')
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [Localidad]) VALUES (1005, N'Callao', 1234, N'CABA')
INSERT [dbo].[DireccionSalon] ([Id], [Calle], [Numero], [Localidad]) VALUES (1006, N'Callao', 1125, N'CABA')
SET IDENTITY_INSERT [dbo].[DireccionSalon] OFF

INSERT [dbo].[DireccionServicio] ([Id], [Calle], [Numero], [Localidad]) VALUES (1, N'Pueyrredon', 1170, N'CABA')

INSERT [dbo].[Evento] ([Id], [Nombre], [Fecha], [Cant_Invitados], [Tipo], [Salon], [Cliente]) VALUES (1, N'Cumpleaños 1', CAST(N'2018-01-06' AS Date), 50, 3, 1013, 39507742)

INSERT [dbo].[EventoPaso] ([Evento], [Paso], [Fecha]) VALUES (1, 4, CAST(N'2017-07-29' AS Date))

SET IDENTITY_INSERT [dbo].[Familia] ON 
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Familia] ([Id], [Nombre]) VALUES (9, N'Usuario')
SET IDENTITY_INSERT [dbo].[Familia] OFF

INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 1, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 5, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 10, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 11, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 12, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 13, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (1, 14, 5)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (9, 1, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (9, 5, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (9, 10, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (9, 11, 1)
INSERT [dbo].[FamiliaGrupoPatente] ([Familia], [GrupoPatente], [Padre]) VALUES (9, 13, 1)

INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 22, 5)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 38, 10)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 39, 10)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 40, 10)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 41, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 42, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 43, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 44, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 45, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 46, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 48, 12)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 49, 12)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 50, 12)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 51, 13)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 52, 13)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 53, 13)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 54, 14)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (1, 55, 12)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 22, 5)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 38, 10)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 39, 10)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 40, 10)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 41, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 42, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 43, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 44, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 45, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 46, 11)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 51, 13)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 52, 13)
INSERT [dbo].[FamiliaPatente] ([Familia], [Patente], [Padre]) VALUES (9, 53, 13)

SET IDENTITY_INSERT [dbo].[GrupoPatente] ON 
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (1, N'Patentes del Sistema', NULL)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (5, N'Archivo', 1)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (10, N'Evento', 1)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (11, N'Datos', 1)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (12, N'Seguridad', 1)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (13, N'Ver', 1)
INSERT [dbo].[GrupoPatente] ([Id], [Nombre], [Padre]) VALUES (14, N'Ver', 5)
SET IDENTITY_INSERT [dbo].[GrupoPatente] OFF

INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (1, N'Español')
INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (2, N'Inglés')

INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 1, N'Aceptar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 2, N'Agregar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 3, N'Agregar descripción')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 4, N'Agregar paso')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 5, N'Apellido')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 6, N'Borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 7, N'Borrar evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 8, N'Borrar paso')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 9, N'Buscar cliente')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 10, N'Buscar material')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 11, N'Calle')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 12, N'Cambiar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 13, N'Cancelar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 14, N'Cantidad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 15, N'Cantidad de invitados')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 16, N'Clave')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 17, N'Cliente')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 18, N'Contraseña')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 19, N'Datos del cliente')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 20, N'Datos del evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 21, N'Datos del servicios')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 22, N'Descripción')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 23, N'DNI')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 24, N'Elegir evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 25, N'Eliminar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 26, N'Correo electrónico')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 27, N'Enviar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 28, N'Familia')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 29, N'Fecha')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 30, N'Fecha límite')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 31, N'Guardar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 32, N'Id')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 33, N'Idioma')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 34, N'Imprimir')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 35, N'Ingrese el nombre')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 36, N'Ingrese el nombre de la familia')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 37, N'Lista de clientes')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 38, N'Lista de familias')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 39, N'Lista de materiales')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 40, N'Lista de pasos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 41, N'Lista de salones')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 42, N'Lista de tipos de evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 43, N'Lista de usuarios')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 44, N'Localidad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 45, N'Material')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 46, N'Materiales')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 47, N'Materiales reservados')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 48, N'Modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 49, N'Modificar evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 50, N'Nombre')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 51, N'Nombre de usuario')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 52, N'Número')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 53, N'Observación')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 54, N'Paso')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 55, N'Precio')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 56, N'Precio unitario')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 57, N'Prioridad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 58, N'Repita la contraseña')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 59, N'Reservar material')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 60, N'Reservar servicio')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 61, N'Salón')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 62, N'Seleccionar evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 63, N'Seleccionar salón')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 64, N'Seleccionar tipo y fecha del evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 65, N'Seleccione el formulario')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 66, N'Seleccione las patentes')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 67, N'Servicios contratados')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 68, N'Tarea nueva')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 69, N'Tarea terminada')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 70, N'Tareas del día')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 71, N'Teléfono')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 72, N'Terminar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 73, N'Tipo de evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 74, N'Total')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 75, N'Total de materiales')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 76, N'Total de servicios')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 77, N'Total del salón')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 78, N'Valor')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 79, N'Ver disponibilidad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 80, N'Ver evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 81, N'Ver pasos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 82, N'Archivo')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 83, N'Ver')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 84, N'Opciones')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 85, N'Evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 86, N'Datos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 87, N'Seguridad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 88, N'Organizar evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 89, N'Generar presupuesto')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 90, N'Servicio')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 91, N'Patente')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 92, N'Usuario')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 93, N'Disponibilidad de materiales')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 94, N'Eventos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 95, N'Crear idioma')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 96, N'El email ingresado es incorrecto')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 97, N'El número de teléfono ingresado es incorrecto')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 98, N'Nombre o apellido ingresados incorrectos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 99, N'Por favor complete todos los campos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 100, N'DNI incorrecto, no puede contener letras')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 101, N'Debe ingresar un id, un nombre de material, una cantidad y un precio')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 102, N'Baja')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 103, N'Media')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 104, N'Alta')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 105, N'Ingrese los datos del paso')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 106, N'Seleccione un evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 107, N'La familia tiene que contener un nombre')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 108, N'Error al eliminar el elemento seleccionado')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 109, N'El nombre de usuario es incorrecto')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 110, N'El nombre de usuario tiene que tener al menos 6 caracteres y solo puede contener letras y números')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 111, N'Las contraseñas no coinciden')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 112, N'Cerrando sesión')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 113, N'Ingrese usuario y contraseña por favor')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 114, N'Gestionar idiomas')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 115, N'Seleccionar servicio')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 116, N'Dirección')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 117, N'Capacidad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 118, N'Lista de servicios')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 119, N'Días')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 120, N'Cambiar valor')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 121, N'Agregar patente')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 122, N'Agregar grupo de patentes')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 123, N'Eliminar elemento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 124, N'Nombre del evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 125, N'Ver todos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 126, N'Filtrar por localidad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 127, N'El nombre de usuario ingresado ya existe')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 128, N'El DNI del cliente ingresado ya existe')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 129, N'El nombre o el id del material ingresado ya existe')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 130, N'El paso ingresado ya existe en el evento seleccionado')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 131, N'El nombre del servicio ingresado ya existe')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 132, N'El nombre del tipo de evento ingresado ya existe')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 133, N'El paso ingresado ya existe en el tipo de evento seleccionado')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 134, N'El nombre de familia ingresado ya existe')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 135, N'El nombre del grupo de patentes ingresado ya existe')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 136, N'Ingrese la localidad')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 137, N'Para ver el nuevo idioma cierre sesión y vuelva a iniciar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 138, N'Seleccione el paso que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 139, N'Seleccione el paso que desea borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 140, N'Seleccione el cliente que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 141, N'Seleccione el cliente que desea borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 142, N'Seleccione el material que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 143, N'Seleccione el material que desea borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 144, N'Seleccione el salón que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 145, N'Seleccione el salón que desea borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 146, N'Seleccione el servicio que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 147, N'Seleccione el servicio que desea borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 148, N'Seleccione el tipo de evento que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 149, N'Seleccione el tipo de evento que desea borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 150, N'Seleccione el usuario que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 151, N'Seleccione el usuario que desea borrar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 152, N'Seleccione el elemento que desea eliminar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 153, N'Ingrese los datos del usuario')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 154, N'Ingrese los datos del material a reservar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 155, N'Ingrese el DNI del cliente')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 156, N'Ingrese los datos del evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 157, N'Ingrese un nombre y seleccione un formulario para la patente nueva')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 158, N'Ingrese un nombre para el grupo de patentes nuevo')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 159, N'No se le pueden agregar grupos de patente al elemento seleccionado, seleccione un grupo')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 160, N'No se le pueden agregar patentes al elemento seleccionado, seleccione un grupo')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 161, N'Seleccione la familia que desea eliminar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 162, N'Seleccione la familia que desea modificar')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 163, N'Seleccione un elemento del árbol para agregarle una patente')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 164, N'Seleccione un elemento del árbol para agregarle un grupo de patentes')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 165, N'El cliente seleccionado tiene eventos relacionados ¿Desea borrar el cliente junto con sus eventos?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 166, N'El material seleccionado tiene reservas pendientes ¿Desea borrar el material y cancelar las reservas?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 167, N'El salón seleccionado posee eventos relacionados ¿Desea eliminarlo de todas formas?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 168, N'El servicio seleccionado posee reservas pendientes ¿Desea eliminarlo de todas formas y cancelar las reservas?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 169, N'Como el tipo de evento seleccionado tiene eventos relacionados se deshabilitará hasta que se realicen o cancelen estos eventos')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 170, N'Genérico')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 171, N'Concreto')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 172, N'Seleccione un tipo de evento')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 173, N'Seleccione un salón')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (1, 174, N'La familia seleccionada no se puede eliminar, tiene usuarios asociados')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 1, N'Accept')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 2, N'Add')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 3, N'Add description')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 4, N'Add step')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 5, N'Last name')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 6, N'Delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 7, N'Delete event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 8, N'Delete step')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 9, N'Search client')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 10, N'Search material')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 11, N'Street')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 12, N'Change')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 13, N'Cancel')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 14, N'Quantity')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 15, N'Number of guests')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 16, N'Key')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 17, N'Client')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 18, N'Password')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 19, N'Client info')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 20, N'Event info')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 21, N'Service info')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 22, N'Description')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 23, N'DNI')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 24, N'Choose event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 25, N'Remove')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 26, N'Email')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 27, N'Send')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 28, N'Family')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 29, N'Date')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 30, N'Deadline')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 31, N'Save')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 32, N'Id')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 33, N'Language')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 34, N'Print')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 35, N'Input your name')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 36, N'Input family name')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 37, N'Client list')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 38, N'Family list')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 39, N'Material list')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 40, N'Step list')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 41, N'Venue list')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 42, N'Event type list')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 43, N'User list')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 44, N'Town')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 45, N'Item')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 46, N'Items')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 47, N'Reserved items')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 48, N'Modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 49, N'Modify event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 50, N'Name')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 51, N'Username')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 52, N'Number')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 53, N'Comment')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 54, N'Step')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 55, N'Price')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 56, N'Unitary price')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 57, N'Priority')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 58, N'Repeat password')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 59, N'Reserve item')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 60, N'Reserve service')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 61, N'Venue')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 62, N'Select event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 63, N'Select venue')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 64, N'Select type and date of the event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 65, N'Select form')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 66, N'Select patents')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 67, N'Hired services')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 68, N'New taks')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 69, N'End task')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 70, N'Tasks of the day')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 71, N'Phone number')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 72, N'End')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 73, N'Event type')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 74, N'Total')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 75, N'Items')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 76, N'Services')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 77, N'Venue')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 78, N'Value')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 79, N'View availability')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 80, N'View event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 81, N'View steps')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 82, N'File')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 83, N'View')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 84, N'Options')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 85, N'Event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 86, N'Data')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 87, N'Security')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 88, N'Plan event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 89, N'Generate budget')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 90, N'Service')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 91, N'Patent')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 92, N'User')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 93, N'Items availability')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 94, N'Events')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 95, N'Create language')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 96, N'The email you entered is incorrect')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 97, N'The phone number you entered is incorrect')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 98, N'Entered name or last name incorrect')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 99, N'Please fill all the fields')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 100, N'Wrong DNI, only letters allowed')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 101, N'You must enter an id, a material name, a quantity and a price')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 102, N'Low')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 103, N'Medium')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 104, N'High')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 105, N'Enter steps info')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 106, N'Select an event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 107, N'The family must have a name')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 108, N'Error deleting the selected item')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 109, N'Wrong username')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 110, N'The username must contain at least 6 characters and it can only contain letters and numbers')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 111, N'Passwords don''t match')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 112, N'Logging out')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 113, N'Please enter username and password')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 114, N'Manage languages')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 115, N'Select service')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 116, N'Direction')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 117, N'Capacity')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 118, N'List of services')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 119, N'Days')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 120, N'Change value')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 121, N'Add patent')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 122, N'Add patent group')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 123, N'Delete element')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 124, N'Event name')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 125, N'View all')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 126, N'Filter by town')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 127, N'Username already exists')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 128, N'The DNI you entered already exists')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 129, N'The name or the id of the item you entered already exists')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 130, N'The step you entered already exists in the selected event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 131, N'The name of the service you entered already exists')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 132, N'The name of the type of event you entered already exists')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 133, N'The step you entered already exists in the selected type of event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 134, N'The name of the family you entered already exists')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 135, N'The name of the group you entered already exists')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 136, N'Input the town')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 137, N'To view the new language please log out and log in again')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 138, N'Select the step you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 139, N'Select the step you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 140, N'Select the client you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 141, N'Select the client you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 142, N'Select the item you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 143, N'Select the item you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 144, N'Select the venue you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 145, N'Select the venue you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 146, N'Select the service you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 147, N'Select the service you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 148, N'Select the type of event you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 149, N'Select the type of event you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 150, N'Select the user you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 151, N'Select the user you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 152, N'Select the element you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 153, N'Enter user info')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 154, N'Enter the items info for your reservation')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 155, N'Enter client''s DNI')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 156, N'Enter event info')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 157, N'Enter a name and select a form for the new patent')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 158, N'Enter a name for the new patent group')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 159, N'The selected item can''t add patent groups, please select a group')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 160, N'The selected item can''t add patents, please select a group')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 161, N'Select the family you want to delete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 162, N'Select the family you want to modify')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 163, N'Select an elemento to add a patent')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 164, N'Select an elemento to add a patent group')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 165, N'Selected client has some related events. Do you wish to delete the client and the related events?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 166, N'Selected item has some pending reserves. Do you wish to delete the item and cancel the reserves?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 167, N'Selected venue has some related events. Do you wish to delete it anyway?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 168, N'Selected service has some pending reserves. Do you wish to delete it anyway and cancel the reserves?')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 169, N'The selected type of event has somw related events. It will be disabled until those events are canceled or finished')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 170, N'Generic')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 171, N'Concrete')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 172, N'Select a type of event')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 173, N'Select a venue')
INSERT [dbo].[IdiomaDiccionario] ([Idioma], [Diccionario], [Valor]) VALUES (2, 174, N'The selected family can''t be deleted because it has users asociated to it')

INSERT [dbo].[Material] ([Id], [Nombre], [Cantidad], [Precio]) VALUES (444, N'Manteles', 200, 20)

INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (2, N'Llamar al cliente', N'Baja', N'Genérico')
INSERT [dbo].[Paso] ([Id], [Descripcion], [Prioridad], [Tipo]) VALUES (4, N'Paso 2', N'Baja', N'Concreto')

SET IDENTITY_INSERT [dbo].[Patente] ON 
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (22, N'Organizar evento', N'OrganizarEvento', 5)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (38, N'Generar presupuesto', N'Presupuesto', 10)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (39, N'Reservar material', N'ReservarMaterial', 10)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (40, N'Reservar servicio', N'ReservarServicio', 10)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (41, N'Cliente', N'ABMCliente', 11)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (42, N'Material', N'ABMMaterial', 11)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (43, N'Paso', N'ABMPaso', 11)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (44, N'Salón', N'ABMSalon', 11)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (45, N'Servicio', N'ABMServicio', 11)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (46, N'Tipo de evento', N'ABMTipoEvento', 11)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (48, N'Familia', N'ABMFamilia', 12)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (49, N'Patente', N'ABMPatente', 12)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (50, N'Usuario', N'ABMUsuario', 12)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (51, N'Disponibilidad de materiales', N'DisponibilidadMateriales', 13)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (52, N'Eventos', N'VerEventos', 13)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (53, N'Tareas del día', N'TareasDelDia', 13)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (54, N'Eventos', N'VerEventos', 14)
INSERT [dbo].[Patente] ([Id], [Nombre], [Formulario], [Padre]) VALUES (55, N'Gestionar idiomas', N'Idiomas', 12)
SET IDENTITY_INSERT [dbo].[Patente] OFF

SET IDENTITY_INSERT [dbo].[Salon] ON 
INSERT [dbo].[Salon] ([Id], [Nombre], [Capacidad], [Email], [Telefono], [Direccion], [Descripcion], [Precio]) VALUES (1013, N'Salón1', 454, N'salon1@gmail.com', 46631281, 1006, N'', 555555)
SET IDENTITY_INSERT [dbo].[Salon] OFF

SET IDENTITY_INSERT [dbo].[TipoEvento] ON 
INSERT [dbo].[TipoEvento] ([Id], [Nombre], [Descripcion], [Activo]) VALUES (0, N'Casamiento', N'Es un casamiento', 0)
INSERT [dbo].[TipoEvento] ([Id], [Nombre], [Descripcion], [Activo]) VALUES (3, N'Cumpleaños', N'Es un cumpleaños', 1)
SET IDENTITY_INSERT [dbo].[TipoEvento] OFF

INSERT [dbo].[TipoEventoPaso] ([TipoEv], [Paso], [Dias]) VALUES (0, 2, 20)

INSERT [dbo].[Usuario] ([Id], [Email], [Password], [Familia]) VALUES (N'Administrador', N'facundo.tripelhorn@gmail.com', N'91F5167C34C400758115C2A6826EC2E3', 1)

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
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Familia];