CREATE PROCEDURE [dbo].[Update_Internari_Externari]
	@externare date,
	@cnp nchar(13)
AS
	UPDATE       Internari_Externari
SET               Data_externare = @externare
Where            CNP=@cnp
RETURN 0
