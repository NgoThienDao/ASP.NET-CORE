USE [ForeignLanguageCenter]
GO
/****** Object:  Table [dbo].[Male]    Script Date: 10/18/2019 20:30:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Male](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Male] [nvarchar](10) NULL,
 CONSTRAINT [PK_Male] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Male] ON
INSERT [dbo].[Male] ([ID], [Male]) VALUES (1, N'Nam')
INSERT [dbo].[Male] ([ID], [Male]) VALUES (2, N'Nữ')
SET IDENTITY_INSERT [dbo].[Male] OFF
/****** Object:  Table [dbo].[LevelLanguage]    Script Date: 10/18/2019 20:30:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[LevelLanguage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LevelLanguage] [varchar](3) NULL,
 CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[LevelLanguage] ON
INSERT [dbo].[LevelLanguage] ([ID], [LevelLanguage]) VALUES (1, N'A')
INSERT [dbo].[LevelLanguage] ([ID], [LevelLanguage]) VALUES (2, N'B')
INSERT [dbo].[LevelLanguage] ([ID], [LevelLanguage]) VALUES (3, N'C')
SET IDENTITY_INSERT [dbo].[LevelLanguage] OFF
/****** Object:  Table [dbo].[LanguageRegistration]    Script Date: 10/18/2019 20:30:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageRegistration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nvarchar](20) NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LanguageRegistration] ON
INSERT [dbo].[LanguageRegistration] ([ID], [Language]) VALUES (1, N'Anh')
INSERT [dbo].[LanguageRegistration] ([ID], [Language]) VALUES (2, N'Pháp')
INSERT [dbo].[LanguageRegistration] ([ID], [Language]) VALUES (3, N'Nhật')
INSERT [dbo].[LanguageRegistration] ([ID], [Language]) VALUES (4, N'Hàn')
INSERT [dbo].[LanguageRegistration] ([ID], [Language]) VALUES (5, N'Nga')
SET IDENTITY_INSERT [dbo].[LanguageRegistration] OFF
/****** Object:  Table [dbo].[Student]    Script Date: 10/18/2019 20:30:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](50) NULL,
	[DOB] [date] NULL,
	[Email] [varchar](100) NULL,
	[IDLanguage] [int] NULL,
	[IDLevel] [int] NULL,
	[IDMale] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT [dbo].[Student] ([ID], [StudentName], [DOB], [Email], [IDLanguage], [IDLevel], [IDMale]) VALUES (1, N'Ngô Thiện Đạo', CAST(0x481F0B00 AS Date), N'thiendao39@gmail.com', 1, 2, 1)
INSERT [dbo].[Student] ([ID], [StudentName], [DOB], [Email], [IDLanguage], [IDLevel], [IDMale]) VALUES (2, N'Lareina Morton', CAST(0x08230B00 AS Date), N'qudov@mailinator.com', 1, 1, 1)
INSERT [dbo].[Student] ([ID], [StudentName], [DOB], [Email], [IDLanguage], [IDLevel], [IDMale]) VALUES (3, N'Zena Petty', CAST(0xF9380B00 AS Date), N'mudasomoki@mailinator.net', 3, 3, 2)
SET IDENTITY_INSERT [dbo].[Student] OFF
/****** Object:  StoredProcedure [dbo].[GetMaleDetails]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetMaleDetails]
AS
BEGIN
	SELECT ID,
			Male
	FROM dbo.Male
END
GO
/****** Object:  StoredProcedure [dbo].[GetLevelDetails]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetLevelDetails]
AS
BEGIN
	SELECT ID,
			LevelLanguage
	FROM dbo.LevelLanguage
END
GO
/****** Object:  StoredProcedure [dbo].[GetLanguageDetails]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetLanguageDetails]
AS
BEGIN
	SELECT ID,
			Language
	FROM dbo.LanguageRegistration
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateStudent]
(
	@ID INT,
	@StudentName NVARCHAR(50),
	@DOB DATE,
	@Email VARCHAR(100),
	@IDLanguage INT,
	@IDLevel INT,
	@IDMale INT
)
AS
BEGIN
	UPDATE dbo.Student
	SET StudentName = @StudentName,
		DOB = @DOB,
		Email = @Email,
		IDLanguage = @IDLanguage,
		IDLevel = @IDLevel,
		IDMale = @IDMale
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAndSearchStudentDetails]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAndSearchStudentDetails]
(
	@keyword NVARCHAR(50)
)
AS
BEGIN
	IF (ISNULL(@keyword,'') = '' OR @keyword = '')
		BEGIN
			SELECT s.ID,
				s.StudentName,
				s.DOB,
				s.Email,
				lr.Language AS LanguageRegistration,
				m.Male,
				l.LevelLanguage
			FROM dbo.Student s INNER JOIN dbo.LevelLanguage l ON s.IDLevel = l.ID
						INNER JOIN dbo.Male m ON m.ID = s.IDMale 
						INNER JOIN dbo.LanguageRegistration lr ON lr.ID = s.IDLanguage
		END
	ELSE
		BEGIN
			SELECT s.ID,
				s.StudentName,
				s.DOB,
				s.Email,
				lr.Language AS LanguageRegistration,
				m.Male,
				l.LevelLanguage
			FROM dbo.Student s INNER JOIN dbo.LevelLanguage l ON s.IDLevel = l.ID
						INNER JOIN dbo.Male m ON m.ID = s.IDMale 
						INNER JOIN dbo.LanguageRegistration lr ON lr.ID = s.IDLanguage
			WHERE (s.StudentName LIKE '%' + @keyword + '%')
				OR (s.Email LIKE '%' + @keyword + '%')
		END
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStudent]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteStudent]
(
	@ID INT
)
AS
BEGIN
	DELETE FROM dbo.Student WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[InsertStudent]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertStudent]
(
	@StudentName NVARCHAR(50),
	@DOB DATE,
	@Email VARCHAR(100),
	@IDLanguage INT,
	@IDLevel INT,
	@IDMale INT
)
AS
BEGIN
	INSERT INTO dbo.Student
	        ( StudentName ,
	          DOB ,
	          Email ,
	          IDLanguage ,
	          IDLevel ,
	          IDMale
	        )
	VALUES  ( @StudentName,
				@DOB,
				@Email,
				@IDLanguage,
				@IDLevel,
				@IDMale
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudentByID]    Script Date: 10/18/2019 20:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetStudentByID]
(
	@ID INT
)
AS
BEGIN
	SELECT s.ID,
			s.StudentName,
			s.DOB,
			s.Email,
			lr.Language AS LanguageRegistration,
			m.Male,
			l.LevelLanguage
	FROM dbo.Student s INNER JOIN dbo.LevelLanguage l ON s.IDLevel = l.ID
						INNER JOIN dbo.Male m ON m.ID = s.IDMale 
						INNER JOIN dbo.LanguageRegistration lr ON lr.ID = s.IDLanguage
	WHERE s.ID = @ID
END
GO
/****** Object:  ForeignKey [FK__Student__IDLangu__1BFD2C07]    Script Date: 10/18/2019 20:30:08 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([IDLanguage])
REFERENCES [dbo].[LanguageRegistration] ([ID])
GO
/****** Object:  ForeignKey [FK__Student__IDLevel__1CF15040]    Script Date: 10/18/2019 20:30:08 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([IDLevel])
REFERENCES [dbo].[LevelLanguage] ([ID])
GO
/****** Object:  ForeignKey [FK__Student__IDMale__1DE57479]    Script Date: 10/18/2019 20:30:08 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([IDMale])
REFERENCES [dbo].[Male] ([ID])
GO
