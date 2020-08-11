
CREATE TABLE dbo.Publicaciones 
(
    ID_Pub              int           identity (1, 1) not null,
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
    Moneda_Venta      	varchar (50)  null
);

select * from Publicaciones;

truncate table Publicaciones;

