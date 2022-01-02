select id_usuario as id, tipo_usuario.tipo_usuario as tipo, username, nombre
from usuario
join tipo_usuario on usuario.id_tipo_usuario = tipo_usuario.id_tipo_usuario
where username like concat("", '%') or
nombre like concat("", '%');

-- joins
-- https://www.baulphp.com/inner-join-mysql-ejemplos-completos/
-- https://www.w3schools.com/sql/sql_join_self.asp
-- https://www.mysqltutorial.org/mysql-inner-join.aspx

select * from datos_alumno where nombre like concat(@Buscar, '%') or
curp like concat(@Buscar, '%')