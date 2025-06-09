CREATE OR REPLACE PROCEDURE proc1(curs INOUT refcursor)
LANGUAGE plpgsql AS $$ 
DECLARE 
lcurs refcursor; 
BEGIN 
open lcurs for 
select * from students order by surname ASC, firstname ASC, lastname ASC;
curs = lcurs; 
END $$; 
create or replace function get_proc_curs () returns text as $$ 
declare 
ret text default ''; 
rec  record; 
curs refcursor; 
begin
call proc1(curs); 
loop 
		fetch curs into rec; 
		exit when not found; 
		ret := ret || '{' || rec.surname || ' ' || rec.firstname ||
		' ' || rec.lastname || ' ' || 
		rec.birthplace || '}' ||E'\n'; 
	end loop; 
close curs; 
return ret; 
end; $$ 
LANGUAGE plpgsql
