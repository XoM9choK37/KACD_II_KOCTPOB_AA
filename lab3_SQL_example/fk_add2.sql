ALTER TABLE Specialities
ADD CONSTRAINT FKSpecialitiesFaculties
FOREIGN KEY (facultyid)
REFERENCES faculties(facultyid)
ON UPDATE CASCADE;