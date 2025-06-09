CREATE OR REPLACE FUNCTION abort_alter_view_command() 
RETURNS event_trigger 
LANGUAGE plpgsql 
AS $$ 
BEGIN 
RAISE EXCEPTION 'Команда % отключена в базе данных %',
	tg_tag, current_catalog;
END; 
$$; 
CREATE EVENT TRIGGER abort_alter_view ON ddl_command_start 
WHEN TAG IN ('ALTER VIEW')
EXECUTE PROCEDURE abort_alter_view_command();
