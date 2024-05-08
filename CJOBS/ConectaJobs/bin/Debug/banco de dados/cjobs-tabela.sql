create database CJOBS
use CJOBS

create table usuariosCJOBS ( -- criando tabela de usuários
cpf char (14) primary key, -- chave primária
nome varchar (100) not null,
email varchar (50) not null,
senha varchar (15) not null
);

create table candidaturas ( -- criando a tabela de candidaturas
	idcandidatura uniqueidentifier default newid() primary key, -- chave primária da tabela gerada randômicamente e automaticamente
	idusuario char (14) not null,
    empresa varchar (50) not null,
    cargo varchar (50) not null,
    situacao bit default 1 -- valor booleano para determinar se a candidatura tá ativa ou não [ATIVA = 1, NÃO ATIVA = 0]
	foreign key (idusuario) REFERENCES usuariosCJOBS(cpf) -- chave estrangeira idusuario que referencia o campo cpf da tabela usuariosCJOBS
);


-- Inserir uma nova candidatura na tabela candidaturas

insert into usuariosCJOBS (cpf, nome, email, senha) VALUES ('445.210.248.40', 'giovanna', 'giovanna@gmail.com', '030498')
insert into candidaturas (idusuario, empresa, cargo) VALUES ('445.210.248.40', 'Nova Empresa', 'Novo Cargo');

-- Verificar se os dados foram inseridos corretamente nas tabelas
SELECT * FROM candidaturas;
select * from usuariosCJOBS