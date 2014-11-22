CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Start] DATETIME NULL, 
    [End] DATETIME NULL
)
