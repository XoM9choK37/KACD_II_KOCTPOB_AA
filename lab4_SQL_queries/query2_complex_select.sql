select * from students order by surname ASC, firstname ASC, lastname ASC;

select * from students where groupid
in (select groupid from groups where teachformid
in (select teachformid from teachform where descript
in ('Part-time')));

select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Full-time')) UNION ALL
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Part-time')) UNION ALL
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Correspondence'))
