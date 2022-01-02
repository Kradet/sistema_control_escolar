-- ? Inserciones en tabla servicio_escolar
insert into servicio_escolar (id_clave_programa_educativo, id_alumno, grado, grupo, estatus) values
(1, 1, "1", "A", "Alta"),
(3, 2, "1", "A", "Alta"),
(1, 3, "2", "A", "Baja"),
(2, 4, "1", "A", "Alta"),
(3, 5, "6", "A", "Baja"),
(1, 6, "1", "A", "Alta");
select * from servicio_escolar;


insert into conceptos_cobranza
(concepto, precio)
values
("cromadas de pito",35.40),
("blody succion", 13.33),
("dirty footjob", 22.35);
select * from conceptos_cobranza;

insert into caja
(idcaja,Caja_Num)
values
(1,"1"),
(2,"2"),
(3,"3"),
(4,"4"),
(5,"5"),
(6,"6");
select * from caja;

insert into sesion_caja
(usuario_id_usuario,caja_idcaja,Estatus,hora_apertura,hora_cierre,cantidad_inicial)
values
(2,1,"Abierta",NOW(),NOW(),99.99),
(3,2,"Cerrada","07:00:34", NOW(),777);

select * from sesion_caja;

