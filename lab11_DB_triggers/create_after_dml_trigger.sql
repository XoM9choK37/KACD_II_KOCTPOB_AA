CREATE OR REPLACE FUNCTION log_orders() RETURNS TRIGGER AS 
$log_orders$ 
    BEGIN 
        IF (TG_OP = 'INSERT') THEN 
            INSERT INTO logs(log_id, date, info)
				VALUES (DEFAULT, now(), 'INSERT');
            RETURN NEW; 
        END IF; 
        RETURN NULL; 
    END; 
$log_orders$ LANGUAGE plpgsql; 
CREATE OR REPLACE TRIGGER log_orders 
AFTER INSERT ON "Заказ" 
    FOR EACH ROW EXECUTE PROCEDURE log_orders();
