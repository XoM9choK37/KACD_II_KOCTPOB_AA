-- Constraint: Заказ_клиента_ИД_заказа_fkey

-- ALTER TABLE IF EXISTS public."Заказ_клиента" DROP CONSTRAINT IF EXISTS "Заказ_клиента_ИД_заказа_fkey";

ALTER TABLE IF EXISTS public."Заказ_клиента"
    ADD CONSTRAINT "Заказ_клиента_ИД_заказа_fkey" FOREIGN KEY ("ИД_заказа")
    REFERENCES public."Заказ" ("ИД_заказа") MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE;
