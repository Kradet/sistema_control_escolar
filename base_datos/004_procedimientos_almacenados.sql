-- ! tabla tipo_usuario

-- crear
delimiter $$
create procedure insertar_tipo_usuario (
    in _tipo varchar(45)
)
begin
insert into tipo_usuario (tipo_usuario)
values (_tipo);
end $$


-- ! tabla usuario

-- crear
delimiter $$
create procedure insertar_usuario(
    in _tipo_usuario int,
    in _username varchar(45),
    in _nombre varchar(45),
    in _pass varchar(45)
)
begin 
insert into usuario (id_tipo_usuario, username, nombre, contrasenia)
values
(_tipo_usuario, _username, _nombre, _pass);
end $$