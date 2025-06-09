insert into specialities(specialtyname, descript, facultyid)
values
('FIIT', 'Fundamental Informatics and Information Technologies', 1);

update specialities set specialtycode='02.03.02'
where specialtyname='FIIT';

delete from teachform where descript='Part-time'
