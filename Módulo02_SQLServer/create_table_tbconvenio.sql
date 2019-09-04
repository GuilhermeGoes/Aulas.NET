USE DB_TRATAMENTOS
GO

CREATE TABLE TBPaciente
(
	Cpf               varchar(11) PRIMARY KEY not null,
	Nome              varchar(50) not null,
	Email             varchar(50) not null,
	Telefone          varchar(15) not null,
	Idade             int not null,
);
GO

CREATE TABLE TBConvenio 
(
    Id           int PRIMARY KEY IDENTITY not null,
    Nome         varchar(30) not null,
	Cnpj         varchar(14) not null,
	Telefone     varchar(15) not null,     
);
GO

CREATE TABLE TBMatMed
(
    Id           int PRIMARY KEY IDENTITY,
    Nome         varchar(20) not null,
	Descricao    varchar(100) not null,
	Preco        float not null,
	unidade      float not null,
	Tipo         int not null CHECK (Tipo = 1 OR Tipo = 2)
);
GO

CREATE TABLE TBTratamento
(
    Id             int PRIMARY KEY IDENTITY not null,
	Nome           varchar(30) not null,
	Descricao      varchar(100) not null,
	preco          float not null,
	duracao        varchar(15) not null,
);
GO

CREATE TABLE TBPacienteConvenio
(
    Id                int PRIMARY KEY IDENTITY not null,
	CpfPaciente       varchar(11) not null,
	IdConvenio        int not null
	FOREIGN KEY (CpfPaciente) REFERENCES TBPaciente(Cpf),
	FOREIGN KEY (IdConvenio) REFERENCES TBConvenio (Id),
);
GO

CREATE TABLE TBPacienteTratamento
(
    Codigo                varchar(20) not null,
	CpfPaciente           varchar(11) not null,
	Descricao             varchar(30) not null,
	IdTratamento          int not null,
	inicioTratamento      datetime not null,
	terminoTratamento     datetime not null
	
	PRIMARY KEY (Codigo),
	FOREIGN KEY (CpfPaciente) REFERENCES TBPaciente (Cpf),
	FOREIGN KEY (IdTratamento) REFERENCES TBTratamento (Id)
);
GO

CREATE TABLE TBPacienteMecicamento
(
    Id             int PRIMARY KEY IDENTITY not null,
	CpfPaciente    varchar(11) not null,
	IdMatMed       int not null,
	Descricao      varchar(50) not null,
	FOREIGN KEY (CpfPaciente) REFERENCES TBPaciente (Cpf),
	FOREIGN KEY (IdMatMed) REFERENCES TBMatMed (Id)
);
GO


