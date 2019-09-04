USE DB_EVENTOS;
GO

--inserir dados na tabela TBEventos (4 eventos)
--Obs: as datas podem, ser fornecidas nos formatos:
--MM/dd/yyyy ou yyyy-MM-dd
INSERT INTO TBEventos (Descricao, Responsavel, Data, Preco)
VALUES 
('Palestra Javascript','Prof. João', '08/12/2019', 500),
('Workshop Python','Profa. Claudia', '2019/08/17', 90),
('Hackaton', 'Marcio Canuto', '2019/08/26', 200),
('Feira da Tecnologia','Seu Jaime', '2019/09/07', 20)

INSERT INTO TBConvidados (Cpf,IdEvento, Nome, Telefone, Email)
VALUES
('55265846988',1,'Cidão do Pastel', '11 965428564', 'cidãopastel@exemplo.com'),
('36328945636',1,'Palestrinha', '11 912547863', 'palestroso@exemplo.com'),
('55548578857',11,'Joane cabeleira', '11 965842310', 'omds@exemplo.com'),
('68448548494',2,'Zé','11 932564781', 'ze@exemplo.com'),
('67854415154',3,'Jão', '11 932546987', 'jao@exemplo.com'),
('65218987855',11,'Ju', '11 965472365', 'ju@exemplo.com'),
('65969884386',4,'Loro José', '11 965475236', 'loro@exemplo.com'),
('65546918787',4,'Casinão', '11 965442389', 'casino@exemplo.com')

--Transferindo dados da tabela TBEventosBackup para a tabela TBEventos, mediante consulta

INSERT INTO TBEventos (Descricao, Responsavel, Data, Preco)
SELECT Descricao, Responsavel, Data, preco 
FROM TBEventosBackup

--Removendo os elementos adicionados a mais
DELETE FROM TBEventos WHERE Id >= 20