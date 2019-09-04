--Listando todos os cursos de todas as escolas
USE DB_ESCOLA;
GO

SELECT * FROM TBEscolas, TBCursos

--Listando com restri��es
SELECT * FROM TBEscolas, TBCursos 
WHERE 
   TBEscolas.Id = TBCursos.IdEscola

--Lista com relacionamento, permitindo sele��o de campos
--Usando uma vari�vel como base de pesquisa 
DECLARE @Valor FLOAT;
SET @Valor = 1500;
SELECT 
    E.Descricao AS Escola,
	C.Descricao AS Curso,
	E.Endereco AS Endere�o,
	C.Preco AS Pre�o 
FROM 
   TBEscolas E, TBCursos C 
WHERE 
   E.Id = C.IdEscola 
   AND C.Preco >= @Valor

--Consultas envolvendo agrupamentos e fun��es de agrega��o
--Apresentar as escolas e a quantidade de cursos por escola
SELECT 
    E.Descricao AS Escola,
	E.Telefone AS Telefone,
	COUNT (C.Descricao) AS QuantCursos,
	SUM(C.Preco) AS Total
FROM
    TBEscolas E, TBCursos C
WHERE
    E.Id = C.IdEscola
GROUP BY
    E.Descricao, E.Telefone