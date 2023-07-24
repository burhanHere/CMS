CREATE DATABASE CMS_DP_Project;
USE CMS_DP_Project;
#drop database CMS_DP_Project;
CREATE TABLE Students
(
  StudentID VARCHAR(100) NOT NULL,
  StudentName VARCHAR(100) NOT NULL,
  PRIMARY KEY (StudentID)
);

CREATE TABLE Courses
(
  CourseID INT NOT NULL AUTO_INCREMENT,
  CourseName VARCHAR(100) NOT NULL,
  AssignmentWeightage FLOAT NOT NULL,
  QuizWeightage FLOAT NOT NULL,
  MidWeightage FLOAT NOT NULL,
  FinalWeightage FLOAT NOT NULL,
  PRIMARY KEY (CourseName),
  UNIQUE (CourseID)
);

CREATE TABLE Sections
(
  SectionID INT NOT NULL AUTO_INCREMENT,
  SectionName VARCHAR(100) NOT NULL,
  CourseName VARCHAR(100) NOT NULL,
  PRIMARY KEY (SectionName),
  FOREIGN KEY (CourseName) REFERENCES Courses(CourseName),
  UNIQUE (SectionID)
);

CREATE TABLE DivideInto
(
  StudentID VARCHAR(100) NOT NULL,
  SectionName VARCHAR(100),
  FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
  FOREIGN KEY (SectionName) REFERENCES Sections(SectionName)
);

CREATE TABLE Quizes
(
  QuizID INT NOT NULL AUTO_INCREMENT,
  DateCommenced DATE NOT NULL,
  TotalMarks FLOAT NOT NULL,
  ObtainedMarks FLOAT NOT NULL,
  SectionName VARCHAR(100),
  StudentID VARCHAR(100) NOT NULL,
  PRIMARY KEY (QuizID),
  FOREIGN KEY (SectionName) REFERENCES Sections(SectionName),
  FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE Assignments
(  
  AssignmentID INT NOT NULL AUTO_INCREMENT,
  DateCommenced DATE NOT NULL,
  TotalMarks FLOAT NOT NULL,
  ObtainedMarks FLOAT NOT NULL,
  SectionName VARCHAR(100),
  StudentID VARCHAR(100) NOT NULL,
  PRIMARY KEY (AssignmentID),
  FOREIGN KEY (SectionName) REFERENCES Sections(SectionName),
  FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE Mids
(
  MidID INT NOT NULL AUTO_INCREMENT,
  DateCommenced DATE NOT NULL,
  TotalMarks FLOAT NOT NULL,
  ObtainedMarks FLOAT NOT NULL,
  SectionName VARCHAR(100),
  StudentID VARCHAR(100) NOT NULL,
  PRIMARY KEY (MidID),
  FOREIGN KEY (SectionName) REFERENCES Sections(SectionName),
  FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE Final
(
  FinalID INT NOT NULL AUTO_INCREMENT,
  TotalMarks FLOAT NOT NULL,
  ObtainedMarks FLOAT NOT NULL,
  DateCommenced DATE NOT NULL,
  SectionName VARCHAR(100),
  StudentID VARCHAR(100) NOT NULL,
  PRIMARY KEY (FinalID),
  FOREIGN KEY (SectionName) REFERENCES Sections(SectionName),
  FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);


select s.studentname,c.coursename,f.obtainedmarks
from students s 
inner join final f
on s.StudentID=f.StudentID
inner join sections sn
on sn.sectionname=f.sectionname
inner join courses c
on c.coursename=sn.coursename
where s.StudentID like 'l1f21bscs1059';
show tables;