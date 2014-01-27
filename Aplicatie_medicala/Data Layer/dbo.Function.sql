CREATE FUNCTION [dbo].[compare]
(
	@pass nvarchar(30),
	@encrpass varbinary(256)
)
RETURNS INT
AS
BEGIN
	RETURN pwdcompare(@pass,@encrpass)
END
