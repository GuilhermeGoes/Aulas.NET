USE master;
GO

CREATE DATABASE DB_TRATAMENTOS
ON
(
    NAME = DB_TRATAMENTOS_DAT,
	FILENAME = N'C:\Users\Ta0505\Documents\Sinqia_AspNet\Data\DbTratamento.mdf',
	SIZE = 5000KB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 1000KB
)
LOG ON
( 
    NAME = DB_TRATAMENTOS_LOG,
	FILENAME = N'C:\Users\Ta0505\Documents\Sinqia_AspNet\Data\DbTratamento_log.ldf',
	SIZE = 2000KB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 1000KB
)
GO
