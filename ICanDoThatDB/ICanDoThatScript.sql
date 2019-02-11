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

INSERT INTO ActionItems(ActionDescription)
VALUES ('Crab walk')
, ('Take giant steps')
, ('Crawl')
, ('Dance')
, ('Skip')
, ('Penguin walk')
, ('Tip toe')
, ('Hop');
GO

INSERT INTO WhereItems (WhereDescription)
VALUES ('to the fridge')
, ('to a sink and back')
, ('to the front door and back')
, ('to a bathtub')
, ('to a book')
, ('around a chair')
, ('to a bedroom')
, ('to a window');
GO

INSERT INTO WithItems (WithDescription)
VALUES ('with a book in your hand!')
, ('with a book on your head!')
, ('with  a book inside your clothes!')
, ('with a book under your left arm!')
, ('with a book between your elbows!')
, ('with a book under your chin!')
, ('with a book between your knees!')
, ('with a book under your right arm!');
GO
