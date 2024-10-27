CREATE TABLE [dbo].[Employee] (
    [emp_Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (50)  NULL,
    [email]      VARCHAR (50)  NULL,
    [department] VARCHAR (50)  NULL,
    [phno]       NVARCHAR (50) NULL,
    [address]    VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([emp_Id] ASC)
);

