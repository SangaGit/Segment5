CREATE PROCEDURE spAddStudents
(
	@name VARCHAR(200),
	@dob DATE,
	@gpa DECIMAL,
	@isActive BIT
)
AS
BEGIN
	INSERT INTO Students(Name,DateOfBirth,GPA,IsActive)
	VALUES(@name,@dob,@gpa,@isActive);
END

