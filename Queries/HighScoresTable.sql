CREATE TABLE HighScores (
	Player_Id int Identity(1,1) Primary Key,
	Player_Name varchar(max) NOT NULL,
	Total_Profit decimal NOT NULL
);
Select * From HighScores;