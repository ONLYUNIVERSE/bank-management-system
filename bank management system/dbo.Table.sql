CREATE TABLE [dbo].[AccountTable]
(
	[UserName] nchar(50) not null,
	[Password] nchar(50) not null,
	[Name] nchar(50) not null,
	[Sex] nvarchar(1) not null,
	[PhoneNumber] nchar(11) not null,
	[IDNumber] char(18) not null,
	[BankCardNumber] char(20) not null,
	[Operator] nchar(50) not null,
	[Money] int not null DEFAULT 0,
	[DepositType] nchar(10) not null
)
