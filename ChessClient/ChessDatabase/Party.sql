CREATE TABLE [dbo].[Party]
(
	[id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [client_owner] BIGINT NOT NULL FOREIGN KEY REFERENCES Client(id), 
    [client_partner] BIGINT NULL UNIQUE FOREIGN KEY REFERENCES Client(id), 
    [owner_color] NCHAR(5) NOT NULL ,
    [victory_client] BIGINT NULL DEFAULT NULL FOREIGN KEY REFERENCES Client(id), 
    [is_finished] BIT NOT NULL DEFAULT 0
)
