SET ANSI_NULLS ON
GO

CREATE TABLE blog(
	id UNIQUEIDENTIFIER,
	writer varchar(30),
	date DATETIME,
	title varchar(255),
	body varchar(max),
	CONSTRAINT PK_blog PRIMARY KEY(id)
);
asdasdasdasd