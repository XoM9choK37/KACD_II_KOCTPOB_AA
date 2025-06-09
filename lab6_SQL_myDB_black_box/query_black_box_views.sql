CREATE VIEW Отчёт_о_заказах AS
	(SELECT NULL AS ИД_заказа, NULL AS ИД_работника,
		NULL AS Дата_и_время_создания,
		SUM(Стоимость_заказа) AS Стоимость_заказа
	FROM (
		SELECT ИД_заказа, ИД_работника, Дата_и_время_создания,
			(SELECT SUM(Стоимость)
			FROM (
				SELECT Цена * (
					SELECT SUM(Количество_порций)
					FROM (
						SELECT *
						FROM Блюдо_в_заказе
						WHERE ИД_блюда = Блюдо.ИД_блюда
					)
					WHERE ИД_заказа = Заказ.ИД_заказа
				) AS Стоимость
				FROM Блюдо
			)) AS Стоимость_заказа
		FROM Заказ
	))
	UNION
	(SELECT ИД_заказа, ИД_работника, Дата_и_время_создания,
		(SELECT SUM(Стоимость)
		FROM (
			SELECT Цена * (
				SELECT SUM(Количество_порций)
				FROM (
					SELECT *
					FROM Блюдо_в_заказе
					WHERE ИД_блюда = Блюдо.ИД_блюда
				)
				WHERE ИД_заказа = Заказ.ИД_заказа
			) AS Стоимость
			FROM Блюдо
		)) AS Стоимость_заказа
	FROM Заказ)
	ORDER BY Дата_и_время_создания DESC;

CREATE VIEW Отчёт_о_количестве_продуктов AS
	(SELECT NULL AS Название, NULL AS Цена,
		SUM(Количество) AS Количество
	FROM Продукт)
	UNION
	(SELECT Название, Цена, Количество
	FROM Продукт)
	ORDER BY Количество DESC;

CREATE VIEW Отчёт_о_зарплатах AS
	(SELECT NULL AS Фамилия, NULL AS Имя,
		NULL AS Отчество, NULL AS Должность,
		SUM(Зарплата) AS Зарплата
	FROM Работник)
	UNION
	(SELECT Фамилия, Имя, Отчество, Должность, Зарплата
	FROM Работник)
	ORDER BY Зарплата DESC
