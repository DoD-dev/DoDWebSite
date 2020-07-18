CREATE TABLE [dbo].[Tag]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [Description] NVARCHAR(2048) NULL, 
    [UrlSlug] NVARCHAR(2048) NULL, 
    [IsHidden] BIT NULL , 
    [QueuePriority] INT NULL, 
    [TotalPostCount] INT NULL, 
    [OnTop] BIT NULL, 
    [CreatedOrModifiedOn] DATETIME2 NULL 
)
