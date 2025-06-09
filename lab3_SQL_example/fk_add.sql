CREATE TABLE Students (
	StudentID int GENERATED ALWAYS
	AS IDENTITY UNIQUE NOT NULL,
	GroupID int NOT NULL,
	Surname text NOT NULL,
	Firstname text NOT NULL,
	Lastname text NOT NULL,
	Birthday date NOT NULL,
	Birthplace text NOT NULL,
	Phone text NOT NULL,
	Address text NOT NULL
);
ALTER TABLE Students ADD CONSTRAINT
PKStudents primary key (StudentID);

ALTER TABLE Students ADD CONSTRAINT
FKStudentsGroups FOREIGN KEY (GroupID)
REFERENCES Groups(GroupID) ON UPDATE CASCADE;
