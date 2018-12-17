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


CREATE TABLE CARDS
(
	CardID					INT PRIMARY KEY IDENTITY,
	CardsName				VARCHAR(100) NOT NULL,
	ThemeIndex				INT NOT NULL,
	ActualCardBG			VARCHAR(200) NOT NULL,
	ActualCardTextColor		VARCHAR(200) NOT NULL,
	CardsFontFamily			VARCHAR(200) NOT NULL,
	CardHolderDisplay		VARCHAR(200) NOT NULL,
	CardHolderPadding		VARCHAR(200) NOT NULL,
	CardHeadBG				VARCHAR(200) NOT NULL,
	CardHeadPadding			VARCHAR(200) NOT NULL,
	WorkAreaDisplay			VARCHAR(200) NOT NULL,
	CardBodyDisplay			VARCHAR(200) NOT NULL,
	CardFooterTextAlign		VARCHAR(200) NOT NULL,
	CardFooterBorderTop		VARCHAR(200) NOT NULL,
	CardFooterPaddingTop	VARCHAR(200) NOT NULL
)

DROP TABLE CARDS
DROP proc ADD_NEW_CARDS

CREATE PROC ADD_NEW_CARDS
@cardsName				VARCHAR(100),
@themeIndex				INT,
@actualCardBG			VARCHAR(200),
@actualCardTextColor	VARCHAR(200),
@cardsFontFamily		VARCHAR(200),
@cardHolderDisplay		VARCHAR(200),
@cardHolderPadding		VARCHAR(200),
@cardHeadBG				VARCHAR(200),
@cardHeadPadding		VARCHAR(200),
@workAreaDisplay		VARCHAR(200),
@cardBodyDisplay		VARCHAR(200),
@cardFooterTextAlign	VARCHAR(200),
@cardFooterBorderTop	VARCHAR(200),
@cardFooterPaddingTop	VARCHAR(200)
AS
BEGIN
	INSERT INTO CARDS VALUES
	(@cardsName, @themeIndex, @actualCardBG, @actualCardTextColor, @cardsFontFamily, @cardHolderDisplay, @cardHolderPadding, @cardHeadBG,
	 @cardHeadPadding, @workAreaDisplay, @cardBodyDisplay, @cardFooterTextAlign, @cardFooterBorderTop, @cardFooterPaddingTop)
END

SELECT * FROM CARDS

delete from Cards

CREATE PROC SELECT_ALL_CARD_IDs
AS
BEGIN
	SELECT
		CardID, CardsName
	FROM 
		Cards
END

CREATE PROC SELECT_CARD_VALUES_BY_ID
@cardID		INT
AS
BEGIN
	SELECT
		*	
	FROM
		CARDS
	WHERE
		CardId = @cardID
	
END

CREATE PROC MODIFY_CARD_BY_ID
@cardID					INT,
@themeIndex				INT,
@cardName				VARCHAR(100),
@actualCardBG			VARCHAR(100),
@actualCardTextColor	VARCHAR(100),
@cardHolderDisplay		VARCHAR(100),
@cardHolderPadding		VARCHAR(100),
@cardHeadBG				VARCHAR(100),
@cardHeadPadding		VARCHAR(100),
@workAreaDisplay		VARCHAR(100),
@cardBodyDisplay		VARCHAR(100),
@cardFooterTextAlign	VARCHAR(100),
@cardFooterBorderTop	VARCHAR(100),
@cardFooterPaddingTop	VARCHAR(100)
AS
BEGIN
	UPDATE
		CARDS
	SET
		ThemeIndex = @themeIndex, CardsName = @cardName, ActualCardBG = @actualCardBG, ActualCardTextColor = @actualCardTextColor, CardHolderDisplay = @cardHolderDisplay,
		CardHolderPadding = @cardHolderPadding, CardHeadBG = @cardHeadBG, CardHeadPadding = @cardHeadPadding, WorkAreaDisplay = @workAreaDisplay,
		CardBodyDisplay = @cardBodyDisplay, CardFooterTextAlign = @cardFooterTextAlign, CardFooterBorderTop = @cardFooterBorderTop, CardFooterPaddingTop = @cardFooterPaddingTop
	WHERE
		CardId = @cardID
END

SELECT * From CARDS


CREATE PROC DELETE_CARD_BY_ID
@cardID		INT
AS
BEGIN
	DELETE FROM CARDS WHERE CardID = @cardID
END

SELECT * FROM CARDS