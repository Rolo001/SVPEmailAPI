﻿CREATE TABLE [dbo].[User]
(
	[UserID] INT NOT NULL PRIMARY KEY IDENTITY(1,1) , 
    [Email] VARCHAR(50) NOT NULL, 
    [FullName] CHAR(30) NOT NULL, 
    [Password] NVARCHAR(30) NOT NULL
)
