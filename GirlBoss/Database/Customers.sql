CREATE TABLE [dbo].[Customers]
(
	[id] INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    [firstName] TEXT NOT NULL, 
    [lastName] TEXT NOT NULL, 
    [email] TEXT NOT NULL
)
