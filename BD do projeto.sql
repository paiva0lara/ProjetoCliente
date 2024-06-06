/* criando banco de dados*/

create database dbProjeto;
/*use dbProjeto*/
use dbProjeto;

/*criando as tabelas do banco*/
create table tbCliente(
CodCli int primary key auto_increment,
Nome varchar (50),
Email varchar(50),
telefone varchar(20)
);

select * from tbCliente;