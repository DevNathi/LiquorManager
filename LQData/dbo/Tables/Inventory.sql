CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [PurchasedPrice] MONEY NOT NULL, 
    [PurchasedDate] DATETIME2 NOT NULL
)
