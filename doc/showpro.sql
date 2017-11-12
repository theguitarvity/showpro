create database showpro;
use showpro;


create table Usuario(
	codUsuario numeric(7) not null,
    emailUsuario varchar(100) not null,
    senhaUsuario varchar(30) not null,
    primary key(codUsuario)
);

create table Cliente(
	codCliente numeric(7) not null,
    nomeCliente varchar(30) not null,
    cpfCliente varchar(11)not null,
    emailCliente varchar(100) not null,
    dtNasc date not null,
    created_at timestamp,
    update_at timestamp,
    primary key(codCliente)
    
    
);
alter table cliente drop update_at;
drop table Cliente;
insert into cliente values(1234, 'teste', '44433322211', 'teste@teste', '2015-03-10')


select * from funcionario
create table Endereco(
	codEndereco numeric(7) not null,
    logradouro varchar(100) not null,
    numero int not null,
    bairro varchar(50) not null,
    cidade varchar(50) not null,
    estado char(2) not null,
    cep varchar(15) not null,
    primary key(codEndereco)
    
);
create table local(
	codLocal numeric(7) not null,
    nomeLocal varchar(30) not null,
    endereco numeric(7) not null,
    detalhes varchar(1000)  not null,
    primary key(codLocal),
    foreign key(endereco) references endereco(codEndereco) on delete cascade on update cascade
);

create table Tipo(

	codTipo numeric(4) not null,
    nomeTipo varchar(30) not null,
    primary key(codTipo)
);

select nomeTipo as nome from Tipo

create table Funcionario(
	codFuncionario numeric(7) not null,
    nomeFuncionario varchar(50) not null,
    cpfFuncionario varchar(11) not null,
    dataNascimento date not null,
    dataInicio date not null,
	cargoFuncionario varchar(40) not null,
    primary key(codFuncionario),
    foreign key(codFuncionario) references Usuario(codUsuario) on update cascade on delete cascade

);


create table Administrador(
	codFuncionario numeric(7) not null,
    privilegio varchar(10) not null,
    primary key(codFuncionario),
    foreign key(codFuncionario) references Funcionario(codFuncionario) on update cascade on delete cascade

);
select * from Tipo;
rename table Tipo to tipo

create table organizador(

codFuncionario numeric(7) not null,
    privilegio varchar(10) not null,
    primary key(codFuncionario),
    foreign key(codFuncionario) references Funcionario(codFuncionario) on update cascade on delete cascade

);

create table evento(
	codEvento numeric(7) not null,
    nomeEvento varchar(100) not null,
    dtEvento date not null,
    horaEvento datetime,
    detalhes varchar(1000)not null,
    tipo numeric(4) not null,
    localEvento numeric(7) not null,
    primary key(codEvento),
    foreign key(tipo) references tipo(codTipo),
    foreign key(localEvento) references local(codLocal)
);

create table atracao(
	codAtracao numeric(7) not null,
    nomeAtracao varchar(100) not null,
    tipoAtracao varchar(30) not null,
    detalhes varchar(1000) not null,
    primary key(codAtracao)
);


create table evento_atracao(
	codEvento numeric(7) not null,
    codAtracao numeric(7)not null,
    primary key(codEvento, codAtracao),
    foreign key(codEvento) references evento(codEvento) on delete cascade,
    foreign key(codAtracao) references atracao(codAtracao) on delete cascade

);
create table ingresso(
	codIngresso numeric(7) not null,
    lote numeric(7) not null,
	evento numeric(7) not null,
    codigoBarras numeric(20) not null,
    primary key(codigoBarras, codIngresso),
    foreign key(evento) references evento(codEvento),
    foreign key(lote) references lote(codLote)
);


alter table ingresso add column tipo varchar(10) not null;
drop table lote;
create table lote(
	codLote numeric(7) not null,
    numero int not null,
    preco decimal(15,2),
    primary key(codLote)

);

create table pedido(
	codPedido numeric(7) not null,
    cliente numeric(7) not null,
    total decimal(15,7),
    primary key(codPedido, cliente),
    foreign key(cliente) references cliente(codCliente)
);

create table pedido_ingresso(
	codIngresso numeric(7) not null,
    codPedido numeric(7) not null,
    primary key(codIngresso, codPedido),
    foreign key(codIngresso) references ingresso(codIngresso) on delete cascade,
    foreign key(codPedido) references pedido(codPedido) on delete cascade
    

);



