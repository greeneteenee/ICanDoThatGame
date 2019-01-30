use master
GO

IF DB_ID('ICanDoThatDB') IS NOT NULL
	DROP Database ICanDoThatDB
GO

CREATE Database ICanDoThatDB
GO

Use ICanDoThatDB
GO

CREATE TABLE ActionItems
(
	ActionID int PRIMARY KEY IDENTITY
	,ActionDescription varchar(50) NOT NULL
)
GO

CREATE TABLE WhereItems
(
	WhereID int PRIMARY KEY IDENTITY
	,WhereDescription varchar(50) NOT NULL
)
GO

CREATE TABLE WithItems
(
	WithID int PRIMARY KEY IDENTITY
	,WithDescription varchar(50) NOT NULL
)
GO