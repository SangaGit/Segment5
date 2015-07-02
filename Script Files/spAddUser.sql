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

EXECUTE spAddStudents 'Sangeeth', '1990-06-22', 1.12, 1
EXECUTE spAddStudents 'Chathura', '1989-09-12', 3.62, 1
EXECUTE spAddStudents 'Janaka', '1992-10-23', 2.12, 0
EXECUTE spAddStudents 'Pethum', '1991-02-05', 2.52, 1

