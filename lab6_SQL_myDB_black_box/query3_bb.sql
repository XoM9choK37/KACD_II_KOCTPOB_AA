SELECT ИД_заказа, ИД_работника, Дата_и_время_создания,
	(SELECT SUM(Стоимость)
	FROM (
		SELECT Цена * (
			SELECT COUNT(ИД_блюда)
			FROM (
				SELECT ИД_блюда
				FROM Блюдо_в_заказе
				WHERE ИД_заказа = Заказ.ИД_заказа
			)
			WHERE ИД_блюда = Блюдо.ИД_блюда
		) AS Стоимость
		FROM Блюдо
	)) AS Стоимость_заказа
FROM Заказ
UNION
SELECT NULL, NULL, NULL, SUM(Стоимость_заказа)
FROM (
	SELECT ИД_заказа, ИД_работника, Дата_и_время_создания,
		(SELECT SUM(Стоимость)
		FROM (
			SELECT Цена * (
				SELECT COUNT(ИД_блюда)
				FROM (
					SELECT ИД_блюда
					FROM Блюдо_в_заказе
					WHERE ИД_заказа = Заказ.ИД_заказа
				)
				WHERE ИД_блюда = Блюдо.ИД_блюда
			) AS Стоимость
			FROM Блюдо
		)) AS Стоимость_заказа
	FROM Заказ
);

SELECT Цена, Название, Количество FROM Продукт
UNION
SELECT NULL, NULL, SUM(Количество) FROM Продукт
ORDER BY Количество ASC;

SELECT Фамилия, Имя, Отчество, Должность, Зарплата FROM Работник
UNION
SELECT NULL, NULL, NULL, NULL, SUM(Зарплата) FROM Работник
ORDER BY Зарплата ASC
