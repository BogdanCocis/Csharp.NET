CREATE TABLE [dbo].[Facultati]
(
	[Id] INT NOT NULL, 
	[Code] INT NOT NULL,
	[NumeFac] TEXT NOT NULL,
	CONSTRAINT [Fk_Facultati_Universitati] FOREIGN KEY ([Code]) REFERENCES [Universitati](Code)
)
