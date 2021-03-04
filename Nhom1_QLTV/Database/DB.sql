
----Create Tables
CREATE TABLE Author (
  AuthorCode varchar(50) NOT NULL,
  AuthorName nvarchar(50) NULL,
  Website varchar(50) NULL,
  Note varchar(50) NULL,
  CONSTRAINT PK_Author_AuthorCode PRIMARY KEY CLUSTERED (AuthorCode)
)
CREATE TABLE Category(
  CategoryCode varchar(50) NOT NULL,
  CategoryName nvarchar(50) NULL,
  CONSTRAINT [PK_Category ] PRIMARY KEY CLUSTERED (CategoryCode)
)
CREATE TABLE Employee (
  EmployeeCode varchar(50) NOT NULL,
  FullName nvarchar(50) NULL,
  DateOfBirth date NULL,
  PhoneNumber varchar(50) NULL,
  CONSTRAINT PK_Employee_EmployeeCode PRIMARY KEY CLUSTERED (EmployeeCode)
)
CREATE TABLE LibraryCard (
  CardCode varchar(50) NOT NULL,
  BeginDate date NULL,
  ExpirationDate date NULL,
  Note varchar(50) NULL,
  CONSTRAINT PK_LibraryCard_CardCode PRIMARY KEY CLUSTERED (CardCode)
)
CREATE TABLE PublishingHouse (
  PublishingHouseCode varchar(50) NOT NULL,
  PublishingHouseName nvarchar(50) NULL,
  Address varchar(50) NULL,
  Email varchar(50) NULL,
  RepresentativeInfo nvarchar(100) NULL,
  CONSTRAINT PK_PublishingHouse_PublishingHouseCode PRIMARY KEY CLUSTERED (PublishingHouseCode)
)
CREATE TABLE Book (
  BookCode varchar(50) NOT NULL,
  BookName nvarchar(50) NULL,
  AuthorCode varchar(50) REFERENCES Author(AuthorCode),
  CategoryCode varchar(50) REFERENCES Category(CategoryCode),
  PublishingHouseCode varchar(50) REFERENCES PublishingHouse(PublishingHouseCode),
  PublishingYear date NULL,
  CONSTRAINT PK_Book_BookCode PRIMARY KEY CLUSTERED (BookCode)
 )

CREATE TABLE BorrowInfomationDetail (
  BorrowCode varchar(50) NOT NULL,
  Note varchar(50) NULL,
  BookReturnDate date NULL,
  ReturnStatus int NULL,
  CONSTRAINT PK_BorrowInfomationDetail_BorrowCode PRIMARY KEY CLUSTERED (BorrowCode),
  BookCode Varchar (50) references Book(BookCode)
)
CREATE TABLE BorrowInfomation (
  BorrowCode varchar(50) references BorrowInfomationDetail(BorrowCode),
  CardCode varchar(50) REFERENCES LibraryCard (CardCode),
  EmployeeCode varchar(50) references Employee(EmployeeCode),
  BorrowDate date NULL,
)
CREATE TABLE Readers (
  ReadersCode varchar(50) NOT NULL,
  ReadersName nvarchar(50) NULL,
  Address varchar(50) NULL,
  CardCode varchar(50) REFERENCES LibraryCard (CardCode),
  CONSTRAINT PK_Readers_ReadersCode PRIMARY KEY CLUSTERED (ReadersCode)
)


