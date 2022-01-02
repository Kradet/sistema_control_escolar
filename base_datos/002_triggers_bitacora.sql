-- * cracion bitacora
create table if not exists bitacora (
    usuario varchar(50),
    descripcion varchar(50),
    fecha timestamp default now()
);

-- ! creacion triggers

-- * trigger tabla tipo_usuario
drop trigger if exists tr_insertar_tipo_usuario;
create trigger tr_insertar_tipo_usuario
before insert on tipo_usuario
for each row
insert into bitacora(usuario, descripcion, fecha)
values (user(), "se agrego un tipo de usuario", now());

