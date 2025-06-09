-- Constraint: Заказ_клиента_ИД_клиента_fkey

-- ALTER TABLE IF EXISTS public."Заказ_клиента" DROP CONSTRAINT IF EXISTS "Заказ_клиента_ИД_клиента_fkey";

ALTER TABLE IF EXISTS public."Заказ_клиента"
    ADD CONSTRAINT "Заказ_клиента_ИД_клиента_fkey" FOREIGN KEY ("ИД_клиента")
    REFERENCES public."Клиент" ("ИД_клиента") MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE CASCADE;
