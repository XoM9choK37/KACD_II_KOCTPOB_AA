CREATE TABLE Продукт
(
	ИД_продукта SERIAL PRIMARY KEY,
	Название TEXT,
	Поставщик TEXT,
	Цена INT,
	Количество INT
);

CREATE TABLE Меню
(
	ИД_меню SERIAL PRIMARY KEY,
	Тип TEXT
);

CREATE TABLE Блюдо
(
	ИД_блюда SERIAL PRIMARY KEY,
	ИД_меню INT REFERENCES Меню(ИД_меню),
	Название TEXT,
	Масса_порции INT,
	Цена INT
);

CREATE TABLE Продукт_в_блюде
(
	ИД_продукта INT REFERENCES Продукт(ИД_продукта),
	ИД_блюда INT REFERENCES Блюдо(ИД_блюда),
	PRIMARY KEY (ИД_продукта, ИД_блюда),
	Количество_продукта INT
);

CREATE TABLE Работник
(
	ИД_работника SERIAL PRIMARY KEY,
	Фамилия TEXT,
	Имя TEXT,
	Отчество TEXT,
	Дата_рождения DATE,
	Должность TEXT,
	Зарплата INT
);

CREATE TABLE Блюдо_работника
(
	ИД_работника INT REFERENCES Работник(ИД_работника),
	ИД_блюда INT REFERENCES Блюдо(ИД_блюда),
	PRIMARY KEY (ИД_работника, ИД_блюда)
);

CREATE TABLE Заказ
(
	ИД_заказа SERIAL PRIMARY KEY,
	ИД_работника INT REFERENCES Работник(ИД_работника),
	Дата_и_время_создания TIMESTAMP
);

CREATE TABLE Блюдо_в_заказе
(
	ИД_заказа INT REFERENCES Заказ(ИД_заказа),
	ИД_блюда INT REFERENCES Блюдо(ИД_блюда),
	PRIMARY KEY (ИД_заказа, ИД_блюда),
	Количество_порций INT
);

CREATE TABLE Клиент
(
	ИД_клиента SERIAL PRIMARY KEY,
	Номер_телефона TEXT
);

CREATE TABLE Заказ_клиента
(
	ИД_клиента INT REFERENCES Клиент(ИД_клиента),
	ИД_заказа INT REFERENCES Заказ(ИД_заказа),
	PRIMARY KEY (ИД_клиента, ИД_заказа)
)
