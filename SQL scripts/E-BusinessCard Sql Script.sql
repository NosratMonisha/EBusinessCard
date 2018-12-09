CREATE DATABASE EBDB

USE EBDB

CREATE TABLE [USER]
(
	UserID				INT PRIMARY KEY IDENTITY,
	UserName			VARCHAR(50)  NOT NULL,
	FullName			VARCHAR(50)  NOT NULL,
	[Password]			VARCHAR(50)	 NOT NULL,
	Email				VARCHAR(200) NOT NULL,
	PhoneNumber			VARCHAR(15)  NOT NULL,
	[Address]			VARCHAR(MAX) NOT NULL,
	DOB					DATETIME	 NOT NULL
)

ALTER PROC SELECT_USER_BY_USERNAME_N_PASSWORD
@username	VARCHAR(50),
@password	VARCHAR(50)
AS
BEGIN
	SELECT
		Username
	FROM 
		[User]
	WHERE
		Username = @username AND [Password] = @password		
END

CREATE PROC ADD_NEW_USER
@username		VARCHAR(50),
@fullname		VARCHAR(50),
@password		VARCHAR(50),
@email			VARCHAR(200),
@address		VARCHAR(MAX),
@dob			DATETIME,
@phonenumber	VARCHAR(15)
AS
BEGIN
	INSERT INTO 
		[User]	
	VALUES
		(@username, @fullname, @password, @email, @phoneNumber, @address, @DOB)
END


SELECT * FROM [User]

CREATE TABLE [Admin]
(
	AdminID			INT PRIMARY KEY IDENTITY,
	Username		VARCHAR(50) NOT NULL,
	Fullname		VARCHAR(50) NOT NULL,
	[Password]		VARCHAR(50) NOT NULL
)

CREATE PROC SELECT_ADMIN_BY_USERNAME_N_PASSWORD
@username		VARCHAR(50),
@password		VARCHAR(50)
AS
BEGIN
	SELECT 
		Fullname
	FROM 
		[Admin]
	WHERE 
		Username = @username AND [Password] = @password
END

INSERT INTO [Admin] VALUES('Monisha','Nosrat Monisha','12345')

SELECT * FROM [Admin]