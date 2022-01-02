-- ? Inserciones en tabla niveles educativos
insert into niveles_educativos(nombre_nivel) values("Primaria");
insert into niveles_educativos(nombre_nivel) values("Secundaria");
insert into niveles_educativos(nombre_nivel) values("Preparatoria");


-- ? Inserciones en tabla planteles (El nombre está diferente en el diagrama, por favor pon nombres más descriptivos en los campos ლ(ಠ益ಠლ) )
insert into escuela_plantel (nombre) values("Latin American School");
insert into escuela_plantel (nombre) values("Colegio Atid");
insert into escuela_plantel (nombre) values("Varmond School");

-- ? insertar en tabla planteles_niveles [Por favooooooorrrrr, pon mejores nombres en los campos ლ(ಠ益ಠლ), en lugar de plantel_id_plantel nada más pon id_plantel, o lo meo ]
insert into planteles_niveles(plantel_id_plantel, niveles_educativos_id_nivel)
values 
(1, 1),
(1, 2),
(1, 3),
(2, 1),
(2, 2),
(3, 2),
(2, 3);

select * from niveles_educativos;
select * from escuela_plantel;
select * from planteles_niveles;

