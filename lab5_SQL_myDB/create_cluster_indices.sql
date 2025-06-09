CREATE UNIQUE INDEX Индекс_продукта ON Продукт(ИД_продукта);
CLUSTER Продукт USING Индекс_продукта;

CREATE UNIQUE INDEX Индекс_работника ON Работник(ИД_работника);
CLUSTER Работник USING Индекс_работника;

CREATE UNIQUE INDEX Индекс_блюда ON Блюдо(ИД_блюда);
CLUSTER Блюдо USING Индекс_блюда;

CREATE UNIQUE INDEX Индекс_меню ON Меню(ИД_меню);
CLUSTER Меню USING Индекс_меню;

CREATE UNIQUE INDEX Индекс_заказа ON Заказ(ИД_заказа);
CLUSTER Заказ USING Индекс_заказа;

CREATE UNIQUE INDEX Индекс_клиента ON Клиент(ИД_клиента);
CLUSTER Клиент USING Индекс_клиента
