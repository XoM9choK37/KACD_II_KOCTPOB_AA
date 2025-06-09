CREATE OR REPLACE FUNCTION check_year_insert() RETURNS trigger AS 
$check_year_insert$
    BEGIN 
        IF NEW."Дата_рождения" IS NULL THEN
            RAISE EXCEPTION 'Укажите дату рождения!';
        END IF;
        IF date_part('year', NEW."Дата_рождения") >
			date_part('year', now()) THEN 
            RAISE EXCEPTION 'Нельзя добавить работника с годом
				рождения позже текущего!'; 
        END IF; 
        RETURN NEW; 
    END; 
$check_year_insert$ LANGUAGE plpgsql; 
CREATE OR REPLACE TRIGGER check_year_insert BEFORE INSERT
ON "Работник"
	FOR EACH ROW EXECUTE PROCEDURE check_year_insert();

CREATE OR REPLACE FUNCTION check_year_update() RETURNS trigger AS 
$check_year_update$
    BEGIN
        IF NEW."Дата_рождения" IS NULL THEN
            RAISE EXCEPTION 'Укажите дату рождения!';
        END IF;
        IF date_part('year', NEW."Дата_рождения") >
			date_part('year', now()) THEN 
            RAISE EXCEPTION 'Нельзя иметь работника с годом
				рождения позже текущего!'; 
        END IF; 
        RETURN NEW; 
    END; 
$check_year_update$ LANGUAGE plpgsql;
CREATE OR REPLACE TRIGGER check_year_update BEFORE UPDATE
ON "Работник"
    FOR EACH ROW EXECUTE PROCEDURE check_year_update();

CREATE OR REPLACE FUNCTION check_product_delete() RETURNS trigger AS 
$check_product_delete$ 
    BEGIN 
        IF OLD."Количество" > 0
		THEN 
            RAISE EXCEPTION 'Нельзя удалить продукт, который есть на складе!';
        END IF; 
        RETURN NEW; 
    END; 
$check_product_delete$ LANGUAGE plpgsql; 
CREATE OR REPLACE TRIGGER check_product_delete BEFORE DELETE
ON "Продукт" 
    FOR EACH ROW EXECUTE PROCEDURE check_product_delete();
