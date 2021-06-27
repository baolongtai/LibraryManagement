
Drop database db_BanHang
Use master
Create Database db_BanHang
Go
Use db_BanHang



CREATE TABLE Admin(
[UserAdmin] [varchar](30) primary key,
[PassAdmin] [varchar](30) NOT NULL,
[Hoten] [nvarchar](50) NOT NULL
)

CREATE TABLE [dbo].[type_products](
[id] [int] IDENTITY(1,1) NOT NULL,
[name] [nvarchar](50) NOT NULL,
[description] [nvarchar](400) NOT NULL,
[image] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_type_products] PRIMARY KEY CLUSTERED ([id] ASC ) WITH
 (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
 ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY]

 CREATE TABLE [dbo].[products](
[id] [int] IDENTITY(1,1) NOT NULL,
[name] [nvarchar](50) NOT NULL,
[id_type] [int] NOT NULL,
[description] [nvarchar](400) NULL,
[unit_price] [int] NOT NULL,
[promotion_price] [int] NOT NULL,
[image] [nvarchar](50) NOT NULL,
[unit] [nvarchar](50) NULL,
[new] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED ([id] ASC) WITH (PAD_INDEX =
OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]

CREATE TABLE [dbo].[customer](
[id] [int] IDENTITY(1,1) NOT NULL,
[name] [nvarchar](50) NOT NULL,
[gender] [nvarchar](50) NOT NULL,
[email] [nvarchar](50) NOT NULL,
[address] [nvarchar](50) NOT NULL,
[phone_number] [nvarchar](50) NOT NULL,
[note] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED ( [id] ASC) WITH (PAD_INDEX
= OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]

CREATE TABLE [dbo].[bills](
[id] [int] IDENTITY(1,1) NOT NULL,
[id_customer] [int] NOT NULL,
[date_order] [date] NOT NULL,
[total] [int] NOT NULL,
[payment] [nvarchar](50) NOT NULL,
[note] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_bills] PRIMARY KEY CLUSTERED ( [id] ASC ) WITH (PAD_INDEX =
OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY]

CREATE TABLE [dbo].[bill_detail](
[id] [int] IDENTITY(1,1) NOT NULL,
[id_bill] [int] NOT NULL,
[id_product] [int] NOT NULL,
[quantity] [nvarchar](50) NOT NULL,
[unit_price] [int] NOT NULL,
CONSTRAINT [PK_bill_detail] PRIMARY KEY CLUSTERED ([id] ASC) WITH (
PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]

CREATE TABLE [dbo].[users](
[id] [int] IDENTITY(1,1) NOT NULL,
[full_name] [nvarchar](50) NOT NULL,
[email] [nvarchar](50) NOT NULL,
[password] [nvarchar](100) NOT NULL,
[phone] [nvarchar](50) NOT NULL,
[address] [nvarchar](50) NOT NULL,
[remember_token] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED ([id] ASC ) WITH (PAD_INDEX =
OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY]

CREATE TABLE [dbo].[slide](
[id] [int] IDENTITY(1,1) NOT NULL,
[link] [nvarchar](1) NULL,
[image] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_slide] PRIMARY KEY CLUSTERED ([id] ASC) WITH (PAD_INDEX =
OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]

CREATE TABLE [dbo].[news](
[id] [int] IDENTITY(1,1) NOT NULL,
[title] [nvarchar](150) NOT NULL,
[content] [nvarchar](200) NOT NULL,
[image] [nvarchar](50) NOT NULL,
CONSTRAINT [PK_news] PRIMARY KEY CLUSTERED ([id] ASC) WITH (PAD_INDEX =
OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY]

ALTER TABLE [dbo].[bill_detail] WITH CHECK ADD CONSTRAINT [FK_bill_detail_bills] FOREIGN
KEY([id_bill]) REFERENCES [dbo].[bills] ([id])
ALTER TABLE [dbo].[bill_detail] CHECK CONSTRAINT [FK_bill_detail_bills]

ALTER TABLE [dbo].[bills] WITH CHECK ADD CONSTRAINT [FK_bills_customer] FOREIGN
KEY([id_customer]) REFERENCES [dbo].[customer] ([id])
ALTER TABLE [dbo].[bills] CHECK CONSTRAINT [FK_bills_customer]

ALTER TABLE [dbo].[products] WITH CHECK ADD CONSTRAINT [FK_products_type_products] FOREIGN
KEY([id_type]) REFERENCES [dbo].[type_products] ([id])
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_type_products]



SET IDENTITY_INSERT [dbo].[slide] ON
INSERT [dbo].[slide] ([id], [link], [image]) VALUES (1, NULL, N'banner01.png')
INSERT [dbo].[slide] ([id], [link], [image]) VALUES (2, NULL, N'banner02.png')
INSERT [dbo].[slide] ([id], [link], [image]) VALUES (3, NULL, N'banner03.png')
INSERT [dbo].[slide] ([id], [link], [image]) VALUES (4, NULL, N'banner04.png')
SET IDENTITY_INSERT [dbo].[slide] OFF

SET IDENTITY_INSERT [dbo].[users] ON
INSERT [dbo].[users] ([id], [full_name], [email], [password], [phone], [address],
[remember_token]) VALUES (6, N'Admin', N'admin@gmail.com', N'admin@123456', N'23456789',
N'Hoàng Diệu 2', N'NULL')
SET IDENTITY_INSERT [dbo].[users] OFF

INSERT Into Admin
VALUES ('admin', '123456', 'Chủ rạp xiếc')
INSERT Into Admin
VALUES ('user', '789', 'Chúa hề')

SET IDENTITY_INSERT [dbo].[news] ON
INSERT [dbo].[news] ([id], [title], [content], [image]) VALUES (1, N'Mùa trung thu năm nay, Hỷ
Lâm Môn muốn gửi đến quý khách hàng sản phẩm mới xuất hiện lần đầu tiên tại Việt nam "Bánh
trung thu Bơ Sữa HongKong".', N'Những ý tưởng dưới đây sẽ giúp bạn sắp xếp tủ quần áo trong
phòng ngủ chật hẹp của mình một cách dễ dàng và hiệu quả nhất. ', N'sample1.jpg')
INSERT [dbo].[news] ([id], [title], [content], [image]) VALUES (2, N'Tư vấn cải tạo phòng ngủ
nhỏ sao cho thoải mái và thoáng mát', N'Chúng tôi sẽ tư vấn cải tạo và bố trí nội thất để giúp
phòng ngủ của chàng trai độc thân thật thoải mái, thoáng mát và sáng sủa nhất. ',
N'sample2.jpg')
INSERT [dbo].[news] ([id], [title], [content], [image]) VALUES (3, N'Đồ gỗ nội thất và nhu
cầu, xu hướng sử dụng của người dùng', N'Đồ gỗ nội thất ngày càng được sử dụng phổ biến nhờ
vào hiệu quả mà nó mang lại cho không gian kiến trúc. Xu thế của các gia đình hiện nay là muốn
đem thiên nhiên vào nhà ', N'sample3.jpg')
INSERT [dbo].[news] ([id], [title], [content], [image]) VALUES (4, N'Hướng dẫn sử dụng bảo
quản đồ gỗ, nội thất.', N'Ngày nay, xu hướng chọn vật dụng làm bằng gỗ để trang trí, sử dụng
trong văn phòng, gia đình được nhiều người ưa chuộng và quan tâm. Trên thị trường có nhiều sản
phẩm mẫu ', N'sample4.jpg')
INSERT [dbo].[news] ([id], [title], [content], [image]) VALUES (5, N'Phong cách mới trong sử
dụng đồ gỗ nội thất gia đình', N'Đồ gỗ nội thất gia đình ngày càng được sử dụng phổ biến nhờ
vào hiệu quả mà nó mang lại cho không gian kiến trúc. Phong cách sử dụng đồ gỗ hiện nay của
các gia đình hầu h ', N'sample5.jpg')
SET IDENTITY_INSERT [dbo].[news] OFF

/**DELETE  FROM [dbo].[type_products]
  WHERE [id]=2;
DELETE  FROM [dbo].[type_products]
  WHERE [id]=3;
DELETE  FROM [dbo].[type_products]
  WHERE [id]=4;
DELETE  FROM [dbo].[type_products]
  WHERE [id]=5;
DELETE  FROM [dbo].[type_products]
  WHERE [id]=6;
DELETE  FROM [dbo].[type_products]
  WHERE [id]=7;
**/

SET IDENTITY_INSERT [dbo].[type_products] ON
INSERT [dbo].[type_products] ([id], [name], [description], [image]) VALUES (1, N'Drama', N'',N'')
INSERT [dbo].[type_products] ([id], [name], [description], [image]) VALUES (2, N'Siscom', N'', N'')
INSERT [dbo].[type_products] ([id], [name], [description], [image]) VALUES (3, N'Romance', N'',N'')
INSERT [dbo].[type_products] ([id], [name], [description], [image]) VALUES (4, N'Action', N'',N'')
INSERT [dbo].[type_products] ([id], [name], [description], [image]) VALUES (5, N'Phiêu lưu',N'',N'')
INSERT [dbo].[type_products] ([id], [name], [description], [image]) VALUES (6, N'Crepy', N'',N'')
INSERT [dbo].[type_products] ([id], [name], [description], [image]) VALUES (7, N'Echi', N'',N'')
SET IDENTITY_INSERT [dbo].[type_products] OFF

SET IDENTITY_INSERT [dbo].[products] ON
INSERT [dbo].[products] ([id], [name], [id_type], [description], [unit_price],
[promotion_price], [image], [unit], [new]) VALUES (1, N'3 ngày hạnh phúc', 5, NULL,
150000, 120000, N'3_ngay_hp.jpg', N'cuốn', N'1')
SET IDENTITY_INSERT [dbo].[products] OFF

SET IDENTITY_INSERT [dbo].[customer] ON
INSERT [dbo].[customer] ([id], [name], [gender], [email], [address], [phone_number], [note])
VALUES (11, N'Hương Hương', N'Nữ', N'huongnguyenak96@gmail.com', N'Lê Thị Riêng, Quận 1',
N'913456987', N'không chú')
INSERT [dbo].[customer] ([id], [name], [gender], [email], [address], [phone_number], [note])
VALUES (12, N'Khoa phạm', N'Nam', N'khoapham@gmail.com', N'Lê thị riêng', N'913119490', N'Vui
lòng chuyển đúng hạn')
INSERT [dbo].[customer] ([id], [name], [gender], [email], [address], [phone_number], [note])
VALUES (13, N'Hương Hương', N'Nữ', N'huongnguyenak96@gmail.com', N'Lê Thị Riêng, Quận 1',
N'907079829', N'Vui lòng giao hàng trước 5h')
INSERT [dbo].[customer] ([id], [name], [gender], [email], [address], [phone_number], [note])
VALUES (14, N'hhh', N'nam', N'huongnguyen@gmail.com', N'Lê thị riêng', N'913746401', N'k')
SET IDENTITY_INSERT [dbo].[customer] OFF

SET IDENTITY_INSERT [dbo].[bills] ON
INSERT [dbo].[bills] ([id], [id_customer], [date_order], [total], [payment], [note]) VALUES
(11, 11, CAST(N'2017-03-21' AS Date), 420000, N'COD', N'không chú')
INSERT [dbo].[bills] ([id], [id_customer], [date_order], [total], [payment], [note]) VALUES
(12, 12, CAST(N'2017-03-21' AS Date), 520000, N'COD', N'Vui lòng chuyển đúng hạn')
INSERT [dbo].[bills] ([id], [id_customer], [date_order], [total], [payment], [note]) VALUES
(13, 13, CAST(N'2017-03-21' AS Date), 400000, N'ATM', N'Vui lòng giao hàng trước 5h')
INSERT [dbo].[bills] ([id], [id_customer], [date_order], [total], [payment], [note]) VALUES
(14, 14, CAST(N'2017-03-23' AS Date), 160000, N'COD', N'k')
SET IDENTITY_INSERT [dbo].[bills] OFF

SET IDENTITY_INSERT [dbo].[bill_detail] ON
INSERT [dbo].[bill_detail] ([id], [id_bill], [id_product], [quantity], [unit_price]) VALUES
(11, 11, 1, N'2', 100000)
INSERT [dbo].[bill_detail] ([id], [id_bill], [id_product], [quantity], [unit_price]) VALUES
(12, 11, 2, N'1', 150000)
INSERT [dbo].[bill_detail] ([id], [id_bill], [id_product], [quantity], [unit_price]) VALUES
(13, 12, 3, N'1', 150000)
INSERT [dbo].[bill_detail] ([id], [id_bill], [id_product], [quantity], [unit_price]) VALUES
(14, 12, 4, N'2', 150000)
INSERT [dbo].[bill_detail] ([id], [id_bill], [id_product], [quantity], [unit_price]) VALUES
(15, 13, 5, N'1', 200000)
INSERT [dbo].[bill_detail] ([id], [id_bill], [id_product], [quantity], [unit_price]) VALUES
(16, 13, 6, N'1', 200000)
INSERT [dbo].[bill_detail] ([id], [id_bill], [id_product], [quantity], [unit_price]) VALUES
(17, 14, 2, N'1', 160000)
SET IDENTITY_INSERT [dbo].[bill_detail] OFF

Select * from [dbo].[products]