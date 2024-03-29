USE DB_EVENTOS;
GO

--CRIANDO A TABELA TBEventos, COM UMA CHAVE PRIMARIA AUTO INCREMENTO
CREATE TABLE TBEventos 
(
    Id              int IDENTITY (1,1) not null , 
	Descricao       varchar(100) not null,
	Responsavel     varchar(50) not null,
	Data            datetime not null,
	Preco           float not null
	PRIMARY KEY (Id)
);
GO

CREATE TABLE TBConvidados
(
    Cpf             varchar(11)not null,
	IdEvento        int not null,
	Nome            varchar(50)not null,
	Telefone        varchar(20)not null,
	Email           varchar(60)not null
	PRIMARY KEY (Cpf),
	FOREIGN KEY (IdEvento) REFERENCES TBEventos(Id)
);
GO