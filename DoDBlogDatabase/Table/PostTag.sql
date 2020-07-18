CREATE TABLE [dbo].[PostTag]
(
	[PostId] INT NOT NULL , 
    [TagId] INT NOT NULL, 
    PRIMARY KEY ([PostId], [TagId]) 
)
