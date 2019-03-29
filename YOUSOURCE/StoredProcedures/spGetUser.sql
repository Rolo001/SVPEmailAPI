CREATE PROCEDURE [dbo].[spGetUser]
	@id int = 0
AS
	SELECT Email, FullName FROM [User] WHERE UserID = @id;
RETURN 0
