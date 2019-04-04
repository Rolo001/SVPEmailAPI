CREATE PROCEDURE [dbo].[spAddUser]
	@email varchar(50) = null, 
	@fullName char(30) = null,
	@password nvarchar(30) = null
AS
	INSERT INTO [User] (Email, FullName, [Password]) VALUES (@email, @fullName, @password)
RETURN 0
