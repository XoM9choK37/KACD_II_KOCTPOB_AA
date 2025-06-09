CREATE OR REPLACE FUNCTION public.get_students()
    RETURNS text
    LANGUAGE 'plpgsql'
    VOLATILE
    PARALLEL UNSAFE
    COST 100
    
AS $BODY$
 
declare 
ret text default ''; 
rec  record; 
curs cursor for 
select * from students order by surname ASC, firstname ASC, lastname ASC;
begin 
	open curs; 
	loop 
		fetch curs into rec; 
		exit when not found; 
		ret := ret || '{' || rec.surname || ' ' || rec.firstname ||
		' ' || rec.lastname || ' ' || 
		rec.birthplace || '}' ||E'\n'; 
	end loop; 
	close curs; 
	return ret; 
end; 
$BODY$;
