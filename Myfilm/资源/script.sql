USE [myFilm]
GO
/****** Object:  Table [dbo].[comments]    Script Date: 2015/7/20 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comments](
	[userId] [int] NOT NULL,
	[filmId] [int] NOT NULL,
	[comments] [text] NOT NULL,
 CONSTRAINT [PK_comments] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[filmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[films]    Script Date: 2015/7/20 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[films](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[filmName] [nvarchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[length] [bigint] NOT NULL,
	[description] [text] NOT NULL,
	[director] [text] NOT NULL,
	[hall] [int] NOT NULL,
	[startTime] [datetime] NOT NULL,
	[logo] [nvarchar](128) NOT NULL,
	[amount] [int] NOT NULL,
	[score] [float] NULL,
 CONSTRAINT [PK_films] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[scores]    Script Date: 2015/7/20 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[scores](
	[userId] [int] NOT NULL,
	[filmId] [int] NOT NULL,
	[score] [float] NOT NULL,
 CONSTRAINT [PK_scores_1] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[filmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[seat]    Script Date: 2015/7/20 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seat](
	[userId] [int] NOT NULL,
	[filmId] [int] NOT NULL,
	[hall] [int] NOT NULL,
	[flag] [int] NOT NULL,
 CONSTRAINT [PK_seat] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[filmId] ASC,
	[hall] ASC,
	[flag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user]    Script Date: 2015/7/20 19:35:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[type] [int] NOT NULL,
	[money] [int] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[user] ADD  CONSTRAINT [DF_user_money]  DEFAULT ((0)) FOR [money]
GO
