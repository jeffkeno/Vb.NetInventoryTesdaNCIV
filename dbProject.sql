USE [dbProject]
GO
/****** Object:  Table [dbo].[tblProd_Inventory]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProd_Inventory](
	[ItemID] [int] NOT NULL,
	[ProdWQty] [int] NOT NULL,
	[ProdRQty] [int] NOT NULL,
	[ItemPerQty] [int] NOT NULL,
	[ReorderPt] [int] NULL,
	[Created_By] [varchar](50) NULL,
	[Create_Date] [varchar](20) NULL,
	[Updated_By] [varchar](20) NULL,
	[Updated_Date] [varchar](20) NULL,
 CONSTRAINT [PK_tblProd_Inventory] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblProd_Inventory] ([ItemID], [ProdWQty], [ProdRQty], [ItemPerQty], [ReorderPt], [Created_By], [Create_Date], [Updated_By], [Updated_Date]) VALUES (1, 1, 1, 1, 1, N'clm01', N'Aug 08-2017', NULL, NULL)
/****** Object:  Table [dbo].[tblDept]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDept](
	[DeptID] [int] NOT NULL,
	[DeptName] [varchar](50) NOT NULL,
	[Created_By] [varchar](10) NULL,
	[Created_Date] [varchar](50) NULL,
	[Updated_By] [varchar](10) NULL,
	[Updated_Date] [varchar](50) NULL,
 CONSTRAINT [PK_tblDept] PRIMARY KEY CLUSTERED 
(
	[DeptID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblDept] ([DeptID], [DeptName], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (0, N'23', N'clm01', N'2017-07-27', N'clm02', N'Aug 08-2017')
INSERT [dbo].[tblDept] ([DeptID], [DeptName], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (1, N'23', N'clm01', N'2017-07-27', N'clm01', N'Jul 30-2017')
INSERT [dbo].[tblDept] ([DeptID], [DeptName], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (2, N'Hello', N'clm01', N'2017-07-27', NULL, NULL)
INSERT [dbo].[tblDept] ([DeptID], [DeptName], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (3, N'Hello', N'clm01', N'2017-07-29', NULL, NULL)
INSERT [dbo].[tblDept] ([DeptID], [DeptName], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (4, N'Hello', N'clm01', N'Jul 27 2017 12:00AM', NULL, NULL)
INSERT [dbo].[tblDept] ([DeptID], [DeptName], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (5, N'Hello', N'clm01', N'Jul 27 2017 12:00AM', N'clm02', N'Aug 08-2017')
INSERT [dbo].[tblDept] ([DeptID], [DeptName], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (40, N'Hill', N'clm01', N'2017-07-27', N'clm02', N'Aug 08-2017')
/****** Object:  Table [dbo].[tblUserName]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUserName](
	[clmUserName] [varchar](20) NOT NULL,
	[clmPassword] [varchar](20) NOT NULL,
	[clmFirstName] [varchar](20) NOT NULL,
	[clmLastName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblUserName] PRIMARY KEY CLUSTERED 
(
	[clmUserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblUserName] ([clmUserName], [clmPassword], [clmFirstName], [clmLastName]) VALUES (N'clm01', N'user01', N'John', N'Wick')
INSERT [dbo].[tblUserName] ([clmUserName], [clmPassword], [clmFirstName], [clmLastName]) VALUES (N'clm02', N'user01', N'John', N'Wick')
INSERT [dbo].[tblUserName] ([clmUserName], [clmPassword], [clmFirstName], [clmLastName]) VALUES (N'clm100', N'hello', N'Mark', N'Caguioa')
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSupplier](
	[SupID] [int] NOT NULL,
	[SupName] [varchar](50) NOT NULL,
	[SupAdd] [varchar](50) NOT NULL,
	[MobileNo] [int] NOT NULL,
	[PhoneNo] [int] NOT NULL,
	[Email] [varchar](20) NOT NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [varchar](50) NULL,
	[Updated_By] [varchar](50) NULL,
	[Updated_Date] [varchar](50) NULL,
 CONSTRAINT [PK_tblSupplier] PRIMARY KEY CLUSTERED 
(
	[SupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblSupplier] ([SupID], [SupName], [SupAdd], [MobileNo], [PhoneNo], [Email], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (1, N'Hellow', N'Manila', 121212, 1212121, N'keno@yahoo.com', N'clm01', N'07 30-2017', N'clm02', N'Aug 08-2017')
INSERT [dbo].[tblSupplier] ([SupID], [SupName], [SupAdd], [MobileNo], [PhoneNo], [Email], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (2, N'hi', N'hello', 121212, 12121, N'12', N'clm01', N'07 30-2017', N'clm02', N'Aug 08-2017')
INSERT [dbo].[tblSupplier] ([SupID], [SupName], [SupAdd], [MobileNo], [PhoneNo], [Email], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (3, N'Hi', N'Hi', 232, 232, N'Hi', N'clm01', N'Aug 08-2017', NULL, NULL)
/****** Object:  Table [dbo].[tblPurchase_Order]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPurchase_Order](
	[PO_No] [int] IDENTITY(1,1) NOT NULL,
	[SupID] [int] NOT NULL,
	[ModeofPayment] [varchar](20) NOT NULL,
	[Bank] [varchar](20) NOT NULL,
	[Check_No] [varchar](20) NOT NULL,
	[Total] [decimal](18, 0) NOT NULL,
	[POStatus] [varchar](10) NULL,
	[Requested_By] [varchar](50) NULL,
	[Requested_Date] [varchar](50) NULL,
	[Received_By] [varchar](50) NULL,
	[Received_Date] [varchar](50) NULL,
	[Delivered_By] [varchar](50) NULL,
	[Delivered_Date] [varchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [varchar](50) NULL,
	[Updated_By] [varchar](20) NULL,
	[Updated_Date] [varchar](20) NULL,
 CONSTRAINT [PK_tblPurchase_Order] PRIMARY KEY CLUSTERED 
(
	[PO_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProduct_Category]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProduct_Category](
	[PC_ID] [int] NOT NULL,
	[DeptID] [int] NOT NULL,
	[PC_Name] [varchar](50) NOT NULL,
	[PC_Locator] [varchar](50) NOT NULL,
	[PC_Remarks] [varchar](50) NOT NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [varchar](50) NULL,
	[Updated_By] [varchar](50) NULL,
	[Updated_Date] [varchar](50) NULL,
 CONSTRAINT [PK_tblProduct_Category] PRIMARY KEY CLUSTERED 
(
	[PC_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblProduct_Category] ([PC_ID], [DeptID], [PC_Name], [PC_Locator], [PC_Remarks], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (1, 1, N'Chips', N'1A', N'Snacks', N'clm01', N'2017-07-27', N'clm01', N'Jul 27 2017 12:00AM')
INSERT [dbo].[tblProduct_Category] ([PC_ID], [DeptID], [PC_Name], [PC_Locator], [PC_Remarks], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (2, 1, N'Chips', N'1A', N'Snacks', N'clm01', N'Jul 27 2017 12:00AM', N'clm01', N'Jul 27 2017 12:00AM')
INSERT [dbo].[tblProduct_Category] ([PC_ID], [DeptID], [PC_Name], [PC_Locator], [PC_Remarks], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (3, 2, N'Chips', N'1A', N'Snacks', N'clm01', N'Jul 27 2017 12:00AM', N'clm01', N'Jul 27 2017 12:00AM')
INSERT [dbo].[tblProduct_Category] ([PC_ID], [DeptID], [PC_Name], [PC_Locator], [PC_Remarks], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (4, 3, N'Chip', N'1B', N'Snack', N'clm01', N'Jul 27 2017 12:00AM', N'clm01', N'Aug 08-2017')
INSERT [dbo].[tblProduct_Category] ([PC_ID], [DeptID], [PC_Name], [PC_Locator], [PC_Remarks], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (5, 1, N'Hi', N'1C', N'12', N'clm01', N'Aug 08-2017', NULL, NULL)
INSERT [dbo].[tblProduct_Category] ([PC_ID], [DeptID], [PC_Name], [PC_Locator], [PC_Remarks], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (6, 2, N'Hello', N'1E', N'212', N'clm01', N'Aug 08-2017', NULL, NULL)
/****** Object:  Table [dbo].[tblProduct]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProduct](
	[ProdID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[PC_ID] [int] NOT NULL,
	[ProdName] [varchar](50) NOT NULL,
	[ProdCode] [varchar](50) NOT NULL,
	[ProdSDesc] [varchar](10) NOT NULL,
	[ProdUOM] [varchar](20) NOT NULL,
	[Status] [varchar](2) NOT NULL,
	[Remarks] [varchar](20) NULL,
	[Cost] [varchar](50) NULL,
	[MarkUp] [varchar](50) NULL,
	[PriceA] [decimal](18, 0) NULL,
	[PriceB] [decimal](18, 0) NULL,
	[PriceC] [decimal](18, 0) NULL,
	[PriceD] [decimal](18, 0) NULL,
	[PriceE] [decimal](18, 0) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [varchar](50) NULL,
	[Updated_By] [varchar](50) NULL,
	[Updated_Date] [varchar](50) NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[ProdID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblProduct] ([ProdID], [ItemID], [PC_ID], [ProdName], [ProdCode], [ProdSDesc], [ProdUOM], [Status], [Remarks], [Cost], [MarkUp], [PriceA], [PriceB], [PriceC], [PriceD], [PriceE], [Created_By], [Created_Date], [Updated_By], [Updated_Date]) VALUES (1, 1, 11, N'1', N'1', N'1', N'1', N'Y', NULL, N'1', N'1', CAST(1 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), N'clm01', N'Aug 08-2017', NULL, NULL)
/****** Object:  Table [dbo].[Product_Price_List]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product_Price_List](
	[PriceID] [int] NOT NULL,
	[ProdID] [int] NOT NULL,
	[Cost] [decimal](18, 0) NOT NULL,
	[MarkUp] [varchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [varchar](50) NULL,
 CONSTRAINT [PK_Product_Price_List] PRIMARY KEY CLUSTERED 
(
	[PriceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPO_Reorder]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPO_Reorder](
	[PO_No] [int] NOT NULL,
	[ProdID] [int] NOT NULL,
	[Quantity] [varchar](20) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
	[ReturnTag] [varchar](2) NOT NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPO_Dtls]    Script Date: 08/08/2017 18:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPO_Dtls](
	[PO_No] [int] NOT NULL,
	[ProdID] [int] NOT NULL,
	[ExpDate] [varchar](20) NOT NULL,
	[Quantity] [varchar](20) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
	[Created_By] [varchar](50) NULL,
	[Created_Date] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Product_Price_List_tblProduct]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[Product_Price_List]  WITH CHECK ADD  CONSTRAINT [FK_Product_Price_List_tblProduct] FOREIGN KEY([ProdID])
REFERENCES [dbo].[tblProduct] ([ProdID])
GO
ALTER TABLE [dbo].[Product_Price_List] CHECK CONSTRAINT [FK_Product_Price_List_tblProduct]
GO
/****** Object:  ForeignKey [FK_tblPO_Dtls_tblProduct]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[tblPO_Dtls]  WITH CHECK ADD  CONSTRAINT [FK_tblPO_Dtls_tblProduct] FOREIGN KEY([ProdID])
REFERENCES [dbo].[tblProduct] ([ProdID])
GO
ALTER TABLE [dbo].[tblPO_Dtls] CHECK CONSTRAINT [FK_tblPO_Dtls_tblProduct]
GO
/****** Object:  ForeignKey [FK_tblPO_Dtls_tblPurchase_Order]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[tblPO_Dtls]  WITH CHECK ADD  CONSTRAINT [FK_tblPO_Dtls_tblPurchase_Order] FOREIGN KEY([PO_No])
REFERENCES [dbo].[tblPurchase_Order] ([PO_No])
GO
ALTER TABLE [dbo].[tblPO_Dtls] CHECK CONSTRAINT [FK_tblPO_Dtls_tblPurchase_Order]
GO
/****** Object:  ForeignKey [FK_tblPO_Reorder_tblProduct]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[tblPO_Reorder]  WITH CHECK ADD  CONSTRAINT [FK_tblPO_Reorder_tblProduct] FOREIGN KEY([ProdID])
REFERENCES [dbo].[tblProduct] ([ProdID])
GO
ALTER TABLE [dbo].[tblPO_Reorder] CHECK CONSTRAINT [FK_tblPO_Reorder_tblProduct]
GO
/****** Object:  ForeignKey [FK_tblPO_Reorder_tblPurchase_Order]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[tblPO_Reorder]  WITH CHECK ADD  CONSTRAINT [FK_tblPO_Reorder_tblPurchase_Order] FOREIGN KEY([PO_No])
REFERENCES [dbo].[tblPurchase_Order] ([PO_No])
GO
ALTER TABLE [dbo].[tblPO_Reorder] CHECK CONSTRAINT [FK_tblPO_Reorder_tblPurchase_Order]
GO
/****** Object:  ForeignKey [FK_tblProd_Inventory_tblProduct]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[tblProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblProd_Inventory_tblProduct] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tblProd_Inventory] ([ItemID])
GO
ALTER TABLE [dbo].[tblProduct] CHECK CONSTRAINT [FK_tblProd_Inventory_tblProduct]
GO
/****** Object:  ForeignKey [FK_tblProduct_Category_tblDept]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[tblProduct_Category]  WITH CHECK ADD  CONSTRAINT [FK_tblProduct_Category_tblDept] FOREIGN KEY([DeptID])
REFERENCES [dbo].[tblDept] ([DeptID])
GO
ALTER TABLE [dbo].[tblProduct_Category] CHECK CONSTRAINT [FK_tblProduct_Category_tblDept]
GO
/****** Object:  ForeignKey [FK_tblPurchase_Order_tblSupplier]    Script Date: 08/08/2017 18:21:59 ******/
ALTER TABLE [dbo].[tblPurchase_Order]  WITH CHECK ADD  CONSTRAINT [FK_tblPurchase_Order_tblSupplier] FOREIGN KEY([SupID])
REFERENCES [dbo].[tblSupplier] ([SupID])
GO
ALTER TABLE [dbo].[tblPurchase_Order] CHECK CONSTRAINT [FK_tblPurchase_Order_tblSupplier]
GO
