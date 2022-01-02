SELECT * FROM sistema_escolar.planteles_niveles;

SELECT planteles_niveles.clave_programa_educativo, escuela_plantel.Nombre, niveles_educativos.Nombre_nivel from planteles_niveles
INNER JOIN escuela_plantel ON planteles_niveles.plantel_id_plantel = escuela_plantel.id_plantel
INNER JOIN niveles_educativos ON planteles_niveles.niveles_educativos_id_nivel = niveles_educativos.id_nivel
ORDER by clave_programa_educativo ASC; 
