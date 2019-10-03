CREATE TABLE [dbo].[Table]
(
	[KanjiID] INT NOT NULL PRIMARY KEY, 
    [Kanji] NCHAR(2) NOT NULL, 
    [KanjiMean] NCHAR(30) NULL, 
    [OnYomi] NCHAR(20) NOT NULL, 
    [KunYomi] NCHAR(20) NOT NULL
)
