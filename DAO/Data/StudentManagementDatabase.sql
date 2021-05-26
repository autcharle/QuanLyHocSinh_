USE [QuanLyHocSinh]
GO
/****** Object:  Table [dbo].[Age]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Age](
	[IDAge] [int] IDENTITY(1,1) NOT NULL,
	[AgeMax] [int] NULL,
	[AgeMin] [int] NULL,
 CONSTRAINT [PK_Age] PRIMARY KEY CLUSTERED 
(
	[IDAge] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClassRoom]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classroom](
	[IDClassroom] [int] IDENTITY(1,1) NOT NULL,
	[NameClass] [nchar](10) NULL,
 CONSTRAINT [PK_Classroom] PRIMARY KEY CLUSTERED 
(
	[IDClassroom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mark]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mark](
	[IDMark] [int] IDENTITY(1,1) NOT NULL,
	[IDSubject] [int] NULL,
	[Score15min] [float] NULL,
	[Score60min] [float] NULL,
	[ScoreFinal] [float] NULL,
 CONSTRAINT [PK_Mark] PRIMARY KEY CLUSTERED 
(
	[IDMark] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumberStudentMax]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumberStudentMax](
	[IDNumberStudentMax] [int] IDENTITY(1,1) NOT NULL,
	[AmountMax] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScorePass]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScorePass](
	[IDScore] [int] IDENTITY(1,1) NOT NULL,
	[Score] [float] NULL,
 CONSTRAINT [PK_ScorePass] PRIMARY KEY CLUSTERED 
(
	[IDScore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semester]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semester](
	[IDSemester] [int] IDENTITY(1,1) NOT NULL,
	[NameSemester] [nchar](10) NULL,
 CONSTRAINT [PK_Semester] PRIMARY KEY CLUSTERED 
(
	[IDSemester] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SemesterClassRoom]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SemesterClassroom](
	[IDSemesterClassroom] [int] IDENTITY(1,1) NOT NULL,
	[IDClassroom] [int] NULL,
	[IDSemester] [int] NULL,
 CONSTRAINT [PK_SemesterClassroom] PRIMARY KEY CLUSTERED 
(
	[IDSemesterClassroom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[IDStudent] [int] IDENTITY(1,1) NOT NULL,
	[IDClassroom] [int] NULL,
	[IDMark] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[Gender] [int] NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[IDStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 5/26/2021 7:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[IDSubject] [int] IDENTITY(1,1) NOT NULL,
	[IDSemesterClassroom] [int] NULL,
	[NameSubject] [nvarchar](50) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[IDSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Age] ON 

INSERT [dbo].[Age] ([IDAge], [AgeMax], [AgeMin]) VALUES (1, 15, 20)
SET IDENTITY_INSERT [dbo].[Age] OFF
GO
SET IDENTITY_INSERT [dbo].[ClassRoom] ON 

INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (1, N'10A1      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (2, N'10A2      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (3, N'10A3      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (4, N'10A4      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (5, N'11A1      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (6, N'11A2      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (7, N'11A3      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (8, N'12A1      ')
INSERT [dbo].[Classroom] ([IDClassroom], [NameClass]) VALUES (9, N'12A2      ')
SET IDENTITY_INSERT [dbo].[Classroom] OFF
GO
SET IDENTITY_INSERT [dbo].[NumberStudentMax] ON 

INSERT [dbo].[NumberStudentMax] ([IDNumberStudentMax], [AmountMax]) VALUES (1, 40)
SET IDENTITY_INSERT [dbo].[NumberStudentMax] OFF
GO
SET IDENTITY_INSERT [dbo].[ScorePass] ON 

INSERT [dbo].[ScorePass] ([IDScore], [Score]) VALUES (1, 5)
SET IDENTITY_INSERT [dbo].[ScorePass] OFF
GO
SET IDENTITY_INSERT [dbo].[Semester] ON 

INSERT [dbo].[Semester] ([IDSemester], [NameSemester]) VALUES (1, N'HK1       ')
INSERT [dbo].[Semester] ([IDSemester], [NameSemester]) VALUES (2, N'HK2       ')
SET IDENTITY_INSERT [dbo].[Semester] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (1, NULL, N'Toán')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (2, NULL, N'Lý')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (3, NULL, N'Hóa')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (4, NULL, N'Sinh')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (5, NULL, N'Sử')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (6, NULL, N'Địa')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (7, NULL, N'Văn')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (8, NULL, N'Đạo Đức')
INSERT [dbo].[Subject] ([IDSubject], [IDSemesterClassroom], [NameSubject]) VALUES (9, NULL, N'Thể Dục')
SET IDENTITY_INSERT [dbo].[Subject] OFF
