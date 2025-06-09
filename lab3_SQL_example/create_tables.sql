create table Specialities 
(
	SpecialtyID int GENERATED ALWAYS AS IDENTITY UNIQUE NOT NULL,
	SpecialtyName text not null,
	SpecialtyCode text not null,
	Descript text null
);
alter table Specialities add constraint PKSpecialities
primary key (SpecialtyID); 
CREATE UNIQUE INDEX SpecialtyIndex on Specialities 
(SpecialtyID); 
CLUSTER Specialities USING SpecialtyIndex;

create table Sets 
( 
SetID int GENERATED ALWAYS AS IDENTITY UNIQUE NOT NULL,
SetName text not null, 
SetYear int not null,
SpecialtyID int not null
);
alter table Sets add constraint PKSets primary key (SetID); 
create index ISetsSetYear on Sets(SetYear);

create table Groups 
( 
GroupID int GENERATED ALWAYS AS IDENTITY UNIQUE NOT NULL,  
SetID int not null,
GroupName text not null, 
TeachformID int not null
);
alter table Groups add constraint PKGroups
primary key (GroupID); 
create index IGroupsTeachformID on Groups(TeachformID);

alter table Sets add constraint FKSetsSpecialities
foreign key (SpecialtyID) 
references Specialities(SpecialtyID) on update cascade;
alter table Groups add constraint FKGroupsSets foreign key 
(SetID) references Sets(SetID) on update cascade on delete cascade 