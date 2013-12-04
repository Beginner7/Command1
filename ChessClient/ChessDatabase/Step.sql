CREATE TABLE [dbo].[Step]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [start_cell] NCHAR(2) NOT NULL, 
    [dest_cell] NCHAR(2) NOT NULL, 
    [party_id] BIGINT NOT NULL FOREIGN KEY REFERENCES Party(id), 
    [time] DATETIME NOT NULL
)
