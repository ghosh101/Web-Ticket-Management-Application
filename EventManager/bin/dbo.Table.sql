CREATE TABLE [dbo].[Table]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [EventCode] INT NULL, 
    [Address] NVARCHAR(MAX) NULL, 
    [Zone] CHAR(10) NULL, 
    [SeatNo] INT NULL
)
