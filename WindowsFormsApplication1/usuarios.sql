create database carimports;
use carimports;

create table tb_login(
log_usuario varchar(20) primary key,
log_senha varchar(8) not null,
log_nome varchar(40) not null,
log_ult_atualizacao timestamp not null
);

select * from tb_login;

CREATE TABLE tb_Produtos (
     CodProd VarChar(5) primary key,
     DescrProd varchar(30) not null,
     QtdEstoq decimal(5,2) not null,
     Locacao varchar(3) not null,
     PrcCusto decimal(6,2) not null,
     PrcVenda decimal(6,2) not null,
     cur_ult_Atualizacao timestamp DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
     );  
     
select * from tb_Produtos;     