create table Category(
	Id Int IDENTITY (1,1) Not Null,
	Name Varchar(100) Not Null,
	CONSTRAINT PK_Category PRIMARY KEY CLUSTERED (Id) 
)

create table Course(
	Id Int IDENTITY (1,1) Not Null,
	CategoryId Int Not Null,
	Name Varchar(100) Not Null,
	Description Varchar(250) Not Null,
	StartDate DateTime Not Null,
	EndDate DateTime Not Null,
	StudentsPerClass Int null,
	CONSTRAINT PK_Course PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT FK_Course_Category FOREIGN KEY (CategoryId) REFERENCES Category(Id) 
)