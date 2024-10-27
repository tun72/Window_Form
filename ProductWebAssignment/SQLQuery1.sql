CREATE TABLE [dbo].[Employee] (
    [Product_Id]     INT           IDENTITY (1, 1) NOT NULL,
    [ProductName]       VARCHAR (50)  NULL,
    [Price]      VARCHAR (50)  NULL,
    [Quantity] VARCHAR (50)  NULL,
 
    PRIMARY KEY CLUSTERED ([Product_Id] ASC)
);

