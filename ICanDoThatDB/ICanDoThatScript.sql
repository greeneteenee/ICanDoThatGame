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
, ('Hop')
, ('Walk backwards')
, ('Spin')
, ('Gallop')
, ('Roll')
, ('Run')
, ('Frog hop')
, ('Jumping jack')
, ('Lunge')
, ('Star jump')
, ('Inchworm')
, ('Tightrope')
, ('Hop on one leg')
, ('Zombie walk')
, ('Chicken dance')
, ('Granny walk')
, ('Snake slither')
, ('March')
, ('Runway walk')
, ('Duck walk')
, ('Jump rope')
, ('Limbo')
, ('Karate kick')
, ('Sideways plank walk')
, ('Skate');
GO

INSERT INTO WhereItems (WhereDescription)
VALUES ('to the fridge')
, ('to a sink and back')
, ('to the front door and back')
, ('to four walls')
, ('to two lighswitches')
, ('to a tv and back')
, ('to a mirror and back')
, ('to a plant')
, ('to a bathtub')
, ('to a bookcase')
, ('to a trashcan')
, ('around a chair')
, ('to a bedroom')
, ('to three rooms')
, ('around a laundry basket four times')
, ('over a toy four times')
, ('behind a curtain three times')
, ('around a table')
, ('under a table')
, ('over a bed')
, ('over a sofa')
, ('to something red')
, ('to something blue')
, ('to something yellow')
, ('to two rugs')
, ('to two doors')
, ('across two chairs')
, ('to a toilet')
, ('to a closet')
, ('to a window and back');
GO

INSERT INTO WithItems (WithDescription)
VALUES ('with a book in your hand!')
, ('with a book on your head!')
, ('with a book inside your clothes!')
, ('with a book under your left arm!')
, ('with a book between your elbows!')
, ('with a book under your chin!')
, ('with a book between your knees!')
, ('with a book under your right arm!')
, ('with a book behind your back!')
, ('with a ball between your elbows!')
, ('with a ball under your chin!')
, ('with a ball between your knees!')
, ('with a bottle between your elbows!')
, ('with a bottle under your chin!')
, ('with a bottle between your knees!')
, ('with a stuffed animal on your head!')
, ('with a stuffed animal inside your clothes!')
, ('with a stuffed animal between your elbows!')
, ('with a stuffed animal under your chin!')
, ('with a stuffed animal between your knees!')
, ('with  a stuffed animal behind your back!')
, ('with a spoon between your teeth')
, ('with a spoon on your nose')
, ('with a spoon behind your back')
, ('with an umbrella in your hand!')
, ('with an umbrella inside your clothes!')
, ('with an unbrella under your left arm!')
, ('with an umbrella between your elbows!')
, ('with an umbrella under your chin!')
, ('with an umbrella between your knees!')
, ('with an umbrella under your right arm!')
, ('with an umbrella behind your back!')
, ('with a broom between your legs')
, ('with a broom over your head')
, ('with a blanket behind your back!')
, ('with a blanket over your head!')
, ('with a tissue on your head')
, ('with a tissue between your elbows!')
, ('with a pillow on your head!')
, ('with a pillow inside your clothes!')
, ('with a pillow between your elbows!')
, ('with a pillow under your chin!')
, ('with a pillow between your knees!')
, ('with a paper on your head!')
, ('with a paper between your elbows!')
, ('with a paper under your chin!')
, ('with a cup in your hand!')
, ('with a cup on your head!')
, ('with a cup behind your back!')
, ('in a pillow case!')
, ('while hula hooping!')
, ('while spinning a hula hoop on your arm!')
, ('while bouncing a ball!')
, ('with high heels on!');
GO
