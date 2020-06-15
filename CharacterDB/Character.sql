CREATE TABLE [dbo].[Character]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [MaxHp] INT NULL, 
    [AC] INT NOT NULL, 
    [InitiativeBonus] INT NULL, 
    [PC] TINYINT NOT NULL, 
    [Type] NVARCHAR(50) NULL, 
    [CR] FLOAT NULL 
)
