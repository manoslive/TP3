CREATE TABLE [dbo].[EVENTS] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (50)  NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Starting]    DATETIME       NULL,
    [Ending]      DATETIME       NULL,
    [Category] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

