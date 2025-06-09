create view viewFTSample3 as select groupname
from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Full-time'));

create view viewPTSample3 as select groupname
from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Part-time'));

create view viewCSample3 as select groupname
from groups where setid
in (select setid from sets where setyear
in ('2015')) and teachformid
in (select teachformid from teachform where descript
in ('Correspondence'))
