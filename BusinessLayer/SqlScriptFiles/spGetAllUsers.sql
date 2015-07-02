CREATE PROCEDURE spGetAllStudents
AS
BEGIN
	SELECT ID,Name,DateOfBirth,GPA,IsActive FROM Students;
END

EXECUTE spGetAllStudents