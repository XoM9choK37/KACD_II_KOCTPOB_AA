create procedure procedureFTSample3()
language sql as $$
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Full-time'))$$;

create procedure procedurePTSample3()
language sql as $$
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Part-time'))$$;

create procedure procedureCSample3()
language sql as $$
select count(*) from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Correspondence'))$$
