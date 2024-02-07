CREATE TABLE [dbo].[StudentRecord]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(MAX) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Mobile] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(50) NULL
)
