BEGIN TRANSACTION;
GO

CREATE TABLE [Categories] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Description] nvarchar(500) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Sales] (
    [Id] uniqueidentifier NOT NULL,
    [CustomerNumber] nvarchar(20) NOT NULL,
    [Name] nvarchar(200) NOT NULL,
    [Address] nvarchar(200) NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Items] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(35) NOT NULL,
    [Description] nvarchar(500) NULL,
    [CategoryId] uniqueidentifier NOT NULL,
    [ImageUrl] nvarchar(250) NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Items_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Orders] (
    [Id] uniqueidentifier NOT NULL,
    [SaleId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Orders_Sales_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [Sales] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [OrderedItems] (
    [Id] uniqueidentifier NOT NULL,
    [Number] nvarchar(5) NOT NULL,
    [Section] nvarchar(5) NOT NULL,
    [IsInUse] bit NOT NULL,
    [ItemsCount] int NOT NULL,
    [ItemId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_OrderedItems] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OrderedItems_Items_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [Items] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [OrderDetails] (
    [Id] uniqueidentifier NOT NULL,
    [OrderId] uniqueidentifier NOT NULL,
    [ItemId] uniqueidentifier NOT NULL,
    [ItemCount] int NOT NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OrderDetails_Items_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [Items] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Items_CategoryId] ON [Items] ([CategoryId]);
GO

CREATE INDEX [IX_OrderDetails_ItemId] ON [OrderDetails] ([ItemId]);
GO

CREATE INDEX [IX_OrderDetails_OrderId] ON [OrderDetails] ([OrderId]);
GO

CREATE INDEX [IX_OrderedItems_ItemId] ON [OrderedItems] ([ItemId]);
GO

CREATE INDEX [IX_Orders_SaleId] ON [Orders] ([SaleId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220411091810_AddEntities', N'6.0.3');
GO

COMMIT;
GO

