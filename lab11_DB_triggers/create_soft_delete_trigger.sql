CREATE OR REPLACE FUNCTION delete_worker() RETURNS trigger 
AS $delete_worker$ 
DECLARE 
command text := '" SET "isdeleted" = true WHERE "ИД_работника" = $1'; 
BEGIN 
IF (OLD."isdeleted" IS NULL) or (OLD."isdeleted" = false) THEN 
EXECUTE 'UPDATE "' || TG_TABLE_NAME || command USING 
OLD."ИД_работника"; 
RETURN NULL; END IF; 
RETURN OLD; END; 
$delete_worker$ LANGUAGE plpgsql; 
CREATE OR REPLACE TRIGGER delete_worker
BEFORE DELETE ON "Работник"  
FOR EACH ROW EXECUTE PROCEDURE delete_worker(); 
