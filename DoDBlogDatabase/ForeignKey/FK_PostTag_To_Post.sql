ALTER TABLE [dbo].[PostTag]
	ADD CONSTRAINT [FK_PostTag_To_Post]
	FOREIGN KEY (PostId)
	REFERENCES [Post] (Id)
