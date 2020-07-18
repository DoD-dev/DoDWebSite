CREATE TABLE [dbo].[Post]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(1024) NOT NULL, 
    [Description] NVARCHAR(2048) NULL, 
    [HeaderImage] NVARCHAR(2048) NULL, 
    [PostContent] NVARCHAR(MAX) NULL, 
    [IsHidden] BIT NULL, 
    [QueuePriority] INT NULL, 
    [OnTop] BIT NULL, 
    [UrlSlug] NVARCHAR(2048) NULL, 
    [AuditLog] NVARCHAR(MAX) NULL, 
    [CreatedOrModifiedOn] DATETIME2 NULL, 
    [PublishedOn] DATETIME2 NULL 
)
