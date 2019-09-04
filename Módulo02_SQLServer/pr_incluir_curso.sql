--criar uma stored procedure capaz de incluir ou alterar um
--convidado. A alteração ocorrerá se o CPF informado já estiver
--cadastrado
USE DB_ESCOLA;
GO
ALTER PROC pr_incluir_curso
(
	@codigo int,
	@idescola int,
	@descricao varchar(50),
	@cargaHoraria int,
	@preco float,
	@status int output         --0: incluido, --1: alterado
)
AS
BEGIN
	IF EXISTS(SELECT Codigo FROM TBCursos WHERE Codigo = @codigo)
		BEGIN
			UPDATE TBCursos SET IdEscola = @idescola, Descricao = @descricao,
			CargaHoraria = @cargaHoraria, Preco=@preco WHERE Codigo=@codigo

			SET @status = 1
		END
	ELSE
		BEGIN
			INSERT INTO TBCursos(Descricao,CargaHoraria,Preco)
			VALUES (@descricao, @cargaHoraria, @preco)

			SET @status = 0
		END
END