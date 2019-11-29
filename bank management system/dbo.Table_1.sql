CREATE TABLE [dbo].[AdministratorTable]
(
	[AdiminName] nchar(50) not null,
	[AdminPasswd] nchar(50) not null,
	[AdminPhoneNumber] char(20) not null,
	[AdminSex] nvarchar(1) not null,
	[AdminID] char(20) not null,
	[AdminSalary] float not null DEFAULT 0
)
