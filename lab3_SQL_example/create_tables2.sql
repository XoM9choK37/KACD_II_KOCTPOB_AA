CREATE TABLE Faculties (
	FacultyID int GENERATED ALWAYS
		AS IDENTITY UNIQUE NOT NULL,
	FacultyName text NOT NULL,
	Descript text NOT NULL
);
ALTER TABLE Faculties
	ADD CONSTRAINT PKFaculties
	PRIMARY KEY (FacultyID);
	CREATE UNIQUE INDEX FacultyIndex
	ON Faculties (FacultyID);
	CLUSTER Faculties USING FacultyIndex;

CREATE TABLE TeachForm (
	TeachformID int GENERATED ALWAYS
		AS IDENTITY UNIQUE NOT NULL,
	Descript text NOT NULL
);
ALTER TABLE TeachForm
	ADD CONSTRAINT PKTeachform
	PRIMARY KEY (TeachformID);
	CREATE INDEX TeachFromIndex
	ON TeachForm (TeachformID);