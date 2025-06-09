SELECT Название
FROM Блюдо
ORDER BY Название ASC;

SELECT Поставщик
FROM Продукт
GROUP BY Поставщик;

SELECT Должность, COUNT(Должность) AS Число
FROM Работник
WHERE Зарплата > 20000
GROUP BY Должность
HAVING COUNT(*) > 1;

SELECT Дата_и_время_создания
FROM Заказ;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Картофель'));

SELECT Масса_порции
FROM Блюдо
ORDER BY Масса_порции ASC;

SELECT Цена
FROM Продукт
GROUP BY Цена;

SELECT Название
FROM Продукт
WHERE Количество >= 10
GROUP BY Название;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Капуста'));

SELECT Номер_телефона
FROM Клиент;

SELECT Название
FROM Продукт
WHERE Количество > 5;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Свинина'));

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Молоко'));

SELECT Название
FROM Продукт
WHERE Количество <= 5;

SELECT * FROM Клиент;

SELECT Зарплата
FROM Работник;

SELECT * FROM Работник;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Огурцы'));

SELECT Название
FROM Продукт
WHERE Количество >= 30;

SELECT Масса_порции
FROM Блюдо
WHERE Масса_порции >= 100
ORDER BY Масса_порции ASC;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Сливки'));

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Сыр'));

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Помидоры'));

SELECT Масса_порции
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Огурцы'));

SELECT Цена
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Капуста'));

SELECT Цена
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Молоко'));

SELECT Цена
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Сыр'));

SELECT Название, Цена
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Свинина'));

SELECT Название, Цена
FROM Продукт
WHERE Количество <= 5;

SELECT Название, Цена
FROM Продукт
WHERE Количество <= 10;

SELECT Название, Цена
FROM Продукт
WHERE Количество <= 15;

SELECT Цена
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Яблоки'));

SELECT Название, Цена
FROM Продукт
WHERE Количество <= 20;

SELECT Название, Цена
FROM Продукт
WHERE Количество <= 25;

SELECT Фамилия
FROM Работник
WHERE Зарплата <= 10000;

SELECT Название
FROM Блюдо
WHERE Цена <= 70 OR Цена >= 200;

SELECT Фамилия
FROM Работник
WHERE Зарплата <= 15000;

SELECT Фамилия
FROM Работник
WHERE Зарплата <= 20000;

SELECT Фамилия
FROM Работник
WHERE Зарплата <= 25000;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Говядина'));

SELECT Фамилия
FROM Работник
WHERE Зарплата >= 30000;

SELECT Название
FROM Блюдо
WHERE Цена >= 100;

SELECT Название
FROM Блюдо
WHERE Цена >= 100 AND Цена <= 200;

SELECT Название
FROM Блюдо
WHERE Цена <= 50;

SELECT Название
FROM Блюдо
WHERE Цена >= 300;

SELECT Дата_и_время_создания
FROM Заказ
ORDER BY Дата_и_время_создания DESC;

SELECT Название, Цена
FROM Блюдо
ORDER BY Цена DESC;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Капуста'))
AND Цена < 100;

SELECT Название
FROM Блюдо
WHERE ИД_блюда
IN (SELECT ИД_блюда FROM Продукт_в_блюде WHERE ИД_продукта
IN (SELECT ИД_продукта FROM Продукт WHERE Название = 'Картофель'))
AND Цена >= 50;

SELECT Фамилия, Имя, Должность, Зарплата
FROM Работник
ORDER BY Зарплата DESC
