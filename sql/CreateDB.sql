CREATE TABLE [Groups] (
	[GroupID]	INT				IDENTITY	NOT NULL,
	[GroupName]	NVARCHAR(255)				NOT NULL,
	PRIMARY KEY CLUSTERED ([GroupID])
);

CREATE TABLE [Students] (
	[StudentID]	INT				IDENTITY	NOT NULL,
	[FullName]	NVARCHAR(100)			NOT NULL,
	[Name]		NVARCHAR(100)				NOT NULL,
	[Gender]	CHAR						NOT NULL,
	[GroupID]	INT							NOT NULL,
	PRIMARY KEY CLUSTERED ([StudentID]),
	FOREIGN KEY ([GroupID]) REFERENCES [Groups]([GroupID])
);

CREATE TABLE [Account] (
	[StudentID]		INT	NOT NULL,
	[Not done]		INT NOT NULL,
	[Homework]		INT NOT NULL,
	[Wrong]			INT NOT NULL,

	FOREIGN KEY ([StudentID]) REFERENCES [Students]([StudentID])
);

TRUNCATE TABLE [Groups];
TRUNCATE TABLE [Students];
TRUNCATE TABLE [Account];

INSERT INTO [Groups]
VALUES (N'ege_11_bl+onl-group_inf_std_paid_max_33w_59l_20.09.23_7524_koms_sochi'), (N'oge_9_bl-group_inf_std_paid_opt_23w_46l_21.11.23_16012_kzev_krd');

INSERT INTO [Students]
VALUES	(N'Алина Козлова',		N'Алина',		'F', 1), --1
		(N'Давид Манасян',		N'Давид',		'M', 1), --2
		(N'Даниил Бибичев',		N'Даниил',		'M', 1), --3
		(N'Егор Аникин',		N'Егор',		'M', 1), --4
		(N'Ирина Виноградова',	N'Ира',			'F', 1), --5
		(N'Лина Кузнецова',		N'Лина',		'F', 1), --6
		(N'Максим Голяков',		N'Макс',		'M', 1), --7
		(N'Максим Примоченко',	N'Макс',		'M', 1), --8
		(N'Милана Самойлова',	N'Милана',		'F', 1), --9
		(N'Никита Шестаков',	N'Никита',		'M', 1), --10
		(N'Рипсиме Мнеян',		N'Рита',		'F', 1), --11
		(N'Семен Истомин',		N'Семен',		'M', 1), --12
		(N'Тимур Казыев',		N'Тимур',		'M', 1), --13
		(N'Юлиан Здоровцев',	N'Юлиан',		'M', 1), --14
		(N'Владислав Асман',	N'Влад',		'M', 2), --15
		(N'Ирина Речняк',		N'Ира',			'F', 2), --16
		(N'Клим Куприянов',		N'Клим',		'M', 2), --17
		(N'Михаил Саламахин',	N'Миша',		'M', 2), --18
		(N'Роман Баклаев',		N'Рома',		'M', 2), --19
		(N'Тимофей Алешкин',	N'Тимофей',		'M', 2); --20

INSERT INTO [Account]
VALUES 
(1, 49, 15, 17),
(2, 34, 41, 56),
(4, 39, 31, 15),
(5, 0, 98, 4),
(6, 19, 66, 51),
(7, 19, 69, 59),
(8, 47, 17, 2),
(9, 59, 0, 0),
(10, 36, 45, 65),
(11, 12, 81, 9),
(12, 56, 7, 20),
(13, 34, 39, 5),
(14, 12, 73, 14),
(15, 17, 59, 18),
(16, 22, 57, 79),
(17, 25, 49, 52),
(18, 2, 92, 9),
(19, 12, 67, 21),
(20, 3, 89, 28)
