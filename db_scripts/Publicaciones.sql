
create table Autores
(
  --  SQL Server
  ID      int not null identity primary key,

  --  MySQL
  --  ID      int not null auto_increment primary key,

  Nombre  varchar(200) 
)


create table dbo.Publicaciones 
(
  --  SQL Server
  ID_Pub              int           identity (1, 1) not null primary key,

  --  MySQL
  --  ID_Pub              int auto_increment not null primary key,

  Titulo              varchar (400) not null,
  Subtitulo           varchar (400) null,
  Autores             varchar (100) null,
  Editorial           varchar (100) null,
  Fecha_Publicacion   datetime      null,
  ISBN_13             varchar (20)  null,
  ISBN_10             varchar (20)  null,
  Paginas             int           null,
  Categorias          varchar (50)  null,
  Tipo                int           not null,
  Lenguaje            varchar (50)  null,
  Imagen              varchar (300) null,
  Rating            	varchar (50)  null,
  Opiniones         	varchar (50)  null,
  Precio_Lista      	decimal (18)  null,
  Moneda_Lista      	varchar (50)  null,
  Precio_Venta      	decimal (18)  null,
  Moneda_Venta      	varchar (50)  null,
  ID_Autor            int           null,
  constraint FK_Publicaciones_Autores foreign key (ID_Autor) references Autores(ID)
);


select * from Publicaciones;

--  truncate table Publicaciones;

select * from Autores

--  cambiamos el autor de algunas publicaciones a Bill Gates para que la consulta final 
--  nos retorne una coleccion de items
--  Verificar que el ID de autor de B Gates sea el 2 (puede cambiar segun como cada uno arme sus consultas)
--
update Publicaciones set ID_Autor=2 where ID_Pub between 10 and 17 ;

