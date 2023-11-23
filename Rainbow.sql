create database Rainbow;
use Rainbow;
create table classes(
classId int Primary Key identity ,
className varchar(50),
classFloor int
)
CREATE TABLE Subjects (
 SubjectID INT PRIMARY KEY IDENTITY(1,1),
 SubjectName NVARCHAR(50),
 TeacherName NVARCHAR(50)
);
create table student(
studentId int primary key,
StudentName varchar(50),
TeacherName varchar(50),
ClassId int constraint FK_student_class foreign key REFERENCES classes
(classId),
SubjectID INT,
CONSTRAINT FK_Student_Subject FOREIGN KEY (SubjectID) REFERENCES Subjects
(SubjectID)
)

