SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furnitura](
	[idfur] [int] IDENTITY(1,1) NOT NULL,
	[namefur] [nvarchar](50) NULL,
	[photo] [varbinary](MAX) NULL,
	[countfur] [int] NULL,
 CONSTRAINT [PK_Furnitura] PRIMARY KEY CLUSTERED 
(
	[idfur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Furnitura] ON 

INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (1, N'Бусинки 1 ', NULL, 20)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (2, N'Бусинки 2 ', NULL, 31)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (3, N'Бусинки 3 ', NULL, 150)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (4, N'Бусинки 4 ', NULL, 210)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (5, N'Бусинки 5 ', NULL, 115)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (6, N'Пряжка 1  ', NULL, 432)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (7, N'Пряжка 2  ', NULL, 54)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (8, N'Пряжка 3  ', NULL, 542)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (9, N'Пряжка 4  ', NULL, 458)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (10, N'Пуговицы 1', NULL, 54)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (11, N'Пуговицы 2', NULL, 354)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (12, N'Пуговицы 3', NULL, 78)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (13, N'Пуговицы 4', NULL, 576)
INSERT [dbo].[Furnitura] ([idfur], [namefur], [photo], [countfur]) VALUES (14, N'Пуговицы 5', NULL, 43)
SET IDENTITY_INSERT [dbo].[Furnitura] OFF
