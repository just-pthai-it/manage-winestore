USE [BTL]
GO
/****** Object:  Table [dbo].[wine]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[wine_name] [varchar](30) NOT NULL,
	[alcohol_level] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[merchandise]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[merchandise](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[wine_id] [int] NOT NULL,
	[year_of_manufacture] [varchar](4) NOT NULL,
	[current_quantity] [int] NOT NULL,
	[price_per_product] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[wine_merchandise]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[wine_merchandise] AS
SELECT wine.*, m.price_per_product as price, m.year_of_manufacture, m.current_quantity, m.id as merchandise_id
FROM wine JOIN merchandise m ON wine.id = m.wine_id
GO
/****** Object:  Table [dbo].[account]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](30) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[role_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[birth] [date] NOT NULL,
	[gender] [int] NOT NULL,
	[phone] [varchar](12) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[account_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[birth] [date] NOT NULL,
	[gender] [int] NOT NULL,
	[phone] [varchar](12) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[birth] [date] NOT NULL,
	[gender] [int] NOT NULL,
	[phone] [varchar](12) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[job_id] [int] NOT NULL,
	[account_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[import_recipt]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[import_recipt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[create_at] [datetime] NOT NULL,
	[employee_id] [int] NOT NULL,
	[supplier_id] [int] NOT NULL,
	[total_money] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[import_recipt_detail]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[import_recipt_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[import_recipt_id] [int] NOT NULL,
	[merchandise_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[cost] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[job]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[job](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[job_name] [nvarchar](30) NOT NULL,
	[salary] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nation]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sale_recipt]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale_recipt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[create_at] [datetime] NOT NULL,
	[employee_id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
	[total_money] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sale_recipt_detail]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale_recipt_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sale_recipt_id] [int] NOT NULL,
	[merchandise_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[cost] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 11/16/2021 3:35:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[phone] [varchar](12) NOT NULL,
	[mail] [varchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[nation_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 

INSERT [dbo].[account] ([id], [username], [password], [role_id]) VALUES (1, N'a', N'21232f297a57a5a743894a0e4a801fc3', 1)
INSERT [dbo].[account] ([id], [username], [password], [role_id]) VALUES (2, N'admin1', N'21232f297a57a5a743894a0e4a801fc3', 1)
INSERT [dbo].[account] ([id], [username], [password], [role_id]) VALUES (3, N'admin2', N'21232f297a57a5a743894a0e4a801fc3', 1)
INSERT [dbo].[account] ([id], [username], [password], [role_id]) VALUES (4, N'b', N'21232f297a57a5a743894a0e4a801fc3', 2)
INSERT [dbo].[account] ([id], [username], [password], [role_id]) VALUES (5, N'nv1', N'21232f297a57a5a743894a0e4a801fc3', 2)
INSERT [dbo].[account] ([id], [username], [password], [role_id]) VALUES (6, N'nv2', N'21232f297a57a5a743894a0e4a801fc3', 2)
INSERT [dbo].[account] ([id], [username], [password], [role_id]) VALUES (7, N'nv3', N'21232f297a57a5a743894a0e4a801fc3', 2)
SET IDENTITY_INSERT [dbo].[account] OFF
GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([id], [name], [birth], [gender], [phone], [mail], [address], [account_id]) VALUES (1, N'Phạm Tiến Hải', CAST(N'2001-05-21' AS Date), 1, N'0967469003', N'dá', N'đâsd', 1)
INSERT [dbo].[admin] ([id], [name], [birth], [gender], [phone], [mail], [address], [account_id]) VALUES (2, N'Phạm Việt Hoàng Minh', CAST(N'2001-05-21' AS Date), 1, N'0967469003', N'dá', N'đâsd', 2)
INSERT [dbo].[admin] ([id], [name], [birth], [gender], [phone], [mail], [address], [account_id]) VALUES (3, N'Nguyễn Xuân Bách', CAST(N'2001-05-21' AS Date), 1, N'0967469003', N'dá', N'đâsd', 3)
SET IDENTITY_INSERT [dbo].[admin] OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (1, N'Nguyễn Văn Công', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (2, N'Nguyễn Thị Tuyết', CAST(N'2001-01-01' AS Date), 0, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (3, N'Nguyễn Trần Tân An', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (4, N'Thái Minh Hiệp', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (5, N'Nguyễn Đình Việt Anh', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (6, N'Đào Ngọc Duy', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (7, N'Nguyễn Diệp Quỳnh', CAST(N'2001-01-01' AS Date), 0, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (8, N'Hoàng Đức Thịnh', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (9, N'Nguyễn Văn Định', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
INSERT [dbo].[customer] ([id], [name], [birth], [gender], [phone], [mail], [address]) VALUES (10, N'Đào Mạnh Dương', CAST(N'2001-01-01' AS Date), 1, N'26654156', N'dsad', N'ádas')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([id], [name], [birth], [gender], [phone], [mail], [address], [job_id], [account_id]) VALUES (1, N'Phạm Tiến Anh', CAST(N'2001-05-01' AS Date), 1, N'161651', N'156161', N'ssasas', 1, 4)
INSERT [dbo].[employee] ([id], [name], [birth], [gender], [phone], [mail], [address], [job_id], [account_id]) VALUES (2, N'Lê Minh Đạt', CAST(N'2001-05-01' AS Date), 1, N'161651', N'156161', N'ssasas', 1, 6)
INSERT [dbo].[employee] ([id], [name], [birth], [gender], [phone], [mail], [address], [job_id], [account_id]) VALUES (3, N'Nguyễn Thị Thủy', CAST(N'2001-05-01' AS Date), 0, N'161651', N'156161', N'ssasas', 2, NULL)
INSERT [dbo].[employee] ([id], [name], [birth], [gender], [phone], [mail], [address], [job_id], [account_id]) VALUES (4, N'Nguyễn Văn Huy', CAST(N'2001-05-01' AS Date), 1, N'161651', N'156161', N'ssasas', 3, 6)
INSERT [dbo].[employee] ([id], [name], [birth], [gender], [phone], [mail], [address], [job_id], [account_id]) VALUES (5, N'Ngô Huy Hoàng', CAST(N'2001-05-01' AS Date), 1, N'161651', N'156161', N'ssasas', 3, 7)
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[import_recipt] ON 

INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (1, CAST(N'2020-11-10T20:26:37.000' AS DateTime), 4, 1, 1000)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (3, CAST(N'2021-01-13T20:30:33.000' AS DateTime), 4, 1, 1700)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (4, CAST(N'2021-02-10T20:26:37.000' AS DateTime), 5, 2, 1800)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (5, CAST(N'2021-03-10T20:30:33.000' AS DateTime), 5, 2, 600)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (6, CAST(N'2021-03-27T20:30:33.000' AS DateTime), 5, 4, 1300)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (7, CAST(N'2021-03-31T20:30:33.000' AS DateTime), 4, 5, 10000)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (9, CAST(N'2021-05-12T21:54:43.000' AS DateTime), 5, 5, 2700)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (10, CAST(N'2021-07-08T22:00:17.000' AS DateTime), 4, 1, 5000)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (11, CAST(N'2021-08-19T22:00:49.000' AS DateTime), 5, 5, 5000)
INSERT [dbo].[import_recipt] ([id], [create_at], [employee_id], [supplier_id], [total_money]) VALUES (12, CAST(N'2021-11-12T22:06:42.000' AS DateTime), 5, 2, 50000)
SET IDENTITY_INSERT [dbo].[import_recipt] OFF
GO
SET IDENTITY_INSERT [dbo].[import_recipt_detail] ON 

INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (1, 1, 1, 20, 500)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (2, 1, 2, 20, 500)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (3, 3, 3, 30, 800)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (4, 3, 4, 40, 600)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (5, 3, 5, 20, 300)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (6, 4, 6, 30, 500)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (7, 4, 7, 50, 500)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (8, 4, 8, 100, 800)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (9, 5, 9, 40, 600)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (10, 6, 10, 20, 300)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (11, 6, 11, 60, 1000)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (12, 7, 12, 200, 10000)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (13, 9, 13, 100, 300)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (14, 9, 14, 100, 500)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (15, 9, 15, 100, 500)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (16, 9, 16, 50, 800)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (17, 9, 17, 150, 600)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (18, 10, 18, 100, 5000)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (19, 11, 19, 100, 5000)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (20, 12, 20, 20, 25000)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (21, 12, 21, 20, 15000)
INSERT [dbo].[import_recipt_detail] ([id], [import_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (22, 12, 22, 20, 10000)
SET IDENTITY_INSERT [dbo].[import_recipt_detail] OFF
GO
SET IDENTITY_INSERT [dbo].[job] ON 

INSERT [dbo].[job] ([id], [job_name], [salary]) VALUES (1, N'Nhân viên bán hàng', 16)
INSERT [dbo].[job] ([id], [job_name], [salary]) VALUES (2, N'Nhân viên dọn vệ sinh', 8)
INSERT [dbo].[job] ([id], [job_name], [salary]) VALUES (3, N'Nhân viên quản lý kho', 20)
SET IDENTITY_INSERT [dbo].[job] OFF
GO
SET IDENTITY_INSERT [dbo].[merchandise] ON 

INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (1, 1, N'1980', 19, 6000)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (2, 1, N'1990', 14, 550)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (3, 1, N'1995', 28, 500)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (4, 1, N'2000', 33, 400)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (5, 1, N'2001', 19, 350)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (6, 2, N'1900', 30, 1000)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (7, 2, N'1975', 48, 800)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (8, 2, N'1980', 99, 700)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (9, 1, N'1990', 34, 550)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (10, 2, N'1995', 20, 500)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (11, 2, N'2001', 58, 200)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (12, 3, N'1950', 200, 700)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (13, 4, N'1980', 100, 400)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (14, 4, N'1990', 100, 500)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (15, 5, N'1995', 100, 600)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (16, 5, N'2001', 50, 1000)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (17, 5, N'1950', 150, 800)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (18, 6, N'1950', 100, 600)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (19, 7, N'1980', 100, 600)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (20, 8, N'1990', 11, 3000)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (21, 8, N'1995', 18, 2500)
INSERT [dbo].[merchandise] ([id], [wine_id], [year_of_manufacture], [current_quantity], [price_per_product]) VALUES (22, 8, N'2001', 20, 2000)
SET IDENTITY_INSERT [dbo].[merchandise] OFF
GO
SET IDENTITY_INSERT [dbo].[nation] ON 

INSERT [dbo].[nation] ([id], [name]) VALUES (1, N'Việt Nam')
INSERT [dbo].[nation] ([id], [name]) VALUES (2, N'Mĩ')
INSERT [dbo].[nation] ([id], [name]) VALUES (3, N'Pháp')
INSERT [dbo].[nation] ([id], [name]) VALUES (4, N'Anh')
INSERT [dbo].[nation] ([id], [name]) VALUES (5, N'Đức')
SET IDENTITY_INSERT [dbo].[nation] OFF
GO
SET IDENTITY_INSERT [dbo].[role] ON 

INSERT [dbo].[role] ([id], [description]) VALUES (1, N'Là admin')
INSERT [dbo].[role] ([id], [description]) VALUES (2, N'là nhân viên')
SET IDENTITY_INSERT [dbo].[role] OFF
GO
SET IDENTITY_INSERT [dbo].[sale_recipt] ON 

INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (1, CAST(N'2021-11-12T21:16:39.000' AS DateTime), 2, 3, 1100)
INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (3, CAST(N'2021-11-12T21:23:17.000' AS DateTime), 2, 1, 7500)
INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (4, CAST(N'2021-11-12T21:26:41.000' AS DateTime), 2, 2, 1900)
INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (5, CAST(N'2021-11-12T21:29:10.000' AS DateTime), 1, 1, 2200)
INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (6, CAST(N'2021-11-12T21:29:31.000' AS DateTime), 1, 5, 2300)
INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (7, CAST(N'2021-11-15T10:43:40.000' AS DateTime), 1, 3, 4450)
INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (8, CAST(N'2021-11-15T14:34:50.000' AS DateTime), 1, 10, 17000)
INSERT [dbo].[sale_recipt] ([id], [create_at], [employee_id], [customer_id], [total_money]) VALUES (9, CAST(N'2021-11-16T15:28:15.000' AS DateTime), 1, 7, 15000)
SET IDENTITY_INSERT [dbo].[sale_recipt] OFF
GO
SET IDENTITY_INSERT [dbo].[sale_recipt_detail] ON 

INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (1, 1, 2, 2, 1100)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (3, 3, 1, 1, 6000)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (4, 3, 4, 2, 800)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (5, 3, 8, 1, 700)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (6, 4, 9, 1, 550)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (7, 4, 3, 2, 1000)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (8, 4, 5, 1, 350)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (9, 5, 2, 4, 2200)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (10, 6, 9, 2, 1100)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (11, 6, 4, 2, 800)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (12, 6, 11, 2, 400)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (13, 7, 4, 3, 1200)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (14, 7, 7, 2, 1600)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (15, 7, 9, 3, 1650)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (16, 8, 20, 4, 12000)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (17, 8, 21, 2, 5000)
INSERT [dbo].[sale_recipt_detail] ([id], [sale_recipt_id], [merchandise_id], [quantity], [cost]) VALUES (18, 9, 20, 5, 15000)
SET IDENTITY_INSERT [dbo].[sale_recipt_detail] OFF
GO
SET IDENTITY_INSERT [dbo].[supplier] ON 

INSERT [dbo].[supplier] ([id], [name], [phone], [mail], [address], [nation_id]) VALUES (1, N'A', N'0452452', N'fasdf', N'adsfa', 1)
INSERT [dbo].[supplier] ([id], [name], [phone], [mail], [address], [nation_id]) VALUES (2, N'B', N'2542', N'adsfdas', N'fdsaf', 2)
INSERT [dbo].[supplier] ([id], [name], [phone], [mail], [address], [nation_id]) VALUES (3, N'C', N'254245', N'fasdf', N'asdfs', 3)
INSERT [dbo].[supplier] ([id], [name], [phone], [mail], [address], [nation_id]) VALUES (4, N'D', N'2542', N'asf', N'dava', 1)
INSERT [dbo].[supplier] ([id], [name], [phone], [mail], [address], [nation_id]) VALUES (5, N'E', N'242', N'asdf', N'fasdf', 3)
SET IDENTITY_INSERT [dbo].[supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[wine] ON 

INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (1, N'Bailey', 10)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (2, N'Ballantine', 20)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (3, N'Blended Scotch Wisky', 30)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (4, N'Camus', 40)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (5, N'Chivas', 50)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (6, N'Glenlivet', 10)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (7, N'Glenmorangle', 20)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (8, N'Hennessy', 30)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (9, N'Jack Daniel', 40)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (10, N'Hibiki', 50)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (11, N'Johnnie Walker', 10)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (12, N'Macallan', 20)
INSERT [dbo].[wine] ([id], [wine_name], [alcohol_level]) VALUES (13, N'Martell', 30)
SET IDENTITY_INSERT [dbo].[wine] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [account_pk]    Script Date: 11/16/2021 3:35:56 PM ******/
ALTER TABLE [dbo].[account] ADD  CONSTRAINT [account_pk] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[account]  WITH CHECK ADD  CONSTRAINT [account_role_id_fk] FOREIGN KEY([role_id])
REFERENCES [dbo].[role] ([id])
GO
ALTER TABLE [dbo].[account] CHECK CONSTRAINT [account_role_id_fk]
GO
ALTER TABLE [dbo].[admin]  WITH CHECK ADD FOREIGN KEY([account_id])
REFERENCES [dbo].[account] ([id])
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD FOREIGN KEY([account_id])
REFERENCES [dbo].[account] ([id])
GO
ALTER TABLE [dbo].[employee]  WITH CHECK ADD FOREIGN KEY([job_id])
REFERENCES [dbo].[job] ([id])
GO
ALTER TABLE [dbo].[import_recipt]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[import_recipt]  WITH CHECK ADD FOREIGN KEY([supplier_id])
REFERENCES [dbo].[supplier] ([id])
GO
ALTER TABLE [dbo].[import_recipt_detail]  WITH CHECK ADD FOREIGN KEY([import_recipt_id])
REFERENCES [dbo].[import_recipt] ([id])
GO
ALTER TABLE [dbo].[import_recipt_detail]  WITH CHECK ADD FOREIGN KEY([merchandise_id])
REFERENCES [dbo].[merchandise] ([id])
GO
ALTER TABLE [dbo].[merchandise]  WITH CHECK ADD FOREIGN KEY([wine_id])
REFERENCES [dbo].[wine] ([id])
GO
ALTER TABLE [dbo].[sale_recipt]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[customer] ([id])
GO
ALTER TABLE [dbo].[sale_recipt]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[sale_recipt_detail]  WITH CHECK ADD FOREIGN KEY([merchandise_id])
REFERENCES [dbo].[merchandise] ([id])
GO
ALTER TABLE [dbo].[sale_recipt_detail]  WITH CHECK ADD FOREIGN KEY([sale_recipt_id])
REFERENCES [dbo].[sale_recipt] ([id])
GO
ALTER TABLE [dbo].[supplier]  WITH CHECK ADD  CONSTRAINT [supplier_nation_id_fk] FOREIGN KEY([nation_id])
REFERENCES [dbo].[nation] ([id])
GO
ALTER TABLE [dbo].[supplier] CHECK CONSTRAINT [supplier_nation_id_fk]
GO
